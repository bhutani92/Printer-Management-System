using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.DirectoryServices;
using System.Management;
using System.Diagnostics;
using System.Printing;
using System.Net;
using System.DirectoryServices.AccountManagement;
using System.Net.Sockets;
using SnmpSharpNet;
using Microsoft.Win32;
using System.Messaging;
using System.Windows.Forms.DataVisualization.Charting;

namespace NewPMS
{
    public partial class DashBoard : Form
    {
        string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
        int cnt = 0;
        public string UserName = "";
        MySqlConnection con;
        MySqlCommand cmd;
        
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
           // SystemUpTimeLblTxt.Text = UpTime.Hours.ToString() + ":" + UpTime.Minutes.ToString() + ":" + UpTime.Seconds.ToString();
            timer1.Start();
            GetUsersInLAN();
            GetNoOfPrinters();
            GetPagesPrintedTillDate();
            GetPagesPrintedToday();
            GetUserCount();
            ScanLanPrinters();
            PrinterStatus();
            PlotGraph();
        }
        //public TimeSpan UpTime
        //{
        //    get
        //    {
        //        using (var uptime = new PerformanceCounter("System", "System Up Time"))
        //        {
        //            uptime.NextValue();
        //            return TimeSpan.FromSeconds(uptime.NextValue());
        //        }
        //    }
        //}
        public void GetUsersInLAN()
        {
            int UserCount = 0;
            DirectoryEntry root = new DirectoryEntry("WinNT:");
            foreach (DirectoryEntry c1 in root.Children)
            {
                if (c1.Name == "WORKGROUP")
                {
                    foreach (DirectoryEntry c2 in c1.Children)
                    {
                        UserCount += 1;
                    }
                }
            }            
            UsersInLANLblTxt.Text = UserCount.ToString();
        }
        public void GetNoOfPrinters()
        {
            try
            {
                int PrinterCount = 0;
                LocalPrintServer myServer = new LocalPrintServer();
                PrintQueueCollection myQueueCollection = myServer.GetPrintQueues();
                foreach (PrintQueue pQ in myQueueCollection)
                {
                    PrinterCount += 1;
                }
                PrintersLblTxt.Text = PrinterCount.ToString();
            }
            catch (Exception)
            { }
        }
        private void GetPagesPrintedTillDate()
        {
            try
            {
                con = new MySqlConnection(cs);
                cmd= con.CreateCommand();
                cmd.CommandText = "SELECT sum(PagesPrintedTillDate) FROM printers";
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TotalPagesLblTxt.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
               // con.Close();
            }
            catch (MySqlException)
            {
                TotalPagesLblTxt.Text = "0";
            }
        }
        private void GetPagesPrintedToday()
        {
            try
            {
                con = new MySqlConnection(cs);
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT sum(NoOfPages) FROM jobs where TimeCompleted like '" + DateTime.Now.Date + "'%''";
               con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PagesTodayLblTxt.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
               //con.Close();
            }
            catch (MySqlException)
            {
                PagesTodayLblTxt.Text = "0";
            }
        }
        public void GetUserCount()
        {
           
            try
            {
                con = new MySqlConnection(cs);
                cmd= con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM users";
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cnt = reader.GetInt16(0);
                }
                reader.Close();
                //con.Close();
                RegisteredUsersLblTxt.Text =cnt.ToString();
                //label25.Text = cnt.ToString();
            }
            catch (MySqlException) { }
        }
        public void ScanLanPrinters()
        {
            try
            {
                var MyList = new List<string>();
                LocalPrintServer myServer = new LocalPrintServer();
                PrintQueueCollection myQueueCollection = myServer.GetPrintQueues();
                foreach (PrintQueue pQ in myQueueCollection)
                {
                    MyList.Add(pQ.Name.ToString());
                }
                var MyPrinters = MyList.ToArray();


                foreach (object item in MyPrinters)
                {

                    string ipAddr_Printer = "";
                    string lookupPrinterName = "";

                    con = new MySqlConnection(cs);
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT PrinterName FROM printers WHERE PrinterName='" + item.ToString() + "'";
                    con.Open();
                    lookupPrinterName = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();
                    if (lookupPrinterName != item.ToString())
                    {
                        try
                        {
                            Oid rootOID = new Oid();
                            con = new MySqlConnection(cs);
                            con.Open();
                            cmd = new MySqlCommand();
                            string SQL = "INSERT INTO printers (PrinterName,PrinterIP,CatridgeLevel,PagesPrintedTillDate,Status,NoOfJobsQueued,CostPerPage) VALUES (@PrinterName,@PrinterIP,@CatridgeLevel,@PagesPrintedTillDate,@Status,@NoOfJobsQueued,@CostPerPage)";
                            cmd.CommandText = SQL;
                            cmd.Parameters.AddWithValue("@PrinterName", item.ToString());
                            ipAddr_Printer = get_Printer_IP(item.ToString());
                            cmd.Parameters.AddWithValue("@PrinterIP", ipAddr_Printer);
                            rootOID = new Oid("1.3.6.1.2.1.43.11.1.1.9");
                            cmd.Parameters.AddWithValue("@CatridgeLevel", getSNMPParam(ipAddr_Printer, rootOID));
                            rootOID = new Oid("1.3.6.1.2.1.43.10.2.1.4");
                            cmd.Parameters.AddWithValue("@PagesPrintedTillDate", getSNMPParam(ipAddr_Printer, rootOID));
                            cmd.Parameters.AddWithValue("@Status", GetPrinterStatus(item.ToString()));
                            cmd.Parameters.AddWithValue("@NoOfJobsQueued", GetNoOfJobsQueued(item.ToString()));
                            cmd.Parameters.AddWithValue("@CostPerPage", 3);
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            // GetPrinterCount();

                            string sql = "INSERT INTO cost (PrinterName,PrinterIP) VALUES (@PrinterName,@PrinterIP)";
                            cmd.CommandText = sql;
                            cmd.Parameters.AddWithValue("@PrinterName", item.ToString());
                            cmd.Parameters.AddWithValue("@PrinterIP", ipAddr_Printer);
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            con.Close();

                            //string sql1 = "INSERT INTO cost (PrinterName,PrinterIP) VALUES (@PrinterName,@PrinterIP)";
                            //cmd.CommandText = sql1;
                            //cmd.Parameters.AddWithValue("@PrinterName", item.ToString());
                            //cmd.Parameters.AddWithValue("@PrinterIP", ipAddr_Printer);
                            //cmd.Connection = con;
                            //cmd.ExecuteNonQuery();
                            //con.Close();
                        }
                        catch (MySqlException)
                        { }
                    }
                }

            }
            catch (Exception)
            { }
        }
        private string get_Printer_IP(string pName)
        {
            try
            {
                string ipAddr_Printer = "";
                string portName = null;
                string WIN32_Query = string.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", pName);
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", WIN32_Query);
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    portName = queryObj["PortName"].ToString();
                }
                string registryUserRoot = "HKEY_LOCAL_MACHINE";
                string registrySubKey = @"System\CurrentControlSet\Control\Print\Monitors\Standard TCP/IP Port\Ports\";
                string keyName = registryUserRoot + "\\" + registrySubKey + portName;
                ipAddr_Printer = (string)Registry.GetValue(keyName, "IPAddress", null);
                if (ipAddr_Printer == null)
                {
                    registrySubKey = @"System\CurrentControlSet\Control\Print\Monitors\Advanced TCP/IP Port Monitor\Ports\";
                    keyName = registryUserRoot + "\\" + registrySubKey + portName;
                    ipAddr_Printer = (string)Registry.GetValue(keyName, "IPAddress", null);
                    if (ipAddr_Printer == null)
                        return "NA";
                }
                return ipAddr_Printer;
            }
            catch (Exception)
            {
                return "NA";
            }
        }
        private int getSNMPParam(string ipAddr, Oid oid_needed)
        {
            try
            {
                OctetString community = new OctetString("public");
                AgentParameters param = new AgentParameters(community);
                param.Version = SnmpVersion.Ver2;
                IpAddress agent = new IpAddress(ipAddr);
                UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);
                Oid rootOid = new Oid(oid_needed);
                Oid lastOid = (Oid)rootOid.Clone();
                Pdu pdu = new Pdu(PduType.GetBulk);
                pdu.NonRepeaters = 0;
                pdu.MaxRepetitions = 5;
                while (lastOid != null)
                {
                    if (pdu.RequestId != 0)
                    {
                        pdu.RequestId += 1;
                    }
                    pdu.VbList.Clear();
                    pdu.VbList.Add(lastOid);
                    try
                    {
                        SnmpV2Packet result = (SnmpV2Packet)target.Request(pdu, param);
                        if (result != null)
                        {
                            if (result.Pdu.ErrorStatus != 0)
                            {
                                throw new NullReferenceException();
                            }
                            else
                            {
                                foreach (Vb v in result.Pdu.VbList)
                                {
                                    if (rootOid.IsRootOf(v.Oid))
                                    {
                                        if (v.Value.Type == SnmpConstants.SMI_ENDOFMIBVIEW)
                                            lastOid = null;
                                        else
                                            lastOid = v.Oid;
                                        target.Close();
                                        return Convert.ToInt32(v.Value);
                                    }
                                    else
                                    {
                                        lastOid = null;
                                    }
                                }
                            }
                        }
                        else
                        {
                            throw new NullReferenceException();
                        }
                    }
                    catch (NullReferenceException)
                    {
                    }
                }
                target.Close();
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private string GetPrinterStatus(string pName)
        {
            try
            {
                LocalPrintServer myServer = new LocalPrintServer();
                PrintQueueCollection myQueueCollection = myServer.GetPrintQueues();
                PrintQueue pQ = new PrintQueue(myServer, pName);
                return pQ.QueueStatus.ToString();
            }
            catch (Exception) { return " "; }
        }
        private int GetNoOfJobsQueued(string pName)
        {
            try
            {
                LocalPrintServer myServer = new LocalPrintServer();
                PrintQueueCollection myQueueCollection = myServer.GetPrintQueues();
                PrintQueue pQ = new PrintQueue(myServer, pName);
                return pQ.NumberOfJobs;
            }
            catch (Exception) { return 0; }

        }

        
        public void PrinterStatus()
        {
            try
            {
                con = new MySqlConnection(cs);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter("select PrinterName,CatridgeLevel from printers", con);
                sda.Fill(dt);               
                DashBoardDataGrid.DataSource=dt;
                con.Close();
            }
            catch (MySqlException)
            { }
        }
        public void PlotGraph()
        {

             int MaxPages=0;
             int MaxPrinters=0;
             var MyPrinters = new List<string>();

            string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = con.CreateCommand();
                MySqlCommand cmd1 = con.CreateCommand();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd.CommandText = "select max(PagesPrintedTillDate) from printers";
                cmd1.CommandText = "select count(PrinterName) from printers";
                cmd2.CommandText = "select PagesPrintedTillDate from printers";
                con.Open();
                MaxPages = Convert.ToInt32(cmd.ExecuteScalar());
                MaxPrinters = Convert.ToInt32(cmd1.ExecuteScalar());
                chart1.ChartAreas[0].AxisX.Title = "Printers";
                chart1.ChartAreas[0].AxisY.Title = "PagesPrinted";
                chart1.ChartAreas[0].AxisX.Maximum = MaxPrinters+1;
                chart1.ChartAreas[0].AxisY.Maximum = MaxPages+500;


                MySqlDataReader reader = cmd2.ExecuteReader(CommandBehavior.SequentialAccess); ;
                while (reader.Read())
                {
                    
                    MyPrinters.Add(reader.GetString("PagesPrintedTillDate"));
                    
                }
                var MyPrintos = MyPrinters.ToArray();

                
                for (int i = 1,j=0; i <=MaxPrinters; i++,j++)
                {
                       chart1.Series["PagesPrinted"].Points.AddXY(i,MyPrintos[j]);
                       chart1.Series["PagesPrinted"].ChartType = SeriesChartType.Column;
                       chart1.Series["PagesPrinted"].Color = Color.Purple;
                    
                }
                con.Close();
            }
            catch (MySqlException) { }
           
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            //SystemUpTimeLblTxt.Text = UpTime.Hours.ToString() + ":" + UpTime.Minutes.ToString() + ":" + UpTime.Seconds.ToString();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            string TopCaption = "Managing Print Services";

            e.Graphics.DrawIcon(Icon.ExtractAssociatedIcon(Application.ExecutablePath), 20, 8);
            e.Graphics.DrawString(TopCaption, new Font("Segoe UI", 14f), Brushes.Azure, new PointF(70, 10));
            e.Graphics.DrawString(UserName, new Font("Segoe UI", 14f), Brushes.Azure, new PointF(570, 10));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Users u = new Users();
            u.Show();
            this.Hide();
        }

        private void PrinterLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Printers p = new Printers();
            p.Show();
            this.Hide();
        }

        private void DeletePrintersLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeletePrinter d = new DeletePrinter();
            d.Show();
            this.Hide();
        }

        private void AddUserLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser a = new AddUser();
            a.Show();
            this.Hide();
        }

        private void DeleteUserLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteUser d = new DeleteUser();
            d.Show();
            this.Hide();
        }

        private void JobsPerUserLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JobsPeruser j = new JobsPeruser();
            j.Show();
            this.Hide();
        }

        private void BillingPerUserLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BillingPerUser b = new BillingPerUser();
            b.Show();
            this.Hide();
        }

        private void JobsPerPrinterLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JobsPerPrinter j = new JobsPerPrinter();
            j.Show();
            this.Hide();
        }

        private void BillingPerPrinterLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BillingPerPrinter b = new BillingPerPrinter();
            b.Show();
            this.Hide();
        }

        private void AddPrintersLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddPrinter a = new AddPrinter();
            a.Show();
            this.Hide();
        }

        private void CreateGrpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddGroups a = new AddGroups();
            a.Show();
            this.Hide();
        }

        private void QuotaReqLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PendingQuotaRequests p = new PendingQuotaRequests();
            p.Show();
            this.Hide();
        }

        private void AddPrintToGrpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddPrintersToGroup a = new AddPrintersToGroup();
            a.Show();
            this.Hide();
        }

        private void AddUserToGrpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUsersToGroup a = new AddUsersToGroup();
            a.Show();
            this.Hide();
        }

        private void ChangeUserQtLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeUserQuota c = new ChangeUserQuota();
            c.Show();
            this.Hide();

        }

        private void ChangePriQtLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeGroupQuota c = new ChangeGroupQuota();
            c.Show();
            this.Hide();
           
        }

        
          


        
        

    }
}

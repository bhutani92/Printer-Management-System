using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Printing;
using MySql.Data.MySqlClient;
using System.Management;
using Microsoft.Win32;
using System.Net;
using System.DirectoryServices.AccountManagement;
using System.Net.Sockets;
using SnmpSharpNet;
using System.Messaging;
namespace NewPMS
{
    public partial class AddPrinter : Form
    {
        public AddPrinter()
        {
            InitializeComponent();
        }

        private string TopCaption = "Managing Print Services";
        string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
        private void AddPrinter_Load(object sender, EventArgs e)
        {
            PopulateprinterList();
           
        }
        public void PopulateprinterList()
        {
            PrintersList.Clear();
            var MyList = new List<string>();
            try
            {
                LocalPrintServer myServer = new LocalPrintServer();
                PrintQueueCollection myQueueCollection = myServer.GetPrintQueues();
                foreach (PrintQueue pQ in myQueueCollection)
                {
                    MyList.Add(pQ.Name.ToString());
                }
                var MyPrinters = MyList.ToArray();
                var items = PrintersList.Items;
                int i = 0;
                foreach (var value in MyPrinters)
                {
                    items.Add(value);
                    PrintersList.Items[i].ImageIndex = 0;
                    i++;
                }
            }
            catch (Exception) { }

        }
        public void CheckPrinterExistance()
        {
            int j = 0;
            foreach (object item in PrintersList.SelectedItems)
            {
                string ipAddr_Printer = "";
                string lookupPrinterName = "";
                try
                {
                    MySqlConnection con = new MySqlConnection(cs);
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT PrinterName FROM printers WHERE PrinterName='" + PrintersList.SelectedItems[j].Text + "'";
                    con.Open();
                    lookupPrinterName = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();
                }
                catch (MySqlException) { }
                if (lookupPrinterName == PrintersList.SelectedItems[j].Text)
                {
                    MessageBox.Show("Selected Entry " + PrintersList.SelectedItems[j].Text + " exists in the database");
                }
                else
                {
                    Oid rootOID = new Oid();
                    try
                    {
                        MySqlConnection con = new MySqlConnection(cs);
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        string SQL = "INSERT INTO printers (PrinterName,PrinterIP,CatridgeLevel,PagesPrintedTillDate,Status,NoOfJobsQueued,CostPerPage) VALUES (@PrinterName,@PrinterIP,@CatridgeLevel,@PagesPrintedTillDate,@Status,@NoOfJobsQueued,@CostPerPage)";
                        cmd.CommandText = SQL;
                        cmd.Parameters.AddWithValue("@PrinterName", PrintersList.SelectedItems[j].Text);
                        ipAddr_Printer = get_Printer_IP(PrintersList.SelectedItems[j].Text);
                        cmd.Parameters.AddWithValue("@PrinterIP", ipAddr_Printer);
                        rootOID = new Oid("1.3.6.1.2.1.43.11.1.1.9");
                        cmd.Parameters.AddWithValue("@CatridgeLevel", getSNMPParam(ipAddr_Printer, rootOID));
                        rootOID = new Oid("1.3.6.1.2.1.43.10.2.1.4");
                        cmd.Parameters.AddWithValue("@PagesPrintedTillDate", getSNMPParam(ipAddr_Printer, rootOID));
                        cmd.Parameters.AddWithValue("@Status", GetPrinterStatus(PrintersList.SelectedItems[j].Text));
                        cmd.Parameters.AddWithValue("@NoOfJobsQueued", GetNoOfJobsQueued(PrintersList.SelectedItems[j].Text));
                        cmd.Parameters.AddWithValue("@CostPerPage", 3);
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                       // GetPrinterCount();
                        UpDateCost(ipAddr_Printer, j);
                        j++;
                    }
                    catch (MySqlException) { }

                }
            }
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
        private int getSNMPParam(string ipAddr, SnmpSharpNet.Oid oid_needed)
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
        public void GetPrinterCount()
        {
            int printCnt = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM printers";
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    printCnt = reader.GetInt16(0);
                }
                reader.Close();
                conn.Close();
                PrinterCount.Text = "Printer Count: "+ printCnt.ToString();
            }
            catch (MySqlException) { }
        }
        private void UpDateCost(string ipAddr_Printer,int j)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                string SQL = "INSERT INTO cost (PrinterName,PrinterIP) VALUES (@PrinterName,@PrinterIP)";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@PrinterName", PrintersList.SelectedItems[j].Text);
                cmd.Parameters.AddWithValue("@PrinterIP", ipAddr_Printer);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException) { }
        }
        private void AddPrinters_Click(object sender, EventArgs e)
        {

            CheckPrinterExistance();
            GetPrinterCount();

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawIcon(Icon.ExtractAssociatedIcon(Application.ExecutablePath), 20, 8);
            e.Graphics.DrawString(TopCaption, new Font("Segoe UI", 14f), Brushes.Azure, new PointF(70, 10));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.Show();
            this.Hide();
        }

        
    }
}

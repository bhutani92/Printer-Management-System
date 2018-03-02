using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Net;
using System.Net.Sockets;
using MySql.Data.MySqlClient;

namespace NewPMS
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        private string TopCaption = "Managing Print Services";
        string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
        int i = 0;
        private void AddUser_Load(object sender, EventArgs e)
        {
            PopulateuserList();
        }
        public string DoGetHostAddresses(string hostname)
        {
            try
            {
                IPAddress[] ips;
                ips = Dns.GetHostAddresses(hostname);
                return ips.Length > 1 ? ips[1].ToString() : ips[0].ToString();

            }
            catch (SocketException)
            {
            }
            return " ";
        }
        public void PopulateuserList()
        {
            UserList.Clear();
            var MyList = new List<string>();
            try
            {
                DirectoryEntry root = new DirectoryEntry("WinNT:");
                foreach (DirectoryEntry c1 in root.Children)
                {
                    if (c1.Name == "WORKGROUP")
                    {
                        foreach (DirectoryEntry c2 in c1.Children)
                        {

                            if (c2.Name.ToString() != "Schema")
                                MyList.Add(c2.Name.ToString());
                        }
                    }
                }
                var MyUsers = MyList.ToArray();
                var items = UserList.Items;
                i = 0;
                foreach (var value in MyUsers)
                {

                    items.Add(value);
                    UserList.Items[i].ImageIndex = 0;
                    DoGetHostAddresses(value.ToString());
                    i++;
                }
            }catch(Exception){}
           
        }

        private void AddUsers_Click(object sender, EventArgs e)
        {
            CheckUserExistance();
        }

        public void CheckUserExistance()
        {
           i = 0;
            try
            {
                foreach (object item in UserList.SelectedItems)
                {
                    string lookupUserName = "";
                    try
                    {
                        MySqlConnection con = new MySqlConnection(cs);
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "SELECT SystemName FROM users WHERE SystemName ='" + UserList.SelectedItems[i].Text + "'";
                        con.Open();
                        lookupUserName = Convert.ToString(cmd.ExecuteScalar());
                        con.Close();
                    }
                    catch (MySqlException) { }
                    if (lookupUserName == UserList.SelectedItems[i].Text)
                    {
                        MessageBox.Show("Selected Entry  " + UserList.SelectedItems[i].Text + "  Exist in the database ");
                    }
                    else
                    {
                        try
                        {
                            MySqlConnection con = new MySqlConnection(cs);
                            con.Open();
                            MySqlCommand cmd= new MySqlCommand();
                            string SQL = "INSERT INTO users (MACAddress,IPAddress,PagesPrintedTillDate,PagesPrintedToday,DateOfJoining,SystemName,GroupId) VALUES (@MACAddress,@IPAddress,@PagesPrintedTillDate,@PagesPrintedToday,@DateOfJoining,@SystemName,@groupid)";
                            cmd.CommandText = SQL;
                            cmd.Parameters.AddWithValue("@MACAddress", "NA");
                            cmd.Parameters.AddWithValue("@SystemName", UserList.SelectedItems[i].Text);
                            cmd.Parameters.AddWithValue("@IPAddress", DoGetHostAddresses(UserList.SelectedItems[i].Text));    
                            cmd.Parameters.AddWithValue("@PagesPrintedTillDate", 0);
                            cmd.Parameters.AddWithValue("@PagesPrintedToday", 0);
                            cmd.Parameters.AddWithValue("@DateOfJoining", DateTime.Now);
                            cmd.Parameters.AddWithValue("@groupid", 0);
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                            con.Close();
                            GetUserCount();
                            UpdateQuota(i);
                        }
                        catch (MySqlException) { }
                    }
                    i++;
                }
            }
            catch (Exception) { }
        }
        public void GetUserCount()
        {
            int cnt = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM users";
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cnt = reader.GetInt16(0);
                }
                reader.Close();
                con.Close();
                UserCount.Text = "User Count: " + cnt.ToString();
               
            }
            catch (MySqlException) { }
        }
        private void UpdateQuota(int i)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                string SQL = "INSERT INTO quota (MACAddress,UserName) VALUES (@MACAddress,@UserName)";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@MACAddress", "NA");
                cmd.Parameters.AddWithValue("@UserName", UserList.SelectedItems[i].Text);
                //command.Parameters.AddWithValue("@IPAddress", DoGetHostAddresses(listView1.SelectedItems[i].Text));
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException) { }
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

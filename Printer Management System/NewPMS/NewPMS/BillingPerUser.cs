using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;

namespace NewPMS
{
    public partial class BillingPerUser : Form
    {
        public BillingPerUser()
        {
            InitializeComponent();
        }
        private string TopCaption = "Managing Print Services";
        string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
        private void ShowBill_Click(object sender, EventArgs e)
        {
            
            string d1 = FromdateTimePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string d2 = TodateTimePicker.Value.ToString("yyyy-MM-dd")+ " 23:59:59";
            MessageBox.Show(d1+ "   " +d2);
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT JobId,PrinterName,NoOfPages,CostOfJob,NoOfCopies FROM jobs WHERE SystemName='" + UserNameComboBox.Text + "'and TimeCompleted between'" + d1 + "' and '" + d2 + "' ", con);
                sda.Fill(dt);
                UserdataGridView.DataSource = dt;
            }
            catch (MySqlException) { }
            CostOfUser();
        }

        private void BillingPerUser_Load(object sender, EventArgs e)
        {
            BindComboBox();
        }
        public void BindComboBox()
        {
            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var query = "SELECT SystemName FROM users";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserNameComboBox.Items.Add(reader.GetString("SystemName"));
                            }
                        }
                    }
                }
            }
            catch (MySqlException) { }
        }
        public void CostOfUser()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT sum(CostOfJob) FROM jobs WHERE SystemName='" + UserNameComboBox.Text + "'";
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CostOfUserLbl.Text = reader.GetString(0);
                }
                CostOfUserLbl.Text = "Cost Of The User : "+CostOfUserLbl.Text;
                reader.Close();
                conn.Close();
            }
            catch (SqlNullValueException) { }
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

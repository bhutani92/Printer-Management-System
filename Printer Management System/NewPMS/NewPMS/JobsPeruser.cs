using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NewPMS
{
    public partial class JobsPeruser : Form
    {
        public JobsPeruser()
        {
            InitializeComponent();
        }
        private string TopCaption = "Managing Print Services";
        string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
        private void GetJobs_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM jobs WHERE SystemName='" + UserNamecomboBox.Text + "'", con);
                sda.Fill(dt);
                UserdataGridView.DataSource = dt;
                GetNoOfJobsPerUser();
            }
            catch (MySqlException) { }
        }
        public void GetNoOfJobsPerUser()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM jobs WHERE SystemName='" + UserNamecomboBox.Text + "'";
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TotalJobsLbl.Text = reader.GetString(0);
                }
                TotalJobsLbl.Text = "No Of Jobs in the DataBase Is: " + TotalJobsLbl.Text;
                reader.Close();
                conn.Close();
            }
            catch (MySqlException) { }
        }
        public void GetTotalNoOfJobs()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM jobs";
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TotalJobsLbl.Text = reader.GetString(0);
                }
                TotalJobsLbl.Visible = true;
                TotalJobsLbl.Text = "No Of Jobs in the DataBase Is: " + TotalJobsLbl.Text;
                reader.Close();
                conn.Close();
            }
            catch (MySqlException) { }
        }
        public void GetAllJobsInfo()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM jobs", con);
                sda.Fill(dt);
                UserdataGridView.DataSource = dt;
                
            }
            catch (MySqlException) { }

        }
        private void GetAllJobs_Click(object sender, EventArgs e)
        {
            GetAllJobsInfo();
            GetTotalNoOfJobs();

        }

        private void JobsPeruser_Load(object sender, EventArgs e)
        {
            BindComboBox();
            GetAllJobsInfo();
            GetTotalNoOfJobs();
            
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
                                UserNamecomboBox.Items.Add(reader.GetString("SystemName"));

                            }
                        }
                    }
                }
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

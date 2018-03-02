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
    public partial class Users : Form
    {
        private string TopCaption = "Managing Print Services";
        string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
        MySqlConnection con;
        MySqlCommand cmd;
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            BindComboBox1();
            BindGrid();
        }
        public void BindComboBox1()
        {
            UserNameComboBox.Text = "";
            UserNameComboBox.Items.Clear();
            try
            {
                using (con = new MySqlConnection(cs))
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
        public void BindGrid()
        {
            try
            {
                con = new MySqlConnection(cs);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM users", con);
                sda.Fill(dt);
                UserTabGrid.DataSource = dt;
            }
            catch (MySqlException)
            { }
        }
        private void GetuserInformationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM users WHERE SystemName='" + UserNameComboBox.Text + "'", con);
                sda.Fill(dt);
                UserTabGrid.DataSource = dt;
            }
            catch (MySqlException) { }
        }

        private void GetAllUserInformationBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
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

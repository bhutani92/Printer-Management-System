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
    public partial class ChangeGroupQuota : Form
    {
        public ChangeGroupQuota()
        {
            InitializeComponent();
        }
        private string TopCaption = "Managing Print Services";
        string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
        private void ChnageGroupQuota_Load(object sender, EventArgs e)
        {
            BindGroupCombo();
            //BindGrid();
        }
        public void BindGroupCombo()
        {
            try
            {
                using (var con= new MySqlConnection(cs))
                {
                    con.Open();
                    var query = "SELECT GroupName FROM mygroup";
                    using (var cmd =new MySqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GroupNamecomboBox.Items.Add(reader.GetString("GroupName"));

                            }
                        }
                    }
                }
            }
            catch (MySqlException) { }
        }

        //public void BindGrid()
        //{
        //    try
        //    {
        //        MySqlConnection con = new MySqlConnection(cs);
        //        DataTable dt = new DataTable();
        //        MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM mygroup", con);
        //        sda.Fill(dt);
        //        GroupsDataGrid.DataSource = dt;
        //    }
        //    catch (MySqlException) { }

        //}
        private void GroupNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM mygroup WHERE GroupName='" + GroupNamecomboBox.Text + "'   ";
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                while (reader.Read())
                {
                    GroupIdVal.Text = reader.GetString("GroupId");
                    GroupNameVal.Text = reader.GetString("GroupName");
                    GroupQuotaTxt.Text = reader.GetString("GroupQuota");
                }
                GroupQuotaGroupBox.Visible = true;
            }
            catch (MySqlException)
            {

            }
        }

        private void UpDateGroupQuota_Click(object sender, EventArgs e)
        {

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

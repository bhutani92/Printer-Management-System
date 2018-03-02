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
    public partial class ChangeUserQuota : Form
    {
        public ChangeUserQuota()
        {
            InitializeComponent();
        }
       string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
       private string TopCaption = "Managing Print Services";
        private void ChangeUserQuota_Load(object sender, EventArgs e)
        {
            BindUserCombo();
            
        }
        public void BindUserCombo()
        {
            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var query = "SELECT UserName FROM quota";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserNamecomboBox.Items.Add(reader.GetString("UserName"));

                            }
                        }
                    }
                }
            }
            catch (MySqlException) { }
        }

        private void UserNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                string sql = "SELECT * FROM quota WHERE UserName='" + UserNamecomboBox.Text + "'   ";
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow); ;
                while (reader.Read())
                {
                    MACAddressTxt.Text = reader.GetString("MACAddress");
                    UserNameTxt.Text = reader.GetString("UserName");
                    AllocatedQuotaTxt.Text = reader.GetString("AllocatedQuota");
                    QuotaLeftTxt.Text = reader.GetString("QuotaLeft");

                }
                UserQuotagroupBox.Visible = true;
            }
            catch (MySqlException) { }
        }

        private void UpdateUserQuota_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "update quota set AllocatedQuota='" + Convert.ToInt32(AllocatedQuotaTxt.Text) + "',QuotaLeft='" + (Convert.ToInt32(QuotaLeftTxt.Text) + Convert.ToInt32(AllocatedQuotaTxt.Text)) + "'where MACAddress='" + MACAddressTxt.Text + "'  ";
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("UpDated Successfully");
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

        private void UpdateUserQuota_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "update quota set AllocatedQuota='" + Convert.ToInt32(AllocatedQuotaTxt.Text) + "',QuotaLeft='" + (Convert.ToInt32(QuotaLeftTxt.Text) + Convert.ToInt32(AllocatedQuotaTxt.Text)) + "'where MACAddress='" + MACAddressTxt.Text + "' ";
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("UpDated Successfully");
                con.Close();
            }
            catch (MySqlException) { }
        }

        

    }
}

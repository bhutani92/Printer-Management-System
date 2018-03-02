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
    public partial class AddUsersToGroup : Form
    {
        public AddUsersToGroup()
        {
            InitializeComponent();
        }
        private string TopCaption = "Managing Print Services";
        string cs = @"server=localhost;userid=root;password=root;database=pms";
        string lookupGroupId = "";
        int j = 0;
        private void AddUsersToGroup_Load(object sender, EventArgs e)
        {
            BindGroupNameCombo();
            GetUserFromDBForGroups();

        }
        public void BindGroupNameCombo()
        {
            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var query = "SELECT distinct GroupName FROM mygroup";
                    using (var cmd = new MySqlCommand(query, con))
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
        private void GetUserFromDBForGroups()
        {
            UserlistView.Clear();
            int i = 0;
            var items = UserlistView.Items;
            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var query = "SELECT distinct SystemName FROM users";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                items.Add(reader.GetString("SystemName"));
                                UserlistView.Items[i].ImageIndex = 0;
                                i++;
                            }
                        }
                    }
                }
            }
            catch (MySqlException) { }

        }
        private void AddUserToGroup_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                //lookupGid();
                j = 0;
                foreach (object item in UserlistView.CheckedItems)
                {
                    string sql = "update users set GroupId='" + lookupGroupId + "' where SystemName='" + UserlistView.CheckedItems[j].Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    j++;
                }
                MessageBox.Show("UpDated Successfully");
                foreach (ListViewItem listItem in UserlistView.Items)
                {
                    listItem.Checked = false;
                }
            }
                
            catch (MySqlException) { }

        }
        public void lookupGid()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT distinct GroupId FROM mygroup WHERE GroupName='" + GroupNamecomboBox.Text + "'";
                con.Open();
                lookupGroupId = Convert.ToString(cmd.ExecuteScalar());
                con.Close();
            }
            catch (MySqlException) { }
        }

        private void GroupNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lookupGid();
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

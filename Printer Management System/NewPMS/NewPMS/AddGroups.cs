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
    public partial class AddGroups : Form
    {
        public AddGroups()
        {
            InitializeComponent();
        }
        private string TopCaption = "Managing Print Services";
        string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
        private void CreateGroupButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                string SQL = "INSERT INTO mygroup (GroupId,GroupName) VALUES (@GroupId,@GroupName)";
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@GroupId", GroupIdTxt.Text);
                cmd.Parameters.AddWithValue("@GroupName", GroupNameTxt.Text);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Group Created Successfully");
                con.Close();
               
            }
            catch (MySqlException) { }
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawIcon(Icon.ExtractAssociatedIcon(Application.ExecutablePath), 20, 8);
            e.Graphics.DrawString(TopCaption, new Font("Segoe UI", 14f), Brushes.Azure, new PointF(70, 10));
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            GroupIdTxt.Text = "";
            GroupNameTxt.Text = "";
        }

        private void AddGroups_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.Show();
            this.Hide();
        }
    }
}

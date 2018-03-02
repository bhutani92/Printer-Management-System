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
    public partial class Printers : Form
    {
        public Printers()
        {
            InitializeComponent();
        }
        private string TopCaption = "Managing Print Services";

        private void Printers_Load(object sender, EventArgs e)
        {
            try
            {
                string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
                MySqlConnection con = new MySqlConnection(cs);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from printers", con);
                sda.Fill(dt);
                PrintersTabGrid.DataSource = dt;
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

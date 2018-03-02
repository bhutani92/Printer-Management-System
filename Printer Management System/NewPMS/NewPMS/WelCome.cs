using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace NewPMS
{
    public partial class WelCome : Form
    {
        private string TopCaption = "SoftPearl Technologies";


        public WelCome()
        {
            InitializeComponent();
        }

        public WelCome(string TopCaption, string Link)
        {
            InitializeComponent();
            this.TopCaption = TopCaption;
            this.linkLabel.Text = Link;
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawIcon(Icon.ExtractAssociatedIcon(Application.ExecutablePath), 20, 8);
            e.Graphics.DrawString(TopCaption, new Font("Segoe UI", 14f), Brushes.Azure, new PointF(70, 10));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            AdminLogin a = new AdminLogin();
            a.Show();
            this.Hide();
        }

    }
}

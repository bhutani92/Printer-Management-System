using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewPMS
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        private string TopCaption = "Managing Print Services";

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawIcon(Icon.ExtractAssociatedIcon(Application.ExecutablePath), 20, 8);
            e.Graphics.DrawString(TopCaption, new Font("Segoe UI", 14f), Brushes.Azure, new PointF(70, 10));
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();


            if (UserNameTxt.Text == "Admin" && PasswordTxt.Text == "Admin")
            {
                d.UserName = UserNameTxt.Text;
                d.Show();
                this.Hide();
                
            }

            else
            {
                MessageBox.Show("Invalid User!!!!!!!!");
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UserNameTxt.Text = "";
            PasswordTxt.Text = "";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
       
        

       
    }
}

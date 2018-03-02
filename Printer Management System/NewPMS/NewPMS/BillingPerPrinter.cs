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
    public partial class BillingPerPrinter : Form
    {
        public BillingPerPrinter()
        {
            InitializeComponent();
        }
        private string TopCaption = "Managing Print Services";
        string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
        private void ShowBill_Click(object sender, EventArgs e)
        {

           
            string d1 = FromdateTimePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string d2 = TodateTimePicker.Value.ToString("yyyy-MM-dd") + " 23:59:59";
         
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT JobId,PrinterName,NoOfPages,CostOfJob,NoOfCopies FROM jobs WHERE PrinterName='" + PrinterNameComboBox.Text + "'and TimeCompleted between'" + d1 + "' and '" + d2 + "' ", con);
                sda.Fill(dt);
                PrinterdataGridView.DataSource = dt;
            }
            catch (MySqlException) { }
            CostOfPrinter();
        }

        private void BillingPerPrinter_Load(object sender, EventArgs e)
        {
           BindComboBox();
        }
        public void BindComboBox()
        {
            try
            {
                using (var con= new MySqlConnection(cs))
                {
                    con.Open();
                    var query = "SELECT PrinterName FROM printers";
                    using (var cmd= new MySqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PrinterNameComboBox.Items.Add(reader.GetString("PrinterName"));
                            }
                        }
                    }
                }
            }
            catch (MySqlException) { }
        }
        public void CostOfPrinter()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cs);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT sum(CostOfJob) FROM jobs WHERE SystemName='" + PrinterNameComboBox.Text + "'";
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CostOfPrinterLbl.Text = reader.GetString(0);
                }
                CostOfPrinterLbl.Text = "Cost Of The User : " + CostOfPrinterLbl.Text;
                reader.Close();
                conn.Close();
            }
            catch (SqlNullValueException) { }
            catch (MySqlException) { }
        }
        private void PrinterdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

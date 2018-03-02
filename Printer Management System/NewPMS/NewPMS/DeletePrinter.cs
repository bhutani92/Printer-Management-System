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
    public partial class DeletePrinter : Form
    {
        public DeletePrinter()
        {
            InitializeComponent();
        }
        private string TopCaption = "Managing Print Services";
        string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
        private void DeletePrinter_Load(object sender, EventArgs e)
        {
           GetPrinterFromDb();
        }
        private void GetPrinterFromDb()
        {
            PrinterList.Clear();
            int i = 0;
            var items = PrinterList.Items;
            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var query = "SELECT PrinterName FROM printers";
                    using (var cmd= new MySqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                items.Add(reader.GetString("PrinterName"));
                                PrinterList.Items[i].ImageIndex = 0;
                                i++;
                            }
                        }
                    }
                }
            }
            catch (MySqlException) { }
        }

        private void RemovePrinter_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd= con.CreateCommand();
                cmd.CommandText = "DELETE FROM printers where PrinterName='" + PrinterList.SelectedItems[0].Text + "' ";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                PrinterList.Clear();
                GetPrinterFromDb();
            }
            catch (MySqlException) { }
            catch (Exception) { }
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

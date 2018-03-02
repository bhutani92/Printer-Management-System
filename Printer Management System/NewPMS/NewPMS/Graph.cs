using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace NewPMS
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            int MaxPages = 0;
            int MaxPrinters = 0;
            var MyPrinters = new List<string>();

            string cs = @"server=192.168.6.72;userid=root;password=root;database=pms";
            try
            {
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand cmd = con.CreateCommand();
                MySqlCommand cmd1 = con.CreateCommand();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd.CommandText = "select max(PagesPrintedTillDate) from printers";
                cmd1.CommandText = "select count(PrinterName) from printers";
                cmd2.CommandText = "select PagesPrintedTillDate from printers";
                con.Open();
                MaxPages = Convert.ToInt32(cmd.ExecuteScalar());
                MaxPrinters = Convert.ToInt32(cmd1.ExecuteScalar());
                chart1.ChartAreas[0].AxisX.Title = "Printers";
                chart1.ChartAreas[0].AxisY.Title = "PagesPrinted";
                chart1.ChartAreas[0].AxisX.Maximum = MaxPrinters+1;
                chart1.ChartAreas[0].AxisY.Maximum = MaxPages;


                MySqlDataReader reader = cmd2.ExecuteReader(CommandBehavior.SequentialAccess); ;
                while (reader.Read())
                {

                    MyPrinters.Add(reader.GetString("PagesPrintedTillDate"));

                }
                var MyPrintos = MyPrinters.ToArray();


                for (int i = 1, j = 0; i <= MaxPrinters; i++, j++)
                {
                    chart1.Series["PagesPrinted"].Points.AddXY(i, MyPrintos[j]);
                    chart1.Series["PagesPrinted"].ChartType = SeriesChartType.Column;
                    chart1.Series["PagesPrinted"].Color = Color.Purple;

                }
                con.Close();
            }
            catch (MySqlException) { }
        }
    }
}

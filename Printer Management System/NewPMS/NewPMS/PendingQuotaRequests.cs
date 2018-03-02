using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Messaging;

namespace NewPMS
{
    public partial class PendingQuotaRequests : Form
    {
        public PendingQuotaRequests()
        {
            InitializeComponent();
        }


        private string TopCaption = "Managing Print Services";
        private void GetRequestsBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string val = " ";
                MessageQueue msgQ = new MessageQueue(@"FormatName:DIRECT=TCP:192.168.6.72\Private$\MsgQ");
                if (msgQ.GetAllMessages().Count() > 0)
                {
                    Object o = new Object();
                    System.Type[] arrTypes = new System.Type[2];
                    arrTypes[0] = val.GetType();
                    arrTypes[1] = o.GetType();
                    msgQ.Formatter = new XmlMessageFormatter(arrTypes);
                    val = ((string)msgQ.Receive().Body);
                    MessageBox.Show("received message " + val);
                }
                else
                {
                    MessageBox.Show("No messages");
                }
            }
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

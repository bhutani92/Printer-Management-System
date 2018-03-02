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
    public partial class PrinterManagementSystem : Form
    {
        public PrinterManagementSystem()
        {
            InitializeComponent();
        }

        Printers p = new Printers();
        Users u = new Users();
        //DashBoard d = new DashBoard();

        BillingPerUser bu = new BillingPerUser();
        BillingPerPrinter bp = new BillingPerPrinter();
        JobsPeruser ju = new JobsPeruser();
        JobsPerPrinter jp = new JobsPerPrinter();
        AddGroups ag = new AddGroups();
        AddUsersToGroup aug = new AddUsersToGroup();
        ChangeUserQuota uq = new ChangeUserQuota();
        ChangeGroupQuota gq = new ChangeGroupQuota();
        PendingQuotaRequests qr = new PendingQuotaRequests();
        DeleteUser du = new DeleteUser();
        DeletePrinter dp = new DeletePrinter();
        AddUser au = new AddUser();
        AddPrinter ap = new AddPrinter();
        AddPrintersToGroup apg = new AddPrintersToGroup();
        
        //private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    d.ShowDialog();
        //}

        //private void uSERSToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    u.ShowDialog();
        //}

        //private void pRINTERSToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    p.ShowDialog();
        //}

        //private void pERUSERToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    bu.ShowDialog();
        //}

        //private void pERPRINTERToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    bp.ShowDialog();
        //}

        //private void pERUSERToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    ju.ShowDialog();
        //}

        //private void pERPRINTERToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    jp.ShowDialog();
        //}

        //private void aDDGROUPToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ag.ShowDialog();
        //}

        //private void aDDUSERSTOGROUPToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    aug.ShowDialog();
        //}

        //private void cHANGEUSERQUOTAToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    uq.ShowDialog();
        //}

        //private void PrinterManagementSystem_Load(object sender, EventArgs e)
        //{

        //}

        //private void cHANGEGROUPQUOTAToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    gq.ShowDialog();
        //}

        //private void pENDINGQUOTAREQUESTSToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    qr.ShowDialog();
        //}

        //private void dELETEUSERToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    du.ShowDialog();
        //}

        //private void dELETEPRINTERSToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    dp.ShowDialog();
        //}

        //private void aDDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    au.ShowDialog();
        //}

        //private void aDDPRINTERSToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ap.ShowDialog();
        //}

        //private void aDDPRINTERSTOGROUPToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    apg.ShowDialog();
        //   // apg.Show();
        //}

        
    }
}

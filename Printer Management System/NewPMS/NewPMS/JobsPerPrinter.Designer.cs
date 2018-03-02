namespace NewPMS
{
    partial class JobsPerPrinter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PrintergroupBox = new System.Windows.Forms.GroupBox();
            this.GetAllJobs = new System.Windows.Forms.Button();
            this.GetJobs = new System.Windows.Forms.Button();
            this.PrintercomboBox = new System.Windows.Forms.ComboBox();
            this.PrinterdataGridView = new System.Windows.Forms.DataGridView();
            this.TotalJobsLbl = new System.Windows.Forms.Label();
            this.PrinterJobsGroupBox = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.PrintergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterdataGridView)).BeginInit();
            this.PrinterJobsGroupBox.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintergroupBox
            // 
            this.PrintergroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintergroupBox.AutoSize = true;
            this.PrintergroupBox.Controls.Add(this.GetAllJobs);
            this.PrintergroupBox.Controls.Add(this.GetJobs);
            this.PrintergroupBox.Controls.Add(this.PrintercomboBox);
            this.PrintergroupBox.Location = new System.Drawing.Point(-3, 53);
            this.PrintergroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.PrintergroupBox.Name = "PrintergroupBox";
            this.PrintergroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.PrintergroupBox.Size = new System.Drawing.Size(599, 74);
            this.PrintergroupBox.TabIndex = 8;
            this.PrintergroupBox.TabStop = false;
            this.PrintergroupBox.Text = "Select Appropriate Printer";
            this.PrintergroupBox.Enter += new System.EventHandler(this.PrintergroupBox_Enter);
            // 
            // GetAllJobs
            // 
            this.GetAllJobs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetAllJobs.AutoSize = true;
            this.GetAllJobs.Location = new System.Drawing.Point(385, 33);
            this.GetAllJobs.Margin = new System.Windows.Forms.Padding(2);
            this.GetAllJobs.Name = "GetAllJobs";
            this.GetAllJobs.Size = new System.Drawing.Size(173, 23);
            this.GetAllJobs.TabIndex = 2;
            this.GetAllJobs.Text = "Get All Jobs";
            this.GetAllJobs.UseVisualStyleBackColor = true;
            this.GetAllJobs.Click += new System.EventHandler(this.GetAllJobs_Click);
            // 
            // GetJobs
            // 
            this.GetJobs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetJobs.AutoSize = true;
            this.GetJobs.Location = new System.Drawing.Point(186, 33);
            this.GetJobs.Margin = new System.Windows.Forms.Padding(2);
            this.GetJobs.Name = "GetJobs";
            this.GetJobs.Size = new System.Drawing.Size(173, 23);
            this.GetJobs.TabIndex = 1;
            this.GetJobs.Text = "Get Jobs";
            this.GetJobs.UseVisualStyleBackColor = true;
            this.GetJobs.Click += new System.EventHandler(this.GetJobs_Click);
            // 
            // PrintercomboBox
            // 
            this.PrintercomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintercomboBox.FormattingEnabled = true;
            this.PrintercomboBox.Location = new System.Drawing.Point(5, 35);
            this.PrintercomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PrintercomboBox.Name = "PrintercomboBox";
            this.PrintercomboBox.Size = new System.Drawing.Size(166, 21);
            this.PrintercomboBox.TabIndex = 0;
            // 
            // PrinterdataGridView
            // 
            this.PrinterdataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrinterdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.PrinterdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrinterdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrinterdataGridView.Location = new System.Drawing.Point(3, 18);
            this.PrinterdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.PrinterdataGridView.Name = "PrinterdataGridView";
            this.PrinterdataGridView.RowTemplate.Height = 24;
            this.PrinterdataGridView.Size = new System.Drawing.Size(596, 287);
            this.PrinterdataGridView.TabIndex = 9;
            this.PrinterdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrinterdataGridView_CellContentClick);
            // 
            // TotalJobsLbl
            // 
            this.TotalJobsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalJobsLbl.AutoSize = true;
            this.TotalJobsLbl.Location = new System.Drawing.Point(12, 20);
            this.TotalJobsLbl.Name = "TotalJobsLbl";
            this.TotalJobsLbl.Size = new System.Drawing.Size(13, 13);
            this.TotalJobsLbl.TabIndex = 10;
            this.TotalJobsLbl.Text = "0";
            this.TotalJobsLbl.Visible = false;
            // 
            // PrinterJobsGroupBox
            // 
            this.PrinterJobsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrinterJobsGroupBox.Controls.Add(this.PrinterdataGridView);
            this.PrinterJobsGroupBox.Location = new System.Drawing.Point(-3, 128);
            this.PrinterJobsGroupBox.Name = "PrinterJobsGroupBox";
            this.PrinterJobsGroupBox.Size = new System.Drawing.Size(599, 304);
            this.PrinterJobsGroupBox.TabIndex = 11;
            this.PrinterJobsGroupBox.TabStop = false;
            this.PrinterJobsGroupBox.Text = "Printer Jobs";
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-3, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(598, 50);
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.topPanel});
            this.shapeContainer1.Size = new System.Drawing.Size(594, 472);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Controls.Add(this.TotalJobsLbl);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 430);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(594, 42);
            this.bottomPanel.TabIndex = 13;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(507, 8);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // JobsPerPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 472);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.PrinterJobsGroupBox);
            this.Controls.Add(this.PrintergroupBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobsPerPrinter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobsPerPrinter";
            this.Load += new System.EventHandler(this.JobsPerPrinter_Load);
            this.PrintergroupBox.ResumeLayout(false);
            this.PrintergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterdataGridView)).EndInit();
            this.PrinterJobsGroupBox.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PrintergroupBox;
        private System.Windows.Forms.Button GetAllJobs;
        private System.Windows.Forms.Button GetJobs;
        private System.Windows.Forms.ComboBox PrintercomboBox;
        private System.Windows.Forms.DataGridView PrinterdataGridView;
        private System.Windows.Forms.Label TotalJobsLbl;
        private System.Windows.Forms.GroupBox PrinterJobsGroupBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;

    }
}
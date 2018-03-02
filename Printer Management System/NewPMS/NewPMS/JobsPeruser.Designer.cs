namespace NewPMS
{
    partial class JobsPeruser
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
            this.UsergroupBox = new System.Windows.Forms.GroupBox();
            this.GetAllJobs = new System.Windows.Forms.Button();
            this.GetJobs = new System.Windows.Forms.Button();
            this.UserNamecomboBox = new System.Windows.Forms.ComboBox();
            this.UserdataGridView = new System.Windows.Forms.DataGridView();
            this.TotalJobsLbl = new System.Windows.Forms.Label();
            this.UserJobsGroupBox = new System.Windows.Forms.GroupBox();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.UsergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
            this.UserJobsGroupBox.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsergroupBox
            // 
            this.UsergroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsergroupBox.AutoSize = true;
            this.UsergroupBox.Controls.Add(this.GetAllJobs);
            this.UsergroupBox.Controls.Add(this.GetJobs);
            this.UsergroupBox.Controls.Add(this.UserNamecomboBox);
            this.UsergroupBox.Location = new System.Drawing.Point(-3, 52);
            this.UsergroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsergroupBox.Name = "UsergroupBox";
            this.UsergroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.UsergroupBox.Size = new System.Drawing.Size(599, 75);
            this.UsergroupBox.TabIndex = 2;
            this.UsergroupBox.TabStop = false;
            this.UsergroupBox.Text = "Select Appropriate User";
            // 
            // GetAllJobs
            // 
            this.GetAllJobs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetAllJobs.AutoSize = true;
            this.GetAllJobs.Location = new System.Drawing.Point(387, 31);
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
            this.GetJobs.Location = new System.Drawing.Point(196, 31);
            this.GetJobs.Margin = new System.Windows.Forms.Padding(2);
            this.GetJobs.Name = "GetJobs";
            this.GetJobs.Size = new System.Drawing.Size(173, 23);
            this.GetJobs.TabIndex = 1;
            this.GetJobs.Text = "Get Jobs";
            this.GetJobs.UseVisualStyleBackColor = true;
            this.GetJobs.Click += new System.EventHandler(this.GetJobs_Click);
            // 
            // UserNamecomboBox
            // 
            this.UserNamecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNamecomboBox.FormattingEnabled = true;
            this.UserNamecomboBox.Location = new System.Drawing.Point(5, 31);
            this.UserNamecomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNamecomboBox.Name = "UserNamecomboBox";
            this.UserNamecomboBox.Size = new System.Drawing.Size(174, 21);
            this.UserNamecomboBox.TabIndex = 0;
            // 
            // UserdataGridView
            // 
            this.UserdataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.UserdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView.Location = new System.Drawing.Point(0, 16);
            this.UserdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.UserdataGridView.Name = "UserdataGridView";
            this.UserdataGridView.RowTemplate.Height = 24;
            this.UserdataGridView.Size = new System.Drawing.Size(599, 287);
            this.UserdataGridView.TabIndex = 3;
            // 
            // TotalJobsLbl
            // 
            this.TotalJobsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalJobsLbl.AutoSize = true;
            this.TotalJobsLbl.Location = new System.Drawing.Point(3, 20);
            this.TotalJobsLbl.Name = "TotalJobsLbl";
            this.TotalJobsLbl.Size = new System.Drawing.Size(13, 13);
            this.TotalJobsLbl.TabIndex = 7;
            this.TotalJobsLbl.Text = "0";
            this.TotalJobsLbl.Visible = false;
            // 
            // UserJobsGroupBox
            // 
            this.UserJobsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserJobsGroupBox.AutoSize = true;
            this.UserJobsGroupBox.Controls.Add(this.UserdataGridView);
            this.UserJobsGroupBox.Location = new System.Drawing.Point(-3, 132);
            this.UserJobsGroupBox.Name = "UserJobsGroupBox";
            this.UserJobsGroupBox.Size = new System.Drawing.Size(599, 321);
            this.UserJobsGroupBox.TabIndex = 8;
            this.UserJobsGroupBox.TabStop = false;
            this.UserJobsGroupBox.Text = "User Jobs";
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-3, -2);
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
            this.shapeContainer1.TabIndex = 9;
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
            this.bottomPanel.TabIndex = 14;
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
            // JobsPeruser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 472);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.UserJobsGroupBox);
            this.Controls.Add(this.UsergroupBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobsPeruser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobsPeruser";
            this.Load += new System.EventHandler(this.JobsPeruser_Load);
            this.UsergroupBox.ResumeLayout(false);
            this.UsergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
            this.UserJobsGroupBox.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UsergroupBox;
        private System.Windows.Forms.Button GetAllJobs;
        private System.Windows.Forms.Button GetJobs;
        private System.Windows.Forms.ComboBox UserNamecomboBox;
        private System.Windows.Forms.DataGridView UserdataGridView;
        private System.Windows.Forms.Label TotalJobsLbl;
        private System.Windows.Forms.GroupBox UserJobsGroupBox;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}
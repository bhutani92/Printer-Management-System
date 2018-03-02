namespace NewPMS
{
    partial class ChangeGroupQuota
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
            this.GroupNamecomboBox = new System.Windows.Forms.ComboBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.GroupQuotaGroupBox = new System.Windows.Forms.GroupBox();
            this.UpDateGroupQuota = new System.Windows.Forms.Button();
            this.GroupNameVal = new System.Windows.Forms.Label();
            this.GroupIdVal = new System.Windows.Forms.Label();
            this.GroupQuotaTxt = new System.Windows.Forms.TextBox();
            this.GroupQuotaLbl = new System.Windows.Forms.Label();
            this.GroupNameLbl = new System.Windows.Forms.Label();
            this.GroupIdLbl = new System.Windows.Forms.Label();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.GroupQuotaGroupBox.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupNamecomboBox
            // 
            this.GroupNamecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupNamecomboBox.FormattingEnabled = true;
            this.GroupNamecomboBox.Location = new System.Drawing.Point(12, 81);
            this.GroupNamecomboBox.Name = "GroupNamecomboBox";
            this.GroupNamecomboBox.Size = new System.Drawing.Size(137, 21);
            this.GroupNamecomboBox.TabIndex = 1;
            this.GroupNamecomboBox.Text = "--Select Group Here--";
            this.GroupNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.GroupNamecomboBox_SelectedIndexChanged);
            // 
            // GroupQuotaGroupBox
            // 
            this.GroupQuotaGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupQuotaGroupBox.AutoSize = true;
            this.GroupQuotaGroupBox.Controls.Add(this.UpDateGroupQuota);
            this.GroupQuotaGroupBox.Controls.Add(this.GroupNameVal);
            this.GroupQuotaGroupBox.Controls.Add(this.GroupIdVal);
            this.GroupQuotaGroupBox.Controls.Add(this.GroupQuotaTxt);
            this.GroupQuotaGroupBox.Controls.Add(this.GroupQuotaLbl);
            this.GroupQuotaGroupBox.Controls.Add(this.GroupNameLbl);
            this.GroupQuotaGroupBox.Controls.Add(this.GroupIdLbl);
            this.GroupQuotaGroupBox.Location = new System.Drawing.Point(287, 65);
            this.GroupQuotaGroupBox.Name = "GroupQuotaGroupBox";
            this.GroupQuotaGroupBox.Size = new System.Drawing.Size(195, 238);
            this.GroupQuotaGroupBox.TabIndex = 2;
            this.GroupQuotaGroupBox.TabStop = false;
            this.GroupQuotaGroupBox.Text = "Group Quota Update";
            this.GroupQuotaGroupBox.Visible = false;
            // 
            // UpDateGroupQuota
            // 
            this.UpDateGroupQuota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpDateGroupQuota.AutoSize = true;
            this.UpDateGroupQuota.Location = new System.Drawing.Point(18, 188);
            this.UpDateGroupQuota.Name = "UpDateGroupQuota";
            this.UpDateGroupQuota.Size = new System.Drawing.Size(116, 23);
            this.UpDateGroupQuota.TabIndex = 8;
            this.UpDateGroupQuota.Text = "Update Group Quota";
            this.UpDateGroupQuota.UseVisualStyleBackColor = true;
            this.UpDateGroupQuota.Click += new System.EventHandler(this.UpDateGroupQuota_Click);
            // 
            // GroupNameVal
            // 
            this.GroupNameVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupNameVal.AutoSize = true;
            this.GroupNameVal.Location = new System.Drawing.Point(108, 101);
            this.GroupNameVal.Name = "GroupNameVal";
            this.GroupNameVal.Size = new System.Drawing.Size(13, 13);
            this.GroupNameVal.TabIndex = 7;
            this.GroupNameVal.Text = "0";
            // 
            // GroupIdVal
            // 
            this.GroupIdVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupIdVal.AutoSize = true;
            this.GroupIdVal.Location = new System.Drawing.Point(108, 56);
            this.GroupIdVal.Name = "GroupIdVal";
            this.GroupIdVal.Size = new System.Drawing.Size(13, 13);
            this.GroupIdVal.TabIndex = 6;
            this.GroupIdVal.Text = "0";
            // 
            // GroupQuotaTxt
            // 
            this.GroupQuotaTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupQuotaTxt.Location = new System.Drawing.Point(111, 140);
            this.GroupQuotaTxt.Name = "GroupQuotaTxt";
            this.GroupQuotaTxt.Size = new System.Drawing.Size(75, 20);
            this.GroupQuotaTxt.TabIndex = 5;
            // 
            // GroupQuotaLbl
            // 
            this.GroupQuotaLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupQuotaLbl.AutoSize = true;
            this.GroupQuotaLbl.Location = new System.Drawing.Point(15, 147);
            this.GroupQuotaLbl.Name = "GroupQuotaLbl";
            this.GroupQuotaLbl.Size = new System.Drawing.Size(68, 13);
            this.GroupQuotaLbl.TabIndex = 4;
            this.GroupQuotaLbl.Text = "Group Quota";
            // 
            // GroupNameLbl
            // 
            this.GroupNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupNameLbl.AutoSize = true;
            this.GroupNameLbl.Location = new System.Drawing.Point(15, 101);
            this.GroupNameLbl.Name = "GroupNameLbl";
            this.GroupNameLbl.Size = new System.Drawing.Size(64, 13);
            this.GroupNameLbl.TabIndex = 3;
            this.GroupNameLbl.Text = "GroupName";
            // 
            // GroupIdLbl
            // 
            this.GroupIdLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupIdLbl.AutoSize = true;
            this.GroupIdLbl.Location = new System.Drawing.Point(15, 56);
            this.GroupIdLbl.Name = "GroupIdLbl";
            this.GroupIdLbl.Size = new System.Drawing.Size(45, 13);
            this.GroupIdLbl.TabIndex = 2;
            this.GroupIdLbl.Text = "GroupId";
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-2, -2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(497, 50);
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.topPanel});
            this.shapeContainer1.Size = new System.Drawing.Size(494, 372);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 330);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(494, 42);
            this.bottomPanel.TabIndex = 9;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(407, 7);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ChangeGroupQuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 372);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.GroupQuotaGroupBox);
            this.Controls.Add(this.GroupNamecomboBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeGroupQuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeGroupQuota";
            this.Load += new System.EventHandler(this.ChnageGroupQuota_Load);
            this.GroupQuotaGroupBox.ResumeLayout(false);
            this.GroupQuotaGroupBox.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GroupNamecomboBox;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.GroupBox GroupQuotaGroupBox;
        private System.Windows.Forms.Button UpDateGroupQuota;
        private System.Windows.Forms.Label GroupNameVal;
        private System.Windows.Forms.Label GroupIdVal;
        private System.Windows.Forms.TextBox GroupQuotaTxt;
        private System.Windows.Forms.Label GroupQuotaLbl;
        private System.Windows.Forms.Label GroupNameLbl;
        private System.Windows.Forms.Label GroupIdLbl;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}
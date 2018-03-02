namespace NewPMS
{
    partial class BillingPerUser
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
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.CostOfUserLbl = new System.Windows.Forms.Label();
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ShowBill = new System.Windows.Forms.Button();
            this.UserNameComboBox = new System.Windows.Forms.ComboBox();
            this.UserdataGridView = new System.Windows.Forms.DataGridView();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.UserGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserGroupBox.AutoSize = true;
            this.UserGroupBox.Controls.Add(this.CostOfUserLbl);
            this.UserGroupBox.Controls.Add(this.TodateTimePicker);
            this.UserGroupBox.Controls.Add(this.FromdateTimePicker);
            this.UserGroupBox.Controls.Add(this.UserNameComboBox);
            this.UserGroupBox.Location = new System.Drawing.Point(-3, 51);
            this.UserGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.UserGroupBox.Size = new System.Drawing.Size(599, 94);
            this.UserGroupBox.TabIndex = 2;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "Select Appropriate User";
            // 
            // CostOfUserLbl
            // 
            this.CostOfUserLbl.AutoSize = true;
            this.CostOfUserLbl.Location = new System.Drawing.Point(316, 66);
            this.CostOfUserLbl.Name = "CostOfUserLbl";
            this.CostOfUserLbl.Size = new System.Drawing.Size(0, 13);
            this.CostOfUserLbl.TabIndex = 4;
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TodateTimePicker.Location = new System.Drawing.Point(394, 40);
            this.TodateTimePicker.Name = "TodateTimePicker";
            this.TodateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.TodateTimePicker.TabIndex = 3;
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromdateTimePicker.Location = new System.Drawing.Point(205, 39);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.FromdateTimePicker.TabIndex = 2;
            // 
            // ShowBill
            // 
            this.ShowBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowBill.AutoSize = true;
            this.ShowBill.Location = new System.Drawing.Point(11, 7);
            this.ShowBill.Margin = new System.Windows.Forms.Padding(2);
            this.ShowBill.Name = "ShowBill";
            this.ShowBill.Size = new System.Drawing.Size(75, 23);
            this.ShowBill.TabIndex = 0;
            this.ShowBill.Text = "Show Bill";
            this.ShowBill.UseVisualStyleBackColor = true;
            this.ShowBill.Click += new System.EventHandler(this.ShowBill_Click);
            // 
            // UserNameComboBox
            // 
            this.UserNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameComboBox.FormattingEnabled = true;
            this.UserNameComboBox.Location = new System.Drawing.Point(16, 39);
            this.UserNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameComboBox.Name = "UserNameComboBox";
            this.UserNameComboBox.Size = new System.Drawing.Size(170, 21);
            this.UserNameComboBox.TabIndex = 0;
            // 
            // UserdataGridView
            // 
            this.UserdataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.UserdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView.Location = new System.Drawing.Point(-3, 132);
            this.UserdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.UserdataGridView.Name = "UserdataGridView";
            this.UserdataGridView.RowTemplate.Height = 24;
            this.UserdataGridView.Size = new System.Drawing.Size(599, 300);
            this.UserdataGridView.TabIndex = 3;
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
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Controls.Add(this.ShowBill);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 430);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(594, 42);
            this.bottomPanel.TabIndex = 10;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(507, 7);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // BillingPerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 472);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.UserdataGridView);
            this.Controls.Add(this.UserGroupBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillingPerUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingPerUser";
            this.Load += new System.EventHandler(this.BillingPerUser_Load);
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.DateTimePicker TodateTimePicker;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.Button ShowBill;
        private System.Windows.Forms.ComboBox UserNameComboBox;
        private System.Windows.Forms.DataGridView UserdataGridView;
        private System.Windows.Forms.Label CostOfUserLbl;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}
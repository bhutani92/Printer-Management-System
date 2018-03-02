namespace NewPMS
{
    partial class Users
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
            this.SelectUserGroupBox = new System.Windows.Forms.GroupBox();
            this.GetAllUserInformationBtn = new System.Windows.Forms.Button();
            this.GetuserInformationBtn = new System.Windows.Forms.Button();
            this.UserNameComboBox = new System.Windows.Forms.ComboBox();
            this.DisplayUserGroupBox = new System.Windows.Forms.GroupBox();
            this.UserTabGrid = new System.Windows.Forms.DataGridView();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.SelectUserGroupBox.SuspendLayout();
            this.DisplayUserGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserTabGrid)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectUserGroupBox
            // 
            this.SelectUserGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectUserGroupBox.AutoSize = true;
            this.SelectUserGroupBox.Controls.Add(this.GetAllUserInformationBtn);
            this.SelectUserGroupBox.Controls.Add(this.GetuserInformationBtn);
            this.SelectUserGroupBox.Controls.Add(this.UserNameComboBox);
            this.SelectUserGroupBox.Location = new System.Drawing.Point(-3, 54);
            this.SelectUserGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectUserGroupBox.Name = "SelectUserGroupBox";
            this.SelectUserGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SelectUserGroupBox.Size = new System.Drawing.Size(599, 76);
            this.SelectUserGroupBox.TabIndex = 0;
            this.SelectUserGroupBox.TabStop = false;
            this.SelectUserGroupBox.Text = "Select User";
            // 
            // GetAllUserInformationBtn
            // 
            this.GetAllUserInformationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetAllUserInformationBtn.AutoSize = true;
            this.GetAllUserInformationBtn.Location = new System.Drawing.Point(422, 25);
            this.GetAllUserInformationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GetAllUserInformationBtn.Name = "GetAllUserInformationBtn";
            this.GetAllUserInformationBtn.Size = new System.Drawing.Size(148, 23);
            this.GetAllUserInformationBtn.TabIndex = 2;
            this.GetAllUserInformationBtn.Text = "Get All User Information";
            this.GetAllUserInformationBtn.UseVisualStyleBackColor = true;
            this.GetAllUserInformationBtn.Click += new System.EventHandler(this.GetAllUserInformationBtn_Click);
            // 
            // GetuserInformationBtn
            // 
            this.GetuserInformationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetuserInformationBtn.AutoSize = true;
            this.GetuserInformationBtn.Location = new System.Drawing.Point(241, 23);
            this.GetuserInformationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GetuserInformationBtn.Name = "GetuserInformationBtn";
            this.GetuserInformationBtn.Size = new System.Drawing.Size(148, 23);
            this.GetuserInformationBtn.TabIndex = 1;
            this.GetuserInformationBtn.Text = "Get User Information";
            this.GetuserInformationBtn.UseVisualStyleBackColor = true;
            this.GetuserInformationBtn.Click += new System.EventHandler(this.GetuserInformationBtn_Click);
            // 
            // UserNameComboBox
            // 
            this.UserNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameComboBox.FormattingEnabled = true;
            this.UserNameComboBox.Location = new System.Drawing.Point(59, 25);
            this.UserNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameComboBox.Name = "UserNameComboBox";
            this.UserNameComboBox.Size = new System.Drawing.Size(139, 21);
            this.UserNameComboBox.TabIndex = 0;
            // 
            // DisplayUserGroupBox
            // 
            this.DisplayUserGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayUserGroupBox.AutoSize = true;
            this.DisplayUserGroupBox.Controls.Add(this.UserTabGrid);
            this.DisplayUserGroupBox.Location = new System.Drawing.Point(-1, 137);
            this.DisplayUserGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayUserGroupBox.Name = "DisplayUserGroupBox";
            this.DisplayUserGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.DisplayUserGroupBox.Size = new System.Drawing.Size(597, 314);
            this.DisplayUserGroupBox.TabIndex = 1;
            this.DisplayUserGroupBox.TabStop = false;
            this.DisplayUserGroupBox.Text = "Display User Information";
           
            // 
            // UserTabGrid
            // 
            this.UserTabGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserTabGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.UserTabGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.UserTabGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserTabGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserTabGrid.Location = new System.Drawing.Point(-5, 26);
            this.UserTabGrid.Margin = new System.Windows.Forms.Padding(2);
            this.UserTabGrid.Name = "UserTabGrid";
            this.UserTabGrid.RowTemplate.Height = 24;
            this.UserTabGrid.Size = new System.Drawing.Size(599, 271);
            this.UserTabGrid.TabIndex = 0;
            
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
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bottomPanel.Controls.Add(this.okButton);
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
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 472);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.DisplayUserGroupBox);
            this.Controls.Add(this.SelectUserGroupBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.SelectUserGroupBox.ResumeLayout(false);
            this.SelectUserGroupBox.PerformLayout();
            this.DisplayUserGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserTabGrid)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectUserGroupBox;
        private System.Windows.Forms.GroupBox DisplayUserGroupBox;
        private System.Windows.Forms.ComboBox UserNameComboBox;
        private System.Windows.Forms.Button GetAllUserInformationBtn;
        private System.Windows.Forms.Button GetuserInformationBtn;
        private System.Windows.Forms.DataGridView UserTabGrid;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}
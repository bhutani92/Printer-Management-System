namespace NewPMS
{
    partial class AddUsersToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsersToGroup));
            this.UserlistView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UsergroupBox = new System.Windows.Forms.GroupBox();
            this.AddUserToGroup = new System.Windows.Forms.Button();
            this.GroupNamecomboBox = new System.Windows.Forms.ComboBox();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.UsergroupBox.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserlistView
            // 
            this.UserlistView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserlistView.CheckBoxes = true;
            this.UserlistView.LargeImageList = this.imageList1;
            this.UserlistView.Location = new System.Drawing.Point(0, 44);
            this.UserlistView.Margin = new System.Windows.Forms.Padding(2);
            this.UserlistView.Name = "UserlistView";
            this.UserlistView.Size = new System.Drawing.Size(357, 290);
            this.UserlistView.SmallImageList = this.imageList1;
            this.UserlistView.TabIndex = 0;
            this.UserlistView.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "images (1).jpg");
            // 
            // UsergroupBox
            // 
            this.UsergroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsergroupBox.AutoSize = true;
            this.UsergroupBox.Controls.Add(this.AddUserToGroup);
            this.UsergroupBox.Controls.Add(this.GroupNamecomboBox);
            this.UsergroupBox.Location = new System.Drawing.Point(361, 51);
            this.UsergroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsergroupBox.Name = "UsergroupBox";
            this.UsergroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.UsergroupBox.Size = new System.Drawing.Size(131, 274);
            this.UsergroupBox.TabIndex = 1;
            this.UsergroupBox.TabStop = false;
            this.UsergroupBox.Text = "Select Group";
            // 
            // AddUserToGroup
            // 
            this.AddUserToGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddUserToGroup.AutoSize = true;
            this.AddUserToGroup.Location = new System.Drawing.Point(12, 149);
            this.AddUserToGroup.Margin = new System.Windows.Forms.Padding(2);
            this.AddUserToGroup.Name = "AddUserToGroup";
            this.AddUserToGroup.Size = new System.Drawing.Size(109, 23);
            this.AddUserToGroup.TabIndex = 1;
            this.AddUserToGroup.Text = "Add User To Group";
            this.AddUserToGroup.UseVisualStyleBackColor = true;
            this.AddUserToGroup.Click += new System.EventHandler(this.AddUserToGroup_Click);
            // 
            // GroupNamecomboBox
            // 
            this.GroupNamecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupNamecomboBox.FormattingEnabled = true;
            this.GroupNamecomboBox.Location = new System.Drawing.Point(12, 68);
            this.GroupNamecomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.GroupNamecomboBox.Name = "GroupNamecomboBox";
            this.GroupNamecomboBox.Size = new System.Drawing.Size(109, 21);
            this.GroupNamecomboBox.TabIndex = 0;
            this.GroupNamecomboBox.Text = "--Select Group-- ";
            this.GroupNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.GroupNamecomboBox_SelectedIndexChanged);
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-3, -3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(498, 50);
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
            this.shapeContainer1.TabIndex = 2;
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
            this.bottomPanel.TabIndex = 13;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(407, 12);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddUsersToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 372);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.UsergroupBox);
            this.Controls.Add(this.UserlistView);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUsersToGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUsersToGroup";
            this.Load += new System.EventHandler(this.AddUsersToGroup_Load);
            this.UsergroupBox.ResumeLayout(false);
            this.UsergroupBox.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView UserlistView;
        private System.Windows.Forms.GroupBox UsergroupBox;
        private System.Windows.Forms.Button AddUserToGroup;
        private System.Windows.Forms.ComboBox GroupNamecomboBox;
        private System.Windows.Forms.ImageList imageList1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}
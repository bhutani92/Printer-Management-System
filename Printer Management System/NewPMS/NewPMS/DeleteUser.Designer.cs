namespace NewPMS
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.Userlist = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.RemoveUser = new System.Windows.Forms.Button();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Userlist
            // 
            this.Userlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Userlist.LargeImageList = this.imageList1;
            this.Userlist.Location = new System.Drawing.Point(-5, 39);
            this.Userlist.Name = "Userlist";
            this.Userlist.Size = new System.Drawing.Size(501, 294);
            this.Userlist.SmallImageList = this.imageList1;
            this.Userlist.TabIndex = 1;
            this.Userlist.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "images (1).jpg");
            // 
            // RemoveUser
            // 
            this.RemoveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveUser.AutoSize = true;
            this.RemoveUser.Location = new System.Drawing.Point(307, 9);
            this.RemoveUser.Name = "RemoveUser";
            this.RemoveUser.Size = new System.Drawing.Size(96, 23);
            this.RemoveUser.TabIndex = 2;
            this.RemoveUser.Text = "REMOVE USER";
            this.RemoveUser.UseVisualStyleBackColor = true;
            this.RemoveUser.Click += new System.EventHandler(this.RemoveUser_Click);
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-5, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(500, 50);
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
            this.bottomPanel.Controls.Add(this.RemoveUser);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 330);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(494, 42);
            this.bottomPanel.TabIndex = 10;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(407, 9);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 372);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.Userlist);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteUser";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Userlist;
        private System.Windows.Forms.Button RemoveUser;
        private System.Windows.Forms.ImageList imageList1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}
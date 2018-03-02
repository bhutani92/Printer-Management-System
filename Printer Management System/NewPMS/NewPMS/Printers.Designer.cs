namespace NewPMS
{
    partial class Printers
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
            this.PrintersTabGrid = new System.Windows.Forms.DataGridView();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrintersTabGrid)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintersTabGrid
            // 
            this.PrintersTabGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.PrintersTabGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.PrintersTabGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrintersTabGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintersTabGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.PrintersTabGrid.Location = new System.Drawing.Point(-4, 53);
            this.PrintersTabGrid.Margin = new System.Windows.Forms.Padding(2);
            this.PrintersTabGrid.Name = "PrintersTabGrid";
            this.PrintersTabGrid.RowTemplate.Height = 24;
            this.PrintersTabGrid.Size = new System.Drawing.Size(599, 379);
            this.PrintersTabGrid.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-4, -2);
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
            this.shapeContainer1.TabIndex = 1;
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
            this.bottomPanel.TabIndex = 9;
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
            // Printers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 472);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.PrintersTabGrid);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Printers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printers";
            this.Load += new System.EventHandler(this.Printers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrintersTabGrid)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PrintersTabGrid;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}
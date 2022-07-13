namespace Timezone_Plus
{
    partial class Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Input));
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.txtJson = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndelete = new ReaLTaiizor.Controls.LostCancelButton();
            this.btncopy = new ReaLTaiizor.Controls.LostAcceptButton();
            this.parrotGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hopeForm1
            // 
            this.hopeForm1.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm1.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm1.Image = ((System.Drawing.Image)(resources.GetObject("hopeForm1.Image")));
            this.hopeForm1.Location = new System.Drawing.Point(0, 0);
            this.hopeForm1.Name = "hopeForm1";
            this.hopeForm1.Padding = new System.Windows.Forms.Padding(2);
            this.hopeForm1.Size = new System.Drawing.Size(556, 40);
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.Text = "Xoá chuỗi";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // parrotGroupBox1
            // 
            this.parrotGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parrotGroupBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.parrotGroupBox1.BorderWidth = 1;
            this.parrotGroupBox1.Controls.Add(this.txtJson);
            this.parrotGroupBox1.Location = new System.Drawing.Point(0, 40);
            this.parrotGroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.parrotGroupBox1.ShowText = true;
            this.parrotGroupBox1.Size = new System.Drawing.Size(556, 347);
            this.parrotGroupBox1.TabIndex = 1;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // txtJson
            // 
            this.txtJson.BackColor = System.Drawing.SystemColors.Control;
            this.txtJson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJson.Location = new System.Drawing.Point(5, 21);
            this.txtJson.Margin = new System.Windows.Forms.Padding(0);
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(546, 321);
            this.txtJson.TabIndex = 0;
            this.txtJson.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btncopy);
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 52);
            this.panel1.TabIndex = 2;
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.HoverColor = System.Drawing.Color.IndianRed;
            this.btndelete.Image = null;
            this.btndelete.Location = new System.Drawing.Point(336, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(185, 40);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Xoá";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncopy
            // 
            this.btncopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncopy.BackColor = System.Drawing.Color.SeaGreen;
            this.btncopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncopy.ForeColor = System.Drawing.Color.White;
            this.btncopy.HoverColor = System.Drawing.Color.ForestGreen;
            this.btncopy.Image = null;
            this.btncopy.Location = new System.Drawing.Point(62, 3);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(185, 40);
            this.btncopy.TabIndex = 0;
            this.btncopy.Text = "Copy";
            this.btncopy.Click += new System.EventHandler(this.btncopy_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.parrotGroupBox1);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoá chuỗi";
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private RichTextBox txtJson;
        private Panel panel1;
        private ReaLTaiizor.Controls.LostCancelButton btndelete;
        private ReaLTaiizor.Controls.LostAcceptButton btncopy;
    }
}
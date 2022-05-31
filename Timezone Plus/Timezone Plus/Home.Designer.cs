namespace Timezone_Plus
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtcheckip = new ReaLTaiizor.Controls.LostAcceptButton();
            this.lostCancelButton1 = new ReaLTaiizor.Controls.LostCancelButton();
            this.lostAcceptButton2 = new ReaLTaiizor.Controls.LostAcceptButton();
            this.txtIP = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hopeForm1
            // 
            this.hopeForm1.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm1.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hopeForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm1.Image = ((System.Drawing.Image)(resources.GetObject("hopeForm1.Image")));
            this.hopeForm1.Location = new System.Drawing.Point(0, 0);
            this.hopeForm1.Name = "hopeForm1";
            this.hopeForm1.Size = new System.Drawing.Size(453, 40);
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.Text = "Timezone Plus";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIP, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 528);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.txtcheckip, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lostCancelButton1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lostAcceptButton2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 425);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(447, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtcheckip
            // 
            this.txtcheckip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcheckip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtcheckip.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcheckip.ForeColor = System.Drawing.Color.White;
            this.txtcheckip.HoverColor = System.Drawing.Color.LightSkyBlue;
            this.txtcheckip.Image = null;
            this.txtcheckip.Location = new System.Drawing.Point(3, 30);
            this.txtcheckip.Name = "txtcheckip";
            this.txtcheckip.Size = new System.Drawing.Size(142, 40);
            this.txtcheckip.TabIndex = 0;
            this.txtcheckip.Text = "Kiểm tra IP";
            this.txtcheckip.Click += new System.EventHandler(this.txtcheckip_Click);
            // 
            // lostCancelButton1
            // 
            this.lostCancelButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lostCancelButton1.BackColor = System.Drawing.Color.Crimson;
            this.lostCancelButton1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lostCancelButton1.ForeColor = System.Drawing.Color.White;
            this.lostCancelButton1.HoverColor = System.Drawing.Color.IndianRed;
            this.lostCancelButton1.Image = null;
            this.lostCancelButton1.Location = new System.Drawing.Point(151, 30);
            this.lostCancelButton1.Name = "lostCancelButton1";
            this.lostCancelButton1.Size = new System.Drawing.Size(143, 40);
            this.lostCancelButton1.TabIndex = 1;
            this.lostCancelButton1.Text = "Kiểm tra IP nâng cao";
            this.lostCancelButton1.Click += new System.EventHandler(this.lostCancelButton1_Click);
            // 
            // lostAcceptButton2
            // 
            this.lostAcceptButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lostAcceptButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.lostAcceptButton2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lostAcceptButton2.ForeColor = System.Drawing.Color.White;
            this.lostAcceptButton2.HoverColor = System.Drawing.Color.ForestGreen;
            this.lostAcceptButton2.Image = null;
            this.lostAcceptButton2.Location = new System.Drawing.Point(300, 30);
            this.lostAcceptButton2.Name = "lostAcceptButton2";
            this.lostAcceptButton2.Size = new System.Drawing.Size(144, 40);
            this.lostAcceptButton2.TabIndex = 2;
            this.lostAcceptButton2.Text = "Đồng bộ thời gian";
            this.lostAcceptButton2.Click += new System.EventHandler(this.lostAcceptButton2_Click);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIP.ForeColor = System.Drawing.Color.White;
            this.txtIP.Location = new System.Drawing.Point(3, 3);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(447, 416);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(453, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timezone plus";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.LostAcceptButton txtcheckip;
        private ReaLTaiizor.Controls.LostCancelButton lostCancelButton1;
        private ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton2;
        private RichTextBox txtIP;
    }
}
namespace proyecto_cine
{
    partial class Confirmarcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmarcs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SIbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NObtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 32);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto_cine.Properties.Resources.Btn_cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(306, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿ESTA SEGURO?";
            // 
            // SIbtn
            // 
            this.SIbtn.ActiveBorderThickness = 1;
            this.SIbtn.ActiveCornerRadius = 5;
            this.SIbtn.ActiveFillColor = System.Drawing.Color.White;
            this.SIbtn.ActiveForecolor = System.Drawing.Color.Black;
            this.SIbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.SIbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.SIbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SIbtn.BackgroundImage")));
            this.SIbtn.ButtonText = "SI";
            this.SIbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SIbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SIbtn.IdleBorderThickness = 1;
            this.SIbtn.IdleCornerRadius = 1;
            this.SIbtn.IdleFillColor = System.Drawing.Color.Black;
            this.SIbtn.IdleForecolor = System.Drawing.Color.White;
            this.SIbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.SIbtn.Location = new System.Drawing.Point(61, 161);
            this.SIbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SIbtn.Name = "SIbtn";
            this.SIbtn.Size = new System.Drawing.Size(86, 41);
            this.SIbtn.TabIndex = 11;
            this.SIbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SIbtn.Click += new System.EventHandler(this.SIbtn_Click);
            // 
            // NObtn
            // 
            this.NObtn.ActiveBorderThickness = 1;
            this.NObtn.ActiveCornerRadius = 5;
            this.NObtn.ActiveFillColor = System.Drawing.Color.White;
            this.NObtn.ActiveForecolor = System.Drawing.Color.Black;
            this.NObtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.NObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.NObtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NObtn.BackgroundImage")));
            this.NObtn.ButtonText = "NO";
            this.NObtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NObtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NObtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.NObtn.IdleBorderThickness = 1;
            this.NObtn.IdleCornerRadius = 1;
            this.NObtn.IdleFillColor = System.Drawing.Color.Black;
            this.NObtn.IdleForecolor = System.Drawing.Color.White;
            this.NObtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.NObtn.Location = new System.Drawing.Point(190, 161);
            this.NObtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NObtn.Name = "NObtn";
            this.NObtn.Size = new System.Drawing.Size(92, 41);
            this.NObtn.TabIndex = 12;
            this.NObtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NObtn.Click += new System.EventHandler(this.NObtn_Click);
            // 
            // Confirmarcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(361, 256);
            this.Controls.Add(this.NObtn);
            this.Controls.Add(this.SIbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirmarcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmarcs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 SIbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 NObtn;
    }
}
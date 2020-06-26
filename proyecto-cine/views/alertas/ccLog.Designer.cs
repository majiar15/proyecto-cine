namespace proyecto_cine
{
    partial class ccLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ccLog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.panel1.Size = new System.Drawing.Size(368, 32);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto_cine.Properties.Resources.Btn_cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(331, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // enviar
            // 
            this.enviar.ActiveBorderThickness = 1;
            this.enviar.ActiveCornerRadius = 5;
            this.enviar.ActiveFillColor = System.Drawing.Color.White;
            this.enviar.ActiveForecolor = System.Drawing.Color.Black;
            this.enviar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.enviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enviar.BackgroundImage")));
            this.enviar.ButtonText = "enviar";
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.ForeColor = System.Drawing.Color.SeaGreen;
            this.enviar.IdleBorderThickness = 1;
            this.enviar.IdleCornerRadius = 1;
            this.enviar.IdleFillColor = System.Drawing.Color.Black;
            this.enviar.IdleForecolor = System.Drawing.Color.White;
            this.enviar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.enviar.Location = new System.Drawing.Point(263, 145);
            this.enviar.Margin = new System.Windows.Forms.Padding(5);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(78, 41);
            this.enviar.TabIndex = 25;
            this.enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // cc
            // 
            this.cc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cc.Location = new System.Drawing.Point(55, 97);
            this.cc.Multiline = true;
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(241, 27);
            this.cc.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "CC. USUARIO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(362, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 170);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 6);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 164);
            this.panel4.TabIndex = 28;
            // 
            // cancelar
            // 
            this.cancelar.ActiveBorderThickness = 1;
            this.cancelar.ActiveCornerRadius = 5;
            this.cancelar.ActiveFillColor = System.Drawing.Color.White;
            this.cancelar.ActiveForecolor = System.Drawing.Color.Black;
            this.cancelar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelar.BackgroundImage")));
            this.cancelar.ButtonText = "cancelar";
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelar.IdleBorderThickness = 1;
            this.cancelar.IdleCornerRadius = 1;
            this.cancelar.IdleFillColor = System.Drawing.Color.Black;
            this.cancelar.IdleForecolor = System.Drawing.Color.White;
            this.cancelar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.cancelar.Location = new System.Drawing.Point(39, 146);
            this.cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(92, 41);
            this.cancelar.TabIndex = 29;
            this.cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ccLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(368, 202);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ccLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ccLog";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 enviar;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelar;
    }
}
namespace proyecto_cine
{
    partial class ReporteFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFecha));
            this.titleReserva = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pagarReservaButtom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // titleReserva
            // 
            this.titleReserva.AutoSize = true;
            this.titleReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleReserva.Location = new System.Drawing.Point(146, 49);
            this.titleReserva.Name = "titleReserva";
            this.titleReserva.Size = new System.Drawing.Size(454, 92);
            this.titleReserva.TabIndex = 5;
            this.titleReserva.Text = "REPORTE DE VENTA \r\n       POR FECHA";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(121, 170);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // pagarReservaButtom
            // 
            this.pagarReservaButtom.ActiveBorderThickness = 1;
            this.pagarReservaButtom.ActiveCornerRadius = 30;
            this.pagarReservaButtom.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pagarReservaButtom.ActiveForecolor = System.Drawing.Color.White;
            this.pagarReservaButtom.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.pagarReservaButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.pagarReservaButtom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pagarReservaButtom.BackgroundImage")));
            this.pagarReservaButtom.ButtonText = "Enviar";
            this.pagarReservaButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pagarReservaButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pagarReservaButtom.ForeColor = System.Drawing.Color.SeaGreen;
            this.pagarReservaButtom.IdleBorderThickness = 1;
            this.pagarReservaButtom.IdleCornerRadius = 20;
            this.pagarReservaButtom.IdleFillColor = System.Drawing.Color.Black;
            this.pagarReservaButtom.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.pagarReservaButtom.IdleLineColor = System.Drawing.Color.Black;
            this.pagarReservaButtom.Location = new System.Drawing.Point(618, 488);
            this.pagarReservaButtom.Margin = new System.Windows.Forms.Padding(11);
            this.pagarReservaButtom.Name = "pagarReservaButtom";
            this.pagarReservaButtom.Size = new System.Drawing.Size(124, 38);
            this.pagarReservaButtom.TabIndex = 11;
            this.pagarReservaButtom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReporteFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(749, 535);
            this.Controls.Add(this.pagarReservaButtom);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.titleReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteFecha";
            this.Text = "ReporteFecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleReserva;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Bunifu.Framework.UI.BunifuThinButton2 pagarReservaButtom;
    }
}
﻿namespace proyecto_cine
{
    partial class Reservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelarReservaButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.reservarBoletoButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.titleReserva = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.cancelarReservaButton);
            this.panel1.Controls.Add(this.reservarBoletoButton);
            this.panel1.Controls.Add(this.titleReserva);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 644);
            this.panel1.TabIndex = 0;
            // 
            // cancelarReservaButton
            // 
            this.cancelarReservaButton.ActiveBorderThickness = 1;
            this.cancelarReservaButton.ActiveCornerRadius = 30;
            this.cancelarReservaButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cancelarReservaButton.ActiveForecolor = System.Drawing.Color.White;
            this.cancelarReservaButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.cancelarReservaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.cancelarReservaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelarReservaButton.BackgroundImage")));
            this.cancelarReservaButton.ButtonText = "Cancelar Reserva";
            this.cancelarReservaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarReservaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelarReservaButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelarReservaButton.IdleBorderThickness = 1;
            this.cancelarReservaButton.IdleCornerRadius = 20;
            this.cancelarReservaButton.IdleFillColor = System.Drawing.Color.Black;
            this.cancelarReservaButton.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.cancelarReservaButton.IdleLineColor = System.Drawing.Color.Black;
            this.cancelarReservaButton.Location = new System.Drawing.Point(449, 264);
            this.cancelarReservaButton.Margin = new System.Windows.Forms.Padding(11);
            this.cancelarReservaButton.Name = "cancelarReservaButton";
            this.cancelarReservaButton.Size = new System.Drawing.Size(225, 99);
            this.cancelarReservaButton.TabIndex = 6;
            this.cancelarReservaButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelarReservaButton.Click += new System.EventHandler(this.cancelarReservaButton_Click);
            // 
            // reservarBoletoButton
            // 
            this.reservarBoletoButton.ActiveBorderThickness = 5;
            this.reservarBoletoButton.ActiveCornerRadius = 30;
            this.reservarBoletoButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.reservarBoletoButton.ActiveForecolor = System.Drawing.Color.White;
            this.reservarBoletoButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.reservarBoletoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.reservarBoletoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reservarBoletoButton.BackgroundImage")));
            this.reservarBoletoButton.ButtonText = "Reservar boleto";
            this.reservarBoletoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservarBoletoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reservarBoletoButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.reservarBoletoButton.IdleBorderThickness = 1;
            this.reservarBoletoButton.IdleCornerRadius = 20;
            this.reservarBoletoButton.IdleFillColor = System.Drawing.Color.Black;
            this.reservarBoletoButton.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.reservarBoletoButton.IdleLineColor = System.Drawing.Color.Black;
            this.reservarBoletoButton.Location = new System.Drawing.Point(145, 264);
            this.reservarBoletoButton.Margin = new System.Windows.Forms.Padding(11);
            this.reservarBoletoButton.Name = "reservarBoletoButton";
            this.reservarBoletoButton.Size = new System.Drawing.Size(220, 99);
            this.reservarBoletoButton.TabIndex = 5;
            this.reservarBoletoButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reservarBoletoButton.Click += new System.EventHandler(this.reservarBoletoButton_Click);
            // 
            // titleReserva
            // 
            this.titleReserva.AutoSize = true;
            this.titleReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleReserva.Location = new System.Drawing.Point(316, 86);
            this.titleReserva.Name = "titleReserva";
            this.titleReserva.Size = new System.Drawing.Size(174, 46);
            this.titleReserva.TabIndex = 4;
            this.titleReserva.Text = "Reserva";
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 644);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservas";
            this.Text = "Reservas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelarReservaButton;
        private Bunifu.Framework.UI.BunifuThinButton2 reservarBoletoButton;
        private System.Windows.Forms.Label titleReserva;
    }
}
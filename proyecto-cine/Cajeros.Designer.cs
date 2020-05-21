using System;
using System.Windows.Forms;

namespace proyecto_cine
{
    partial class Cajeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cajeros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTextboxBuscarIdCaje = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnEliminarCajero = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.enviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.bunifuTextboxBuscarIdCaje);
            this.panel1.Controls.Add(this.btnEliminarCajero);
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Controls.Add(this.enviar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 535);
            this.panel1.TabIndex = 0;
            // 
            // bunifuTextboxBuscarIdCaje
            // 
            this.bunifuTextboxBuscarIdCaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.bunifuTextboxBuscarIdCaje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxBuscarIdCaje.BackgroundImage")));
            this.bunifuTextboxBuscarIdCaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextboxBuscarIdCaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextboxBuscarIdCaje.ForeColor = System.Drawing.Color.Black;
            this.bunifuTextboxBuscarIdCaje.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxBuscarIdCaje.Icon")));
            this.bunifuTextboxBuscarIdCaje.Location = new System.Drawing.Point(487, 97);
            this.bunifuTextboxBuscarIdCaje.Name = "bunifuTextboxBuscarIdCaje";
            this.bunifuTextboxBuscarIdCaje.Size = new System.Drawing.Size(250, 42);
            this.bunifuTextboxBuscarIdCaje.TabIndex = 50;
            this.bunifuTextboxBuscarIdCaje.text = "";
            this.bunifuTextboxBuscarIdCaje.OnTextChange += new System.EventHandler(this.bunifuTextboxBuscarIdCaje_OnTextChange);
            // 
            // btnEliminarCajero
            // 
            this.btnEliminarCajero.ActiveBorderThickness = 1;
            this.btnEliminarCajero.ActiveCornerRadius = 1;
            this.btnEliminarCajero.ActiveFillColor = System.Drawing.Color.White;
            this.btnEliminarCajero.ActiveForecolor = System.Drawing.Color.Black;
            this.btnEliminarCajero.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.btnEliminarCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.btnEliminarCajero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarCajero.BackgroundImage")));
            this.btnEliminarCajero.ButtonText = "Eliminar";
            this.btnEliminarCajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCajero.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCajero.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCajero.IdleBorderThickness = 1;
            this.btnEliminarCajero.IdleCornerRadius = 1;
            this.btnEliminarCajero.IdleFillColor = System.Drawing.Color.Black;
            this.btnEliminarCajero.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.btnEliminarCajero.IdleLineColor = System.Drawing.Color.White;
            this.btnEliminarCajero.Location = new System.Drawing.Point(587, 401);
            this.btnEliminarCajero.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnEliminarCajero.Name = "btnEliminarCajero";
            this.btnEliminarCajero.Size = new System.Drawing.Size(156, 43);
            this.btnEliminarCajero.TabIndex = 48;
            this.btnEliminarCajero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarCajero.Click += new System.EventHandler(this.btnEliminarCajero_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 1;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.bunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Modificar";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 1;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton24.Location = new System.Drawing.Point(587, 325);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(156, 43);
            this.bunifuThinButton24.TabIndex = 47;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click_1);
            // 
            // enviar
            // 
            this.enviar.ActiveBorderThickness = 1;
            this.enviar.ActiveCornerRadius = 1;
            this.enviar.ActiveFillColor = System.Drawing.Color.White;
            this.enviar.ActiveForecolor = System.Drawing.Color.Black;
            this.enviar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.enviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enviar.BackgroundImage")));
            this.enviar.ButtonText = "Crear";
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.ForeColor = System.Drawing.Color.White;
            this.enviar.IdleBorderThickness = 1;
            this.enviar.IdleCornerRadius = 1;
            this.enviar.IdleFillColor = System.Drawing.Color.Black;
            this.enviar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.enviar.IdleLineColor = System.Drawing.Color.White;
            this.enviar.Location = new System.Drawing.Point(587, 249);
            this.enviar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(156, 43);
            this.enviar.TabIndex = 46;
            this.enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 13.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(566, 363);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(274, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 57);
            this.label1.TabIndex = 27;
            this.label1.Text = "CAJEROS";
            // 
            // Cajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 535);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cajeros";
            this.Text = "Cajeros";
            this.Load += new System.EventHandler(this.Cajeros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void menuBuscar_OnTextChange(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminarCajero;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 enviar;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextboxBuscarIdCaje;
        public DataGridView dataGridView1;
    }
}
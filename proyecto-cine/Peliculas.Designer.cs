namespace proyecto_cine
{
    partial class Peliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peliculas));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Crear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Modificar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.eliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Buscador = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peliculas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 326);
            this.dataGridView1.TabIndex = 1;
            // 
            // Crear
            // 
            this.Crear.ActiveBorderThickness = 1;
            this.Crear.ActiveCornerRadius = 1;
            this.Crear.ActiveFillColor = System.Drawing.Color.White;
            this.Crear.ActiveForecolor = System.Drawing.Color.Black;
            this.Crear.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.Crear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Crear.BackgroundImage")));
            this.Crear.ButtonText = "Crear";
            this.Crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Crear.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crear.ForeColor = System.Drawing.Color.SeaGreen;
            this.Crear.IdleBorderThickness = 1;
            this.Crear.IdleCornerRadius = 1;
            this.Crear.IdleFillColor = System.Drawing.Color.Black;
            this.Crear.IdleForecolor = System.Drawing.Color.White;
            this.Crear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.Crear.Location = new System.Drawing.Point(594, 251);
            this.Crear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(126, 49);
            this.Crear.TabIndex = 2;
            this.Crear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Modificar
            // 
            this.Modificar.ActiveBorderThickness = 1;
            this.Modificar.ActiveCornerRadius = 1;
            this.Modificar.ActiveFillColor = System.Drawing.Color.White;
            this.Modificar.ActiveForecolor = System.Drawing.Color.Black;
            this.Modificar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Modificar.BackgroundImage")));
            this.Modificar.ButtonText = "Modificar";
            this.Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ForeColor = System.Drawing.Color.SeaGreen;
            this.Modificar.IdleBorderThickness = 1;
            this.Modificar.IdleCornerRadius = 1;
            this.Modificar.IdleFillColor = System.Drawing.Color.Black;
            this.Modificar.IdleForecolor = System.Drawing.Color.White;
            this.Modificar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.Modificar.Location = new System.Drawing.Point(594, 329);
            this.Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(126, 49);
            this.Modificar.TabIndex = 4;
            this.Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // eliminar
            // 
            this.eliminar.ActiveBorderThickness = 1;
            this.eliminar.ActiveCornerRadius = 1;
            this.eliminar.ActiveFillColor = System.Drawing.Color.White;
            this.eliminar.ActiveForecolor = System.Drawing.Color.Black;
            this.eliminar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminar.BackgroundImage")));
            this.eliminar.ButtonText = "Eliminar";
            this.eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.Color.SeaGreen;
            this.eliminar.IdleBorderThickness = 1;
            this.eliminar.IdleCornerRadius = 1;
            this.eliminar.IdleFillColor = System.Drawing.Color.Black;
            this.eliminar.IdleForecolor = System.Drawing.Color.White;
            this.eliminar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.eliminar.Location = new System.Drawing.Point(594, 418);
            this.eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(126, 49);
            this.eliminar.TabIndex = 5;
            this.eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Buscador
            // 
            this.Buscador.AutoScroll = true;
            this.Buscador.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Buscador.BackColor = System.Drawing.Color.DarkGray;
            this.Buscador.BorderColorFocused = System.Drawing.Color.Black;
            this.Buscador.BorderColorIdle = System.Drawing.Color.Black;
            this.Buscador.BorderColorMouseHover = System.Drawing.Color.Black;
            this.Buscador.BorderThickness = 3;
            this.Buscador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Buscador.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Buscador.isPassword = false;
            this.Buscador.Location = new System.Drawing.Point(484, 136);
            this.Buscador.Margin = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(236, 41);
            this.Buscador.TabIndex = 6;
            this.Buscador.Text = "buscar pelicula";
            this.Buscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::proyecto_cine.Properties.Resources.icon_Buscador;
            this.pictureBox1.Location = new System.Drawing.Point(682, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(749, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Buscador);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Peliculas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "pelicula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 Crear;
        private Bunifu.Framework.UI.BunifuThinButton2 Modificar;
        private Bunifu.Framework.UI.BunifuThinButton2 eliminar;
        private Bunifu.Framework.UI.BunifuMetroTextbox Buscador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
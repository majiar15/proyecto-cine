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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Crear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Modificar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.eliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchMenu = new Bunifu.Framework.UI.BunifuTextbox();
            this.dataGridView23 = new System.Windows.Forms.DataGridView();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView23)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(243, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "PELICULAS";
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
            this.Crear.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.Crear.ForeColor = System.Drawing.Color.SeaGreen;
            this.Crear.IdleBorderThickness = 1;
            this.Crear.IdleCornerRadius = 1;
            this.Crear.IdleFillColor = System.Drawing.Color.Black;
            this.Crear.IdleForecolor = System.Drawing.Color.White;
            this.Crear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.Crear.Location = new System.Drawing.Point(616, 269);
            this.Crear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(156, 43);
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
            this.Modificar.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.Modificar.ForeColor = System.Drawing.Color.SeaGreen;
            this.Modificar.IdleBorderThickness = 1;
            this.Modificar.IdleCornerRadius = 1;
            this.Modificar.IdleFillColor = System.Drawing.Color.Black;
            this.Modificar.IdleForecolor = System.Drawing.Color.White;
            this.Modificar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.Modificar.Location = new System.Drawing.Point(623, 344);
            this.Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(149, 43);
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
            this.eliminar.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.eliminar.ForeColor = System.Drawing.Color.SeaGreen;
            this.eliminar.IdleBorderThickness = 1;
            this.eliminar.IdleCornerRadius = 1;
            this.eliminar.IdleFillColor = System.Drawing.Color.Black;
            this.eliminar.IdleForecolor = System.Drawing.Color.White;
            this.eliminar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.eliminar.Location = new System.Drawing.Point(623, 417);
            this.eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(149, 43);
            this.eliminar.TabIndex = 5;
            this.eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // searchMenu
            // 
            this.searchMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.searchMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.searchMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchMenu.BackgroundImage")));
            this.searchMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchMenu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchMenu.ForeColor = System.Drawing.Color.Black;
            this.searchMenu.Icon = ((System.Drawing.Image)(resources.GetObject("searchMenu.Icon")));
            this.searchMenu.Location = new System.Drawing.Point(506, 84);
            this.searchMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchMenu.Name = "searchMenu";
            this.searchMenu.Size = new System.Drawing.Size(230, 45);
            this.searchMenu.TabIndex = 53;
            this.searchMenu.text = "";
            this.searchMenu.OnTextChange += new System.EventHandler(this.searchMenu_OnTextChange);
            // 
            // dataGridView23
            // 
            this.dataGridView23.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView23.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView23.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.dataGridView23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView23.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 13.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView23.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView23.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView23.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView23.EnableHeadersVisualStyles = false;
            this.dataGridView23.GridColor = System.Drawing.Color.Black;
            this.dataGridView23.Location = new System.Drawing.Point(12, 206);
            this.dataGridView23.Name = "dataGridView23";
            this.dataGridView23.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView23.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView23.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView23.Size = new System.Drawing.Size(566, 363);
            this.dataGridView23.TabIndex = 52;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Crear Funcion";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(623, 490);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(126, 49);
            this.bunifuThinButton21.TabIndex = 54;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(812, 644);
            this.Controls.Add(this.searchMenu);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dataGridView23);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Peliculas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "pelicula";
            this.Load += new System.EventHandler(this.Peliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView23)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 Crear;
        private Bunifu.Framework.UI.BunifuThinButton2 Modificar;
        private Bunifu.Framework.UI.BunifuThinButton2 eliminar;
        private Bunifu.Framework.UI.BunifuTextbox searchMenu;
        public System.Windows.Forms.DataGridView dataGridView23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
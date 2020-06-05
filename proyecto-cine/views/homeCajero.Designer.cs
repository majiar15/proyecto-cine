namespace proyecto_cine
{
    partial class homeCajero
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeCajero));
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelCenter = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.peliculasButtonMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logButtonMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportesButtonMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cajerosButtonMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientesButtonMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logOutMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reservaButtonMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ventasButtonMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelTopMenu = new System.Windows.Forms.Panel();
            this.minimizeMenu = new System.Windows.Forms.PictureBox();
            this.showHideMenu = new System.Windows.Forms.PictureBox();
            this.closeAppMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginClose = new System.Windows.Forms.PictureBox();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeftMenu.SuspendLayout();
            this.PanelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHideMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.panelCenter.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panelCenter, BunifuAnimatorNS.DecorationType.None);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(151, 65);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(749, 585);
            this.panelCenter.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::proyecto_cine.Properties.Resources.Marco_cine3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel22, BunifuAnimatorNS.DecorationType.None);
            this.panel22.Location = new System.Drawing.Point(3, 9);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(4, 64);
            this.panel22.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel20, BunifuAnimatorNS.DecorationType.None);
            this.panel20.Location = new System.Drawing.Point(3, 80);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(4, 64);
            this.panel20.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel19, BunifuAnimatorNS.DecorationType.None);
            this.panel19.Location = new System.Drawing.Point(3, 514);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(4, 64);
            this.panel19.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel14, BunifuAnimatorNS.DecorationType.None);
            this.panel14.Location = new System.Drawing.Point(3, 514);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(4, 64);
            this.panel14.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel13, BunifuAnimatorNS.DecorationType.None);
            this.panel13.Location = new System.Drawing.Point(3, 8);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(4, 64);
            this.panel13.TabIndex = 6;
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelLeftMenu.Controls.Add(this.panel5);
            this.panelLeftMenu.Controls.Add(this.panel6);
            this.panelLeftMenu.Controls.Add(this.peliculasButtonMenu);
            this.panelLeftMenu.Controls.Add(this.panel4);
            this.panelLeftMenu.Controls.Add(this.logButtonMenu);
            this.panelLeftMenu.Controls.Add(this.panel3);
            this.panelLeftMenu.Controls.Add(this.reportesButtonMenu);
            this.panelLeftMenu.Controls.Add(this.panel2);
            this.panelLeftMenu.Controls.Add(this.cajerosButtonMenu);
            this.panelLeftMenu.Controls.Add(this.panel1);
            this.panelLeftMenu.Controls.Add(this.clientesButtonMenu);
            this.panelLeftMenu.Controls.Add(this.logOutMenu);
            this.panelLeftMenu.Controls.Add(this.reservaButtonMenu);
            this.panelLeftMenu.Controls.Add(this.panel13);
            this.panelLeftMenu.Controls.Add(this.panel14);
            this.panelLeftMenu.Controls.Add(this.panel19);
            this.panelLeftMenu.Controls.Add(this.panel20);
            this.panelLeftMenu.Controls.Add(this.panel22);
            this.panelLeftMenu.Controls.Add(this.ventasButtonMenu);
            this.bunifuTransition1.SetDecoration(this.panelLeftMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 65);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(151, 585);
            this.panelLeftMenu.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(3, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 64);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(3, 152);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 64);
            this.panel6.TabIndex = 23;
            // 
            // peliculasButtonMenu
            // 
            this.peliculasButtonMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.peliculasButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.peliculasButtonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.peliculasButtonMenu.BorderRadius = 0;
            this.peliculasButtonMenu.ButtonText = " Peliculas";
            this.peliculasButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.peliculasButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.peliculasButtonMenu.DisabledColor = System.Drawing.Color.Gray;
            this.peliculasButtonMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.peliculasButtonMenu.Iconimage = global::proyecto_cine.Properties.Resources.icon_peliculas_invert;
            this.peliculasButtonMenu.Iconimage_right = null;
            this.peliculasButtonMenu.Iconimage_right_Selected = null;
            this.peliculasButtonMenu.Iconimage_Selected = null;
            this.peliculasButtonMenu.IconMarginLeft = 0;
            this.peliculasButtonMenu.IconMarginRight = 0;
            this.peliculasButtonMenu.IconRightVisible = true;
            this.peliculasButtonMenu.IconRightZoom = 0D;
            this.peliculasButtonMenu.IconVisible = true;
            this.peliculasButtonMenu.IconZoom = 90D;
            this.peliculasButtonMenu.IsTab = false;
            this.peliculasButtonMenu.Location = new System.Drawing.Point(8, 153);
            this.peliculasButtonMenu.Name = "peliculasButtonMenu";
            this.peliculasButtonMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.peliculasButtonMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.peliculasButtonMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.peliculasButtonMenu.selected = false;
            this.peliculasButtonMenu.Size = new System.Drawing.Size(150, 55);
            this.peliculasButtonMenu.TabIndex = 25;
            this.peliculasButtonMenu.Text = " Peliculas";
            this.peliculasButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.peliculasButtonMenu.Textcolor = System.Drawing.Color.White;
            this.peliculasButtonMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peliculasButtonMenu.Click += new System.EventHandler(this.peliculasButtonMenu_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(4, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 64);
            this.panel4.TabIndex = 22;
            // 
            // logButtonMenu
            // 
            this.logButtonMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.logButtonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logButtonMenu.BorderRadius = 0;
            this.logButtonMenu.ButtonText = "Log Usuarios";
            this.logButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.logButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.logButtonMenu.DisabledColor = System.Drawing.Color.Gray;
            this.logButtonMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.logButtonMenu.Iconimage = global::proyecto_cine.Properties.Resources.log1;
            this.logButtonMenu.Iconimage_right = null;
            this.logButtonMenu.Iconimage_right_Selected = null;
            this.logButtonMenu.Iconimage_Selected = null;
            this.logButtonMenu.IconMarginLeft = 0;
            this.logButtonMenu.IconMarginRight = 0;
            this.logButtonMenu.IconRightVisible = true;
            this.logButtonMenu.IconRightZoom = 0D;
            this.logButtonMenu.IconVisible = true;
            this.logButtonMenu.IconZoom = 90D;
            this.logButtonMenu.IsTab = false;
            this.logButtonMenu.Location = new System.Drawing.Point(12, 448);
            this.logButtonMenu.Name = "logButtonMenu";
            this.logButtonMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.logButtonMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.logButtonMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.logButtonMenu.selected = false;
            this.logButtonMenu.Size = new System.Drawing.Size(140, 55);
            this.logButtonMenu.TabIndex = 21;
            this.logButtonMenu.Text = "Log Usuarios";
            this.logButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logButtonMenu.Textcolor = System.Drawing.Color.White;
            this.logButtonMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButtonMenu.Click += new System.EventHandler(this.logButtonMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(4, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 64);
            this.panel3.TabIndex = 20;
            // 
            // reportesButtonMenu
            // 
            this.reportesButtonMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reportesButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.reportesButtonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportesButtonMenu.BorderRadius = 0;
            this.reportesButtonMenu.ButtonText = "Reportes";
            this.reportesButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.reportesButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.reportesButtonMenu.DisabledColor = System.Drawing.Color.Gray;
            this.reportesButtonMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.reportesButtonMenu.Iconimage = global::proyecto_cine.Properties.Resources.Icon_Reporte;
            this.reportesButtonMenu.Iconimage_right = null;
            this.reportesButtonMenu.Iconimage_right_Selected = null;
            this.reportesButtonMenu.Iconimage_Selected = null;
            this.reportesButtonMenu.IconMarginLeft = 0;
            this.reportesButtonMenu.IconMarginRight = 0;
            this.reportesButtonMenu.IconRightVisible = true;
            this.reportesButtonMenu.IconRightZoom = 0D;
            this.reportesButtonMenu.IconVisible = true;
            this.reportesButtonMenu.IconZoom = 90D;
            this.reportesButtonMenu.IsTab = false;
            this.reportesButtonMenu.Location = new System.Drawing.Point(12, 376);
            this.reportesButtonMenu.Name = "reportesButtonMenu";
            this.reportesButtonMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.reportesButtonMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.reportesButtonMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.reportesButtonMenu.selected = false;
            this.reportesButtonMenu.Size = new System.Drawing.Size(145, 55);
            this.reportesButtonMenu.TabIndex = 19;
            this.reportesButtonMenu.Text = "Reportes";
            this.reportesButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reportesButtonMenu.Textcolor = System.Drawing.Color.White;
            this.reportesButtonMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesButtonMenu.Click += new System.EventHandler(this.reportesButtonMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(4, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 64);
            this.panel2.TabIndex = 18;
            // 
            // cajerosButtonMenu
            // 
            this.cajerosButtonMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cajerosButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cajerosButtonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cajerosButtonMenu.BorderRadius = 0;
            this.cajerosButtonMenu.ButtonText = "Cajeros";
            this.cajerosButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.cajerosButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.cajerosButtonMenu.DisabledColor = System.Drawing.Color.Gray;
            this.cajerosButtonMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.cajerosButtonMenu.Iconimage = global::proyecto_cine.Properties.Resources.empleado;
            this.cajerosButtonMenu.Iconimage_right = null;
            this.cajerosButtonMenu.Iconimage_right_Selected = null;
            this.cajerosButtonMenu.Iconimage_Selected = null;
            this.cajerosButtonMenu.IconMarginLeft = 0;
            this.cajerosButtonMenu.IconMarginRight = 0;
            this.cajerosButtonMenu.IconRightVisible = true;
            this.cajerosButtonMenu.IconRightZoom = 0D;
            this.cajerosButtonMenu.IconVisible = true;
            this.cajerosButtonMenu.IconZoom = 90D;
            this.cajerosButtonMenu.IsTab = false;
            this.cajerosButtonMenu.Location = new System.Drawing.Point(14, 303);
            this.cajerosButtonMenu.Name = "cajerosButtonMenu";
            this.cajerosButtonMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cajerosButtonMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cajerosButtonMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.cajerosButtonMenu.selected = false;
            this.cajerosButtonMenu.Size = new System.Drawing.Size(138, 55);
            this.cajerosButtonMenu.TabIndex = 17;
            this.cajerosButtonMenu.Text = "Cajeros";
            this.cajerosButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cajerosButtonMenu.Textcolor = System.Drawing.Color.White;
            this.cajerosButtonMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajerosButtonMenu.Click += new System.EventHandler(this.cajerosButtonMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(4, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 64);
            this.panel1.TabIndex = 16;
            // 
            // clientesButtonMenu
            // 
            this.clientesButtonMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.clientesButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.clientesButtonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientesButtonMenu.BorderRadius = 0;
            this.clientesButtonMenu.ButtonText = "Clientes";
            this.clientesButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.clientesButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.clientesButtonMenu.DisabledColor = System.Drawing.Color.Gray;
            this.clientesButtonMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.clientesButtonMenu.Iconimage = global::proyecto_cine.Properties.Resources.iconCliente;
            this.clientesButtonMenu.Iconimage_right = null;
            this.clientesButtonMenu.Iconimage_right_Selected = null;
            this.clientesButtonMenu.Iconimage_Selected = null;
            this.clientesButtonMenu.IconMarginLeft = 0;
            this.clientesButtonMenu.IconMarginRight = 0;
            this.clientesButtonMenu.IconRightVisible = true;
            this.clientesButtonMenu.IconRightZoom = 0D;
            this.clientesButtonMenu.IconVisible = true;
            this.clientesButtonMenu.IconZoom = 90D;
            this.clientesButtonMenu.IsTab = false;
            this.clientesButtonMenu.Location = new System.Drawing.Point(14, 232);
            this.clientesButtonMenu.Name = "clientesButtonMenu";
            this.clientesButtonMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.clientesButtonMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.clientesButtonMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.clientesButtonMenu.selected = false;
            this.clientesButtonMenu.Size = new System.Drawing.Size(138, 55);
            this.clientesButtonMenu.TabIndex = 15;
            this.clientesButtonMenu.Text = "Clientes";
            this.clientesButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clientesButtonMenu.Textcolor = System.Drawing.Color.White;
            this.clientesButtonMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesButtonMenu.Click += new System.EventHandler(this.clientesButtonMenu_Click);
            // 
            // logOutMenu
            // 
            this.logOutMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logOutMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.logOutMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutMenu.BorderRadius = 0;
            this.logOutMenu.ButtonText = "Cerrar Sesion";
            this.logOutMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.logOutMenu, BunifuAnimatorNS.DecorationType.None);
            this.logOutMenu.DisabledColor = System.Drawing.Color.Gray;
            this.logOutMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.logOutMenu.Iconimage = global::proyecto_cine.Properties.Resources.icon_Cerrar_sesion;
            this.logOutMenu.Iconimage_right = null;
            this.logOutMenu.Iconimage_right_Selected = null;
            this.logOutMenu.Iconimage_Selected = null;
            this.logOutMenu.IconMarginLeft = 0;
            this.logOutMenu.IconMarginRight = 0;
            this.logOutMenu.IconRightVisible = true;
            this.logOutMenu.IconRightZoom = 0D;
            this.logOutMenu.IconVisible = true;
            this.logOutMenu.IconZoom = 90D;
            this.logOutMenu.IsTab = false;
            this.logOutMenu.Location = new System.Drawing.Point(11, 518);
            this.logOutMenu.Name = "logOutMenu";
            this.logOutMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.logOutMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.logOutMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.logOutMenu.selected = false;
            this.logOutMenu.Size = new System.Drawing.Size(137, 55);
            this.logOutMenu.TabIndex = 5;
            this.logOutMenu.Text = "Cerrar Sesion";
            this.logOutMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logOutMenu.Textcolor = System.Drawing.Color.White;
            this.logOutMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutMenu.Click += new System.EventHandler(this.logOutMenu_Click);
            // 
            // reservaButtonMenu
            // 
            this.reservaButtonMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reservaButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.reservaButtonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reservaButtonMenu.BorderRadius = 0;
            this.reservaButtonMenu.ButtonText = "Reservas";
            this.reservaButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.reservaButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.reservaButtonMenu.DisabledColor = System.Drawing.Color.Gray;
            this.reservaButtonMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.reservaButtonMenu.Iconimage = global::proyecto_cine.Properties.Resources.icon_reserva_invert;
            this.reservaButtonMenu.Iconimage_right = null;
            this.reservaButtonMenu.Iconimage_right_Selected = null;
            this.reservaButtonMenu.Iconimage_Selected = null;
            this.reservaButtonMenu.IconMarginLeft = 0;
            this.reservaButtonMenu.IconMarginRight = 0;
            this.reservaButtonMenu.IconRightVisible = true;
            this.reservaButtonMenu.IconRightZoom = 0D;
            this.reservaButtonMenu.IconVisible = true;
            this.reservaButtonMenu.IconZoom = 90D;
            this.reservaButtonMenu.IsTab = false;
            this.reservaButtonMenu.Location = new System.Drawing.Point(13, 80);
            this.reservaButtonMenu.Name = "reservaButtonMenu";
            this.reservaButtonMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.reservaButtonMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.reservaButtonMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.reservaButtonMenu.selected = false;
            this.reservaButtonMenu.Size = new System.Drawing.Size(177, 55);
            this.reservaButtonMenu.TabIndex = 14;
            this.reservaButtonMenu.Text = "Reservas";
            this.reservaButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservaButtonMenu.Textcolor = System.Drawing.Color.White;
            this.reservaButtonMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservaButtonMenu.Click += new System.EventHandler(this.reservaButtonMenu_Click);
            // 
            // ventasButtonMenu
            // 
            this.ventasButtonMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ventasButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ventasButtonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ventasButtonMenu.BorderRadius = 0;
            this.ventasButtonMenu.ButtonText = "Ventas";
            this.ventasButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.ventasButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.ventasButtonMenu.DisabledColor = System.Drawing.Color.Gray;
            this.ventasButtonMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.ventasButtonMenu.Iconimage = global::proyecto_cine.Properties.Resources.icon_ticket_invert;
            this.ventasButtonMenu.Iconimage_right = null;
            this.ventasButtonMenu.Iconimage_right_Selected = null;
            this.ventasButtonMenu.Iconimage_Selected = null;
            this.ventasButtonMenu.IconMarginLeft = 0;
            this.ventasButtonMenu.IconMarginRight = 0;
            this.ventasButtonMenu.IconRightVisible = true;
            this.ventasButtonMenu.IconRightZoom = 0D;
            this.ventasButtonMenu.IconVisible = true;
            this.ventasButtonMenu.IconZoom = 90D;
            this.ventasButtonMenu.IsTab = false;
            this.ventasButtonMenu.Location = new System.Drawing.Point(8, 10);
            this.ventasButtonMenu.Name = "ventasButtonMenu";
            this.ventasButtonMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ventasButtonMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ventasButtonMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.ventasButtonMenu.selected = false;
            this.ventasButtonMenu.Size = new System.Drawing.Size(150, 55);
            this.ventasButtonMenu.TabIndex = 7;
            this.ventasButtonMenu.Text = "Ventas";
            this.ventasButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ventasButtonMenu.Textcolor = System.Drawing.Color.White;
            this.ventasButtonMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasButtonMenu.Click += new System.EventHandler(this.ventasButtonMenu_Click);
            // 
            // PanelTopMenu
            // 
            this.PanelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PanelTopMenu.Controls.Add(this.minimizeMenu);
            this.PanelTopMenu.Controls.Add(this.showHideMenu);
            this.PanelTopMenu.Controls.Add(this.closeAppMenu);
            this.PanelTopMenu.Controls.Add(this.pictureBox2);
            this.PanelTopMenu.Controls.Add(this.loginClose);
            this.bunifuTransition1.SetDecoration(this.PanelTopMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelTopMenu.Name = "PanelTopMenu";
            this.PanelTopMenu.Size = new System.Drawing.Size(900, 65);
            this.PanelTopMenu.TabIndex = 0;
            this.PanelTopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTopMenu_MouseDown);
            // 
            // minimizeMenu
            // 
            this.minimizeMenu.BackColor = System.Drawing.Color.Transparent;
            this.minimizeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.minimizeMenu, BunifuAnimatorNS.DecorationType.None);
            this.minimizeMenu.Image = global::proyecto_cine.Properties.Resources.Btn_Minimizar;
            this.minimizeMenu.Location = new System.Drawing.Point(818, 12);
            this.minimizeMenu.Name = "minimizeMenu";
            this.minimizeMenu.Size = new System.Drawing.Size(28, 34);
            this.minimizeMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeMenu.TabIndex = 16;
            this.minimizeMenu.TabStop = false;
            this.minimizeMenu.Click += new System.EventHandler(this.minimizeMenu_Click);
            // 
            // showHideMenu
            // 
            this.showHideMenu.BackColor = System.Drawing.Color.Transparent;
            this.showHideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.showHideMenu, BunifuAnimatorNS.DecorationType.None);
            this.showHideMenu.Image = global::proyecto_cine.Properties.Resources.Icon_Menu;
            this.showHideMenu.Location = new System.Drawing.Point(12, 14);
            this.showHideMenu.Name = "showHideMenu";
            this.showHideMenu.Size = new System.Drawing.Size(40, 34);
            this.showHideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showHideMenu.TabIndex = 21;
            this.showHideMenu.TabStop = false;
            this.showHideMenu.Click += new System.EventHandler(this.showHideMenu_Click);
            // 
            // closeAppMenu
            // 
            this.closeAppMenu.BackColor = System.Drawing.Color.Transparent;
            this.closeAppMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.closeAppMenu, BunifuAnimatorNS.DecorationType.None);
            this.closeAppMenu.Image = global::proyecto_cine.Properties.Resources.Btn_cerrar;
            this.closeAppMenu.Location = new System.Drawing.Point(860, 12);
            this.closeAppMenu.Name = "closeAppMenu";
            this.closeAppMenu.Size = new System.Drawing.Size(27, 34);
            this.closeAppMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeAppMenu.TabIndex = 17;
            this.closeAppMenu.TabStop = false;
            this.closeAppMenu.Click += new System.EventHandler(this.closeAppMenu_Click);
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 50);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // loginClose
            // 
            this.bunifuTransition1.SetDecoration(this.loginClose, BunifuAnimatorNS.DecorationType.None);
            this.loginClose.Location = new System.Drawing.Point(0, 0);
            this.loginClose.Name = "loginClose";
            this.loginClose.Size = new System.Drawing.Size(100, 50);
            this.loginClose.TabIndex = 23;
            this.loginClose.TabStop = false;
            // 
            // homeCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelLeftMenu);
            this.Controls.Add(this.PanelTopMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homeCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homeCajero";
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeftMenu.ResumeLayout(false);
            this.PanelTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHideMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private Bunifu.Framework.UI.BunifuFlatButton ventasButtonMenu;
        private Bunifu.Framework.UI.BunifuFlatButton reservaButtonMenu;
        private Bunifu.Framework.UI.BunifuFlatButton logOutMenu;
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox loginClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox closeAppMenu;
        private System.Windows.Forms.PictureBox showHideMenu;
        private System.Windows.Forms.PictureBox minimizeMenu;
        private System.Windows.Forms.Panel PanelTopMenu;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton clientesButtonMenu;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton cajerosButtonMenu;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton reportesButtonMenu;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton logButtonMenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton peliculasButtonMenu;
    }
}
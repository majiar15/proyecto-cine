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
            this.PanelTopMenu = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelCenter = new System.Windows.Forms.Panel();
            this.minimizeMenu = new System.Windows.Forms.PictureBox();
            this.showHideMenu = new System.Windows.Forms.PictureBox();
            this.closeAppMenu = new System.Windows.Forms.PictureBox();
            this.seachMenu = new Bunifu.Framework.UI.BunifuTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginClose = new System.Windows.Forms.PictureBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton17 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.peliculaButtonMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reservaButtonMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogOutMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTopMenu.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHideMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginClose)).BeginInit();
            this.panelLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopMenu
            // 
            this.PanelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PanelTopMenu.Controls.Add(this.minimizeMenu);
            this.PanelTopMenu.Controls.Add(this.showHideMenu);
            this.PanelTopMenu.Controls.Add(this.closeAppMenu);
            this.PanelTopMenu.Controls.Add(this.seachMenu);
            this.PanelTopMenu.Controls.Add(this.pictureBox2);
            this.PanelTopMenu.Controls.Add(this.loginClose);
            this.bunifuTransition1.SetDecoration(this.PanelTopMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelTopMenu.Name = "PanelTopMenu";
            this.PanelTopMenu.Size = new System.Drawing.Size(900, 65);
            this.PanelTopMenu.TabIndex = 0;
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
            this.panelCenter.Size = new System.Drawing.Size(749, 535);
            this.panelCenter.TabIndex = 18;
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
            this.showHideMenu.Image = global::proyecto_cine.Properties.Resources.Menu_48px;
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
            // seachMenu
            // 
            this.seachMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.seachMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seachMenu.BackgroundImage")));
            this.seachMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seachMenu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.seachMenu, BunifuAnimatorNS.DecorationType.None);
            this.seachMenu.ForeColor = System.Drawing.Color.White;
            this.seachMenu.Icon = ((System.Drawing.Image)(resources.GetObject("seachMenu.Icon")));
            this.seachMenu.Location = new System.Drawing.Point(291, 14);
            this.seachMenu.Name = "seachMenu";
            this.seachMenu.Size = new System.Drawing.Size(357, 42);
            this.seachMenu.TabIndex = 20;
            this.seachMenu.text = "";
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
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel22, BunifuAnimatorNS.DecorationType.None);
            this.panel22.Location = new System.Drawing.Point(3, 18);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(4, 64);
            this.panel22.TabIndex = 0;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel20, BunifuAnimatorNS.DecorationType.None);
            this.panel20.Location = new System.Drawing.Point(3, 88);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(4, 64);
            this.panel20.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel19, BunifuAnimatorNS.DecorationType.None);
            this.panel19.Location = new System.Drawing.Point(3, 452);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(4, 64);
            this.panel19.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel14, BunifuAnimatorNS.DecorationType.None);
            this.panel14.Location = new System.Drawing.Point(3, 452);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(4, 64);
            this.panel14.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.panel13, BunifuAnimatorNS.DecorationType.None);
            this.panel13.Location = new System.Drawing.Point(3, 18);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(4, 64);
            this.panel13.TabIndex = 6;
            // 
            // bunifuFlatButton17
            // 
            this.bunifuFlatButton17.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton17.BorderRadius = 0;
            this.bunifuFlatButton17.ButtonText = " Peliculas";
            this.bunifuFlatButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton17, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton17.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton17.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton17.Iconimage = global::proyecto_cine.Properties.Resources.icon_peliculas_invert;
            this.bunifuFlatButton17.Iconimage_right = null;
            this.bunifuFlatButton17.Iconimage_right_Selected = null;
            this.bunifuFlatButton17.Iconimage_Selected = null;
            this.bunifuFlatButton17.IconMarginLeft = 0;
            this.bunifuFlatButton17.IconMarginRight = 0;
            this.bunifuFlatButton17.IconRightVisible = true;
            this.bunifuFlatButton17.IconRightZoom = 0D;
            this.bunifuFlatButton17.IconVisible = true;
            this.bunifuFlatButton17.IconZoom = 90D;
            this.bunifuFlatButton17.IsTab = false;
            this.bunifuFlatButton17.Location = new System.Drawing.Point(8, 19);
            this.bunifuFlatButton17.Name = "bunifuFlatButton17";
            this.bunifuFlatButton17.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton17.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton17.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton17.selected = false;
            this.bunifuFlatButton17.Size = new System.Drawing.Size(59, 55);
            this.bunifuFlatButton17.TabIndex = 1;
            this.bunifuFlatButton17.Text = " Peliculas";
            this.bunifuFlatButton17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton17.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton17.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // peliculaButtonMenu
            // 
            this.peliculaButtonMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.peliculaButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.peliculaButtonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.peliculaButtonMenu.BorderRadius = 0;
            this.peliculaButtonMenu.ButtonText = " Peliculas";
            this.peliculaButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.peliculaButtonMenu, BunifuAnimatorNS.DecorationType.None);
            this.peliculaButtonMenu.DisabledColor = System.Drawing.Color.Gray;
            this.peliculaButtonMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.peliculaButtonMenu.Iconimage = global::proyecto_cine.Properties.Resources.icon_peliculas_invert;
            this.peliculaButtonMenu.Iconimage_right = null;
            this.peliculaButtonMenu.Iconimage_right_Selected = null;
            this.peliculaButtonMenu.Iconimage_Selected = null;
            this.peliculaButtonMenu.IconMarginLeft = 0;
            this.peliculaButtonMenu.IconMarginRight = 0;
            this.peliculaButtonMenu.IconRightVisible = true;
            this.peliculaButtonMenu.IconRightZoom = 0D;
            this.peliculaButtonMenu.IconVisible = true;
            this.peliculaButtonMenu.IconZoom = 90D;
            this.peliculaButtonMenu.IsTab = false;
            this.peliculaButtonMenu.Location = new System.Drawing.Point(8, 19);
            this.peliculaButtonMenu.Name = "peliculaButtonMenu";
            this.peliculaButtonMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.peliculaButtonMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.peliculaButtonMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.peliculaButtonMenu.selected = false;
            this.peliculaButtonMenu.Size = new System.Drawing.Size(150, 55);
            this.peliculaButtonMenu.TabIndex = 7;
            this.peliculaButtonMenu.Text = " Peliculas";
            this.peliculaButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.peliculaButtonMenu.Textcolor = System.Drawing.Color.White;
            this.peliculaButtonMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.reservaButtonMenu.Location = new System.Drawing.Point(13, 88);
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
            // 
            // LogOutMenu
            // 
            this.LogOutMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LogOutMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LogOutMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOutMenu.BorderRadius = 0;
            this.LogOutMenu.ButtonText = "Cerrar Sesion";
            this.LogOutMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.LogOutMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogOutMenu.DisabledColor = System.Drawing.Color.Gray;
            this.LogOutMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.LogOutMenu.Iconimage = global::proyecto_cine.Properties.Resources.icon_Cerrar_sesion;
            this.LogOutMenu.Iconimage_right = null;
            this.LogOutMenu.Iconimage_right_Selected = null;
            this.LogOutMenu.Iconimage_Selected = null;
            this.LogOutMenu.IconMarginLeft = 0;
            this.LogOutMenu.IconMarginRight = 0;
            this.LogOutMenu.IconRightVisible = true;
            this.LogOutMenu.IconRightZoom = 0D;
            this.LogOutMenu.IconVisible = true;
            this.LogOutMenu.IconZoom = 90D;
            this.LogOutMenu.IsTab = false;
            this.LogOutMenu.Location = new System.Drawing.Point(11, 456);
            this.LogOutMenu.Name = "LogOutMenu";
            this.LogOutMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LogOutMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LogOutMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.LogOutMenu.selected = false;
            this.LogOutMenu.Size = new System.Drawing.Size(137, 55);
            this.LogOutMenu.TabIndex = 5;
            this.LogOutMenu.Text = "Cerrar Sesion";
            this.LogOutMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogOutMenu.Textcolor = System.Drawing.Color.White;
            this.LogOutMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelLeftMenu.Controls.Add(this.LogOutMenu);
            this.panelLeftMenu.Controls.Add(this.reservaButtonMenu);
            this.panelLeftMenu.Controls.Add(this.peliculaButtonMenu);
            this.panelLeftMenu.Controls.Add(this.bunifuFlatButton17);
            this.panelLeftMenu.Controls.Add(this.panel13);
            this.panelLeftMenu.Controls.Add(this.panel14);
            this.panelLeftMenu.Controls.Add(this.panel19);
            this.panelLeftMenu.Controls.Add(this.panel20);
            this.panelLeftMenu.Controls.Add(this.panel22);
            this.bunifuTransition1.SetDecoration(this.panelLeftMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 65);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(151, 535);
            this.panelLeftMenu.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::proyecto_cine.Properties.Resources.Marco_cine3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homeCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelLeftMenu);
            this.Controls.Add(this.PanelTopMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homeCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homeCajero";
            this.PanelTopMenu.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showHideMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginClose)).EndInit();
            this.panelLeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox loginClose;
        private Bunifu.Framework.UI.BunifuTextbox seachMenu;
        private System.Windows.Forms.PictureBox showHideMenu;
        private System.Windows.Forms.PictureBox minimizeMenu;
        private System.Windows.Forms.PictureBox closeAppMenu;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton17;
        private Bunifu.Framework.UI.BunifuFlatButton peliculaButtonMenu;
        private Bunifu.Framework.UI.BunifuFlatButton reservaButtonMenu;
        private Bunifu.Framework.UI.BunifuFlatButton LogOutMenu;
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
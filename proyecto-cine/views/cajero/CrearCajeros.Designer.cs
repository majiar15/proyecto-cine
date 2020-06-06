namespace proyecto_cine
{
    partial class CrearCajeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCajeros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbCargo = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.enviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.tbCedula);
            this.panel1.Controls.Add(this.tbContraseña);
            this.panel1.Controls.Add(this.tbTelefono);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbApellidos);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.cbCargo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.enviar);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 535);
            this.panel1.TabIndex = 0;
            // 
            // btUpdate
            // 
            this.btUpdate.ActiveBorderThickness = 1;
            this.btUpdate.ActiveCornerRadius = 1;
            this.btUpdate.ActiveFillColor = System.Drawing.Color.White;
            this.btUpdate.ActiveForecolor = System.Drawing.Color.Black;
            this.btUpdate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.btUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUpdate.BackgroundImage")));
            this.btUpdate.ButtonText = "Actualizar";
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.IdleBorderThickness = 1;
            this.btUpdate.IdleCornerRadius = 1;
            this.btUpdate.IdleFillColor = System.Drawing.Color.Black;
            this.btUpdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.btUpdate.IdleLineColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(386, 476);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(177, 43);
            this.btUpdate.TabIndex = 66;
            this.btUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btUpdate.Visible = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.Color.Transparent;
            this.cbCargo.BorderRadius = 3;
            this.cbCargo.DisabledColor = System.Drawing.Color.Gray;
            this.cbCargo.ForeColor = System.Drawing.Color.White;
            this.cbCargo.Items = new string[] {
        "",
        "Administrador",
        "Cajero"};
            this.cbCargo.Location = new System.Drawing.Point(389, 431);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.NomalColor = System.Drawing.Color.Black;
            this.cbCargo.onHoverColor = System.Drawing.Color.Black;
            this.cbCargo.selectedIndex = -1;
            this.cbCargo.Size = new System.Drawing.Size(177, 23);
            this.cbCargo.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(183, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 42);
            this.label6.TabIndex = 64;
            this.label6.Text = "Cargo :";
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
            this.bunifuThinButton21.ButtonText = "Cancelar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(190, 476);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(177, 43);
            this.bunifuThinButton21.TabIndex = 62;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
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
            this.enviar.ButtonText = "Enviar";
            this.enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enviar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.ForeColor = System.Drawing.Color.White;
            this.enviar.IdleBorderThickness = 1;
            this.enviar.IdleCornerRadius = 1;
            this.enviar.IdleFillColor = System.Drawing.Color.Black;
            this.enviar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(60)))));
            this.enviar.IdleLineColor = System.Drawing.Color.White;
            this.enviar.Location = new System.Drawing.Point(386, 476);
            this.enviar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(177, 43);
            this.enviar.TabIndex = 61;
            this.enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(221, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(307, 46);
            this.lbTitle.TabIndex = 60;
            this.lbTitle.Text = "CREAR CAJEROS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(180, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 42);
            this.label7.TabIndex = 58;
            this.label7.Text = "Contraseña :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(180, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 42);
            this.label5.TabIndex = 48;
            this.label5.Text = "Telefono :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(180, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 42);
            this.label4.TabIndex = 47;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(180, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 42);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cedula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(180, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 42);
            this.label2.TabIndex = 45;
            this.label2.Text = "Apellidos :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(180, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 42);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nombres :";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.Black;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.White;
            this.tbNombre.Location = new System.Drawing.Point(389, 88);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(177, 23);
            this.tbNombre.TabIndex = 67;
            // 
            // tbApellidos
            // 
            this.tbApellidos.BackColor = System.Drawing.Color.Black;
            this.tbApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.ForeColor = System.Drawing.Color.White;
            this.tbApellidos.Location = new System.Drawing.Point(389, 146);
            this.tbApellidos.Multiline = true;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(177, 23);
            this.tbApellidos.TabIndex = 68;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Black;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(389, 204);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(177, 23);
            this.tbEmail.TabIndex = 69;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.Color.Black;
            this.tbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.ForeColor = System.Drawing.Color.White;
            this.tbTelefono.Location = new System.Drawing.Point(389, 262);
            this.tbTelefono.Multiline = true;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(177, 23);
            this.tbTelefono.TabIndex = 70;
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.Color.Black;
            this.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.ForeColor = System.Drawing.Color.White;
            this.tbContraseña.Location = new System.Drawing.Point(389, 320);
            this.tbContraseña.Multiline = true;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(177, 23);
            this.tbContraseña.TabIndex = 71;
            // 
            // tbCedula
            // 
            this.tbCedula.BackColor = System.Drawing.Color.Black;
            this.tbCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.ForeColor = System.Drawing.Color.White;
            this.tbCedula.Location = new System.Drawing.Point(389, 378);
            this.tbCedula.Multiline = true;
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(177, 23);
            this.tbCedula.TabIndex = 72;
            // 
            // CrearCajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 535);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearCajeros";
            this.Text = "CrearCajeros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbTitle;
        public Bunifu.Framework.UI.BunifuDropdown cbCargo;
        public Bunifu.Framework.UI.BunifuThinButton2 enviar;
        public Bunifu.Framework.UI.BunifuThinButton2 btUpdate;
        public System.Windows.Forms.TextBox tbCedula;
        public System.Windows.Forms.TextBox tbContraseña;
        public System.Windows.Forms.TextBox tbTelefono;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.TextBox tbApellidos;
        public System.Windows.Forms.TextBox tbNombre;
    }
}
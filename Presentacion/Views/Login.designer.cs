
namespace Presentacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLogin = new System.Windows.Forms.Label();
            this.cbRecordar = new System.Windows.Forms.CheckBox();
            this.linklblForgot = new System.Windows.Forms.LinkLabel();
            this.pbMostrar = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.pbshowPassword = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Jornic.JComponente.JButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEyeOpen = new FontAwesome.Sharp.IconButton();
            this.btnAyesClose = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbshowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.lblLogin.Location = new System.Drawing.Point(80, 124);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(139, 32);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Welcome !";
            // 
            // cbRecordar
            // 
            this.cbRecordar.AutoSize = true;
            this.cbRecordar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRecordar.FlatAppearance.BorderSize = 0;
            this.cbRecordar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRecordar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.cbRecordar.Location = new System.Drawing.Point(41, 298);
            this.cbRecordar.Name = "cbRecordar";
            this.cbRecordar.Size = new System.Drawing.Size(101, 19);
            this.cbRecordar.TabIndex = 3;
            this.cbRecordar.Text = "Remember me";
            this.cbRecordar.UseVisualStyleBackColor = true;
            // 
            // linklblForgot
            // 
            this.linklblForgot.AutoSize = true;
            this.linklblForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.linklblForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.linklblForgot.Location = new System.Drawing.Point(103, 382);
            this.linklblForgot.Name = "linklblForgot";
            this.linklblForgot.Size = new System.Drawing.Size(95, 15);
            this.linklblForgot.TabIndex = 5;
            this.linklblForgot.TabStop = true;
            this.linklblForgot.Text = "Forgot Password";
            // 
            // pbMostrar
            // 
            this.pbMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMostrar.Image = ((System.Drawing.Image)(resources.GetObject("pbMostrar.Image")));
            this.pbMostrar.Location = new System.Drawing.Point(221, 5);
            this.pbMostrar.Name = "pbMostrar";
            this.pbMostrar.Size = new System.Drawing.Size(20, 20);
            this.pbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrar.TabIndex = 5;
            this.pbMostrar.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(35, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            // 
            // pbLock
            // 
            this.pbLock.Image = ((System.Drawing.Image)(resources.GetObject("pbLock.Image")));
            this.pbLock.Location = new System.Drawing.Point(6, 5);
            this.pbLock.Name = "pbLock";
            this.pbLock.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pbLock.Size = new System.Drawing.Size(20, 20);
            this.pbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLock.TabIndex = 0;
            this.pbLock.TabStop = false;
            // 
            // pbshowPassword
            // 
            this.pbshowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbshowPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbshowPassword.Image")));
            this.pbshowPassword.Location = new System.Drawing.Point(221, 5);
            this.pbshowPassword.Name = "pbshowPassword";
            this.pbshowPassword.Size = new System.Drawing.Size(20, 20);
            this.pbshowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbshowPassword.TabIndex = 6;
            this.pbshowPassword.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.Location = new System.Drawing.Point(35, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(180, 22);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "User";
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(6, 5);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(20, 20);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnLogin.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(41, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(212, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.DarkGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(272, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.txtPass.Location = new System.Drawing.Point(14, 10);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(164, 18);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnEyeOpen);
            this.panel1.Controls.Add(this.btnAyesClose);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Location = new System.Drawing.Point(41, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 37);
            this.panel1.TabIndex = 11;
            // 
            // btnEyeOpen
            // 
            this.btnEyeOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEyeOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEyeOpen.FlatAppearance.BorderSize = 0;
            this.btnEyeOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEyeOpen.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnEyeOpen.IconColor = System.Drawing.Color.DarkGray;
            this.btnEyeOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEyeOpen.IconSize = 25;
            this.btnEyeOpen.Location = new System.Drawing.Point(184, 6);
            this.btnEyeOpen.Name = "btnEyeOpen";
            this.btnEyeOpen.Size = new System.Drawing.Size(25, 25);
            this.btnEyeOpen.TabIndex = 7;
            this.btnEyeOpen.UseVisualStyleBackColor = false;
            this.btnEyeOpen.Click += new System.EventHandler(this.btnEyeOpen_Click);
            // 
            // btnAyesClose
            // 
            this.btnAyesClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyesClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAyesClose.FlatAppearance.BorderSize = 0;
            this.btnAyesClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyesClose.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnAyesClose.IconColor = System.Drawing.Color.DarkGray;
            this.btnAyesClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyesClose.IconSize = 25;
            this.btnAyesClose.Location = new System.Drawing.Point(184, 6);
            this.btnAyesClose.Name = "btnAyesClose";
            this.btnAyesClose.Size = new System.Drawing.Size(25, 25);
            this.btnAyesClose.TabIndex = 8;
            this.btnAyesClose.UseVisualStyleBackColor = false;
            this.btnAyesClose.Visible = false;
            this.btnAyesClose.Click += new System.EventHandler(this.btnAyesClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.txtUsers);
            this.panel2.Location = new System.Drawing.Point(41, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 37);
            this.panel2.TabIndex = 12;
            // 
            // txtUsers
            // 
            this.txtUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.txtUsers.Location = new System.Drawing.Point(14, 10);
            this.txtUsers.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsers.MaxLength = 50;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(185, 18);
            this.txtUsers.TabIndex = 0;
            this.txtUsers.Text = "Usuario";
            this.txtUsers.Enter += new System.EventHandler(this.txtUsers_Enter);
            this.txtUsers.Leave += new System.EventHandler(this.txtUsers_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(97, 278);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 15);
            this.lbError.TabIndex = 15;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 433);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linklblForgot);
            this.Controls.Add(this.cbRecordar);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbshowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbMostrar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.CheckBox cbRecordar;
        private System.Windows.Forms.LinkLabel linklblForgot;
        private System.Windows.Forms.PictureBox pbshowPassword;
        private Jornic.JComponente.JButton btnLogin;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnEyeOpen;
        private FontAwesome.Sharp.IconButton btnAyesClose;
        private System.Windows.Forms.Label lbError;
    }
}


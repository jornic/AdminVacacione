
namespace Presentacion
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnCabecera = new System.Windows.Forms.Panel();
            this.lbDatos = new System.Windows.Forms.Label();
            this.btnMaximized = new FontAwesome.Sharp.IconButton();
            this.btnMinimized = new FontAwesome.Sharp.IconButton();
            this.btnMinimizedNormal = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnOpciones = new System.Windows.Forms.Panel();
            this.pnControlButton = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHisto = new FontAwesome.Sharp.IconButton();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLisEmpl = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVDePers = new FontAwesome.Sharp.IconButton();
            this.btnDiasEspeV = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevaV = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new Jornic.JComponente.JButton();
            this.pnVentanas = new System.Windows.Forms.Panel();
            this.pnCabecera.SuspendLayout();
            this.pnOpciones.SuspendLayout();
            this.pnControlButton.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCabecera
            // 
            this.pnCabecera.BackColor = System.Drawing.Color.White;
            this.pnCabecera.Controls.Add(this.lbDatos);
            this.pnCabecera.Controls.Add(this.btnMaximized);
            this.pnCabecera.Controls.Add(this.btnMinimized);
            this.pnCabecera.Controls.Add(this.btnMinimizedNormal);
            this.pnCabecera.Controls.Add(this.btnClose);
            resources.ApplyResources(this.pnCabecera, "pnCabecera");
            this.pnCabecera.Name = "pnCabecera";
            this.pnCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecera_MouseDown);
            // 
            // lbDatos
            // 
            resources.ApplyResources(this.lbDatos, "lbDatos");
            this.lbDatos.ForeColor = System.Drawing.Color.DimGray;
            this.lbDatos.Name = "lbDatos";
            this.lbDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDatos_MouseDown);
            // 
            // btnMaximized
            // 
            resources.ApplyResources(this.btnMaximized, "btnMaximized");
            this.btnMaximized.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximized.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnMaximized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximized.IconSize = 25;
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            this.btnMaximized.MouseLeave += new System.EventHandler(this.btnMaximized_MouseLeave);
            this.btnMaximized.MouseHover += new System.EventHandler(this.btnMaximized_MouseHover);
            // 
            // btnMinimized
            // 
            resources.ApplyResources(this.btnMinimized, "btnMinimized");
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimized.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimized.IconSize = 25;
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            this.btnMinimized.MouseLeave += new System.EventHandler(this.btnMinimized_MouseLeave);
            this.btnMinimized.MouseHover += new System.EventHandler(this.btnMinimized_MouseHover);
            // 
            // btnMinimizedNormal
            // 
            resources.ApplyResources(this.btnMinimizedNormal, "btnMinimizedNormal");
            this.btnMinimizedNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizedNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizedNormal.FlatAppearance.BorderSize = 0;
            this.btnMinimizedNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinimizedNormal.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMinimizedNormal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnMinimizedNormal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizedNormal.IconSize = 20;
            this.btnMinimizedNormal.Name = "btnMinimizedNormal";
            this.btnMinimizedNormal.UseVisualStyleBackColor = false;
            this.btnMinimizedNormal.Click += new System.EventHandler(this.btnMinimizedNormal_Click);
            this.btnMinimizedNormal.MouseLeave += new System.EventHandler(this.btnMinimizedNormal_MouseLeave);
            this.btnMinimizedNormal.MouseHover += new System.EventHandler(this.btnMinimizedNormal_MouseHover);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // pnOpciones
            // 
            this.pnOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(29)))), ((int)(((byte)(191)))));
            this.pnOpciones.Controls.Add(this.pnControlButton);
            resources.ApplyResources(this.pnOpciones, "pnOpciones");
            this.pnOpciones.Name = "pnOpciones";
            // 
            // pnControlButton
            // 
            this.pnControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.pnControlButton.Controls.Add(this.panel4);
            this.pnControlButton.Controls.Add(this.panel5);
            this.pnControlButton.Controls.Add(this.panel3);
            this.pnControlButton.Controls.Add(this.panel2);
            this.pnControlButton.Controls.Add(this.panel1);
            this.pnControlButton.Controls.Add(this.btnCerrarSesion);
            resources.ApplyResources(this.pnControlButton, "pnControlButton");
            this.pnControlButton.Name = "pnControlButton";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHisto);
            this.panel4.Controls.Add(this.btnUsers);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btnHisto
            // 
            resources.ApplyResources(this.btnHisto, "btnHisto");
            this.btnHisto.FlatAppearance.BorderSize = 0;
            this.btnHisto.ForeColor = System.Drawing.Color.White;
            this.btnHisto.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnHisto.IconColor = System.Drawing.Color.White;
            this.btnHisto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHisto.IconSize = 25;
            this.btnHisto.Name = "btnHisto";
            this.btnHisto.UseVisualStyleBackColor = true;
            this.btnHisto.Click += new System.EventHandler(this.btnHisto_Click);
            // 
            // btnUsers
            // 
            resources.ApplyResources(this.btnUsers, "btnUsers");
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsers.IconColor = System.Drawing.Color.White;
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.IconSize = 25;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnLisEmpl);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // btnLisEmpl
            // 
            resources.ApplyResources(this.btnLisEmpl, "btnLisEmpl");
            this.btnLisEmpl.FlatAppearance.BorderSize = 0;
            this.btnLisEmpl.ForeColor = System.Drawing.Color.White;
            this.btnLisEmpl.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnLisEmpl.IconColor = System.Drawing.Color.White;
            this.btnLisEmpl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLisEmpl.IconSize = 25;
            this.btnLisEmpl.Name = "btnLisEmpl";
            this.btnLisEmpl.UseVisualStyleBackColor = true;
            this.btnLisEmpl.Click += new System.EventHandler(this.btnLisEmpl_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnVDePers);
            this.panel3.Controls.Add(this.btnDiasEspeV);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnNuevaV);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnVDePers
            // 
            resources.ApplyResources(this.btnVDePers, "btnVDePers");
            this.btnVDePers.FlatAppearance.BorderSize = 0;
            this.btnVDePers.ForeColor = System.Drawing.Color.White;
            this.btnVDePers.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnVDePers.IconColor = System.Drawing.Color.White;
            this.btnVDePers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVDePers.IconSize = 25;
            this.btnVDePers.Name = "btnVDePers";
            this.btnVDePers.UseVisualStyleBackColor = true;
            this.btnVDePers.Click += new System.EventHandler(this.btnVDePers_Click);
            // 
            // btnDiasEspeV
            // 
            resources.ApplyResources(this.btnDiasEspeV, "btnDiasEspeV");
            this.btnDiasEspeV.FlatAppearance.BorderSize = 0;
            this.btnDiasEspeV.ForeColor = System.Drawing.Color.White;
            this.btnDiasEspeV.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.btnDiasEspeV.IconColor = System.Drawing.Color.White;
            this.btnDiasEspeV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiasEspeV.IconSize = 25;
            this.btnDiasEspeV.Name = "btnDiasEspeV";
            this.btnDiasEspeV.UseVisualStyleBackColor = true;
            this.btnDiasEspeV.Click += new System.EventHandler(this.btnDiasEspeV_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // btnNuevaV
            // 
            resources.ApplyResources(this.btnNuevaV, "btnNuevaV");
            this.btnNuevaV.FlatAppearance.BorderSize = 0;
            this.btnNuevaV.ForeColor = System.Drawing.Color.White;
            this.btnNuevaV.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnNuevaV.IconColor = System.Drawing.Color.White;
            this.btnNuevaV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaV.IconSize = 25;
            this.btnNuevaV.Name = "btnNuevaV";
            this.btnNuevaV.UseVisualStyleBackColor = true;
            this.btnNuevaV.Click += new System.EventHandler(this.btnNuevaV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnHome);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // btnHome
            // 
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 25;
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(63)))), ((int)(((byte)(50)))));
            this.btnCerrarSesion.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(63)))), ((int)(((byte)(50)))));
            this.btnCerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrarSesion.BorderRadius = 45;
            this.btnCerrarSesion.BorderSize = 0;
            resources.ApplyResources(this.btnCerrarSesion, "btnCerrarSesion");
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.TextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnVentanas
            // 
            resources.ApplyResources(this.pnVentanas, "pnVentanas");
            this.pnVentanas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnVentanas.Name = "pnVentanas";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnVentanas);
            this.Controls.Add(this.pnCabecera);
            this.Controls.Add(this.pnOpciones);
            this.Name = "Home";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnCabecera.ResumeLayout(false);
            this.pnCabecera.PerformLayout();
            this.pnOpciones.ResumeLayout(false);
            this.pnControlButton.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCabecera;
        private System.Windows.Forms.Panel pnOpciones;
        private System.Windows.Forms.Panel pnVentanas;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimized;
        private FontAwesome.Sharp.IconButton btnMaximized;
        private FontAwesome.Sharp.IconButton btnMinimizedNormal;
        private System.Windows.Forms.Label lbDatos;
        private Jornic.JComponente.JButton btnCerrarSesion;
        private System.Windows.Forms.Panel pnControlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnDiasEspeV;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnNuevaV;
        private FontAwesome.Sharp.IconButton btnVDePers;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnHisto;
        private FontAwesome.Sharp.IconButton btnUsers;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnLisEmpl;
    }
}


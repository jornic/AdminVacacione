using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio;
using Soporte.Entidades;
using Soporte.CacheUsers;

namespace Presentacion.Views
{
    public partial class frmLogin : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void Mover()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }

        private void pbImg_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbError.Text = string.Empty;
            NLogin login = new NLogin();
            ELogin eLogin = new ELogin()
            {
                Users = txtUsers.Text,
                Password = txtPass.Text

            };

            if (login.AccessLogin(eLogin))
            {
                Home home = new Home();
                this.Close();
                home.Show();
                txtUsers.Text = "";
                txtPass.Text = "";
            }
            else
            {
                lbError.Text = "Acceso denegado";
                lbError.ForeColor = ColorTranslator.FromHtml("#E73F32");
                txtUsers.Focus();
            }
        }

        private void btnEyeOpen_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
                btnEyeOpen.Visible = false;
                btnAyesClose.Visible = true;
            }
        }

        private void btnAyesClose_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == false)
            {
                txtPass.UseSystemPasswordChar = true;
                btnAyesClose.Visible = false;
                btnEyeOpen.Visible = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsers_Enter(object sender, EventArgs e)
        {
            if (txtUsers.Text == "Usuario")
            {
                txtUsers.Text = "";
                txtUsers.ForeColor = ColorTranslator.FromHtml("#125570");
            }
        }

        private void txtUsers_Leave(object sender, EventArgs e)
        {
            if (txtUsers.Text == "")
            {
                txtUsers.ForeColor = Color.DarkGray;
                txtUsers.Text = "Usuario";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.DarkGray;
                txtPass.Text = "Contraseña";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
                txtPass.ForeColor = ColorTranslator.FromHtml("#125570");
            }
        }
    }
}

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
//using Negocios;

namespace Presentacion
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

       
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "User")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.FromArgb(1, 91, 234);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.ForeColor = Color.DarkGray;
                txtUsuario.Text = "User";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.FromArgb(1, 91, 234);
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.Text = "Password";
            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }

        private void pbImg_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }

        
        private void pbshowPassword_Click(object sender, EventArgs e)
        {
           
        }
        private void btnSingIn_Click(object sender, EventArgs e)
        {/*
            Negocio negocio = new Negocio();
            if (negocio.Login(txtUsuario.Text,txtPassword.Text))
            {
                Home home = new Home();
                this.Hide();
                home.Show(); 
                MessageBox.Show("Hola Bievenido al sistema.");
            }
            else
            {
                MessageBox.Show("Usuario no valido.");
            }              */          
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

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
                btnAyesClose.Visible =false;
                btnEyeOpen.Visible = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
    }
}

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

namespace Presentacion
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           
        }

        private string ColorActivo = "#003449";
        private string ColorNoActivo = "#125570";

        #region ConfiguracionDelFrm

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Mover()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormEnPanel(object formhijo)
        {
            if (this.pnVentanas.Controls.Count > 0)
                this.pnVentanas.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnVentanas.Controls.Add(fh);
            this.pnVentanas.Tag = fh;
            fh.Show();

        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.Show();
        }
        #region Eventos
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.IconColor = ColorTranslator.FromHtml("#E73F32");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = ColorTranslator.FromHtml("#686868");
        }

       
        private void btnMaximized_MouseLeave(object sender, EventArgs e)
        {
            btnMaximized.IconColor = ColorTranslator.FromHtml("#686868");
        }
        private void btnMaximized_MouseHover(object sender, EventArgs e)
        {
            btnMaximized.IconColor = ColorTranslator.FromHtml("#125570");
        }
        private void btnMaximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximized.Visible = false;
            btnMinimizedNormal.Visible = true;
        }

        private void btnMinimizedNormal_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizedNormal.IconColor = ColorTranslator.FromHtml("#686868");
        }

        private void btnMinimizedNormal_MouseHover(object sender, EventArgs e)
        {
            btnMinimizedNormal.IconColor = ColorTranslator.FromHtml("#125570");
        }
        private void btnMinimizedNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximized.Visible = true;
            btnMinimizedNormal.Visible = false;
        }

        
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimized_MouseHover(object sender, EventArgs e)
        {
            btnMinimized.IconColor = ColorTranslator.FromHtml("#125570");
        }

        private void btnMinimized_MouseLeave(object sender, EventArgs e)
        {
            btnMinimized.IconColor = ColorTranslator.FromHtml("#686868");
        }

        #endregion

        private void EjecutarBtnHome()
        {

            btnHome.BackColor = ColorTranslator.FromHtml(ColorActivo);
            btnNuevaV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnDiasEspeV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnVDePers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnLisEmpl.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnUsers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnHisto.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            EjecutarBtnHome();
          //  lbDatos.Text = CacheUsers.Cargo + " - " + CacheUsers.Nombre + " " + CacheUsers.Apellido;
            
        }

        private void pnCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }

        private void lbDatos_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnHisto_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnNuevaV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnDiasEspeV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnVDePers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnLisEmpl.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnUsers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnHisto.BackColor = ColorTranslator.FromHtml(ColorActivo);

        }

        private void btnNuevaV_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnNuevaV.BackColor = ColorTranslator.FromHtml(ColorActivo);
            btnDiasEspeV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnVDePers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnLisEmpl.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnUsers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnHisto.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
        }

        private void btnDiasEspeV_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnNuevaV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnDiasEspeV.BackColor = ColorTranslator.FromHtml(ColorActivo);
            btnVDePers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnLisEmpl.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnUsers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnHisto.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
        }

        private void btnVDePers_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnNuevaV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnDiasEspeV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnVDePers.BackColor = ColorTranslator.FromHtml(ColorActivo);
            btnLisEmpl.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnUsers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnHisto.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
        }

        private void btnLisEmpl_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnNuevaV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnDiasEspeV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnVDePers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnLisEmpl.BackColor = ColorTranslator.FromHtml(ColorActivo);
            btnUsers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnHisto.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnNuevaV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnDiasEspeV.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnVDePers.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnLisEmpl.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
            btnUsers.BackColor = ColorTranslator.FromHtml(ColorActivo);
            btnHisto.BackColor = ColorTranslator.FromHtml(ColorNoActivo);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            EjecutarBtnHome();
        }
    }
}

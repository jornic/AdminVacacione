using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Server;
using Negocio;


namespace Presentacion
{
    public partial class Configuracion : Form
    {
        Settings settings = new Settings();
        public bool Estado { get; set; }

        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Server.Servidor = txtServer.Text;
            Server.BD = txtBaseDeDato.Text;
            Server.Users = txtUsers.Text;
            Server.pwd = txtPas.Text;

            settings.UpdateSettings();
            if (MessageBox.Show("Se debe reiniciar el sistema para reflejar los cambios\n¿Deseas continuar?", "INFORMACION DEL SISTEMA",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {                
                DialogResult = DialogResult.OK;
                Application.Exit();
            }
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            txtServer.Text = ".";
            txtBaseDeDato.Text = "Vacaciones";
            txtUsers.Text = "Jornic";
            txtPas.Text = "Admin12345";
        }
    }
}

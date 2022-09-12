using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Entidades;
using Negocio.Modelos;

namespace Presentacion
{
    public partial class RegistrarEmpleado : Form
    {
        NEmpleado ne;

        public int IdEmpleado = 0;

        public RegistrarEmpleado()
        {
            InitializeComponent();
            Cargar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Verificar campos vacio
        public bool CamposVacios()
        {
            bool a = false;
            error.Clear();

            if (txtNombreA.Text == string.Empty)
            {
                error.SetError(txtNombreA, "Rellenar campo");
                a = true;
            }
            if (txtNombreB.Text == string.Empty)
            {
                error.SetError(txtNombreB, "Rellenar campo");
                a = true;

            }
            if (txtApellidoA.Text == string.Empty)
            {
                error.SetError(txtApellidoA, "Rellenar campo");
                a = true;

            }
            if (txtApellidoB.Text == string.Empty)
            {
                error.SetError(txtApellidoB, "Rellenar campo");
                a = true;
            }
            if (txtDir.Text == string.Empty)
            {
                error.SetError(txtDir, "Rellenar campo");
                a = true;
            }
            if (txtNIdentificacion.Text.Equals(string.Empty))
            {
                error.SetError(txtNIdentificacion, "Rellenar campo");
                a = true;
            }
            if (txtSalario.Text == string.Empty)
            {
                error.SetError(txtSalario, "Rellenar campo");
                a = true;
            }
            else
            {
                try
                {
                    int i = Convert.ToInt32(txtSalario.Text);
                }
                catch
                {
                    error.SetError(txtSalario, "Revisa los valores enviados");
                    a = true;
                }
            }

            return a;
        }

        #endregion
        public void Cargar()
        { 
            cbTipo.Items.Add("CEDULA");
            cbTipo.Items.Add("PASAPORTE");
            cbTipo.SelectedIndex = 0;
        }
        public void LimpiarCajas()
        {
            txtNombreA.Text = string.Empty;
            txtNombreB.Text = string.Empty;
            txtApellidoA.Text = string.Empty;
            txtApellidoB.Text = string.Empty;
            txtDir.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtNIdentificacion.Text = string.Empty;
        }

        public void Guardar()
        {
            ne = new NEmpleado();
            EEmpleado e = new EEmpleado() { Id = IdEmpleado, Nombrea = txtNombreA.Text,
                Nombreb = txtNombreB.Text, Apellidoa = txtApellidoA.Text, Apellidob = txtApellidoB.Text,
                Ttipodeident = cbTipo.Text, Nident = txtNIdentificacion.Text, Fecha = dtpFecha.Value.Date,
                Direccion = txtDir.Text,
                Salario = Convert.ToDouble(txtSalario.Text)
            };

            string msj = ne.InsertEmpleado(e);
            MessageBox.Show(msj);
            IdEmpleado = 0;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (CamposVacios() == false)
            {
                Guardar();
                LimpiarCajas();
                Close();
            }
        }

    }
}

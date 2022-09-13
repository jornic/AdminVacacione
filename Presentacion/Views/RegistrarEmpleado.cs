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

            if (txtFirstName.Text == string.Empty)
            {
                error.SetError(txtFirstName, "Rellenar campo");
                a = true;
            }
            if (txtSecunName.Text == string.Empty)
            {
                error.SetError(txtSecunName, "Rellenar campo");
                a = true;

            }
            if (txtFLastName.Text == string.Empty)
            {
                error.SetError(txtFLastName, "Rellenar campo");
                a = true;

            }
            if (txtSLastName.Text == string.Empty)
            {
                error.SetError(txtSLastName, "Rellenar campo");
                a = true;
            }
            if (rtbAddres.Text == string.Empty)
            {
                error.SetError(rtbAddres, "Rellenar campo");
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
                    double i = Convert.ToDouble(txtSalario.Text);
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
            txtFirstName.Text = string.Empty;
            txtSecunName.Text = string.Empty;
            txtFLastName.Text = string.Empty;
            txtSLastName.Text = string.Empty;
            rtbAddres.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtNIdentificacion.Text = string.Empty;
        }

        public void Guardar()
        {
            ne = new NEmpleado();
            string a = txtSalario.Text;
            string b = a.Replace('.', ',');
            double Salarios = Convert.ToDouble(b);
            EEmpleado e = new EEmpleado() { Id = IdEmpleado, Nombrea = txtFirstName.Text,
                Nombreb = txtSecunName.Text, Apellidoa = txtFLastName.Text, Apellidob = txtSLastName.Text,
                Ttipodeident = cbTipo.Text, Nident = txtNIdentificacion.Text, Fecha = dtpDate.Value.Date,
                Direccion = rtbAddres.Text,
                Salario = Convert.ToDouble((txtSalario.Text).Replace('.',','))
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


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

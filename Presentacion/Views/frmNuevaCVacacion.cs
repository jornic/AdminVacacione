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
using Soporte.Entidades;

namespace Presentacion.Views
{
    public partial class frmNuevaCVacacion : Form
    {
        private int IdEmpledo = 0;
        NEmpleado nempleado = new NEmpleado();
        NVacacion nVacacion = new NVacacion();
        public frmNuevaCVacacion()
        {
            InitializeComponent();
        }
        public void Cargar()
        {
            cbMotivo.Items.Clear();
            cbMotivo.Items.Add("Enfermedad");
            cbMotivo.Items.Add("Tramites");
            cbMotivo.Items.Add("Personal");
            cbMotivo.SelectedIndex = 0;
        }

        private void frmNuevaCVacacion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (IdEmpledo != 0)
            {
                gbEmpleado.Enabled = false;
                gbDetalles.Enabled = true;
            }
            else
            {
                MessageBox.Show("Algo salió mal, verifica el numero de empleado si existe ", "INFORMACION DEL SISTEMA ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cancelar()
        {
            IdEmpledo = 0;
            txtFirstName.Text = string.Empty;
            txtSecunName.Text = string.Empty;
            txtFLastName.Text = string.Empty;
            txtSLastName.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtTipoIdent.Text = string.Empty;
            txtFechaImgreso.Text = string.Empty;
            txtSalario.Text = string.Empty;
            Error.Clear();
            rcbObservacion.Text = string.Empty;
            txtBuscar.Text = string.Empty;
            gbEmpleado.Enabled = true;
            gbDetalles.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                var resul = nempleado.InforEmpleado(txtBuscar.Text);

                if (resul.Id != 0)
                {
                    IdEmpledo = resul.Id;
                    txtFirstName.Text = resul.Nombrea;
                    txtSecunName.Text = resul.Nombreb;
                    txtFLastName.Text = resul.Apellidoa;
                    txtSLastName.Text = resul.Apellidob;
                    txtIdentificacion.Text = resul.Nident;
                    txtTipoIdent.Text = resul.Ttipodeident;
                    txtFechaImgreso.Text = resul.Fecha.ToString();
                    txtSalario.Text = string.Concat("C$ ", resul.Salario.ToString());
                    Error.Clear();
                }
                else
                {
                    MessageBox.Show("Sin resultado", "INFORMACION DEL SISTEMA ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                Error.SetError(txtBuscar,"Campo nulo");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
            Cargar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(rcbObservacion.Text != "")
            {
                    var vacacion = new EVacacion() { Fk_empleado = IdEmpledo, Motivo = cbMotivo.Text, Descripcion = rcbObservacion.Text, Finicio = dtpInicio.Value, Ffin = dtpFin.Value };

                    MessageBox.Show(nVacacion.InsertVacacion(vacacion), "INFORMACION DEL SISTEMA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cancelar();
                    Cargar();               
            }
            else
            {
                Error.SetError(rcbObservacion, "No se permiten campos vacio");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

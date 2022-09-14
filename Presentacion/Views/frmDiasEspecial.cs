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

namespace Presentacion.Views
{
    public partial class frmDiasEspecial : Form
    {
        NVacacion nVacacion = new NVacacion();
        dgvModi dgv = new dgvModi();
        public frmDiasEspecial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rcbObservacion.Text != "")
            {
                if (MessageBox.Show("La siguiente operación agregara el día a cuenta de vacación a todos los trabajadores.\n¿Quieres continuar?", "INFORMACION DEL SISTEMA ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var vacacion = new EVacacion() { Motivo = cbMotivo.Text, Descripcion = rcbObservacion.Text, Finicio = dtpInicio.Value, Ffin = dtpFin.Value };

                    MessageBox.Show(nVacacion.InsertVacacionEspecial(vacacion), "INFORMACION DEL SISTEMA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rcbObservacion.Text = "";
                    cbMotivo.SelectedIndex = 0;
                    CargarData();
                    Error.Clear();
                }
            }
            else
            {
                Error.SetError(rcbObservacion, "No se permiten campos vacio");
            }
        }

        private void frmDiasEspecial_Load(object sender, EventArgs e)
        {
            Cargar();
            CargarData();
        }
        public void Cargar()
        {
            cbMotivo.Items.Add("Feriado");
            cbMotivo.Items.Add("Otros motivos");
            cbMotivo.SelectedIndex = 0;

        }
        public void CargarData()
        {
            dgv.NewDGV(dgvDetalleVacacione);

            dgvDetalleVacacione.DataSource = null;
            dgvDetalleVacacione.DataSource = nVacacion.ListVacacEspeci();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarData();
        }
    }
}

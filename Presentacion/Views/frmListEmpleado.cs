using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Modelos;


namespace Presentacion
{
    public partial class frmListEmpleado : Form
    {
        NEmpleado empleado = new NEmpleado();


        public frmListEmpleado()
        {
            InitializeComponent();
        }
        public void Cargar()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleado.ListEmpleado(); ;
            ModificarDgv();
        }

        private void btnAddEmpleado_Click(object sender, EventArgs e)
        {         
           RegistrarEmpleado frmRegistrar = new RegistrarEmpleado();
           frmRegistrar.ShowDialog();
           Cargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void ModificarDgv()
        {
            var dgv = dgvEmpleados;
            // dgv.ColumnCount = 9;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7B68EE");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#007ACC");
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight =30;


            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = true;

            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = false;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar?", "INFORMACION DE SISTEMA ",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string idEmpleado = dgvEmpleados.CurrentRow.Cells["Numero"].Value.ToString();
                    string res = empleado.Delete(idEmpleado);
                    MessageBox.Show(res);
                    Cargar();
                }
            }
            else
                MessageBox.Show("seleccione una fila");
        }
        
        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                var obj = empleado.InforEmpleado(dgvEmpleados.CurrentRow.Cells["Numero"].Value.ToString());

                RegistrarEmpleado registrar = new RegistrarEmpleado();
                registrar.IdEmpleado = obj.Id;
                registrar.txtFirstName.Text = obj.Nombrea;
                registrar.txtSecunName.Text = obj.Nombreb;
                registrar.txtFLastName.Text = obj.Apellidoa;
                registrar.txtSLastName.Text = obj.Apellidob;
                registrar.cbTipo.Text = obj.Ttipodeident;
                registrar.txtNIdentificacion.Text = obj.Nident;
                registrar.rtbAddres.Text = obj.Direccion;
                registrar.dtpDate.Value = obj.Fecha;
                registrar.txtSalario.Text = obj.Salario.ToString();

                registrar.ShowDialog();
                Cargar();
            }
            else
                MessageBox.Show("seleccione una fila");

        }

    }
}

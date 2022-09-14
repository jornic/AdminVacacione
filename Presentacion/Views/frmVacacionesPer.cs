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
using Microsoft.Office.Interop.Excel;

namespace Presentacion.Views
{
    public partial class frmVacacionesPer : Form
    {
        NVacacion nVacacion = new NVacacion();
        dgvModi dgv = new dgvModi();
        public frmVacacionesPer()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dgv.NewDGV(dgvVacacioneEmpleados);
            dgvVacacioneEmpleados.DataSource = nVacacion.MostrarVacaciones(dtpFInicio.Value,dtpFFin.Value);
        }

        private void dgvVacacioneEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.NewDGV(dgvDetalleVEmpleado);
            dgvDetalleVEmpleado.DataSource = nVacacion.MostrarDetalleVacaciones(Convert.ToInt32(dgvVacacioneEmpleados.CurrentRow.Cells[0].Value.ToString()),dtpFInicio.Value, dtpFFin.Value);

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel(dgvVacacioneEmpleados);
        }

        public void ExportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            int index = 0;

            foreach(DataGridViewColumn column in tabla.Columns)
            {
                index++;
                excel.Cells[1, index] = column.Name;
            }

            int indexFila = 0;
            foreach(DataGridViewRow row in tabla.Rows)
            {
                indexFila++;
                index = 0;

                foreach (DataGridViewColumn column in tabla.Columns)
                {
                    index++;
                    excel.Cells[indexFila + 1, index] = row.Cells[column.Name].Value; ;
                }
            }

            excel.Visible = true;
        }
    }
}

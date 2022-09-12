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

        public string idEmpleado1 = "";
        public string Nombre1 = "";
        public string Apellido1 = "";
        public string Tele1;
        public string Email1;
        public string Dir1;
        public string Edad1;
        public string Genero1;
        public string Cargo1;

        public frmListEmpleado()
        {
            InitializeComponent();
        }
        
        public void RegisEmpleado(string nombre, string apillido, string tel, string email, string dir, int edad, string sexo, string cargo)
        {
           /* int id = random.Next(100, 1000);
            Empleado empleado = new Empleado(id, nombre, apillido, tel, email, dir, edad, sexo, cargo);
            lis.Add(empleado);
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = lis;*/
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
                string idEmpleado = dgvEmpleados.CurrentRow.Cells["Numero"].Value.ToString();
                string res = empleado.Delete(idEmpleado);
                MessageBox.Show(res);
                Cargar();
            }
            else
                MessageBox.Show("seleccione una fila");
        }
        
        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          /*  RegistrarEmpleado frmRegistrar = new RegistrarEmpleado();

            string Genero = "";

            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                frmRegistrar.IdEmpleado = dgvEmpleados.CurrentRow.Cells["Id"].Value.ToString();
                frmRegistrar.txtNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                frmRegistrar.txtApellido.Text = dgvEmpleados.CurrentRow.Cells["Apellido"].Value.ToString();
                frmRegistrar.txtTelefono.Text = dgvEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();
                frmRegistrar.txtEmail.Text = dgvEmpleados.CurrentRow.Cells["Email"].Value.ToString();
                frmRegistrar.txtDir.Text = dgvEmpleados.CurrentRow.Cells["Direccion"].Value.ToString();
                frmRegistrar.txtEdad.Text = dgvEmpleados.CurrentRow.Cells["Edad"].Value.ToString();
                Genero = dgvEmpleados.CurrentRow.Cells["Genero"].Value.ToString();
                frmRegistrar.cbCargo.Text = dgvEmpleados.CurrentRow.Cells["Cargo"].Value.ToString();

                if(Genero == "Masculino")
                {
                    frmRegistrar.rbMasculino.Checked = true;
                    frmRegistrar.rbFemenino.Checked = false;
                }
                else
                {
                    frmRegistrar.rbFemenino.Checked = true;
                    frmRegistrar.rbMasculino.Checked = false;
                }

                frmRegistrar.ShowDialog();
                Cargar();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            
            */
        }
    }
}

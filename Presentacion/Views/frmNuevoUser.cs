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
using Soporte.Entidades;

namespace Presentacion.Views
{
    public partial class frmNuevoUser : Form
    {
        NEmpleado empleado = new NEmpleado();
        NUser u = new NUser();
        dgvModi dgvModi = new dgvModi();

        private bool Estado = false;
        private int Id = 0;
        public frmNuevoUser()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtBuscar.Text.Equals(string.Empty))
            {
                var DEmpleado = empleado.InforEmpleado(txtBuscar.Text);

                txtFirstName.Text = DEmpleado.Nombrea;
                txtSecunName.Text = DEmpleado.Nombreb;
                txtFLastName.Text = DEmpleado.Apellidoa;
                txtSLastName.Text = DEmpleado.Apellidob;
                txtIdentificacion.Text = DEmpleado.Nident;
                txtTipoIdent.Text = DEmpleado.Ttipodeident;

                if (DEmpleado.Nombrea == null)
                {
                    MessageBox.Show("Sin resultados");
                }
                else
                {
                    Estado = true;
                    Id = DEmpleado.Id;
                }
            }
            else
            {
                errorStringEmpty.SetError(txtBuscar, "Ingrese el numero del empleado a buscar");
            }
        }


        private void frmNuevoUser_Load(object sender, EventArgs e)
        {
            Refrescardgv();
        }

        private void Refrescardgv()
        {
            dgvModi.NewDGV(dgvListUsers);

            dgvListUsers.DataSource = null;
            dgvListUsers.DataSource = u.SelectAllUsers();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refrescardgv();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Estado&&Id != 0)
            {
                if (DatosOk())
                {
                    var usuario = new NuevoUsuario() { Usuario = txtUser.Text, Contrasena = txtPassword.Text, Fk_Empleado = Id };
                    MessageBox.Show(u.InsertUser(usuario), "INFORMACION DEL SISTEMA ", MessageBoxButtons.OK);
                    Refrescardgv();

                    Estado = false;
                    Id = 0;

                    txtBuscar.Text = string.Empty;
                    txtFirstName.Text = string.Empty;
                    txtFLastName.Text = string.Empty;
                    txtSecunName.Text = string.Empty;
                    txtSLastName.Text = string.Empty;
                    txtIdentificacion.Text = string.Empty;
                    txtTipoIdent.Text = string.Empty;
                    txtUser.Text = string.Empty;
                    txtPassword.Text = string.Empty;

                    errorStringEmpty.Clear();
                }
            }
            else
            {
                MessageBox.Show("Algo salió mal, verifica el numero de empleado si existe ", "INFORMACION DEL SISTEMA ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool DatosOk()
        {
            bool ok = true;
            errorStringEmpty.Clear();

            if (txtUser.Text == "")
            {
                errorStringEmpty.SetError(txtUser, "No se permite campo vacío");
                ok = false;
            }
            if (txtPassword.Text == "")
            {
                errorStringEmpty.SetError(txtPassword, "No se permite campo vacío");
                ok = false;
            }

                return ok;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListUsers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar?", "INFORMACION DEL SISTEMA ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string res = u.DeleteUser(dgvListUsers.CurrentRow.Cells["Id Usuario"].Value.ToString());
                    MessageBox.Show(res);
                    Refrescardgv();
                }
            }
            else
                MessageBox.Show("seleccione una fila");
        }
    }
}

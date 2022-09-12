
namespace Presentacion
{
    partial class frmListEmpleado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListEmpleado));
            this.pnData = new System.Windows.Forms.Panel();
            this.lbLista = new System.Windows.Forms.Label();
            this.btnAddEmpleado = new Jornic.JComponente.JButton();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.cmsData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.pnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.cmsData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnData
            // 
            this.pnData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnData.AutoScroll = true;
            this.pnData.AutoScrollMinSize = new System.Drawing.Size(905, 387);
            this.pnData.AutoSize = true;
            this.pnData.BackColor = System.Drawing.Color.White;
            this.pnData.Controls.Add(this.lbLista);
            this.pnData.Controls.Add(this.btnAddEmpleado);
            this.pnData.Controls.Add(this.dgvEmpleados);
            this.pnData.Location = new System.Drawing.Point(12, 12);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(905, 387);
            this.pnData.TabIndex = 22;
            // 
            // lbLista
            // 
            this.lbLista.AutoSize = true;
            this.lbLista.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLista.Location = new System.Drawing.Point(12, 14);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(114, 16);
            this.lbLista.TabIndex = 24;
            this.lbLista.Text = "Lista de Empleado";
            // 
            // btnAddEmpleado
            // 
            this.btnAddEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnAddEmpleado.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnAddEmpleado.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddEmpleado.BorderRadius = 0;
            this.btnAddEmpleado.BorderSize = 0;
            this.btnAddEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAddEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnAddEmpleado.Location = new System.Drawing.Point(783, 12);
            this.btnAddEmpleado.Name = "btnAddEmpleado";
            this.btnAddEmpleado.Size = new System.Drawing.Size(109, 23);
            this.btnAddEmpleado.TabIndex = 23;
            this.btnAddEmpleado.Text = "Agregar";
            this.btnAddEmpleado.TextColor = System.Drawing.Color.White;
            this.btnAddEmpleado.UseVisualStyleBackColor = false;
            this.btnAddEmpleado.Click += new System.EventHandler(this.btnAddEmpleado_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.ContextMenuStrip = this.cmsData;
            this.dgvEmpleados.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 48);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEmpleados.Size = new System.Drawing.Size(905, 339);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // cmsData
            // 
            this.cmsData.AutoSize = false;
            this.cmsData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.cmsData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.actualizarToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.cmsData.Name = "cmsData";
            this.cmsData.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsData.Size = new System.Drawing.Size(120, 85);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.actualizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarToolStripMenuItem.Image")));
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem1
            // 
            this.actualizarToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.actualizarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("actualizarToolStripMenuItem1.Image")));
            this.actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1";
            this.actualizarToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.actualizarToolStripMenuItem1.Text = "Editar";
            this.actualizarToolStripMenuItem1.Click += new System.EventHandler(this.actualizarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // frmListEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(929, 411);
            this.Controls.Add(this.pnData);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(905, 387);
            this.Name = "frmListEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systems";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.cmsData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private Jornic.JComponente.JButton btnAddEmpleado;
        private System.Windows.Forms.Label lbLista;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.ContextMenuStrip cmsData;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}


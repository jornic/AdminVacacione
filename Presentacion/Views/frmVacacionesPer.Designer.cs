
namespace Presentacion.Views
{
    partial class frmVacacionesPer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnData = new System.Windows.Forms.Panel();
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDetalleVEmpleado = new System.Windows.Forms.DataGridView();
            this.btnExportar = new Jornic.JComponente.JButton();
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpFFin = new System.Windows.Forms.DateTimePicker();
            this.btnCargar = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvVacacioneEmpleados = new System.Windows.Forms.DataGridView();
            this.pnData.SuspendLayout();
            this.gbDetalles.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVEmpleado)).BeginInit();
            this.gbEmpleado.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacacioneEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnData
            // 
            this.pnData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnData.AutoScroll = true;
            this.pnData.BackColor = System.Drawing.Color.White;
            this.pnData.Controls.Add(this.gbDetalles);
            this.pnData.Controls.Add(this.gbEmpleado);
            this.pnData.Location = new System.Drawing.Point(11, 14);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(846, 387);
            this.pnData.TabIndex = 25;
            // 
            // gbDetalles
            // 
            this.gbDetalles.Controls.Add(this.panel1);
            this.gbDetalles.Controls.Add(this.btnExportar);
            this.gbDetalles.Location = new System.Drawing.Point(444, 3);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Size = new System.Drawing.Size(393, 381);
            this.gbDetalles.TabIndex = 37;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalles";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDetalleVEmpleado);
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 323);
            this.panel1.TabIndex = 45;
            // 
            // dgvDetalleVEmpleado
            // 
            this.dgvDetalleVEmpleado.AllowUserToAddRows = false;
            this.dgvDetalleVEmpleado.AllowUserToDeleteRows = false;
            this.dgvDetalleVEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalleVEmpleado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetalleVEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleVEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVEmpleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvDetalleVEmpleado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetalleVEmpleado.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleVEmpleado.Name = "dgvDetalleVEmpleado";
            this.dgvDetalleVEmpleado.ReadOnly = true;
            this.dgvDetalleVEmpleado.Size = new System.Drawing.Size(392, 323);
            this.dgvDetalleVEmpleado.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnExportar.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnExportar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExportar.BorderRadius = 0;
            this.btnExportar.BorderSize = 0;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(278, 348);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(109, 27);
            this.btnExportar.TabIndex = 44;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextColor = System.Drawing.Color.White;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.Controls.Add(this.groupBox4);
            this.gbEmpleado.Controls.Add(this.dgvVacacioneEmpleados);
            this.gbEmpleado.Location = new System.Drawing.Point(3, 3);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Size = new System.Drawing.Size(435, 381);
            this.gbEmpleado.TabIndex = 0;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Text = "Lista de vacaciones";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dtpFFin);
            this.groupBox4.Controls.Add(this.btnCargar);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dtpFInicio);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 74);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rango de fecha";
            // 
            // dtpFFin
            // 
            this.dtpFFin.Location = new System.Drawing.Point(175, 38);
            this.dtpFFin.Name = "dtpFFin";
            this.dtpFFin.Size = new System.Drawing.Size(152, 23);
            this.dtpFFin.TabIndex = 38;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnCargar.IconColor = System.Drawing.Color.White;
            this.btnCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargar.IconSize = 19;
            this.btnCargar.Location = new System.Drawing.Point(333, 38);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(74, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(172, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Desde ";
            // 
            // dtpFInicio
            // 
            this.dtpFInicio.Location = new System.Drawing.Point(14, 38);
            this.dtpFInicio.Name = "dtpFInicio";
            this.dtpFInicio.Size = new System.Drawing.Size(152, 23);
            this.dtpFInicio.TabIndex = 37;
            // 
            // dgvVacacioneEmpleados
            // 
            this.dgvVacacioneEmpleados.AllowUserToAddRows = false;
            this.dgvVacacioneEmpleados.AllowUserToDeleteRows = false;
            this.dgvVacacioneEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVacacioneEmpleados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVacacioneEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVacacioneEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacacioneEmpleados.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvVacacioneEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVacacioneEmpleados.Location = new System.Drawing.Point(3, 99);
            this.dgvVacacioneEmpleados.Name = "dgvVacacioneEmpleados";
            this.dgvVacacioneEmpleados.ReadOnly = true;
            this.dgvVacacioneEmpleados.Size = new System.Drawing.Size(429, 279);
            this.dgvVacacioneEmpleados.TabIndex = 1;
            this.dgvVacacioneEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacacioneEmpleados_CellDoubleClick);
            // 
            // frmVacacionesPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(869, 414);
            this.Controls.Add(this.pnData);
            this.Name = "frmVacacionesPer";
            this.Text = "frmVacacionesPer";
            this.pnData.ResumeLayout(false);
            this.gbDetalles.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVEmpleado)).EndInit();
            this.gbEmpleado.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacacioneEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.GroupBox gbDetalles;
        private Jornic.JComponente.JButton btnExportar;
        private System.Windows.Forms.GroupBox gbEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDetalleVEmpleado;
        private System.Windows.Forms.DataGridView dgvVacacioneEmpleados;
        private System.Windows.Forms.DateTimePicker dtpFFin;
        private System.Windows.Forms.DateTimePicker dtpFInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnCargar;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}
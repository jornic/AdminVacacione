
namespace Presentacion.Views
{
    partial class frmPrincipal
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
            this.mcMeses = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // mcMeses
            // 
            this.mcMeses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcMeses.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.mcMeses.Enabled = false;
            this.mcMeses.Location = new System.Drawing.Point(3, 5);
            this.mcMeses.Name = "mcMeses";
            this.mcMeses.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(791, 474);
            this.Controls.Add(this.mcMeses);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcMeses;
    }
}
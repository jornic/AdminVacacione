using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Presentacion
{
    public class dgvModi
    {
        public void NewDGV(DataGridView e)
        {
            e.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            e.BackgroundColor = Color.White;
            e.BorderStyle = BorderStyle.None;
            e.CellBorderStyle = DataGridViewCellBorderStyle.None;
            e.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            e.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            e.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7B68EE");
            e.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            e.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#007ACC");
            e.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            e.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            e.ColumnHeadersDefaultCellStyle.Font = new Font(e.Font, FontStyle.Bold);
            e.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11);
            e.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            e.ColumnHeadersHeight = 30;


            e.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            e.MultiSelect = true;

            e.EnableHeadersVisualStyles = false;
            e.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            e.RowHeadersVisible = false;

        }
    }
}

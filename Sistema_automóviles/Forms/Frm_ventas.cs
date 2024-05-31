using Sistema_automóviles.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Sistema_automóviles.Models.Classes;
using System.Windows.Controls.Primitives;

namespace Sistema_automóviles.Forms
{
    public partial class Frm_ventas : Form
    {
        readonly AutoDB db = new AutoDB();
        public Frm_ventas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void Frm_ventas_Load(object sender, EventArgs e)
        {
            DGV.DataSource = db.GetAllVentas();

            DataGridViewTextBoxColumn nuevaColumna = new DataGridViewTextBoxColumn();
            nuevaColumna.HeaderText = "X";
            nuevaColumna.Name = "Eliminar";
            nuevaColumna.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nuevaColumna.Width = 40;
            DGV.Columns.Add(nuevaColumna);
            //foreach (DataGridViewRow row in DGV.Rows)
            //{
            //    DataGridViewCell cell = row.Cells["Eliminar"];
            //    cell.Style.BackColor = Color.FromArgb(255, 255, 0, 0);
            //}
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DGV.CurrentRow.Cells[0].Value);
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar la venta", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    if (db.DeleteVenta(id))
                        DGV.DataSource = db.GetAllVentas();
                }
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    (Proveedor, Cliente) datos = db.GetInfoVenta(id);
                    var p = datos.Item1;
                    var c = datos.Item2;
                    MessageBox.Show($"\tCLIENTE\n-Nombre: {c.Nombre} {c.APaterno} {c.AMaterno}\n-Correo: {c.Correo}\n" +
                        $"-Teléfono: {c.Telefono}\n-RFC: {c.RFC}\n-CP: {c.CP}\n-------------------------------------------" +
                        $"\n\tPROVEEDOR\n-Nombre: {p.Nombre}\n-Teléfono: {p.Telefono}\n-Correo: {p.Correo}" +
                        $"\n-Dirección: {p.Direccion}", "Información de la venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

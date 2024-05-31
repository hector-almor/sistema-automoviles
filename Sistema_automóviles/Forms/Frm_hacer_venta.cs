using System;
using System.Collections;
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
using Sistema_automóviles.Models.Models;

namespace Sistema_automóviles.Forms
{
    public partial class Frm_hacer_venta : Form
    {
        private readonly Auto oAuto;
        private Dictionary<string, int?> clientes = new Dictionary<string, int?>();
        readonly AutoDB db = new AutoDB();
        public Frm_hacer_venta(Auto auto)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            oAuto = auto;
        }

        private void Frm_hacer_venta_Load(object sender, EventArgs e)
        {
            LblAuto.Text = $"{oAuto.Marca} - {oAuto.Modelo} - {oAuto.Año} - {oAuto.Precio.ToString("$ " + "#,##0.00")}";
            float total = Convert.ToInt32(NumAutos.Value) * oAuto.Precio;
            TxtPrecio.Text = total.ToString("$ " + "#,##0.00");
            var allclientes = db.GetClientes();
            allclientes.ForEach(c => clientes.Add($"{c.Nombre} {c.APaterno} {c.AMaterno}", c.ID_cliente));
            foreach (var cliente in clientes)
            {
                CmbCliente.Items.Add(cliente.Key);
            }
            db.SetImageMemory(PicBox,oAuto.ID_auto,db.GetDirectoryImg());
        }

        private void NumAutos_ValueChanged(object sender, EventArgs e)
        {
            float total = Convert.ToInt32(NumAutos.Value) * oAuto.Precio;
            TxtPrecio.Text = total.ToString("$ " + "#,##0.00");
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            ErrorP.Clear();
            foreach (System.Windows.Forms.Control control in Controls)
            {
                if (control is System.Windows.Forms.TextBox && control.Text.Trim() == string.Empty)
                {
                    ErrorP.SetError(control, "El campo no puede estar vacío");
                    return;
                }
            }
            if (CmbCliente.SelectedIndex == -1)
            {
                ErrorP.SetError(CmbCliente, "Selecciona un cliente");
                return;
            }
            if (!Frm_detalles_auto.IsNumeric(TxtTotal.Text.Trim()))
            {
                ErrorP.SetError(TxtTotal, "El valor debe ser numérico");
                return;
            }
            if (Convert.ToInt32(NumAutos.Value) == 0)
            {
                ErrorP.SetError(NumAutos, "Al menos selecciona un auto");
                return;
            }
            if (Convert.ToInt32(NumAutos.Value) > oAuto.Existencia)
            {
                ErrorP.SetError(NumAutos, "No hay suficientes autos en stock");
                return;
            }
            //Hacer la venta
            DialogResult result = MessageBox.Show("¿Todos sus campos son correctos?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                var venta = new Venta();
                venta.ID_auto = oAuto.ID_auto;
                venta.ID_cliente = clientes[CmbCliente.SelectedItem.ToString()].Value;
                venta.Descripcion = TxtDescripcion.Text.Trim();
                venta.Fecha = DateTime.Now;
                venta.Numero_autos = Convert.ToByte(NumAutos.Value);
                venta.Precio = Convert.ToInt32(NumAutos.Value) * oAuto.Precio;
                venta.Total = float.Parse(TxtTotal.Text.Trim());
                db.HacerVenta(venta);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

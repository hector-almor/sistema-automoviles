using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_automóviles.Models.Classes;

namespace Sistema_automóviles.Forms
{
    public partial class Frm_detalles_auto : Form
    {
        private readonly Auto oAuto;
        public Frm_detalles_auto(Auto auto)
        {
            InitializeComponent();
            oAuto = auto;
        }
        public bool IsNumeric(string cadena, bool fourdigits = false)
        {
            Regex regex;
            if (fourdigits)
                regex = new Regex(@"^\d{4}$");
            else
                regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(cadena);
        }
        private void Frm_detalles_auto_Load(object sender, EventArgs e)
        {
            TxtID.Text = oAuto.ID_auto.ToString();
            TxtMarca.Text = oAuto.Marca;
            TxtModelo.Text = oAuto.Modelo;
            TxtAño.Text = oAuto.Año.ToString();
            TxtExistencia.Text = oAuto.Existencia.ToString();
        }
        private void ValidarNumeros(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if(txt.Text.Trim()!=string.Empty && !IsNumeric(txt.Text.Trim()))
            {
                MessageBox.Show("Solo se admiten valores numéricos.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                int index = txt.Text.Length;
                txt.Text = txt.Text.Substring(0, index-1);
            }
        }
    }
}

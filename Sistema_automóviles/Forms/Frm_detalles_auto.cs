using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Asn1.Misc;
using Sistema_automóviles.Models.Classes;
using Sistema_automóviles.Models.Models;

namespace Sistema_automóviles.Forms
{
    public partial class Frm_detalles_auto : Form
    {
        private readonly Auto oAuto;
        readonly AutoDB db = new AutoDB();
        private readonly TipoForm tipoForm;
        private string pathImg;
        public Frm_detalles_auto(Auto auto, TipoForm tpform)
        {
            InitializeComponent();
            oAuto = auto;
            tipoForm = tpform;
            pathImg = db.GetDirectoryImg() + "\\img\\" + auto.ID_auto;
            StartPosition = FormStartPosition.CenterScreen;
        }
        public enum TipoForm
        {
            Agregar = 0,
            Actualizar = 1,
            Mostrar = 2
        }
        public void AddImg(int? id)
        {
            if (pathImg.LastIndexOf(".") != -1)
            {
                string extension = pathImg.Substring(pathImg.LastIndexOf("."));
                File.Copy(pathImg, db.GetDirectoryImg() + "\\img\\" + id + extension);
            }
        }
        public static bool IsNumeric(string cadena, bool fourdigits = false)
        {
            Regex regex;
            if (fourdigits)
                regex = new Regex(@"^\d{1,4}$");
            else
                regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(cadena);
        }
        private void Frm_detalles_auto_Load(object sender, EventArgs e)
        {
            AutoDB.newPathImg = "";
            string? path = db.GetDirectoryImg();
            switch (tipoForm)
            {
                case TipoForm.Agregar:
                    LblTitulo.Text = "Agregar auto";
                    PicBox.IconChar = IconChar.Image;
                    PicBox.IconColor = Color.FromArgb(224, 224, 224);
                    BtnEditImg.IconChar = IconChar.Upload;
                    LblID.Visible = true;
                    TxtID.Visible = true;
                    break;
                case TipoForm.Actualizar:
                    LblTitulo.Text = "Actualizar auto";
                    //BtnEditImg.Visible = false;
                    PicBox.IconChar = IconChar.None;
                    BtnAccion.IconChar = IconChar.Check;
                    BtnLimpiar.Visible = false;
                    db.SetImageMemory(PicBox, oAuto.ID_auto, path);
                    break;
                case TipoForm.Mostrar:
                    LblTitulo.Text = "Detalles auto";
                    db.SetImage(PicBox, oAuto.ID_auto, path);
                    BtnAccion.Visible = false;
                    BtnEditImg.Visible = false;
                    BtnLimpiar.Visible = false;
                    LblID.Visible = true;
                    TxtID.Visible = true;
                    foreach (Control control in Controls)
                    {
                        if (control is TextBox)
                        {
                            var newcontrol = (TextBox)control;
                            newcontrol.ReadOnly = true;
                        }
                    }
                    break;
            }
            TxtID.Text = oAuto.ID_auto.ToString();
            TxtMarca.Text = oAuto.Marca;
            TxtModelo.Text = oAuto.Modelo;
            TxtAño.Text = oAuto.Año.ToString();
            TxtExistencia.Text = oAuto.Existencia.ToString();
            TxtCosto.Text = oAuto.Costo.ToString();
            TxtPrecio.Text = oAuto.Precio.ToString();
            if (tipoForm == TipoForm.Agregar)
                TxtPrecio.Clear();
        }
        private void ValidarNumeros(object sender, EventArgs e)
        {
            bool fourdigits = false;
            string agregado = ".";
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Trim();
            if (txt.Name == "TxtAño")
            {
                fourdigits = true;
                agregado = " de cuatro dígitos.";
            }
            if (txt.Text != string.Empty && !IsNumeric(txt.Text, fourdigits))
            {
                MessageBox.Show("Solo se admiten valores numéricos" + agregado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string caracter = ".";
                if (fourdigits && IsNumeric(txt.Text))
                {
                    txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
                }
                else
                {
                    for (int i = 0; i < txt.Text.Length; i++)
                    {
                        if (!IsNumeric(txt.Text[i].ToString()))
                        {
                            caracter = txt.Text[i].ToString();
                            break;
                        }
                    }
                }
                txt.Text = txt.Text.Replace(caracter, "");
            }
        }

        private void BtnAcción_Click(object sender, EventArgs e)
        {
            ErrorP.Clear();
            foreach (Control control in Controls)
            {
                if (control is TextBox && control.Text.Trim() != string.Empty && control.Name == "TxtAño" && control.Text.Trim().Length < 4)
                {
                    ErrorP.SetError(control, "El año debe ser de 4 digitos");
                    return;
                }
                if (control is TextBox && control.Text.Trim() == string.Empty)
                {
                    ErrorP.SetError(control, "Este campo no puede estar vacío.");
                    return;
                }
            }
            string message = "¿Estás seguro de actualizar los valores de este auto?";
            if (tipoForm == TipoForm.Agregar)
                message = "¿Estás seguro de agregar este auto?";
            DialogResult result = MessageBox.Show(message, "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                return;

            Auto auto = new Auto();
            auto.ID_auto = oAuto.ID_auto;
            if (oAuto.ID_auto == null)
                auto.ID_auto = Convert.ToInt32(TxtID.Text.Trim());
            auto.Marca = TxtMarca.Text.Trim();
            auto.Modelo = TxtModelo.Text.Trim();
            auto.Año = Convert.ToInt32(TxtAño.Text.Trim());
            auto.Existencia = Convert.ToInt32(TxtExistencia.Text.Trim());
            auto.Costo = float.Parse(TxtCosto.Text.Trim());
            auto.Precio = float.Parse(TxtPrecio.Text.Trim());
            if (tipoForm == TipoForm.Actualizar)
            {
                db.UpdateAuto(auto);
            }
            else
            {
                if (db.AddAuto(auto))
                {
                    AddImg(auto.ID_auto);
                }
            }
        }

        private void BtnEditImg_Click(object sender, EventArgs e)
        {
            AutoDB.newPathImg = "";
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathImg = openFileDialog.FileName;
                    using (FileStream fs = new FileStream(pathImg, FileMode.Open, FileAccess.Read))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            fs.CopyTo(ms);
                            ms.Position = 0;
                            PicBox.Image = new Bitmap(ms);
                        }
                    }
                    AutoDB.newPathImg = pathImg;
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            AutoDB.newPathImg = pathImg = "";
            if (PicBox != null && PicBox.Image != null)
            {
                PicBox.Image.Dispose();
                PicBox.Image = null;
            }
            PicBox.IconChar = IconChar.Image;
            PicBox.IconColor = Color.FromArgb(224, 224, 224);
        }

        
    }
}

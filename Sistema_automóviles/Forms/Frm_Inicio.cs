using Sistema_automóviles.Models.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_automóviles.Models.Models;
using FontAwesome.Sharp;

namespace Sistema_automóviles.Forms
{
    public partial class Frm_Inicio : Form
    {
        const byte Xinicial = 24;
        const byte Yinicial = 10;
        const byte separacion = 15;//15
        ushort conteoPanelesEnlinea = 0;
        ushort conteoFilasPaneles = 0;
        const ushort anchoPanel = 350;//292
        const ushort altoPanel = 435;//400
        readonly AutoDB db = new AutoDB();
        Dictionary<Panel, string[]> kvpaneles = new Dictionary<Panel, string[]>();
        public Frm_Inicio()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private void PanelUpdate(Auto auto)
        {
            string index = auto.ID_auto.ToString();
            var prepanel = Contenedor.Controls["Panel_" + index];
            if (prepanel == null)
                return;
            Panel panel = (Panel)prepanel;
            panel.Controls["Marca_" + index].Text = auto.Marca;
            panel.Controls["Modelo_" + index].Text = auto.Modelo;
            panel.Controls["Año_" + index].Text = auto.Año.ToString();
            panel.Controls["Existencia_" + index].Text = "Existencia: " + auto.Existencia.ToString();
            panel.Controls["Precio_" + index].Text = auto.Precio.ToString("$ " + "#,##0.00");
            kvpaneles[panel] = [auto.Marca, auto.Modelo, auto.Año.ToString()];
            var picBox = (IconPictureBox)panel.Controls["Imagen_" + index];
            if (AutoDB.newPathImg != string.Empty)
            {
                if (picBox != null && picBox.Image != null)
                {
                    picBox.Image.Dispose();
                    picBox.Image = null;
                }
                db.DeleteImg(Convert.ToInt32(index));
                string newpath = AutoDB.newPathImg.Substring(AutoDB.newPathImg.LastIndexOf("\\") + 1);
                File.Copy(AutoDB.newPathImg, db.GetDirectoryImgById(Convert.ToInt32(index), newpath, db.GetDirectoryImg()));
                db.SetImage(picBox, Convert.ToInt32(index), db.GetDirectoryImg());
            }
            AutoDB.newPathImg = "";
        }
        private void OrdenarPaneles(Predicate<KeyValuePair<Panel, string[]>> condicion)
        {
            conteoFilasPaneles = 0;
            conteoPanelesEnlinea = 0;
            var scrollEnX = Contenedor.AutoScrollPosition.X;
            var scrollEnY = Contenedor.AutoScrollPosition.Y;
            foreach (var kvp in kvpaneles)
            {
                if (condicion(kvp))
                {
                    kvp.Key.Visible = true;
                    kvp.Key.Location = new Point(
                        Xinicial + (conteoPanelesEnlinea * (separacion + anchoPanel)) + scrollEnX,
                        Yinicial + (conteoFilasPaneles * (separacion + altoPanel)) + scrollEnY);
                    conteoPanelesEnlinea++;
                    if (conteoPanelesEnlinea >= 5)
                    {
                        conteoPanelesEnlinea = 0;
                        conteoFilasPaneles++;
                    }
                }
                else
                    kvp.Key.Visible = false;
            }
        }
        private void FirstShowAutos()
        {
            string? path = db.GetDirectoryImg();
            IEnumerable<Auto> autos = db.GetAllAutos().ToList().OrderBy(c => c.Marca);
            foreach (Auto auto in autos)
            {
                //Crear panel
                Panel panel = new Panel();
                panel.Name = "Panel_" + auto.ID_auto.ToString();
                panel.Width = anchoPanel;
                panel.Height = altoPanel;
                panel.BorderStyle = BorderStyle.None;
                Point punto = new Point(Xinicial + (conteoPanelesEnlinea * (separacion + anchoPanel)),
                    Yinicial + (conteoFilasPaneles * (separacion + altoPanel)));
                panel.Location = punto;
                panel.BackColor = Color.FromArgb(0x2A, 0x2C, 0x41);
                ///////////Contenido panel
                //Imagen
                IconPictureBox picbox = new IconPictureBox();
                picbox.Name = "Imagen_" + auto.ID_auto.ToString();
                picbox.Location = new Point(14, 14);
                picbox.Width = 326;//266
                picbox.Height = 202;
                picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                db.SetImage(picbox, auto.ID_auto, path);
                panel.Controls.Add(picbox);
                //////Informacion
                //Marca
                Label marca = new Label();
                marca.Name = "Marca_" + auto.ID_auto.ToString();
                marca.Text = auto.Marca;
                marca.Size = new Size(52, 20);
                marca.Location = new Point(27, 231);
                marca.AutoSize = true;
                marca.Font = new Font("Century Gothic", 11, FontStyle.Regular);
                marca.ForeColor = Color.FromArgb(0xF4, 0xF4, 0xF8);
                panel.Controls.Add(marca);
                //Modelo
                Label modelo = new Label();
                modelo.Name = "Modelo_" + auto.ID_auto.ToString();
                modelo.Text = auto.Modelo;
                modelo.Size = new Size(52, 20);
                modelo.Location = new Point(27, 311);//27,272
                modelo.AutoSize = true;
                modelo.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                modelo.ForeColor = Color.FromArgb(0xF4, 0xF4, 0xF8);
                panel.Controls.Add(modelo);
                //Existencia
                Label existencia = new Label();
                existencia.Name = "Existencia_" + auto.ID_auto.ToString();
                existencia.Text = "Existencia: " + auto.Existencia.ToString();
                existencia.Size = new Size(25, 20);
                existencia.Location = new Point(27, 271);//128,251
                existencia.AutoSize = true;
                existencia.Font = new Font("Century Gothic", 11, FontStyle.Italic);
                existencia.ForeColor = Color.FromArgb(0xF4, 0xF4, 0xF8);
                panel.Controls.Add(existencia);
                //Año
                Label año = new Label();
                año.Name = "Año_" + auto.ID_auto.ToString();
                año.Text = auto.Año.ToString();
                año.Size = new Size(41, 20);
                año.Location = new Point(252, 231);//202,231
                año.AutoSize = true;
                año.Font = new Font("Century Gothic", 11, FontStyle.Italic);
                año.ForeColor = Color.FromArgb(0xF4, 0xF4, 0xF8);
                panel.Controls.Add(año);
                //Precio
                Label precio = new Label();
                precio.Name = "Precio_" + auto.ID_auto.ToString();
                precio.Text = auto.Precio.ToString("$ " + "#,##0.00");
                precio.Size = new Size(87, 20);
                precio.Location = new Point(179, 311);//179,272
                precio.AutoSize = true;
                precio.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                precio.ForeColor = Color.FromArgb(0xF4, 0xF4, 0xF8);
                panel.Controls.Add(precio);
                //Botón actualizar
                IconButton btnActu = new IconButton();
                btnActu.Name = "Actualizar_" + auto.ID_auto.ToString();
                btnActu.IconChar = IconChar.Gear;
                btnActu.Size = new Size(60, 20);//94,29
                btnActu.Location = new Point(27, 371);//40,312
                btnActu.AutoSize = true;
                btnActu.Click += Btn_actualizar_auto;
                //btnActu.Font = precio.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                //btnActu.ForeColor = Color.FromArgb(0xF4, 0xF4, 0xF8);
                btnActu.BackColor = Color.FromArgb(0xFF, 0x5F, 0x00);
                btnActu.FlatStyle = FlatStyle.Flat;
                btnActu.FlatAppearance.BorderSize = 0;
                panel.Controls.Add(btnActu);
                //Botón eliminar
                IconButton btnEli = new IconButton();
                btnEli.Name = "Eliminar_" + auto.ID_auto.ToString();
                btnEli.IconChar = IconChar.Xmark;
                btnEli.Size = new Size(60, 20);////94,29
                btnEli.Location = new Point(95, 371);
                btnEli.Click += Btn_eliminar_auto;
                btnEli.AutoSize = true;
                //btnEli.Font = precio.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                //btnEli.ForeColor = Color.FromArgb(0xF4, 0xF4, 0xF8);
                btnEli.BackColor = Color.FromArgb(0xFF, 0x00, 0x00);
                btnEli.FlatStyle = FlatStyle.Flat;
                btnEli.FlatAppearance.BorderSize = 0;
                panel.Controls.Add(btnEli);
                //Botón ver
                IconButton btnVer = new IconButton();
                btnVer.Name = "Ver_" + auto.ID_auto.ToString();
                btnVer.IconChar = IconChar.Car;
                btnVer.Size = new Size(60, 20);//94,29
                btnVer.Location = new Point(160, 371);
                btnVer.Click += Btn_actualizar_auto;
                btnVer.AutoSize = true;
                //btnEli.Font = precio.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                //btnEli.ForeColor = Color.FromArgb(0xF4, 0xF4, 0xF8);
                btnVer.BackColor = Color.FromArgb(0xFF, 0x00, 0x00);
                btnVer.FlatStyle = FlatStyle.Flat;
                btnVer.FlatAppearance.BorderSize = 0;
                panel.Controls.Add(btnVer);
                ////Botón vender
                IconButton btnAdd = new IconButton();
                btnAdd.Name = "Vender_" + auto.ID_auto.ToString();
                btnAdd.IconChar = IconChar.CartPlus;
                btnAdd.Size = new Size(60, 20);//94,29
                btnAdd.Location = new Point(225, 371);
                btnAdd.Click += Vender;
                btnAdd.AutoSize = true;
                ////btnEli.Font = precio.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                ///btnEli.ForeColor = Color.FromArgb(0xF4, 0xF4, 0xF8);
                btnVer.BackColor = Color.FromArgb(0xFF, 0x00, 0x00);
                btnVer.FlatStyle = FlatStyle.Flat;
                btnVer.FlatAppearance.BorderSize = 0;
                panel.Controls.Add(btnAdd);
                //Convertir propiedades a array de string
                string[] array = {auto.Marca.Trim().ToLower(),
                    auto.Modelo.Trim().ToLower(),
                    auto.Año.ToString().Trim().ToLower()};
                //
                kvpaneles.Add(panel, array);
                Contenedor.Controls.Add(panel);
                //Condiciones
                conteoPanelesEnlinea++;
                if (conteoPanelesEnlinea >= 5)
                {
                    conteoPanelesEnlinea = 0;
                    conteoFilasPaneles++;
                }

            }
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {
            FirstShowAutos();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string busqueda = textBox.Text.Trim().ToLower();
            if (busqueda == string.Empty)
            {
                OrdenarPaneles((kvp) => true);
            }
            else
            {
                OrdenarPaneles(kvp =>
                {
                    foreach (string str in kvp.Value)
                    {
                        if (str.StartsWith(textBox.Text.Trim().ToLower()))
                            return true;
                    }
                    return false;
                });
            }
        }
        private void Btn_actualizar_auto(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            Auto auto = new Auto();
            int index = 0;
            if (!btn.Name.StartsWith("Agregar"))
            {
                index = btn.Name.IndexOf("_");
                auto = db.GetAutoByID(Convert.ToInt32(btn.Name.Substring(index + 1)));
            }
            Frm_detalles_auto frm_detalles;
            if (btn.Name.StartsWith("Ver"))
            {
                frm_detalles = new Frm_detalles_auto(auto, Frm_detalles_auto.TipoForm.Mostrar);
            }
            else if (btn.Name.StartsWith("Actualizar"))
            {
                frm_detalles = new Frm_detalles_auto(auto, Frm_detalles_auto.TipoForm.Actualizar);
            }
            else
            {
                frm_detalles = new Frm_detalles_auto(new Auto(), Frm_detalles_auto.TipoForm.Agregar);
            }
            frm_detalles.ShowDialog();
            if (btn.Name.StartsWith("Actualizar"))
            {
                auto = db.GetAutoByID(Convert.ToInt32(btn.Name.Substring(index + 1)));
                PanelUpdate(auto);
            }
            else if (btn.Name.StartsWith("Agregar"))
            {
                Contenedor.Controls.Clear();
                kvpaneles.Clear();
                conteoFilasPaneles = 0;
                conteoPanelesEnlinea = 0;
                FirstShowAutos();
            }
        }

        private void Btn_eliminar_auto(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar el auto?\n" +
                "Se borrará:\n-Entidad\n-Ventas asociadas", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Button btn = (Button)sender;
                int index = btn.Name.IndexOf("_");
                (bool, int) resultado = db.DeleteAuto(Convert.ToInt32(btn.Name.Substring(index + 1)));
                if (resultado.Item1)
                {
                    Panel panel = (Panel)btn.Parent;
                    PictureBox picBox = panel.Controls.OfType<PictureBox>().FirstOrDefault();
                    if (picBox != null && picBox.Image != null)
                    {
                        picBox.Image.Dispose();
                        picBox.Image = null;
                    }
                    Contenedor.Controls.Remove(btn.Parent);
                    kvpaneles.Remove((Panel)btn.Parent);
                    db.DeleteImg(resultado.Item2);
                    TxtBusqueda_TextChanged(TxtBusqueda, new EventArgs());
                }
            }
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            var frmVentas = new Frm_ventas();
            frmVentas.ShowDialog();
        }

        private void Vender(object sender, EventArgs e)
        {
            IconButton boton = (IconButton)sender;
            int index = boton.Name.IndexOf("_");
            var auto = db.GetAutoByID(Convert.ToInt32(boton.Name.Substring(index + 1)));
            Frm_hacer_venta venta = new Frm_hacer_venta(auto);
            venta.ShowDialog();
        }
    }
}

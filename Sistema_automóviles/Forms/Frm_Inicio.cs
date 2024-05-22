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

namespace Sistema_automóviles.Forms
{
    public partial class Frm_Inicio : Form
    {
        const byte Xinicial = 24;
        const byte Yinicial = 60;
        const byte separacion = 15;
        ushort conteoPanelesEnlinea = 0;
        ushort conteoFilasPaneles = 0;
        const ushort anchoPanel = 292;
        const ushort altoPanel = 400;
        readonly AutoDB db = new AutoDB();
        Dictionary<Panel, string[]> kvpaneles = new Dictionary<Panel, string[]>();
        public Frm_Inicio()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private void OrdenarPaneles(Predicate<KeyValuePair<Panel, string[]>> condicion)
        {
            conteoFilasPaneles = 0;
            conteoPanelesEnlinea = 0;
            foreach (var kvp in kvpaneles)
            {
                if (condicion(kvp))
                {
                    kvp.Key.Visible = true;
                    kvp.Key.Location = new Point(Xinicial + (conteoPanelesEnlinea * (separacion + anchoPanel)),
                            Yinicial + (conteoFilasPaneles * (separacion + altoPanel)));
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
            IEnumerable<Auto> autos = db.GetAllAutos().ToList().OrderBy(c=>c.Marca);
            foreach (Auto auto in autos)
            {
                //Crear panel
                Panel panel = new Panel();
                panel.Name = "Pnl_" + auto.ID_auto.ToString();
                panel.Width = anchoPanel;
                panel.Height = altoPanel;
                panel.BorderStyle = BorderStyle.Fixed3D;
                Point punto = new Point(Xinicial + (conteoPanelesEnlinea * (separacion + anchoPanel)),
                    Yinicial + (conteoFilasPaneles * (separacion + altoPanel)));
                panel.Location = punto;
                ///////////Contenido panel
                //Imagen
                PictureBox picbox = new PictureBox();
                picbox.Name = "Imagen_" + auto.ID_auto.ToString();
                picbox.Location = new Point(14, 14);
                picbox.Width = 266;
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
                panel.Controls.Add(marca);
                //Modelo
                Label modelo = new Label();
                modelo.Name = "Modelo_" + auto.ID_auto.ToString();
                modelo.Text = auto.Modelo;
                modelo.Size = new Size(52, 20);
                modelo.Location = new Point(27, 272);
                modelo.AutoSize = true;
                panel.Controls.Add(modelo);
                //Existencia
                Label existencia = new Label();
                existencia.Name = "Existencia_" + auto.ID_auto.ToString();
                existencia.Text = auto.Existencia.ToString();
                existencia.Size = new Size(25, 20);
                existencia.Location = new Point(128, 251);
                existencia.AutoSize = true;
                panel.Controls.Add(existencia);
                //Año
                Label año = new Label();
                año.Name = "Año_" + auto.ID_auto.ToString();
                año.Text = auto.Año.ToString();
                año.Size = new Size(41, 20);
                año.Location = new Point(202, 231);
                año.AutoSize = true;
                panel.Controls.Add(año);
                //Precio
                Label precio = new Label();
                precio.Name = "Precio_" + auto.ID_auto.ToString();
                precio.Text = auto.Precio.ToString("$" + "#,##0.00");
                precio.Size = new Size(87, 20);
                precio.Location = new Point(179, 272);
                precio.AutoSize = true;
                panel.Controls.Add(precio);
                //Convertir propiedades a array de string
                string[] array = {auto.Marca.Trim().ToLower(),
                    auto.Modelo.Trim().ToLower(),
                    auto.Año.ToString().Trim().ToLower()}; 
                //
                kvpaneles.Add(panel,array);
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

        private void Frm_Inicio_Shown(object sender, EventArgs e)
        {
            
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string busqueda = textBox.Text.Trim().ToLower();
            if (busqueda == string.Empty)
            {
                Predicate<KeyValuePair<Panel, string[]>> func = (kvp) => true;
                OrdenarPaneles(func);
            }
            else
            {
                Predicate<KeyValuePair<Panel, string[]>> func = (kvp) =>
                {
                    foreach (string str in kvp.Value)
                    {
                        if (str.StartsWith(textBox.Text.Trim().ToLower()))
                            return true;
                    }
                    return false;
                };
                OrdenarPaneles(func);
            }
        }
    }
}

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
        const byte XYinicial = 24;
        const byte separacion = 15;
        ushort conteoPanelesEnlinea = 0;
        ushort conteoFilasPaneles = 0;
        const ushort anchoPanel = 292;
        const ushort altoPanel = 400;
        readonly AutoDB db = new AutoDB();
        public Frm_Inicio()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private void ShowAutos()
        {
            string? path = db.GetDirectoryImg();
            //PictureBox pictureBox = new PictureBox();
            //pictureBox.Name = "Agregar";
            //pictureBox.Width = anchoPanel;
            //pictureBox.Height = altoPanel;
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox.Location = new Point(XYinicial,XYinicial);
            //db.SetImage(pictureBox,-1,path);
            //Contenedor.Controls.Add(pictureBox);
            //conteoPanelesEnlinea++;
            IEnumerable<Auto> autos = db.GetAllAutos().Take(11).ToList();
            foreach(Auto auto in autos)
            {
                //Crear panel
                Panel panel = new Panel();
                panel.Name = "Pnl_" + auto.ID_auto.ToString();
                panel.Width = anchoPanel;
                panel.Height = altoPanel;
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.BackColor = Color.Cyan;
                Point punto = new Point(XYinicial + (conteoPanelesEnlinea * (separacion + anchoPanel)),
                    XYinicial + (conteoFilasPaneles * (separacion + altoPanel)));
                panel.Location = punto;
                //Contenido panel
                //Imagen
                PictureBox picbox = new PictureBox();
                picbox.Name = "Pb_"+auto.ID_auto.ToString();
                picbox.Location = new Point(14, 14);
                picbox.Width = 266;
                picbox.Height = 202;
                picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                db.SetImage(picbox,auto.ID_auto, path);
                panel.Controls.Add(picbox);
                //Informacion
                Label marca = new Label();
                marca.Text = auto.Marca;
                
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
            ShowAutos();
        }

        private void Frm_Inicio_Shown(object sender, EventArgs e)
        {
        }
    }
}

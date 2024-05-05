using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_automóviles.Models.Classes;

namespace Sistema_automóviles.Models.Models
{
    internal class AutoDB: DB
    {
        MySqlCommand? _command;
        MySqlDataReader? _reader;
        public string? GetDirectoryImg()
        {
            string? path = AppDomain.CurrentDomain.BaseDirectory;
            for (byte i = 0; i < 4; i++)
            {
                path = Path.GetDirectoryName(path);
            }
            return path;
        }
        public List<Auto> GetAllAutos()
        {
            var carros = new List<Auto>();
            using (_connection)
            {
                Connect();
                _command = new MySqlCommand("SELECT * FROM autos", _connection);
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    var auto = new Auto();
                    auto.ID_auto = _reader.GetInt32(0);
                    auto.ID_proveedor = _reader.GetInt32(1);
                    auto.Marca = _reader.GetString(2);
                    auto.Modelo = _reader.GetString(3);
                    auto.Año = _reader.GetInt32(4);
                    auto.Precio = _reader.GetFloat(5);
                    auto.Existencia = _reader.GetInt32(6);
                    carros.Add(auto);
                }
                Close();
            }
            return carros;
        }
        public void SetImage(PictureBox pictureBox, int? id, string? path)
        {
            string fullpath = path + "\\img\\" + id;
            string[] extensiones = [ ".jpg", ".jpeg", ".png" ];
            foreach (string extension in extensiones)
            {
                if (File.Exists(fullpath + extension))
                {
                    pictureBox.Image = Image.FromFile(fullpath + extension);
                }
            }
        }
    }
}

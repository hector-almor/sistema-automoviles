using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_automóviles.Models.Classes;
using ZstdSharp.Unsafe;

namespace Sistema_automóviles.Models.Models
{
    internal class AutoDB: DB
    {
        MySqlCommand? _command;
        MySqlDataReader? _reader;
        MySqlDataAdapter? _adapter;
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
                try
                {
                    Connect();
                    _command = new MySqlCommand("SELECT * FROM autos", _connection);
                    _reader = _command.ExecuteReader();
                    while (_reader.Read())
                    {
                        var auto = new Auto();
                        auto.ID_auto = _reader.GetInt32(0);
                        auto.Marca = _reader.GetString(1);
                        auto.Modelo = _reader.GetString(2);
                        auto.Año = _reader.GetInt32(3);
                        auto.Existencia = _reader.GetInt32(4);
                        auto.Costo = _reader.GetFloat(5);
                        auto.Precio = _reader.GetFloat(6);
                        carros.Add(auto);
                    }
                    Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        public bool DeleteAuto(int id)
        {
            bool result = false;
            try
            {
                using (_connection)
                {
                    Connect();
                    _command = new MySqlCommand("DELETE FROM proveedores WHERE ID_auto=@IDA;" +
                        "DELETE FROM ventas WHERE ID_auto=@IDA;" + "DELETE FROM autos WHERE ID_auto=@IDA;", _connection);
                    _command.Parameters.AddWithValue("@IDA", id);
                    int rows = _command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("El auto ha sido eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        result = true;
                    }
                    else
                        MessageBox.Show("¡Oops!, ha ocurrido un error, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public Auto GetAutoByID(int id)
        {
            var auto = new Auto();
            try
            {
                using(_connection)
                {
                    Connect();
                    _command = new MySqlCommand("SELECT * FROM autos WHERE ID_auto = @IDA",_connection);
                    _command.Parameters.AddWithValue("@IDA",id);
                    _reader = _command.ExecuteReader();
                    while(_reader.Read())
                    {
                        auto.ID_auto = _reader.GetInt32(0);
                        auto.Marca = _reader.GetString(1);
                        auto.Modelo = _reader.GetString(2);
                        auto.Año = _reader.GetInt32(3);
                        auto.Existencia = _reader.GetInt32(4);
                        auto.Costo = _reader.GetFloat(5);
                        auto.Precio = _reader.GetFloat(6);
                    }
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return auto;
        }
    }
}

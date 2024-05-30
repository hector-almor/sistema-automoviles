using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_automóviles.Models.Classes;
using ZstdSharp.Unsafe;
using FontAwesome.Sharp;
using System.Windows.Forms;
using System.Data;
using MySqlX.XDevAPI;

namespace Sistema_automóviles.Models.Models
{
    internal class AutoDB: DB
    {
        MySqlCommand? _command;
        MySqlDataReader? _reader;
        MySqlDataAdapter? _adapter;
        public static string newPathImg = "";
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
        public void SetImage(IconPictureBox pictureBox, int? id, string? path)
        {
            string fullpath = path + "\\img\\" + id;
            string[] extensiones = [ ".jpg", ".jpeg", ".png" ];
            foreach (string extension in extensiones)
            {
                if (File.Exists(fullpath + extension))
                {
                    pictureBox.Image = Image.FromFile(fullpath + extension);
                    return;
                }
            }
            pictureBox.IconChar = IconChar.Image;
        }
        public string GetDirectoryImgById(int id, string extension, string? path)
        {
            int indexextension = extension.LastIndexOf(".");
            return path + "\\img\\" + id+extension.Substring(indexextension);
        }
        public void SetImageMemory(IconPictureBox pictureBox, int? id, string? path)
        {
            string fullpath = path + "\\img\\" + id;
            string[] extensiones = [".jpg", ".jpeg", ".png"];
            foreach (string extension in extensiones)
            {
                if (File.Exists(fullpath + extension))
                {
                    using (FileStream fs = new FileStream(fullpath+extension, FileMode.Open, FileAccess.Read))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            fs.CopyTo(ms);
                            ms.Position = 0;
                            pictureBox.Image = new Bitmap(ms);
                        }
                    }
                    return;
                }
            }
            pictureBox.IconChar = IconChar.Image;
        }
        public void DeleteImg(int id)
        {
            string fullpath = GetDirectoryImg() + "\\img\\" + id;
            string[] extensiones = [".jpg", ".jpeg", ".png"];
            foreach (string extension in extensiones)
            {
                if (File.Exists(fullpath + extension))
                {
                    File.Delete(fullpath + extension);
                }
            }
        }
        public (bool,int) DeleteAuto(int id)
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
            return (result,id);
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
        public bool UpdateAuto(Auto auto)
        {
            bool result = false;
            try
            {
                using(_connection)
                {
                    Connect();
                    _command = new MySqlCommand("UPDATE autos" +
                        " SET Marca=@MARCA, Modelo=@MODELO, Año=@AÑO, Existencia=@EXIS," +
                        " Costo=@COSTO, Precio=@PRECIO WHERE ID_auto=@IDA;", _connection);
                    _command.Parameters.AddWithValue("@IDA", auto.ID_auto);
                    _command.Parameters.AddWithValue("@MARCA",auto.Marca);
                    _command.Parameters.AddWithValue("@MODELO", auto.Modelo);
                    _command.Parameters.AddWithValue("@AÑO", auto.Año);
                    _command.Parameters.AddWithValue("@EXIS", auto.Existencia);
                    _command.Parameters.AddWithValue("@COSTO", auto.Costo);
                    _command.Parameters.AddWithValue("@PRECIO", auto.Precio);
                    int rows = _command.ExecuteNonQuery();
                    if (rows == 1)
                    {
                        MessageBox.Show("El auto ha sido actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        result = true;
                    }
                    else
                        MessageBox.Show("¡Oops!, ha ocurrido un error, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public bool AddAuto(Auto auto)
        {
            bool result = false;
            try
            {
                using (_connection)
                {
                    Connect();
                    _command = new MySqlCommand("SELECT * FROM autos WHERE ID_auto=@IDA",_connection);
                    _command.Parameters.AddWithValue("@IDA",auto.ID_auto);
                    _reader = _command.ExecuteReader();
                    if(_reader.HasRows)
                    {
                        MessageBox.Show("Ya existe un auto con este ID, elige otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        return false;
                    }
                    _reader.DisposeAsync();
                    _command = new MySqlCommand("INSERT INTO autos VALUES(@IDA,@MARCA," +
                        "@MODELO,@AÑO,@EXIS,@COSTO,@PRECIO);",_connection);
                    _command.Parameters.AddWithValue("@IDA", auto.ID_auto);
                    _command.Parameters.AddWithValue("@MARCA", auto.Marca);
                    _command.Parameters.AddWithValue("@MODELO", auto.Modelo);
                    _command.Parameters.AddWithValue("@AÑO", auto.Año);
                    _command.Parameters.AddWithValue("@EXIS", auto.Existencia);
                    _command.Parameters.AddWithValue("@COSTO", auto.Costo);
                    _command.Parameters.AddWithValue("@PRECIO", auto.Precio);
                    int rows = _command.ExecuteNonQuery();
                    if (rows == 1)
                    {
                        MessageBox.Show("El auto ha sido agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        result = true;
                    }
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public DataTable GetAllVentas()
        {
            var dt = new DataTable();
            try
            {
                using (_connection)
                {
                    Connect();
                    _command = new MySqlCommand("SELECT ID_venta as 'Número de venta', Descripcion as 'Descripción', " +
                        "CAST(Fecha as DATE) as 'Fecha', CAST(Fecha as TIME) as 'Hora', Numero_autos as 'Cantidad', " +
                        "CONCAT('$ ',FORMAT(Precio, 'C', 'es-MX')) as 'Precio', CONCAT('$ ',FORMAT(Total, 'C', 'es-MX')) as 'Total' FROM ventas", _connection);
                    _adapter = new MySqlDataAdapter(_command);
                    _adapter.Fill(dt);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public (Proveedor,Cliente) GetInfoVenta(int idventa)
        {
            var proveedor = new Proveedor();
            var cliente = new Cliente();
            try
            {
                using(_connection)
                {
                    Connect();
                    _command = new MySqlCommand("SELECT c.Nombre, c.APaterno, c.AMaterno, c.Correo, c.Telefono, c.RFC, c.CP, " +
                        "p.Nombre, p.Telefono, p.Correo, p.Direccion " +
                        "FROM ventas v " +
                        "INNER JOIN Proveedores p ON v.ID_auto = p.ID_auto " +
                        "INNER JOIN Clientes c ON v.ID_cliente = c.ID_cliente " +
                        "WHERE v.ID_venta = @IDV " +
                        "LIMIT 1;", _connection);
                    _command.Parameters.AddWithValue("@IDV", idventa);
                    _reader = _command.ExecuteReader();
                    while(_reader.Read())
                    {
                        cliente.Nombre = _reader.GetString(0);
                        cliente.APaterno = _reader.GetString(1);
                        cliente.AMaterno = _reader.GetString(2);
                        cliente.Correo = _reader.GetString(3);
                        cliente.Telefono = Convert.ToInt64(_reader[4]);
                        cliente.RFC = _reader.GetString(5);
                        cliente.CP = _reader.GetInt32(6);
                        proveedor.Nombre = _reader.GetString(7);
                        proveedor.Telefono = Convert.ToInt64(_reader[8]);
                        proveedor.Correo = _reader.GetString(9);
                        proveedor.Direccion = _reader.GetString(10);
                    }
                    Close();
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (proveedor, cliente);
        }
        public bool DeleteVenta(int id)
        {
            bool result = false;
            try
            {
                using (_connection)
                {
                    Connect();
                    _command = new MySqlCommand("DELETE FROM ventas WHERE ID_venta=@IDV;", _connection);
                    _command.Parameters.AddWithValue("@IDV", id);
                    int rows = _command.ExecuteNonQuery();
                    if (rows ==1)
                    {
                        MessageBox.Show("La venta ha sido eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (_connection)
                {
                    Connect();
                    _command = new MySqlCommand("SELECT * FROM clientes", _connection);
                    _reader = _command.ExecuteReader();
                    while (_reader.Read())
                    {
                        var cliente = new Cliente();
                        cliente.ID_cliente = _reader.GetInt32(0);
                        cliente.Nombre = _reader.GetString(1);
                        cliente.APaterno = _reader.GetString(2);
                        cliente.AMaterno = _reader.GetString(3);
                        clientes.Add(cliente);
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return clientes;
        }
        public void HacerVenta(Venta venta)
        {
            //try
            //{
                using (_connection)
                {
                    Connect();
                    _command = new MySqlCommand("INSERT INTO ventas (ID_auto,ID_cliente,Descripcion,Fecha,Numero_autos,Precio,Total) " +
                        "VALUES(@IDAUTO,@IDCLIE,@DESC,@FECHA,@NUMAUTOS,@PRECIO,@TOTAL);", _connection);
                    _command.Parameters.AddWithValue("@IDAUTO",venta.ID_auto);
                    _command.Parameters.AddWithValue("@IDCLIE", venta.ID_cliente);
                    _command.Parameters.AddWithValue("@DESC", venta.Descripcion);
                    _command.Parameters.AddWithValue("@FECHA", venta.Fecha);
                    _command.Parameters.AddWithValue("@NUMAUTOS", venta.Numero_autos);
                    _command.Parameters.AddWithValue("@PRECIO", venta.Precio);
                    _command.Parameters.AddWithValue("@TOTAL", venta.Total);
                    int rows = _command.ExecuteNonQuery();
                    if(rows==1)
                    {
                        MessageBox.Show("La venta ha sido registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("¡Oops!, ha ocurrido un error, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            //}
            //catch (Exception ex)
            //{
              //  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}

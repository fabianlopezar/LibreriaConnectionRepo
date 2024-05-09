using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibreriaConnection.models
{
    class ConnectDB//video 01 min 18:00
    {
        public MySqlConnection connManager = new MySqlConnection();
        string server = "127.0.0.1;";
        string database = "libreria;";
        string user = "root;";
        string pass = "root;";

        public MySqlConnection DataSource()
        {
            connManager = new MySqlConnection($"server={server} database={database}Uid={user} password={pass}");
            return connManager;
        }
        #region    ---------       SELECTS        --------
        internal List<Categorias> SelectCategorias(string sql)
        {
            List<Categorias> listaC = new List<Categorias>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idC = reader.GetInt32(0);
                        string nameC = reader.GetString(1);
                        listaC.Add(new Categorias(idC, nameC));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaC;
        }
        internal List<Cuentas> SelectCuentas(string sql)
        {
            List<Cuentas> listaCuentas = new List<Cuentas>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idCuenta = reader.GetInt32(0);
                        string _nombre1Cuenta = reader.GetString(1);
                        listaCuentas.Add(new Cuentas(_idCuenta, _nombre1Cuenta));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaCuentas;
        }
        internal List<Editoriales> SelectEditoriales(string sql)
        {
            List<Editoriales> listaEditoriales = new List<Editoriales>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idEditorial = reader.GetInt32(0);
                        string _nombreEditorial = reader.GetString(1);
                        listaEditoriales.Add(new Editoriales(_idEditorial, _nombreEditorial));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaEditoriales;

        }
        internal List<Paises> SelectPaises(string sql)
        {
            List<Paises> listaPaises = new List<Paises>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idPais = reader.GetInt32(0);
                        string _nombrePais = reader.GetString(1);
                        listaPaises.Add(new Paises(_idPais, _nombrePais));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaPaises;
        }
        internal List<Administradores> SelectAdministradores(string sql)
        {
            List<Administradores> listaAdministradores = new List<Administradores>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idAdministrador = reader.GetInt32(0);
                        string _nombre1Administrador = reader.GetString(1);
                        listaAdministradores.Add(new Administradores(_idAdministrador, _nombre1Administrador));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaAdministradores;

        }
        internal List<Telefonos> SelectTelefonos(string sql)
        {
            List<Telefonos> listaTelefonos = new List<Telefonos>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idTelefonos = reader.GetInt32(0);
                        string _numeroTelefonico = reader.GetString(1);
                        listaTelefonos.Add(new Telefonos(_idTelefonos, _numeroTelefonico));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaTelefonos;
        }
        internal List<Multas> SelectMultas(string sql)
        {
            List<Multas> listaMultas = new List<Multas>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idMulta = reader.GetInt32(0);
                        string _fechaInicio = reader.GetString(1);
                        listaMultas.Add(new Multas(_idMulta, _fechaInicio));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaMultas;
        }
        internal List<Prestamos> SelectPrestamos(string sql)
        {
            List<Prestamos> listaPrestamos = new List<Prestamos>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idPrestamo = reader.GetInt32(0);
                        string _fechaPrestamo = reader.GetString(1);
                        listaPrestamos.Add(new Prestamos(_idPrestamo, _fechaPrestamo));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaPrestamos;
        }
        internal List<Libros> SelectLibros(string sql)
        {
            List<Libros> listaLibros = new List<Libros>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idLibro = reader.GetInt32(0);
                        string _titulo = reader.GetString(1);
                        listaLibros.Add(new Libros(_idLibro, _titulo));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaLibros;
        }
        internal List<Autores> SelectAutores(string sql)
        {
            List<Autores> listaAutores = new List<Autores>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idAutor = reader.GetInt32(0);
                        string _nombre1Autor = reader.GetString(1);
                        listaAutores.Add(new Autores(_idAutor, _nombre1Autor));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaAutores;
        }
        internal List<Ciudades> SelectCiudades(string sql)
        {
            List<Ciudades> listaCiudades = new List<Ciudades>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idCiudad = reader.GetInt32(0);
                        string _nombreCiudad = reader.GetString(1);
                        listaCiudades.Add(new Ciudades(_idCiudad, _nombreCiudad));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaCiudades;
        }
        #endregion  ---------  END SELECTS        --------
        public bool ExecuteQuery(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                cmd.ExecuteNonQuery();
                result = true;
                //Connect Closed();
            }
            catch (Exception w)
            {
                Console.WriteLine("ERROR " + w.Message);
                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }
        public void ConnectOpened()
        {
            //DataSource();
            connManager.Open();
        }
        public void ConnectClosed()
        {
            DataSource();
            connManager.Close();
        }
    }
}

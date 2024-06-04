using System;
using System.IO;
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
        string pass = "maxwell55A@;";

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

        internal bool ExecuteQueryImage(string sql, string imagen)
        {
            bool result = false;
            FileStream fs;
            BinaryReader br;
            try
            {
                byte[] ImageData;
                fs = new FileStream(imagen, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                cmd = new MySqlCommand(sql, DataSource());
                cmd.Parameters.Add("@fotoLibro", MySqlDbType.LongBlob);
                cmd.Parameters["@fotoLibro"].Value = ImageData;
                ConnectOpened();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    result = true;
                }
            }
            catch (Exception w)
            {
                Console.WriteLine("Error en ConnectDB: " + w.Message);
                ConnectClosed();
            }
            finally
            {
                ConnectClosed();

            }
            return result;
        }
        internal bool ExecuteQueryImageCuenta(string sql, string imagen)
        {
            bool result = false;
            FileStream fs;
            BinaryReader br;
            try
            {
                byte[] ImageData;
                fs = new FileStream(imagen, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                cmd = new MySqlCommand(sql, DataSource());
                cmd.Parameters.Add("@fotoCuenta", MySqlDbType.LongBlob);
                cmd.Parameters["@fotoCuenta"].Value = ImageData;
                ConnectOpened();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    result = true;
                }
            }
            catch (Exception w)
            {
                Console.WriteLine("Error en ConnectDB: " + w.Message);
                ConnectClosed();
            }
            finally
            {
                ConnectClosed();

            }
            return result;
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
                ConnectClosed();
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
                        int idLibro = reader.GetInt32(0);
                        string titulo = reader.GetString(1);
                        string imagen = reader.IsDBNull(2) ? null : Convert.ToBase64String((byte[])reader[2]);
                        //Console.WriteLine("soy imagen: "+imagen);
                        string codigoISBN = reader.GetString(3);
                        bool _disponible = reader.GetBoolean(4);
                        int cantidadEjemplares = reader.GetInt32(5);                        
                        string fechaCreacion = reader.IsDBNull(6) ? null : reader.GetDateTime(6).ToString("yyyy-MM-dd HH:mm:ss");                        
                        int idEditorialLibro= reader.GetInt32(7);
                        int idCategoria= reader.GetInt32(8);
                        int idAdministrador= reader.GetInt32(9);
                                                                       
                        listaLibros.Add(new Libros(idLibro, titulo,imagen,codigoISBN,_disponible,cantidadEjemplares,fechaCreacion,idEditorialLibro,idCategoria,idAdministrador));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en connect select libro: " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaLibros;
        }
        internal List<Libros> ConsultaLibros(string sql)
        {
            List<Libros> listaLibros = new List<Libros>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("Deberia funcionar");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _idLibro = reader.GetInt32(0);
                        string _titulo = reader.GetString(1);
                        /*string _imagen = reader.GetString(2);
                        string _codigoISBN = reader.GetString(3);
                        string _disponible = reader.GetString(4);
                        int _cantidadEjemplares = reader.GetInt32(5);
                        string _fechaCreacion = reader.GetString(6);
                        int _idEditorialLibro= reader.GetInt32(7);
                        int _idCategoria= reader.GetInt32(8);
                        int _idAdministrador= reader.GetInt32(9);
                        bool disponible = false;
                        if (_disponible.Equals(1))
                        {
                            disponible = true;
                        }*/

                        //listaLibros.Add(new Libros(_idLibro, _titulo,_imagen,_codigoISBN,disponible,_cantidadEjemplares,_fechaCreacion,_idEditorialLibro, _idCategoria, _idAdministrador));
                        listaLibros.Add(new Libros(_idLibro, _titulo));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en connect select libro: " + e.Message);
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
                        int idAutor = reader.GetInt32(0);
                        string nombre1 = reader.GetString(1);
                        string nombre2 = reader.GetString(2);
                        string apellido1 = reader.GetString(3);
                        string apellido2 = reader.GetString(4);
                        string direccion = reader.GetString(5);
                        string telefono = reader.GetString(6);
                        int idCiudad = reader.GetInt32(7);

                        listaAutores.Add(new Autores(idAutor, nombre1, nombre2, apellido1, apellido2, direccion, telefono, idCiudad));
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

        #region -------Consultas ------------
        internal List<Libros> ConsultaLibrosPrestamoLector(string sql)
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
                        int id = reader.GetInt32(0);// Leo la posicion.                        
                        //Console.WriteLine("soy 0: " + id);
                        string _titulo = reader.GetString(4);// Leo la posicion.
                        //Console.WriteLine("soy 0: " + _titulo);

                        listaLibros.Add(new Libros(_titulo));// agrego a la lista de libros prestados.
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Connect (ConsultaLibrosPrestamoLector): " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaLibros;
        }
        internal List<Libros> ConsultarCantidadLibrosActuales(string sql)
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
                        string _titulo = reader.GetString(1);// Leo la posicion.                        
                        listaLibros.Add(new Libros(_titulo));// agrego a la lista de libros prestados.
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Connect (ConsultaLibrosPrestamoLector): " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaLibros;
        }
        internal List<Libros> ConsultarLibrosPrestadosEntreFechas(string sql)
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
                        string _titulo = reader.GetString(10);// Leo la posicion.                        
                        listaLibros.Add(new Libros(_titulo));// agrego a la lista de libros prestados.
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Connect (ConsultarLibrosPrestadosEntreFechas): " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaLibros;
        }
        internal List<Multas> ConsultarMultasPagadasEntreFechas(string sql)
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
                        int idMulta = reader.GetInt32(0);// Leo la posicion.                        
                        listaMultas.Add(new Multas(idMulta));// agrego a la lista de libros prestados.
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Connect (ConsultarLibrosPrestadosEntreFechas): " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaMultas;
        }
        internal List<Multas> ConsultarValorMulta(string sql)
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
                        double _titulo = reader.GetDouble(0);// Leo la posicion.                        
                        listaMultas.Add(new Multas(_titulo));// agrego a la lista de libros prestados.
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Connect (: " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaMultas;
        }
        internal List<Multas> ConsultarMultaSinPagar(string sql)
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
                        int idMulta = reader.GetInt32(0);// Leo la posicion.                        
                        double valorPagar= reader.GetDouble(3);// Leo la posicion.                        
                        listaMultas.Add(new Multas(idMulta, valorPagar));// agrego a la lista de libros prestados.
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Connect (: " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaMultas;
        }
        internal List<Libros> ConsultarTodosLosLibrosPrestados(string sql)
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
                        string _titulo = reader.GetString(0);// Leo la posicion.                  
                        listaLibros.Add(new Libros(_titulo));// agrego a la lista de libros prestados.
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Connect (ConsultaLibrosPrestamoLector): " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaLibros;
        }
        internal List<Libros> ConsultaLibrosPrestamo2(string sql)
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
                        string _titulo = reader.GetString(4);// Leo la posicion.

                        listaLibros.Add(new Libros(_titulo));// agrego a la lista de libros prestados.
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Connect: " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaLibros;
        }

        internal List<Libros> ConsultaLibroCategoria(string sql)
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
                        string _titulo = reader.GetString(1);// Leo la posicion.

                        listaLibros.Add(new Libros(_titulo));// agrego a la lista de libros prestados.
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Connect ConsultaLibroCategoria: " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaLibros;
        }
        #endregion

        #region -----  Connects   -----------
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
        #endregion
    }
}

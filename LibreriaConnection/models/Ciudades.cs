using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibreriaConnection.models
{
    class Ciudades
    {
        private int idCiudad;
        private string nombreCiudad;
        private int idPaisCiudad;
        ConnectDB objConnect = new ConnectDB();

        public Ciudades()
        {
        }

        public Ciudades(string nombreCiudad)
        {
            this.nombreCiudad = nombreCiudad;
        }

        public Ciudades(int idCiudad, string nombreCiudad)
        {
            this.idCiudad = idCiudad;
            this.nombreCiudad = nombreCiudad;
        }

        public Ciudades(int idCiudad, string nombreCiudad, int idPaisCiudad)
        {
            this.idCiudad = idCiudad;
            this.nombreCiudad = nombreCiudad;
            this.idPaisCiudad = idPaisCiudad;
        }
        internal List<Ciudades> SelectCiudad(string sql)
        {
            List<Ciudades> listaCiudades = new List<Ciudades>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConnect.DataSource());
                objConnect.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idCiudad = reader.GetInt32(0);
                        string nombreCiudad = reader.GetString(1);
                        Ciudades objCiudad = new Ciudades(idCiudad, nombreCiudad);
                        listaCiudades.Add(objCiudad);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
                objConnect.ConnectClosed();
            }
            finally
            {
                objConnect.ConnectClosed();

            }return listaCiudades;
        }

        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }
        public int IdPaisCiudad { get => idPaisCiudad; set => idPaisCiudad = value; }


    }
}

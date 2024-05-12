using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibreriaConnection.models
{
    class Telefonos
    {
        private int idTelefono;
        private string numeroTelefonico;
        private int idCuentaTelefono;
        ConnectDB objConnect = new ConnectDB();

        public Telefonos()
        {
        }

        public Telefonos(string numeroTelefonico)
        {
            this.NumeroTelefonico = numeroTelefonico;
        }

        public Telefonos(int idTelefono, string numeroTelefonico)
        {
            this.IdTelefono = idTelefono;
            this.NumeroTelefonico = numeroTelefonico;
        }

        public Telefonos(int idTelefono, string numeroTelefonico, int idCuentaTelefono)
        {
            this.IdTelefono = idTelefono;
            this.NumeroTelefonico = numeroTelefonico;
            this.IdCuentaTelefono = idCuentaTelefono;
        }

        public Telefonos(string numeroTelefonico, int idCuentaTelefono) : this(numeroTelefonico)
        {
            this.idCuentaTelefono = idCuentaTelefono;
        }

        internal List<Telefonos> SelectTelefono(string sql)
        {
            List<Telefonos> listaTelefonos = new List<Telefonos>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConnect.DataSource());
                objConnect.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idTelefono = reader.GetInt32(0);
                        string numeroTelefonico = reader.GetString(1);
                        Telefonos objTelefono = new Telefonos(idTelefono, numeroTelefonico);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Telefonos" + e.Message);
                objConnect.ConnectClosed();
            }
            finally
            {
                objConnect.ConnectClosed();
            }
            return listaTelefonos;
        }

        public int IdTelefono { get => idTelefono; set => idTelefono = value; }
        public string NumeroTelefonico { get => numeroTelefonico; set => numeroTelefonico = value; }
        public int IdCuentaTelefono { get => idCuentaTelefono; set => idCuentaTelefono = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Telefonos
    {
        private int idTelefono;
        private string numeroTelefonico;
        private int idCuentaTelefono;

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

        public int IdTelefono { get => idTelefono; set => idTelefono = value; }
        public string NumeroTelefonico { get => numeroTelefonico; set => numeroTelefonico = value; }
        public int IdCuentaTelefono { get => idCuentaTelefono; set => idCuentaTelefono = value; }
    }
}

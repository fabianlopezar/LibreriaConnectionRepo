using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Paises
    {
        private int idPais;
        private string nombrePais;

        public int IdPais { get => idPais; set => idPais = value; }
        public string NombrePais { get => nombrePais; set => nombrePais = value; }

        public Paises(string nombrePais)
        {
            this.NombrePais = nombrePais;
        }

        public Paises(int idPais, string nombrePais)
        {
            this.IdPais = idPais;
            this.NombrePais = nombrePais;
        }

        public Paises()
        {
        }

    }
}

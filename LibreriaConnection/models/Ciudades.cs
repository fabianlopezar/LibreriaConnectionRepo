using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Ciudades
    {
        private int idCiudad;
        private string nombreCiudad;
        private int idPaisCiudad;

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

        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }
        public int IdPaisCiudad { get => idPaisCiudad; set => idPaisCiudad = value; }
    }
}

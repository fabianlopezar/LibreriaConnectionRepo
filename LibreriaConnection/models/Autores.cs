using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Autores
    {
        private int idAutor;
        private string nombre1Autor;
        private string nombre2Autor;
        private string apellido1Autor;
        private string apellido2Autor;
        private string direccionAutor;
        private string telefonoAutor;
        private string idCiudadAutor;

        public Autores()
        {
        }

        public Autores(int idAutor, string nombre1Autor)
        {
            this.IdAutor = idAutor;
            this.Nombre1Autor = nombre1Autor;
        }

        public Autores(int idAutor, string nombre1Autor, string nombre2Autor, string apellido1Autor, string apellido2Autor, string direccionAutor, string telefonoAutor, string idCiudadAutor)
        {
            this.IdAutor = idAutor;
            this.Nombre1Autor = nombre1Autor;
            this.Nombre2Autor = nombre2Autor;
            this.Apellido1Autor = apellido1Autor;
            this.Apellido2Autor = apellido2Autor;
            this.DireccionAutor = direccionAutor;
            this.TelefonoAutor = telefonoAutor;
            this.IdCiudadAutor = idCiudadAutor;
        }

        public int IdAutor { get => idAutor; set => idAutor = value; }
        public string Nombre1Autor { get => nombre1Autor; set => nombre1Autor = value; }
        public string Nombre2Autor { get => nombre2Autor; set => nombre2Autor = value; }
        public string Apellido1Autor { get => apellido1Autor; set => apellido1Autor = value; }
        public string Apellido2Autor { get => apellido2Autor; set => apellido2Autor = value; }
        public string DireccionAutor { get => direccionAutor; set => direccionAutor = value; }
        public string TelefonoAutor { get => telefonoAutor; set => telefonoAutor = value; }
        public string IdCiudadAutor { get => idCiudadAutor; set => idCiudadAutor = value; }
    }
}

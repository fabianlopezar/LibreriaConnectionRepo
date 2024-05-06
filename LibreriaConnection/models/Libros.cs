using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Libros
    {
        private int idLibro;
        private string titulo;
        private string imagen;
        private string codigoISBN;
        private bool disponible;
        private int cantidadEjemplares;
        private string fechaCreacion;
        private int idEditorialLibro;
        private int idCategoriaLibro;
        private int idAdministradorLibro;

        public Libros()
        {
        }

        public Libros(string titulo)
        {
            this.titulo = titulo;
        }

        public Libros(int idLibro, string titulo)
        {
            this.idLibro = idLibro;
            this.titulo = titulo;
        }

        public Libros(int idLibro, string titulo, string imagen, string codigoISBN, bool disponible, int cantidadEjemplares, string fechaCreacion, int idEditorialLibro, int idCategoriaLibro, int idAdministradorLibro)
        {
            this.idLibro = idLibro;
            this.titulo = titulo;
            this.imagen = imagen;
            this.codigoISBN = codigoISBN;
            this.disponible = disponible;
            this.cantidadEjemplares = cantidadEjemplares;
            this.fechaCreacion = fechaCreacion;
            this.idEditorialLibro = idEditorialLibro;
            this.idCategoriaLibro = idCategoriaLibro;
            this.idAdministradorLibro = idAdministradorLibro;
        }

        public int IdLibro { get => idLibro; set => idLibro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string CodigoISBN { get => codigoISBN; set => codigoISBN = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        public int CantidadEjemplares { get => cantidadEjemplares; set => cantidadEjemplares = value; }
        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int IdEditorialLibro { get => idEditorialLibro; set => idEditorialLibro = value; }
        public int IdCategoriaLibro { get => idCategoriaLibro; set => idCategoriaLibro = value; }
        public int IdAdministradorLibro { get => idAdministradorLibro; set => idAdministradorLibro = value; }
    }
}

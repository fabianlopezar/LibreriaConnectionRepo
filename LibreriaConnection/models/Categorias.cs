using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Categorias
    {
        private int idCategoria;
        private string nombreCategoria;
        private string fechaCreacion;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

        public Categorias()
        {
           
        }

        public Categorias(int idCategoria, string nombreCategoria)
        {
            this.IdCategoria = idCategoria;
            this.NombreCategoria = nombreCategoria;
        }

        public Categorias(string nombreCategoria)
        {
            this.NombreCategoria = nombreCategoria;
        }

        public Categorias(int idCategoria, string nombreCategoria, string fechaCreacion)
        {
            this.IdCategoria = idCategoria;
            this.NombreCategoria = nombreCategoria;
            this.FechaCreacion = fechaCreacion;
        }

    }
}

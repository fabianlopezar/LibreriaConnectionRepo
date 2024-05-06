using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Editoriales
    {
        private int idEditorial;
        private string nombreEditorial;

        public string NombreEditorial { get => nombreEditorial; set => nombreEditorial = value; }
        public int IdEditorial { get => idEditorial; set => idEditorial = value; }

        public Editoriales()
        {
        }

        public Editoriales(string nombreEditorial)
        {
            this.nombreEditorial = nombreEditorial;
        }

        public Editoriales(int idEditorial, string nombreEditorial)
        {
            this.idEditorial = idEditorial;
            this.nombreEditorial = nombreEditorial;
        }
    }
}

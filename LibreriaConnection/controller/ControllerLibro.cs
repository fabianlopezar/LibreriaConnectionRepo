using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConnection.models;
namespace LibreriaConnection.controller
{
    class ControllerLibro 
    {
      
        internal List<Libros> SelectLibros()
        {
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = "select * from libros;";
            listaLibros = connect.SelectLibros(sql);
            return listaLibros;
        }

        internal bool InsertLibroImage(Libros objLibro)
        {
            bool result = false;
            string sql = "insert into libros(titulo, imagen, codigoISBN, disponible, cantidadEjemplares, fechaCreacion, idEditorialLibro, idCategoriaLibro, idAdministradorLibro) values";
            return result;
        }
    }
}

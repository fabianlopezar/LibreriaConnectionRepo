using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConnection.models;


namespace LibreriaConnection.controller
{
    class ControllerLibro //min 50:00
    {

        internal List<Libros> SelectLibros()
        {
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = "select * from libros;";
            listaLibros = connect.SelectLibros(sql);
            return listaLibros;
        }

        internal void ConsultarLibroPrestamo()
        {

        }
        internal bool InsertLibroImage(Libros objLibro)
        {
            bool result = false;
            int disponibleInt = 0; if (objLibro.Disponible)
            {
                disponibleInt = 1;
            }
            else
            {
                disponibleInt = 0;
            }

            //                                                                                                                                                                     titulo, imagen, codigoISBN, disponible, cantidadEjemplares, fechaCreacion, idEditorialLibro, idCategoriaLibro, idAdministradorLibro                                                               
            string sql = "insert into libros(titulo, imagen, codigoISBN, disponible, cantidadEjemplares, fechaCreacion, idEditorialLibro, idCategoriaLibro, idAdministradorLibro) values('" + objLibro.Titulo + "', @fotoLibro, '" + objLibro.CodigoISBN + "', '" + disponibleInt + "', " + objLibro.CantidadEjemplares + ", '" + objLibro.FechaCreacion + "', " + objLibro.IdEditorialLibro + ", " + objLibro.IdCategoriaLibro + ", " + objLibro.IdAdministradorLibro + ");";
            ConnectDB connect = new ConnectDB();
            result = connect.ExecuteQueryImage(sql, objLibro.Imagen);
            return result;
        }

        internal List<Libros> ConsultarLibroCategoria(int idCategoria)//------------ hasta aui llege
        {
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = "select l.idLibro, l.titulo, l.idCategoriaLibro, c.idCategoria FROM libros l inner  JOIN categorias c ON l.idCategoriaLibro=c.idCategoria Where C.idCategoria=" + idCategoria + ";";

            listaLibros = connect.ConsultaLibroCategoria(sql);

            return listaLibros;

        }
        internal bool UpdateLibro(Libros libro)
        {
            bool result = false;
            int disponibleInt = 0; if (libro.Disponible)
            {
                disponibleInt = 1;
            }
            else
            {
                disponibleInt = 0;
            }
            Console.WriteLine("Soy la imagen" + libro.Imagen);
            
            string sql = "UPDATE libros SET titulo='" + libro.Titulo + "', imagen= @fotoLibro  , codigoISBN='" + libro.CodigoISBN + "', disponible=" + disponibleInt + ", cantidadEjemplares=" + libro.CantidadEjemplares + ", fechaCreacion='" + libro.FechaCreacion + "', idEditorialLibro=" + libro.IdEditorialLibro + ", idCategoriaLibro=" + libro.IdCategoriaLibro + ", idAdministradorLibro=" + libro.IdAdministradorLibro + " WHERE idLibro=" + libro.IdLibro;
            ConnectDB connect = new ConnectDB();
            //result = connect.ExecuteQueryImage(sql, objLibro.Imagen);
            //result= connect.ExecuteQuery(sql);
            result= connect.ExecuteQueryImage(sql,libro.Imagen);
            return result;
        }
    }
}

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
            string sql = "CALL SeleccionarLibros();";
            listaLibros = connect.SelectLibros(sql);
            return listaLibros;
        }

        internal void ConsultarLibroPrestamo()
        {

        }
        internal bool InsertLibroImage(Libros objLibro)
        {
            bool result = false;
            int disponibleInt = 0;
            if (objLibro.Disponible)
            {
                disponibleInt = 1;
            }
            else
            {
                disponibleInt = 0;
            }

            //string sql = "insert into libros(titulo, imagen, codigoISBN, disponible, cantidadEjemplares, fechaCreacion, idEditorialLibro, idCategoriaLibro, idAdministradorLibro) values('" + objLibro.Titulo + "', @fotoLibro, '" + objLibro.CodigoISBN + "', '" + disponibleInt + "', " + objLibro.CantidadEjemplares + ", '" + objLibro.FechaCreacion + "', " + objLibro.IdEditorialLibro + ", " + objLibro.IdCategoriaLibro + ", " + objLibro.IdAdministradorLibro + ");";
            string sql = $"CALL InsertarLibro('{objLibro.Titulo}', @fotoLibro, '{objLibro.CodigoISBN}', {disponibleInt}, {objLibro.CantidadEjemplares}, '{objLibro.FechaCreacion}', {objLibro.IdEditorialLibro}, {objLibro.IdCategoriaLibro}, {objLibro.IdAdministradorLibro});";           ;
            ConnectDB connect = new ConnectDB();
            result = connect.ExecuteQueryImage(sql, objLibro.Imagen);
            return result;
        }

        internal List<Libros> ConsultarLibroCategoria(int idCategoria)
        {
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = $"CALL SeleccionarLibrosPorCategoria({idCategoria});";


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
            //Console.WriteLine("Soy la imagen" + libro.Imagen);

            string sql = $"CALL ActualizarLibro({libro.IdLibro}, '{libro.Titulo}', @fotoLibro, '{libro.CodigoISBN}', {disponibleInt}, {libro.CantidadEjemplares}, '{libro.FechaCreacion}', {libro.IdEditorialLibro}, {libro.IdCategoriaLibro}, {libro.IdAdministradorLibro});";            ;
            ConnectDB connect = new ConnectDB();
            //result = connect.ExecuteQueryImage(sql, objLibro.Imagen);
            //result= connect.ExecuteQuery(sql);
            result = connect.ExecuteQueryImage(sql, libro.Imagen);
            return result;
        }
    }
}

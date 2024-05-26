using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConnection.models;
using LibreriaConnection.controller;


namespace LibreriaConnection.controller
{
    class ControllerPrestamo
    {
        List<Libros> listaLibrosEnPrestamo;
        /*internal List<Libros> SelectLibros()
        {
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = "select * from libros;";
            listaLibros = connect.SelectLibros(sql);
            return listaLibros;
        }*/
        internal List<Libros> ConsultaLibrosEnPrestamo()
        {
            ConnectDB connect = new ConnectDB();
            string sql = "select titulo from libros l right join libro_prestamo lp on l.idLibro=lp.idLibroPrestamo_Libro;";
            listaLibrosEnPrestamo = connect.ConsultaLibrosPrestamo(sql);
            return listaLibrosEnPrestamo;
        }

    }
}

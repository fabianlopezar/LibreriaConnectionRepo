﻿using System;
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
            listaLibrosEnPrestamo = connect.ConsultarTodosLosLibrosPrestados(sql);
            return listaLibrosEnPrestamo;
        }
        internal List<Libros> ConsultaLibroPrestamoCuenta(int id)
        {
       
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = "SELECT c.idCuenta, p.idCuentaPrestamo, lp.idLibroPrestamo_Prestamo, l.idLibro, l.titulo FROM cuentas c INNER JOIN prestamos p ON  "+id+" = p.idCuentaPrestamo INNER JOIN libro_prestamo lp ON c.idCuenta = lp.idLibroPrestamo_Prestamo INNER JOIN libros l ON lp.idLibroPrestamo_Prestamo = l.idLibro;";            
            listaLibros = connect.ConsultaLibrosPrestamoLector(sql);            
            return listaLibros;

        }
        internal List<Libros> ConsultarCantidadLibrosPrestamosActuales()
        {
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = "SELECT * FROM libros l INNER JOIN libro_prestamo lp ON l.idLibro= lp.idLibroPrestamo_Libro INNER JOIN prestamos p ON lp.idLibroPrestamo_Prestamo= p.idPrestamo WHERE p.estaVencido = 1;";
            listaLibros = connect.ConsultarCantidadLibrosActuales(sql);
            return listaLibros;
        }
        internal List<Libros> ConsultarCantidadLibrosPrestamosVencidos()
        {
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = "SELECT * FROM libros l INNER JOIN libro_prestamo lp ON l.idLibro= lp.idLibroPrestamo_Libro INNER JOIN prestamos p ON lp.idLibroPrestamo_Prestamo= p.idPrestamo WHERE p.estaVencido = 0;";
            listaLibros = connect.ConsultarCantidadLibrosActuales(sql);
            return listaLibros;
        }


    }
}
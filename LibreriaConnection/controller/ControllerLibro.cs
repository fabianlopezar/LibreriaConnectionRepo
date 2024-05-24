﻿using System;
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
    }
}

using LibreriaConnection.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.controller
{
    class ControllerAutor
    {
        internal bool InsertAutor(Autores objAutor)
        {
            bool result = false;
            string sql = "insert into autores(nombre1Autor,nombre2Autor,apellido1Autor,apellido2Autor,direccionAutor,telefonoAutor, idCiudadAutores) values('" + objAutor.Nombre1Autor + "', '" + objAutor.Nombre2Autor + "', '" + objAutor.Apellido1Autor + "', '" + objAutor.Apellido2Autor + "', '" + objAutor.DireccionAutor + "', '" + objAutor.TelefonoAutor + "', " + objAutor.IdCiudadAutor + ");";
            ConnectDB objConnect = new ConnectDB();
            result = objConnect.ExecuteQuery(sql);
            return result;
        }

        internal List<Autores> SelectAutores()
        {
            List<Autores> listaAutores = null;
            ConnectDB objConnect = new ConnectDB();
            string sql = "select * from autores;";
            listaAutores = objConnect.SelectAutores(sql);

            return listaAutores;
        }

        internal bool UpdateAutor(Autores objAutor)
        {
            bool result = false;     
            //string sql = "UPDATE autores SET nombre1Autor='" + objAutor.Nombre1Autor + "', nombre2Autor='" + objAutor.Nombre2Autor + "', apellido1Autor='" + objAutor.Apellido1Autor + "', apellido2Autor='" + objAutor.Apellido2Autor + "', direccionAutor='" + objAutor.DireccionAutor + "', telefonoAutor='" + objAutor.TelefonoAutor + "' WHERE idAutor=" + objAutor.IdAutor;
            //string sql = "UPDATE autores SET nombre1Autor='" + objAutor.Nombre1Autor + "', nombre2Autor='" + objAutor.Nombre2Autor + "', apellido1Autor='" + objAutor.Apellido1Autor + "', apellido2Autor='" + objAutor.Apellido2Autor + "', direccionAutor='" + objAutor.DireccionAutor + "', telefonoAutor='" + objAutor.TelefonoAutor +"', idCiudadAutores='"+objAutor.IdCiudadAutor +"' WHERE idAutor=" + objAutor.IdAutor;
            string sql = "UPDATE autores SET idCiudadAutores='"+objAutor.IdCiudadAutor +"' WHERE idAutor=" + objAutor.IdAutor;

            ConnectDB objConnect = new ConnectDB();
            result = objConnect.ExecuteQuery(sql);
            return result;
        }
    }
}

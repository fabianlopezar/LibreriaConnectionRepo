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
            string sql = "insert into autores(nombre1Autor,nombre2Autor,apellido1Autor,apellido2Autor,direccionAutor,telefonoAutor, idCiudadAutores) values('"+objAutor.Nombre1Autor+"', '"+objAutor.Nombre2Autor+"', '"+objAutor.Apellido1Autor+"', '"+objAutor.Apellido2Autor+"', '"+objAutor.DireccionAutor+"', '"+objAutor.TelefonoAutor+"', "+objAutor.IdCiudadAutor+");";
            ConnectDB objConnect = new ConnectDB();
            result = objConnect.ExecuteQuery(sql);
            return result;
        }
    }
}

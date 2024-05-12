using LibreriaConnection.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.controller
{
    class ControllerAdministrador
    {
        internal bool InsertAdministrador(Administradores objAdministrador)
        {
            bool result = false;
            string sql = "insert  into administradores (nombre1Administrador, nombre2Administrador,apellido1Administrador,apellido2Administrador,correo,contraseniaAdministrador)" +
                         " values('" + objAdministrador.Nombre1Administrador + "' , '" + objAdministrador.Nombre2Administrador + "', '" + objAdministrador.Apellido1Administrador + "' ,'" + objAdministrador.Apellido2Administrador + "', '" + objAdministrador.Correo + "', +'" + objAdministrador.ContraseniaAdministrador + "');";

            ConnectDB objConnect = new ConnectDB();
            result = objConnect.ExecuteQuery(sql);
            return result;
        }
    }
}

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
        internal bool InsertAdministrador(Administradores admin)
        {
            bool result = false;
            //string sql = $"CALL InsertarAdministrador('Nombre1', 'Nombre2', 'Apellido1', 'Apellido2', 'correo@example.com', 'contrasenia');";
            string sql = $"CALL InsertarAdministrador('{admin.Nombre1Administrador}', '{admin.Nombre2Administrador}', '{admin.Apellido1Administrador}', '{admin.Apellido2Administrador}', '{admin.Correo}', '{admin.ContraseniaAdministrador}');";

            ConnectDB objConnect = new ConnectDB();
            result = objConnect.ExecuteQuery(sql);
            return result;
        }
        internal List<Administradores> SelectAdministradores()
        {
            List<Administradores> listaAdministradores = null;
            ConnectDB connect = new ConnectDB();
            string sql = "select * from administradores";
            listaAdministradores = connect.SelectAdministradores(sql);
            return listaAdministradores;
        }
    }
}

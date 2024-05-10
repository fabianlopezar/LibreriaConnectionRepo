using LibreriaConnection.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.controller
{
    class ControllerTelefono
    {
        internal bool InsertTelefono(Telefonos objTelefono)
        {
            bool result = false;
            string sql = "insert into telefonos(numeroTelefonico, idCuentaTelefono) values('"+objTelefono.NumeroTelefonico+"', "+objTelefono.IdCuentaTelefono+")";
            ConnectDB objConnect = new ConnectDB();
            result = objConnect.ExecuteQuery(sql);
            return result;
        }
    }
}

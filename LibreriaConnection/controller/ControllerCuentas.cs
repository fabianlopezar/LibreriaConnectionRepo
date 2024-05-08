using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConnection.models;

namespace LibreriaConnection.controller
{
    class ControllerCuentas
    {
        
        internal List<Cuentas> SelectCuentas()
        {
            List<Cuentas> listaCuentas = null;
           
            string sql = "select * from cuentas;";
            Cuentas objCuenta = new Cuentas();
            listaCuentas = objCuenta.SelectCuenta(sql);// video min

            return listaCuentas;
        }

        internal bool UpdateCuentas(Cuentas objCuenta)
        {
            bool result = false;
            string sql = "update cuentas set nombre1Cuenta='" + objCuenta.Nombre1Cuenta + "' WHERE idCuenta=" + objCuenta.IdCuenta;
            ConnectDB objCBD = new ConnectDB();
            result = objCBD.ExecuteQuery(sql);
            return result;
        }
    }
}

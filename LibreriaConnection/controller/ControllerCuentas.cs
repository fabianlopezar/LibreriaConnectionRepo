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
            listaCuentas = objCuenta.SelectCuenta(sql);

            return listaCuentas;
        }

        internal bool InsertCuentaImage(Cuentas cuenta)
        {            
            bool result = false;

            string sql = $"CALL InsertarCuenta({cuenta.IdCuenta}, '{cuenta.Nombre1Cuenta}', '{cuenta.Nombre2Cuenta}', '{cuenta.Apellido1Cuenta}', '{cuenta.Apellido2Cuenta}', '{cuenta.DireccionCuenta}', @fotoCuenta, '{cuenta.FechaNacimiento}', '{cuenta.ContraseniaCuenta}');";
            
            ConnectDB objCBD = new ConnectDB();
            result = objCBD.ExecuteQueryImageCuenta(sql,cuenta.Foto);
         
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConnection.models;

namespace LibreriaConnection.controller
{
    class ControllerCiudad
    {
        internal bool InsertCiudad(Ciudades objCiudad)
        {
            bool result = false;
            string sql = "";
            ConnectDB objConnect = new ConnectDB();
            result = objConnect.ExecuteQuery(sql);
            return result;
        }
        internal List<Ciudades> SelectCiudades()
        {
            List<Ciudades> listaCiudades = null;
            string sql = "select * from ciudades;";
            Ciudades objCiudad = new Ciudades();
            listaCiudades = objCiudad.SelectCiudad(sql);
            return listaCiudades;
        }
    }
}

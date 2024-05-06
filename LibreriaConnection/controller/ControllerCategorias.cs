using LibreriaConnection.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.controller
{
    class ControllerCategorias
    {
        internal List<Categorias> SelectCategorias()
        {
            List<Categorias> listaC = null;
            ConnectDB objCBD = new ConnectDB();
            string sql = "select * from categorias;";
            listaC = objCBD.SelectCategorias(sql);
            return listaC;
        }

        internal bool UpdateCategorias(Categorias objCategoria)
        {
            bool result = false;
            string sql = "update categorias set nombreCategoria='"+objCategoria.NombreCategoria+"' WHERE idCategoria="+objCategoria.IdCategoria;
            ConnectDB objCBD = new ConnectDB();
            result = objCBD.ExecuteQuery(sql);
            return result;
        }
    }
}

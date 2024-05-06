using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConnection.models;

namespace LibreriaConnection.controller
{
    class ControllerEditorial
    {
        internal List<Editoriales> SelectEditoriales()
        {
            List<Editoriales> listaEditoriales = null;
            ConnectDB objCDB = new ConnectDB();
            string sql = "select * from editoriales;";
            listaEditoriales = objCDB.SelectEditoriales(sql);
            return listaEditoriales;
        }
        internal bool UpdateEditoriales(Editoriales objEditorial)
        {
            bool result =false;
            string sql = "update editoriales set nombreEditorial='" + objEditorial.NombreEditorial + "' WHERE idEditorial=" + objEditorial.IdEditorial;
            ConnectDB objCBD = new ConnectDB();
            result = objCBD.ExecuteQuery(sql);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConnection.models;

namespace LibreriaConnection.controller
{
    class ControllerLibro_Prestamo
    {
        internal bool InsertPrestamo(Libro_Prestamo libro_Prestamo)
        {
            bool result = false;
            
            string sql = "insert into libro_prestamo(idLibroPrestamo_Prestamo, idLibroPrestamo_Libro) values("+libro_Prestamo.IdLibroPrestamo_Prestamo+", "+libro_Prestamo.IdLibroPrestamo_Libro+");";
            ConnectDB connect = new ConnectDB();
            result = connect.ExecuteQuery(sql);
            return result;

        }
    }
}

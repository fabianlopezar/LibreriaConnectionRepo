using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConnection.models;

namespace LibreriaConnection.controller
{
    class ControllerPrestamo
    {
        List<Libros> listaLibrosEnPrestamo;

        internal List<Libros> ConsultaLibrosEnPrestamo()
        {
            ConnectDB connect = new ConnectDB();
            string sql = "select titulo from libros l right join libro_prestamo lp on l.idLibro=lp.idLibroPrestamo_Libro;";
            listaLibrosEnPrestamo = connect.ConsultarTodosLosLibrosPrestados(sql);
            return listaLibrosEnPrestamo;
        }
        internal List<Libros> ConsultaLibroPrestamoCuenta(int id)
        {

            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = "SELECT c.idCuenta, p.idCuentaPrestamo, lp.idLibroPrestamo_Prestamo, l.idLibro, l.titulo FROM cuentas c INNER JOIN prestamos p ON  " + id + " = p.idCuentaPrestamo INNER JOIN libro_prestamo lp ON c.idCuenta = lp.idLibroPrestamo_Prestamo INNER JOIN libros l ON lp.idLibroPrestamo_Prestamo = l.idLibro;";
            listaLibros = connect.ConsultaLibrosPrestamoLector(sql);
            return listaLibros;

        }
        internal List<Libros> ConsultarCantidadLibrosPrestamosActuales()
        {
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = "SELECT * FROM libros l INNER JOIN libro_prestamo lp ON l.idLibro= lp.idLibroPrestamo_Libro INNER JOIN prestamos p ON lp.idLibroPrestamo_Prestamo= p.idPrestamo WHERE p.estaVencido = 1;";
            listaLibros = connect.ConsultarCantidadLibrosActuales(sql);
            return listaLibros;
        }
        internal List<Libros> ConsultarCantidadLibrosPrestamosVencidos()
        {
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = "SELECT * FROM libros l INNER JOIN libro_prestamo lp ON l.idLibro= lp.idLibroPrestamo_Libro INNER JOIN prestamos p ON lp.idLibroPrestamo_Prestamo= p.idPrestamo WHERE p.estaVencido = 0;";
            listaLibros = connect.ConsultarCantidadLibrosActuales(sql);

            return listaLibros;
        }

        internal List<Libros> ConsultarLibrosPrestadoEntreFechas(string fecha1, string fecha2)
        {
            List<Libros> listaLibros = null;
            ConnectDB connect = new ConnectDB();
            string sql = $"SELECT * FROM prestamos p INNER JOIN libro_prestamo lp ON p.idPrestamo = lp.idLibroPrestamo_Prestamo INNER JOIN libros l ON lp.idLibroPrestamo_Libro = l.idLibro WHERE p.fechaPrestamo BETWEEN '{fecha1}' AND '{fecha2}';";
            listaLibros = connect.ConsultarLibrosPrestadosEntreFechas(sql);

            return listaLibros;
        }
        internal List<Multas> ConsultarMultasPagadasEntreFechas(string fecha1, string fecha2, int idCuenta)
        {
            List<Multas> listaMultas = null;
            ConnectDB connect = new ConnectDB();
            string sql = $"select m.idPrestamoMulta FROM cuentas c INNER JOIN prestamos p ON c.idCuenta= p.idCuentaPrestamo INNER JOIN multas m ON p.idCuentaPrestamo=m.idPrestamoMulta  WHERE m.estaPagado=1 AND m.fechaPago BETWEEN '{fecha1}' AND '{fecha2}' AND c.idCuenta={idCuenta} ;";

            listaMultas = connect.ConsultarMultasPagadasEntreFechas(sql);

            return listaMultas;
        }
        internal List<Multas> ConsultaTotalPagado(string fecha1, string fecha2, int idCuenta)
        {
            List<Multas> listaMultas = null;
            ConnectDB connect = new ConnectDB();
            string sql = $"SELECT SUM(m.valorAPagar) AS totalValorAPagar FROM cuentas c INNER JOIN prestamos p ON c.idCuenta = p.idCuentaPrestamo INNER JOIN multas m ON p.idCuentaPrestamo = m.idPrestamoMulta WHERE m.estaPagado = 1 AND m.fechaPago BETWEEN '{fecha1}' AND '{fecha2}' AND c.idCuenta = {idCuenta};";
            listaMultas = connect.ConsultarTotalPagado(sql);

            return listaMultas;
        }
        internal List<Multas> ConsultarValorMulta(int idCuenta)
        {
            List<Multas> listaMultas = null;
            ConnectDB connect = new ConnectDB();
            string sql = $"select m.valorAPagar FROM cuentas c INNER JOIN prestamos p ON {idCuenta} = p.idCuentaPrestamo INNER JOIN multas m ON p.idMultaPrestamo=m.idPrestamoMulta;";
            listaMultas = connect.ConsultarValorMulta(sql);

            return listaMultas;
        }
        internal List<Multas> ConsultarMultaSinPagar()
        {
            List<Multas> listaMultas = null;
            ConnectDB connect = new ConnectDB();
            string sql = $"select * from multas m where m.estaPagado=0;";
            listaMultas = connect.ConsultarMultaSinPagar(sql);

            return listaMultas;
        }
    }
}

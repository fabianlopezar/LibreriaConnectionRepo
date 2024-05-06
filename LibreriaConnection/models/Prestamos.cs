using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Prestamos
    {
        private int idPrestamo;
        private string fechaPrestamo;
        private string fechaDevolucion;
        private bool estaVencido;
        private int idCuentaPrestamo;
        private int idLibroPrestamo;

        public Prestamos()
        {
        }

        public Prestamos(string fechaPrestamo)
        {
            this.fechaPrestamo = fechaPrestamo;
        }

        public Prestamos(int idPrestamo, string fechaPrestamo)
        {
            this.idPrestamo = idPrestamo;
            this.fechaPrestamo = fechaPrestamo;
        }

        public Prestamos(int idPrestamo, string fechaPrestamo, string fechaDevolucion, bool estaVencido, int idCuentaPrestamo, int idLibroPrestamo)
        {
            this.idPrestamo = idPrestamo;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
            this.estaVencido = estaVencido;
            this.idCuentaPrestamo = idCuentaPrestamo;
            this.idLibroPrestamo = idLibroPrestamo;
        }
    }
}

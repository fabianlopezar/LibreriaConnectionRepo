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

        public Prestamos()
        {
        }

        public Prestamos(string fechaPrestamo)
        {
            this.fechaPrestamo = fechaPrestamo;
        }

        public Prestamos(int idPrestamo)
        {
            this.idPrestamo = idPrestamo;
        }

        public Prestamos(string fechaPrestamo, string fechaDevolucion, bool estaVencido, int idCuentaPrestamo) : this(fechaPrestamo)
        {
            this.fechaDevolucion = fechaDevolucion;
            this.estaVencido = estaVencido;
            this.idCuentaPrestamo = idCuentaPrestamo;
        }

        public Prestamos(int idPrestamo, string fechaPrestamo)
        {
            this.idPrestamo = idPrestamo;
            this.fechaPrestamo = fechaPrestamo;
        }

        public Prestamos(int idPrestamo, string fechaPrestamo, string fechaDevolucion, bool estaVencido, int idCuentaPrestamo)
        {
            this.idPrestamo = idPrestamo;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
            this.estaVencido = estaVencido;
            this.idCuentaPrestamo = idCuentaPrestamo;

        }

        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public string FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public string FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public bool EstaVencido { get => estaVencido; set => estaVencido = value; }
        public int IdCuentaPrestamo { get => idCuentaPrestamo; set => idCuentaPrestamo = value; }
    }
}

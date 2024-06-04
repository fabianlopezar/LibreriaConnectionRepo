using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Libro_Prestamo
    {
        private int idLibroPrestamo;
        private int idLibroPrestamo_Prestamo;
        private int idLibroPrestamo_Libro;

        public int IdLibroPrestamo { get => idLibroPrestamo; set => idLibroPrestamo = value; }
        public int IdLibroPrestamo_Prestamo { get => idLibroPrestamo_Prestamo; set => idLibroPrestamo_Prestamo = value; }
        public int IdLibroPrestamo_Libro { get => idLibroPrestamo_Libro; set => idLibroPrestamo_Libro = value; }

        public Libro_Prestamo()
        {
        }

        public Libro_Prestamo(int idLibroPrestamo, int idLibroPrestamo_Prestamo, int idLibroPrestamo_Libro)
        {
            this.idLibroPrestamo = idLibroPrestamo;
            this.idLibroPrestamo_Prestamo = idLibroPrestamo_Prestamo;
            this.idLibroPrestamo_Libro = idLibroPrestamo_Libro;
        }

        public Libro_Prestamo(int idLibroPrestamo_Prestamo, int idLibroPrestamo_Libro)
        {
            this.idLibroPrestamo_Prestamo = idLibroPrestamo_Prestamo;
            this.idLibroPrestamo_Libro = idLibroPrestamo_Libro;
        }

    }
}

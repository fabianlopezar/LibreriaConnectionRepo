using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Multas
    {
        private int idMultas;
        private string fechaInicio;
        private bool estapagado;
        private double valorAPagar;
        private string fechaPago;
        private string idPrestamoMulta;

        public Multas()
        {
        }

        public Multas(string fechaInicio)
        {
            this.fechaInicio = fechaInicio;
        }

        public Multas(int idMultas, string fechaInicio)
        {
            this.idMultas = idMultas;
            this.fechaInicio = fechaInicio;
        }

        public Multas(int idMultas, string fechaInicio, bool estapagado, double valorAPagar, string fechaPago, string idPrestamoMulta)
        {
            this.idMultas = idMultas;
            this.fechaInicio = fechaInicio;
            this.estapagado = estapagado;
            this.valorAPagar = valorAPagar;
            this.fechaPago = fechaPago;
            this.idPrestamoMulta = idPrestamoMulta;
        }

        public int IdMultas { get => idMultas; set => idMultas = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public bool Estapagado { get => estapagado; set => estapagado = value; }
        public double ValorAPagar { get => valorAPagar; set => valorAPagar = value; }
        public string FechaPago { get => fechaPago; set => fechaPago = value; }
        public string IdPrestamoMulta { get => idPrestamoMulta; set => idPrestamoMulta = value; }
    }
}

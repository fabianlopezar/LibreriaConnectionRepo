using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Cuentas
    {
     private int idCuenta ;
     private string nombre1Cuenta;
     private string nombre2Cuenta;
     private string apellido1Cuenta;
     private string apellido2Cuenta;
     private string direccionCuenta;
     private string foto;
     private string fechaNacimiento;
     private string contraseniaCuenta;



        public Cuentas()
        {
        }

        public Cuentas(string nombre1Cuenta)
        {
            this.Nombre1Cuenta = nombre1Cuenta;
        }

        public Cuentas(int idCuenta, string nombre1Cuenta)
        {
            this.IdCuenta = idCuenta;
            this.Nombre1Cuenta = nombre1Cuenta;
        }

        public Cuentas(int idCuenta, string nombre1Cuenta, string nombre2Cuenta) : this(idCuenta, nombre1Cuenta)
        {
            this.nombre2Cuenta = nombre2Cuenta;
        }

        public Cuentas(int idCuenta, string nombre1Cuenta, string nombre2Cuenta, string apellido1Cuenta, string apellido2Cuenta, string direccionCuenta, string foto, string fechaNacimiento, string contraseniaCuenta)
        {
            this.IdCuenta = idCuenta;
            this.Nombre1Cuenta = nombre1Cuenta;
            this.Nombre2Cuenta = nombre2Cuenta;
            this.Apellido1Cuenta = apellido1Cuenta;
            this.Apellido2Cuenta = apellido2Cuenta;
            this.DireccionCuenta = direccionCuenta;
            this.Foto = foto;
            this.FechaNacimiento = fechaNacimiento;
            this.ContraseniaCuenta = contraseniaCuenta;
        }

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string Nombre1Cuenta { get => nombre1Cuenta; set => nombre1Cuenta = value; }
        public string Nombre2Cuenta { get => nombre2Cuenta; set => nombre2Cuenta = value; }
        public string Apellido1Cuenta { get => apellido1Cuenta; set => apellido1Cuenta = value; }
        public string Apellido2Cuenta { get => apellido2Cuenta; set => apellido2Cuenta = value; }
        public string DireccionCuenta { get => direccionCuenta; set => direccionCuenta = value; }
        public string Foto { get => foto; set => foto = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string ContraseniaCuenta { get => contraseniaCuenta; set => contraseniaCuenta = value; }
    }
}

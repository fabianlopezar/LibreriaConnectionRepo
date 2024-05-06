using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Administradores
    {
        private int idAdministrador;
        private string nombre1Administrador;
        private string nombre2Administrador;
        private string apellido1Administrador;
        private string apellido2Administrador;
        private string correo;
        private string contraseniaAdministrador;

        public int IdAdministrador { get => idAdministrador; set => idAdministrador = value; }
        public string Nombre1Administrador { get => nombre1Administrador; set => nombre1Administrador = value; }
        public string Nombre2Administrador { get => nombre2Administrador; set => nombre2Administrador = value; }
        public string Apellido1Administrador { get => apellido1Administrador; set => apellido1Administrador = value; }
        public string Apellido2Administrador { get => apellido2Administrador; set => apellido2Administrador = value; }
        public string Correo { get => correo; set => correo = value; }
        public string ContraseniaAdministrador { get => contraseniaAdministrador; set => contraseniaAdministrador = value; }

        public Administradores(string nombre1Administrador)
        {
            this.nombre1Administrador = nombre1Administrador;
        }

        public Administradores(int idAdministrador, string nombre1Administrador)
        {
            this.idAdministrador = idAdministrador;
            this.nombre1Administrador = nombre1Administrador;
        }

        public Administradores(int idAdministrador, string nombre1Administrador, string nombre2Administrador, string apellido1Administrador, string apellido2Administrador, string correo, string contraseniaAdministrador)
        {
            this.idAdministrador = idAdministrador;
            this.nombre1Administrador = nombre1Administrador;
            this.nombre2Administrador = nombre2Administrador;
            this.apellido1Administrador = apellido1Administrador;
            this.apellido2Administrador = apellido2Administrador;
            this.correo = correo;
            this.contraseniaAdministrador = contraseniaAdministrador;
        }

        public Administradores()
        {
        }
    }
}

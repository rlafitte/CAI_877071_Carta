using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta.Libreria.Entidades
{
    public class Remitente
    {
        private string s_nombre;
        private string s_apellido;
        private string s_domicilio;
        public string s_Nombre
        {
            get
            {
                return this.s_nombre;
            }
            set
            {
                this.s_nombre = value;
            }
        }
        //s_apellido
        public string s_Apellido
        {
            get
            {
                return this.s_apellido;
            }
            set
            {
                this.s_apellido = value;
            }
        }
        public string s_Domicilio
        {
            get
            {
                return this.s_domicilio;
            }
            set
            {
                this.s_domicilio = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta.Libreria.Entidades
{
    public class Estampilla
    {
        private int i_nroSerie;
        private string s_nombre;
        private int i_añoEmision;
        private double d_precio;

        public int NroSerie
        {
            get
            {
                return this.i_nroSerie;
            }
            set
            {
                this.i_nroSerie = value;
            }
        }

        public string Nombre
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
        public int AñoEmision
        {
            get
            {
                return this.i_añoEmision;
            }
            set
            {
                this.i_añoEmision = value;
            }
        }
        private double Precio
        {
            get
            {
                return this.d_precio;
            }
            set
            {
                this.d_precio = value;
            }
        }
    }
}

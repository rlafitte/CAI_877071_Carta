using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta.Libreria.Entidades
{
    public class Envio
    {
        private int i_nroEnvio;
        private string s_claseEnvio;
        private Destinatario[] Dest;
        private Remitente[] Remi;
        private Estampilla[] Estam;

        public int Envios
        {
            get
            {
                return this.i_nroEnvio;
            }
            set
            {
                this.i_nroEnvio = value;
            }
        }
        public string Clase
        {
            get
            {
                return this.s_claseEnvio;
            }
            set
            {
                this.s_claseEnvio = value;
            }
        }
        public Destinatario dest
        {
            get;set;
        }
        public Remitente remi
        {
            get;set;
        }
        public Estampilla estamp
        {
            get;set;
        }
    }
}

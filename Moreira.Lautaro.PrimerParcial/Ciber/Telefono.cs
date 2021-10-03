using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Telefono : Equipo
    {
        private string identificador;
        private Llamada llamada;
        private ETipo tipo;
        
        public Telefono( string identificador , ETipo tipo ) : base(identificador)
        {
            this.tipo = tipo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Tipo: {tipo.ToString()}");
            sb.AppendLine($"{llamada.Mostrar()}");
            return sb.ToString();
        }
        public string NumeroLlamada //Deberia llamarse numero llamada?
        {
            get
            {
                if (llamada is not null)
                {
                    return llamada.NumeroDestino;
                }
                return "-1";
            }
            set
            {
                if (Llamada.ValidarLlamada(value))
                {
                    llamada.NumeroDestino = value;
                }
                
            }  
        }


        public override string ToString()
        {
            return this.Mostrar();
        }

        public enum ETipo
        {
            ADisco, Teclado
        }

    }
}

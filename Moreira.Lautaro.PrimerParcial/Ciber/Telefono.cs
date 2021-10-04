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
        
        /// <summary>
        /// Constructor del telefono
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="tipo"></param>
        public Telefono( string identificador , ETipo tipo ) : base(identificador)
        {
            this.Tipo = tipo;
        }


        /// <summary>
        /// Muestra la informacion del telefono con su llamada.
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Tipo: {Tipo.ToString()}");
            sb.AppendLine($"{llamada.Mostrar()}");
            return sb.ToString();
        }
        /// <summary>
        /// Retorna el numero de la llamada si no fue inicializada retorna -1.
        /// </summary>
        public string NumeroLlamada
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

        public ETipo Tipo
        {
            get { return tipo; }
        }


        /// <summary>
        /// Sobrescritura del metodo tostring 
        /// </summary>
        /// <returns>Informacion del telefono en string</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        /// <summary>
        /// Enum con los tipos de telefonos
        /// </summary>
        public enum ETipo
        {
            None,ADisco, Teclado
        }

    }
}

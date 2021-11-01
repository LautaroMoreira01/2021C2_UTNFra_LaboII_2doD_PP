using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {

         
        private bool enEspera;

        /// <summary>
        /// constructor de cliente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        public Cliente(string nombre, string apellido, int edad, long dni) : base(nombre, apellido, edad, dni)
        {
            enEspera = true;
        }

        /// <summary>
        /// propiedad que devuelva estado de espera.
        /// </summary>
        public bool EnEspera
        {
            get { return enEspera; }
            set { enEspera = value; }
        }

        /// <summary>
        /// Muestra el cliente con los requerimientos
        /// </summary>
        /// <returns>string con la informacion y requerimientos del cliente</returns>
        public virtual string MostrarClienteConRequerimientos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------------------------------------------------------");
            sb.AppendLine(this.MostrarInformacionPersonal());
            return sb.ToString();
        }

        /// <summary>
        /// Sobrescritura del toString que retorna la informacion personal de el cliente.
        /// </summary>
        /// <returns>string con la informacion personal del cliente</returns>
        public override string ToString()
        {
            return this.MostrarInformacionPersonal();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class ClienteTelefono : Cliente
    {
        private ETipo requerimientoTipoTelefono;
     
        /// <summary>
        /// Constuctor de cliente telefono
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="requerimientoTelefono"></param>
        public ClienteTelefono(string nombre, string apellido, int edad, long dni , ETipo requerimientoTelefono) : base(nombre, apellido, edad, dni)
        {
            this.requerimientoTipoTelefono = requerimientoTelefono;
        }

        /// <summary>
        /// sobrecarga del construcor que no recibe el requerimiento del telefono y pasa none por defecto
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        public ClienteTelefono(string nombre, string apellido, int edad, long dni) : this(nombre, apellido, edad, dni , ETipo.None)
        {}

        /// <summary>
        /// propiedad que retorna el requerimiento del cliente en telefono
        /// </summary>
        public ETipo RequerimientoTipoTelefono 
        {
            get { return requerimientoTipoTelefono; }
        }

        /// <summary>
        /// Muestra el cliente con rel requerimiento del telefono.
        /// </summary>
        /// <returns>string con el requerimiento del telefono</returns>
        public override string MostrarClienteConRequerimientos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(base.MostrarClienteConRequerimientos());
            sb.AppendLine($"Tipo telefono solicitado: {RequerimientoTipoTelefono}");
            sb.AppendLine("-------------------------------------------------------");
            
            return sb.ToString();
        }


    }
}

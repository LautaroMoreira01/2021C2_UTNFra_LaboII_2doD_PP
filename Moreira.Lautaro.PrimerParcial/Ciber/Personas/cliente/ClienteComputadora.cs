using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class ClienteComputadora : Cliente
    {
        private List<Software> requerimientoSoftware;
        private List<Hardware> requerimientoHardware;
        private List<Juegos> requerimientoJuegos;
        private List<Perifericos> requerimientoPerifericos;

        /// <summary>
        /// Constructor de cliente computadora
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        public ClienteComputadora(string nombre , string apellido , int edad ,long dni) : base(nombre , apellido , edad , dni)
        {}

        
        #region Agregar hardware
        /// <summary>
        /// Sobrecarga del operador + para agregar un hardware a la lista de requerimientos en un cliente
        /// </summary>
        /// <param name="c">cliente</param>
        /// <param name="requerimiento">requerimiento a agregar</param>
        /// <returns>true si pudo ser agregado false si no pudo</returns>
        public static bool operator +(ClienteComputadora c, Hardware requerimiento)
        {
            bool rta = false;
            if (c.requerimientoHardware == null)
            {
                c.requerimientoHardware = new List<Hardware>();
            }
            if (c != requerimiento)
            {
                c.requerimientoHardware.Add(requerimiento);
                rta = true;
            }
            return rta;
        }

        /// <summary>
        /// sobrecarga del operador == que busca si un hardware ya se encuentra en la lista de requerimientos dle cliente
        /// </summary>
        /// <param name="c1">cliente</param>
        /// <param name="requerimiento">requerimietno a comparar</param>
        /// <returns>true si lo encuentra , false si no lo encuentra</returns>
        public static bool operator ==(ClienteComputadora c1, Hardware requerimiento)
        {
            bool rta = false;
            foreach (Hardware hardware in c1.requerimientoHardware)
            {
                if (requerimiento == hardware)
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }

        /// <summary>
        /// Sobrecarga del operador != que busca si un requerimiento no se encuentra en la lista de requerimientos del cliente
        /// </summary>
        /// <param name="c1">cliente</param>
        /// <param name="requerimiento">requerimiento a comparar</param>
        /// <returns></returns>
        public static bool operator !=(ClienteComputadora c1, Hardware requerimiento)
        {
            return !(c1 == requerimiento);
        }


        #endregion

        #region Agregar software


        /// <summary>
        /// sobrecarga del operador == que busca si un Software ya se encuentra en la lista de requerimientos dle cliente
        /// </summary>
        /// <param name="c1">cliente</param>
        /// <param name="requerimiento">requerimietno a comparar</param>
        /// <returns>true si lo encuentra , false si no lo encuentra</returns>
        public static bool operator ==(ClienteComputadora c1, Software requerimiento)
        {
            bool rta = false;
            foreach (Software software in c1.requerimientoSoftware)
            {
                if (requerimiento == software)
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }

        /// <summary>
        /// Sobrecarga del operador != que busca si un requerimiento no se encuentra en la lista de requerimientos del cliente
        /// </summary>
        /// <param name="c1">cliente</param>
        /// <param name="requerimiento">requerimiento a comparar</param>
        /// <returns>true si no lo encuentra, false si lo encuentra</returns>
        public static bool operator !=(ClienteComputadora c1, Software requerimiento)
        {
            return !(c1 == requerimiento);
        }

        /// <summary>
        /// Sobrecarga del operador + para agregar un Software a la lista de requerimientos en un cliente
        /// </summary>
        /// <param name="c">cliente</param>
        /// <param name="requerimiento">requerimiento a agregar</param>
        /// <returns>true si pudo ser agregado false si no pudo</returns>
        public static bool operator +(ClienteComputadora c, Software requerimiento)
        {
            bool rta = false;
            if (c.requerimientoSoftware == null)
            {
                c.requerimientoSoftware = new List<Software>();
            }

            if (c != requerimiento)
            {
                c.requerimientoSoftware.Add(requerimiento);
                rta = true;
            }
            return rta;
        }
        #endregion
        #region Agregar Juegos
        /// <summary>
        /// sobrecarga del operador == que busca si un Software ya se encuentra en la lista de requerimientos dle cliente
        /// </summary>
        /// <param name="c1">cliente</param>
        /// <param name="requerimiento">requerimietno a comparar</param>
        /// <returns>true si lo encuentra , false si no lo encuentra</returns>
        public static bool operator ==(ClienteComputadora c1, Juegos requerimiento)
        {
            bool rta = false;
            foreach (Juegos juego in c1.requerimientoJuegos)
            {
                if (requerimiento == juego)
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }

        /// <summary>
        /// Sobrecarga del operador != que busca si un requerimiento no se encuentra en la lista de requerimientos del cliente
        /// </summary>
        /// <param name="c1">cliente</param>
        /// <param name="requerimiento">requerimiento a comparar</param>
        /// <returns>true si no lo encuentra, false si lo encuentra</returns>
        public static bool operator !=(ClienteComputadora c1, Juegos requerimiento)
        {
            return !(c1 == requerimiento);
        }

        /// <summary>
        /// Sobrecarga del operador + para agregar un Juego a la lista de requerimientos en un cliente
        /// </summary>
        /// <param name="c">cliente</param>
        /// <param name="requerimiento">requerimiento a agregar</param>
        /// <returns>true si pudo ser agregado false si no pudo</returns>
        public static bool operator +(ClienteComputadora c, Juegos requerimiento)
        {
            bool rta = false;
            if (c.requerimientoJuegos == null)
            {
                c.requerimientoJuegos = new List<Juegos>();
            }

            if (c != requerimiento)
            {
                c.requerimientoJuegos.Add(requerimiento);
                rta = true;
            }
            return rta;
        }
        #endregion
        #region Agregar Perifericos

        /// <summary>
        /// sobrecarga del operador == que busca si un periferico ya se encuentra en la lista de requerimientos dle cliente
        /// </summary>
        /// <param name="c1">cliente</param>
        /// <param name="requerimiento">requerimietno a comparar</param>
        /// <returns>true si lo encuentra , false si no lo encuentra</returns>
        public static bool operator ==(ClienteComputadora c1, Perifericos requerimiento)
        {
            bool rta = false;
            foreach (Perifericos periferico in c1.requerimientoPerifericos)
            {
                if (requerimiento == periferico)
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }

        /// <summary>
        /// Sobrecarga del operador != que busca si un requerimiento no se encuentra en la lista de requerimientos del cliente
        /// </summary>
        /// <param name="c1">cliente</param>
        /// <param name="requerimiento">requerimiento a comparar</param>
        /// <returns>true si no lo encuentra, false si lo encuentra</returns>
        public static bool operator !=(ClienteComputadora c1, Perifericos requerimiento)
        {
            return !(c1 == requerimiento);
        }

        /// <summary>
        /// Sobrecarga del operador + para agregar un periferico a la lista de requerimientos en un cliente
        /// </summary>
        /// <param name="c">cliente</param>
        /// <param name="requerimiento">requerimiento a agregar</param>
        /// <returns>true si pudo ser agregado false si no pudo</returns>
        public static bool operator +(ClienteComputadora c, Perifericos requerimiento)
        {
            bool rta = false;
            if (c.requerimientoPerifericos == null)
            {
                c.requerimientoPerifericos = new List<Perifericos>();
            }

            if (c != requerimiento)
            {
                c.requerimientoPerifericos.Add(requerimiento);
                rta = true;
            }

            return rta;
        }
        #endregion

        /// <summary>
        /// Propiedad que retorna la lista de requerimientos de hardware del cliente
        /// </summary>
        public List<Hardware> RequerimientosHarware
        {
            get { return this.requerimientoHardware; }
        }

        /// <summary>
        /// Propiedad que retorna la lista de requerimientos de software del cliente
        /// </summary>
        public List<Software> RequerimientosSoftware
        {
            get { return this.requerimientoSoftware; }
        }

        /// <summary>
        /// Propiedad que retorna la lista de requerimientos de juegos del cliente
        /// </summary>
        public List<Juegos> RequerimientosJuegos
        {
            get { return this.requerimientoJuegos; }
        }

        /// <summary>
        /// Propiedad que retorna la lista de requerimientos de perifericos del cliente
        /// </summary>
        public List<Perifericos> RequerimientosPerifericos
        {
            get { return this.requerimientoPerifericos; }
        }

        /// <summary>
        /// Muestra la informacion del cliente con los requerimientos de este
        /// </summary>
        /// <returns>string con la informacion del cliente y sus requerimientos</returns>
        public override string MostrarClienteConRequerimientos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarClienteConRequerimientos());
            if (RequerimientosHarware is not null && RequerimientosHarware.Count > 0)
            {
                sb.AppendLine("Requerimientos hardware.");

                foreach (Hardware hardware in this.RequerimientosHarware)
                {
                    sb.AppendLine(hardware.ToString());
                }
            }

            if (requerimientoSoftware is not null && requerimientoSoftware.Count > 0)
            {
                sb.AppendLine("Requerimientos Software.");

                foreach (Software software in this.requerimientoSoftware)
                {
                    sb.AppendLine(software.ToString());
                }
            }

            if (RequerimientosJuegos is not null && RequerimientosJuegos.Count > 0)
            {
                sb.AppendLine("Requerimientos Juegos.");

                foreach (Juegos juegos in this.requerimientoJuegos)
                {
                    sb.AppendLine(juegos.ToString());
                }
            }
            sb.AppendLine("-------------------------------------------------------");

            return sb.ToString();
        }

        /// <summary>
        ///  sobrescritura del equals que compara el objeto pasado por parametro.
        /// </summary>
        /// <param name="obj">objeto a comparar</param>
        /// <returns>si obj es nulo false, si el tipo de obj es el mismo de el objeto a comparar y el dni es el mismo true si no false.</returns>
        public override bool Equals(object obj)
        {
            if(obj == null )
            {
                return false;
            }
            else if(obj.GetType() == GetType() && ((ClienteComputadora)obj).dni == this.dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// sobrescritura del metodo GetHashCode 
        /// </summary>
        /// <returns>Retorna el getHashCode del dni</returns>
        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cliente : Persona
    {
        private List<Software> requerimientoSoftware;
        private List<Hardware> requerimientoHardware;
        private List<Juegos> requerimientoJuegos;
        private List<Perifericos> requerimientoPerifericos;
        private Telefono.ETipo requerimientoTipoTelefono;

        private bool enEspera;//En espera true o ya fue atendido false 


        public Cliente(string nombre, string apellido, int edad, long dni) : base(nombre, apellido, edad, dni)
        {
            enEspera = true;
        }

        public Cliente(string nombre, string apellido, int edad, long dni, Telefono.ETipo requerimientoTipoTelefono) : this(nombre, apellido, edad, dni)
        {
            this.requerimientoTipoTelefono = requerimientoTipoTelefono;
        }



        #region Agregar hardware
        public static bool operator +(Cliente c, Hardware requerimiento)
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
        public static bool operator ==(Cliente c1, Hardware requerimiento)
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
        public static bool operator !=(Cliente c1, Hardware requerimiento)
        {
            return !(c1 == requerimiento);
        }


        #endregion
        #region Agregar software

        public static bool operator ==(Cliente c1, Software requerimiento)
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
        public static bool operator !=(Cliente c1, Software requerimiento)
        {
            return !(c1 == requerimiento);
        }
        public static bool operator +(Cliente c, Software requerimiento)
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

        public static bool operator ==(Cliente c1, Juegos requerimiento)
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
        public static bool operator !=(Cliente c1, Juegos requerimiento)
        {
            return !(c1 == requerimiento);
        }
        public static bool operator +(Cliente c, Juegos requerimiento)
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

        public static bool operator ==(Cliente c1, Perifericos requerimiento)
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
        public static bool operator !=(Cliente c1, Perifericos requerimiento)
        {
            return !(c1 == requerimiento);
        }
        public static bool operator +(Cliente c, Perifericos requerimiento)
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
        /// propiedad que devuelva estado de espera.
        /// </summary>
        public bool EnEspera
        {
            get { return enEspera; }
            set { enEspera = value; }
        }

        public string MostrarClienteConRequerimientos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------------------------------------------------------");
            sb.AppendLine(this.Mostrar());
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


        public List<Hardware> RequerimientosHarware
        {
            get { return this.requerimientoHardware; }
        }
        public List<Software> RequerimientosSoftware
        {
            get { return this.requerimientoSoftware; }
        }
        public List<Juegos> RequerimientosJuegos
        {
            get { return this.requerimientoJuegos; }
        }
        public List<Perifericos> RequerimientosPerifericos
        {
            get { return this.requerimientoPerifericos; }
        }


        public static bool operator ==(Cliente c1, string str)
        {
            if (c1.Mostrar() == str)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cliente c1, string str)
        {
            return !(c1 == str);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            return this.Edad.GetHashCode();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora : Equipo
    {
        private const float costoDeUso = 0.50F;
        private List<Hardware> listHardware;
        private List<Juegos> listJuegos;
        private List<Software> listSoftware;
        private List<Perifericos> listPerifericos;

        /// <summary>
        /// Propiedad que retorna la lista de hardware o la setea
        /// </summary>
        public List<Hardware> ListHardware
        {
            get
            {
                return listHardware;
            }
            set
            {
                listHardware = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna la lista de juegos o la setea
        /// </summary>
        public List<Juegos> ListJuegos { 
            get
            {
                return listJuegos;
            }
            set
            {
                listJuegos = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna la lista de software o la setea
        /// </summary>
        public List<Software> ListSoftware
        {
            get
            {
                return listSoftware;
            }
            set
            {
                listSoftware = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna la lista de perifericos o la setea
        /// </summary>
        public List<Perifericos> ListPerifericos
        {
            get
            {
                return listPerifericos;
            }

            set
            {
                listPerifericos = value;
            }
        }


        /// <summary>
        /// Constructor de la clase Computadora.
        /// </summary>
        /// <param name="hardware"></param>
        /// <param name="juegos"></param>
        /// <param name="software"></param>
        /// <param name="perifericos"></param>
        /// <param name="identificador"></param>
        public Computadora(List<Hardware> hardware, List<Juegos> juegos, List<Software> software
            , List<Perifericos> perifericos, string identificador):base(identificador)
        {
            ListHardware = hardware;
            ListJuegos = juegos;
            ListSoftware = software;
            ListPerifericos = perifericos;
        }


        /// <summary>
        /// Calcula el costo de el uso de la computadora.
        /// </summary>
        /// <returns></returns>
        protected override float CalcularCostoDeUso()
        {
            int horasDeUso = TiempoDeUso.Minutes;
            int minutosDeUso = TiempoDeUso.Seconds + (horasDeUso * 60);
            float costo = (minutosDeUso / 30) * costoDeUso;
            if(minutosDeUso % 30 > 0) 
            {
                costo += costoDeUso;
            }
            
            return costo; 
        }

        /// <summary>
        /// Muestra la informacion de la Computadora.
        /// </summary>
        /// <returns>devuelve la informacion de la computadora en string</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{base.Mostrar()}");
            if (!estaLibre)
            {
                sb.AppendLine($"Tiempo de uso: {TiempoDeUso}");

            }
            sb.AppendLine($"--------------------------------------");
            sb.AppendLine($"Hardware:");
            foreach (Hardware item in ListHardware)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Software:");
            foreach (Software item in ListSoftware)
            {
                sb.AppendLine($"{item.ToString()}");
            
            }
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Juegos:");
            foreach (Juegos item in ListJuegos)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Perifericos:");
            foreach (Perifericos item in ListPerifericos)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            sb.AppendLine($"--------------------------------------");
            return sb.ToString();

        }

        /// <summary>
        /// Sobrescritura del metodo toString que devuelve la informacion de la computadora.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar(); 
        }

        /// <summary>
        /// Muestra la informacion de la computadora con el software y hardware de esta
        /// </summary>
        /// <returns></returns>
        public string MostrarComputadoraConHardwareYSoftware()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{base.Mostrar()}");
            //sb.AppendLine($"Tiempo de uso: {TiempoDeUso}");
            sb.AppendLine($"--------------------------------------");
            sb.AppendLine($"Hardware:");
            foreach (Hardware item in ListHardware)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Software:");
            foreach (Software item in ListSoftware)
            {
                sb.AppendLine($"{item.ToString()}");

            }
            sb.AppendLine($"--------------------------------------");
            return sb.ToString();
        }

        /// <summary>
        /// Ordena la lista de computadoras pasada por parametro por minutos de uso
        /// </summary>
        /// <param name="computadoras"></param>
        public static void OrdenarComputadorasPorMinutosDeUso(List<Computadora> computadoras)
        {
            computadoras.Sort(CompararEquiposPorMinutosDeUso);
        }

    }   
}

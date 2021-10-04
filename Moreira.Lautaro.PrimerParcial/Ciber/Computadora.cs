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

        private TimeSpan tiempoDeUso;
        private DateTime inicioDeUso; //Para constructor de uso libre.
        private List<Hardware> listHardware;
        private List<Juegos> listJuegos;
        private List<Software> listSoftware;
        private List<Perifericos> listPerifericos;


        /// <summary>
        /// Constructor de la clase Computadora.
        /// </summary>
        /// <param name="hardware"></param>
        /// <param name="juegos"></param>
        /// <param name="software"></param>
        /// <param name="perifericos"></param>
        /// <param name="identificador"></param>
        /// <param name="tiempoDeUso"></param>
        public Computadora(List<Hardware> hardware , List<Juegos> juegos , List<Software> software 
            , List<Perifericos> perifericos  , string identificador , TimeSpan tiempoDeUso )
            : base(identificador)
        {
            this.listHardware = hardware ;
            this.listJuegos = juegos ;
            this.listSoftware = software;
            this.listPerifericos = perifericos;
            this.TiempoDeUso = tiempoDeUso;
        }
        public Computadora(List<Hardware> hardware, List<Juegos> juegos, List<Software> software
            , List<Perifericos> perifericos, string identificador)
            : this(hardware, juegos, software, perifericos, identificador , new TimeSpan())
        {
            this.inicioDeUso = DateTime.Now;
        }
        /// <summary>
        /// Calcula el costo de el uso de la computadora.
        /// </summary>
        /// <returns></returns>
        private float CalcularCostoDeUso()
        {
            //Pasar todo a segundos y buscar si es modulo de 30?
            int minutosDeUso = TiempoDeUso.Seconds;
            float costo ;
            costo = (minutosDeUso / 30) * costoDeUso;//Divide por 30 la todo el total de minutos y te da cuantos 30 minutos hay
            

            if(minutosDeUso % 30 > 0) //Por mas que los minutos de uso sean menores a 30 te los cobra
                //Si hay sobrante de minutos "redondea" para arriba y te suma otra media hora de costo de uso
            {
                costo += costoDeUso;
            }

            
            return costo; //REVISAR
        }
        /// <summary>
        /// Propiedad que calcula el tiempo de uso de la computadora
        /// </summary>
        public TimeSpan TiempoDeUso //REVISAR ESTA PROPIEDAD
        {
            get
            {
                if(tiempoDeUso != TimeSpan.MinValue)
                {
                    return tiempoDeUso;
                }
                else
                {
                    return inicioDeUso - DateTime.Now;
                }
            } 
            set 
            { 
                if(value > tiempoDeUso)
                {
                    tiempoDeUso = value;// Creo que esta maaal
                }
            } 
        }
        /// <summary>
        /// Muestra la informacion de la Computadora.
        /// </summary>
        /// <returns>devuelve la informacion de la computadora en string</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{base.Mostrar()}");
            sb.AppendFormat($"Tiempo de uso: {00.00}",TiempoDeUso);
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Hardware:");
            foreach (Hardware item in listHardware)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Software:");
            foreach (Software item in listSoftware)
            {
                sb.AppendLine($"{item.ToString()}");
            
            }
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Juegos:");
            foreach (Juegos item in listJuegos)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Perifericos:");
            foreach (Perifericos item in listPerifericos)
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
    }
}

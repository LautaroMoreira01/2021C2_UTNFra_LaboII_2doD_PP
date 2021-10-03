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
        /// <param name="sistemaOperativo"></param>
        /// <param name="identificador"></param>
        /// <param name="tiempoDeUso"></param>
        public Computadora(List<Hardware> hardware , List<Juegos> juegos , List<Software> software 
            , List<Perifericos> perifericos  , SistemasOperativos sistemaOperativo , string identificador , TimeSpan tiempoDeUso )
            : base(identificador)
        {
            this.listHardware = hardware ;
            this.listJuegos = juegos ;
            this.listSoftware = software;
            this.listPerifericos = perifericos;
            this.tiempoDeUso = tiempoDeUso;
        }
        /// <summary>
        /// Calcula el costo de el uso de la computadora.
        /// </summary>
        /// <returns></returns>
        private float CalcularCostoDeUso()
        {
            //Pasar todo a segundos y buscar si es modulo de 30?
            int minutosDeUso = tiempoDeUso.Seconds;
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
        /// Muestra la informacion de la Computadora.
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Equipo: {00.00}",tiempoDeUso);
            sb.AppendFormat($"Tiempo de uso: {00.00}",tiempoDeUso);
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

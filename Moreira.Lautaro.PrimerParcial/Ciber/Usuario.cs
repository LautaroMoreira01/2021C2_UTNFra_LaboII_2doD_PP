using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {   
        
        private DateTime horaDeEntrada;
        private DateTime horaDeSalida;
        private TimeSpan HorasTrabajadas;
        public Usuario(string nombre, string apellido, int edad, long dni) 
            : base( nombre , apellido , edad , dni)
        {

            horaDeEntrada = DateTime.Now; 
            
        }
        public TimeSpan HoraDeEntrada
        {
            get { return new TimeSpan(horaDeEntrada.Hour , horaDeEntrada.Minute, horaDeEntrada.Second); }
        }
        public TimeSpan HoraDeSalida
        {
            
            get 
            {   
                if(horaDeSalida != DateTime.MinValue)
                {
                    return new TimeSpan(horaDeSalida.Hour, horaDeSalida.Minute, horaDeSalida.Second); ;
                }
                else
                {
                    return new TimeSpan(horaDeEntrada.Hour, horaDeEntrada.Minute, horaDeEntrada.Second); 
                }
            }
            set
            {
                TimeSpan hrEntrada = new TimeSpan(horaDeEntrada.Hour, horaDeEntrada.Minute, horaDeEntrada.Second);

                if ( value > hrEntrada)
                {
                    horaDeSalida =
                        new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, value.Hours, value.Minutes, value.Seconds);
                }
            }
        }

        public TimeSpan CalcularHorasTrabajadas
        {
            get {  return HoraDeEntrada - HoraDeSalida ; } 
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Hora de entrada: {horaDeEntrada.Hour}");
            if (horaDeSalida != DateTime.MinValue )//Si la hora de salida no fue inicializada el valor es DateTime.minValue
            {
                sb.AppendLine($"Hora de Salida: {horaDeSalida.Hour}");
                sb.AppendLine($"Horas trabajadas: {CalcularHorasTrabajadas.Hours}:{CalcularHorasTrabajadas.Minutes}");
            }
            return sb.ToString();

        }
        public override string ToString()
        {
            return Mostrar();
        }


    }
}

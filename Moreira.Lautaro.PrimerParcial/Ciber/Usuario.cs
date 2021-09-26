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

            horaDeEntrada = DateTime.Now; //Empieza a contar cuando inicializan la persona
            
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
            set//No se le puede asignar una hora de salida menor que la hora de entrada.
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
            get {  return horaDeEntrada - horaDeSalida ; } 
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Hora de entrada: {horaDeEntrada.Hour}");
            if (horaDeSalida != DateTime.MinValue )
            {
                sb.AppendLine($"Hora de Salida: {horaDeSalida.Hour}");
            }
            sb.AppendLine($"Horas trabajadas: {CalcularHorasTrabajadas}");
            return sb.ToString();


        }
        public override string ToString()
        {
            return Mostrar();
        }


    }
}

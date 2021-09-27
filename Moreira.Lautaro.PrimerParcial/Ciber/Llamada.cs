
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Entidades
{

    public class Llamada
    {
        private bool estado;//Verifica si la llamada esta en curso o ya fue finalizada.
        private string numero;
        private float costoLlamada;
        private DateTime inicioLlamada;
        private TimeSpan duracionLlamada;//VER COMO CALCULAR LA DURACION
        //Podes calcular un random entre 1 y 60 que lo vas a poner y esos van a ser los segundos que va a durar la llamda
        //Puede ser con dos dateTime y un timeSpan
        //o con un timer.
        private ETipoLlamada tipoLlamada;

        public Llamada(string numero)
        {
            this.numero = numero;
            tipoLlamada = TipoLlamada;
            inicioLlamada = DateTime.Now;
            estado = true;

        }
        public bool Estado
        {
            get {return estado; } 
        }
        public string NumeroDestino
        {
            get {return numero; } 
        }

        //Calcula el precio final de la llamada
        public float CostoLlamada
        {
            get
            {
                return Costo() * duracionLlamada.Seconds;//Los segundos cuentan como un minuto
            }
        }
        public ETipoLlamada TipoLlamada
        {
            get          
            {
                ETipoLlamada llamada = ETipoLlamada.Local;

                //numero.Split('-');//Decirle al usuario que tiene que poner el numero sin( -(giones) +(mas) o " " (Espacios))
                
                for (int i = 0; i < numero.Length; i++)
                {
                    if (numero[0] != '5')
                    {
                        llamada = ETipoLlamada.Internacional;
                    }
                    else if (numero[2] != '0' && (numero[2] != '1' && numero[3] != '1'))
                    {
                        llamada = ETipoLlamada.LargaDistancia;
                    }
                    else
                    {
                        llamada = ETipoLlamada.Local;
                    }

                }
                return llamada;

            }

        }
        //metodo que se fija el costo por zona y lo devuelva
        private float Costo()
        {
            if(this.TipoLlamada == ETipoLlamada.Internacional)
            {
                return 5.00F;
            }else if (this.TipoLlamada == ETipoLlamada.LargaDistancia)
            {
                return 2.50F;
            }
            else
            {
                return 1.00F;
            }
        }
        //IDEAS DE COMO CALCULAR EL TIEMPO
        public TimeSpan CalcularDuracion()
        {
            DateTime finLlamada = DateTime.Now;
            TimeSpan duracion = new TimeSpan();
            if (estado == true)
            {
                duracion = inicioLlamada - finLlamada;
                estado = false;
            }
            else
            {
                duracion = this.duracionLlamada;
            }

            return duracion;
        }


        //Metodo finalizar llamada. Deberia devolver la duracion? o  el estado de la llamada
        private bool FinalizarLlamada()
        {
            estado = false;
            return estado;
        }
        //Mostrar LLamada
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"---------------------Llamada---------------------");
            sb.AppendLine($"Numero destino: {numero}");
            if(estado == true)
            {
                sb.AppendLine($"Estado de llamda: En curso");
            }
            else
            {
                sb.AppendLine($"Estado de llamda: Finalizada");
            }
            sb.AppendLine($"Tipo de llamda: {tipoLlamada}");
            sb.AppendLine($"Duracion de llamda: {duracionLlamada}");
            sb.AppendLine($"Coste de llamda: {CostoLlamada}");

            return sb.ToString();
        }

        //public override int GetHashCode()
        //{ }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        public enum ETipoLlamada
        {
            Local,LargaDistancia,Internacional
        }
    }
}

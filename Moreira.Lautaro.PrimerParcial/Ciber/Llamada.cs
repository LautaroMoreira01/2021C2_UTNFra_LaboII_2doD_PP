
using System;
using System.Text;

namespace Entidades
{

    public class Llamada
    {
        private bool llamadaEnCurso;//Verifica si la llamada esta en curso o ya fue finalizada.
        private string numero;
        private float costoLlamada;
        private DateTime inicioLlamada;
        private TimeSpan duracionLlamada;
        private ETipoLlamada tipoLlamada;

        /// <summary>
        /// Propiedad de clase llamada que recibe el numero a llamar.
        /// </summary>
        /// <param name="numero"></param>
        public Llamada(string numero)
        {
            NumeroDestino = numero;
            tipoLlamada = TipoLlamada;
            inicioLlamada = DateTime.Now;
            llamadaEnCurso = true;

        }
        /// <summary>
        /// Retorna el estado de la llamada, true si sigue, false si ya fue finalizada.
        /// </summary>
        public bool Estado
        {
            get {return llamadaEnCurso; } 
        }
        /// <summary>
        /// Retorna el numero de la llamada, -1 si no es un numero valido.
        /// setea el numero si es valido.
        /// </summary>
        public string NumeroDestino
        {
            get
            {
                if(numero != "-1")
                {
                    return numero;
                }
                return "-1";
            }
            
            set
            {
                string auxStrign = FormatearLlamada(value);
                if (auxStrign != "-1")
                {
                    numero = auxStrign;
                }
            }
        }

        /// <summary>
        /// Calcula el costo de la llamada
        /// </summary>
        public float CostoLlamada
        {
            get
            {
                return CostoPorZona * duracionLlamada.Seconds;
        }
        /// <summary>
        /// Retorna el tipo de la llamada.
        /// </summary>
        public ETipoLlamada TipoLlamada
        {
            get 
            {
                string auxLlamada;

                auxLlamada = FormatearLlamada(numero);
                
                if (auxLlamada.StartsWith("54011") || auxLlamada.StartsWith("5411"))
                {
                    return ETipoLlamada.Local;
                }else if(auxLlamada.StartsWith("54") && !auxLlamada.StartsWith("54011") || !auxLlamada.StartsWith("5411"))
                {
                    return ETipoLlamada.LargaDistancia;
                }
                else
                {
                    return ETipoLlamada.Internacional;
                }
            } 

        }
        /// <summary>
        /// Devuelve el costo por minuto de la llamada dependiendo la zona
        /// </summary>
        private float CostoPorZona
        {
            get 
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
        }
        /// <summary>
        /// Calcula la duracion de la llamada.
        /// </summary>
        /// <returns>un time span con la duracion de la llamada</returns>
        private TimeSpan CalcularDuracion()
        {
            DateTime finLlamada = DateTime.Now;
            TimeSpan duracion = new TimeSpan();
            if (llamadaEnCurso == true)
            {
                duracion = inicioLlamada - finLlamada;
                
            }
            else
            {
                duracion = duracionLlamada;
            }

            return duracion;
        }

        /// <summary>
        /// Finaliza la llamada.
        /// </summary>
        /// <returns>Si la llamada esta en curso retorna la informacion de la llamada, si ya fue finalizada lo informa.</returns>
        private string FinalizarLlamada()
        {
            StringBuilder sb = new StringBuilder();

            if (Estado)
            {
                llamadaEnCurso = false;
                sb.Append(Mostrar());
            }
            else
            {
                sb.AppendLine($"La llamada {Mostrar()} ya fue finalizada.");
            }
           
            return sb.ToString() ;

        }
        /// <summary>
        /// Muestra la informacion de la llamada.
        /// </summary>
        /// <returns>retorna un string con la informacion de la llamada.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"---------------------Llamada---------------------");
            sb.AppendLine($"Numero destino: {numero}");
            if(llamadaEnCurso == true)
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
        
        /// <summary>
        /// Valida si la llamada no contiene caracteres incorrectos
        /// </summary>
        /// <param name="numero">numero a validar</param>
        /// <returns>true si es valida, else si no lo es.</returns>
        public static bool ValidarLlamada(string numero)//valida si el numero es correcto
        {
            bool rta = true;
            int aux = 0;
           
            for (int i = 0; i < numero.Length ; i++)
            {
                if ((numero[i] != '+' && numero[i] != '-' && numero[i] != ' ') || int.TryParse(numero[i].ToString() , out aux) == false)
                {
                    rta = false;
                }
            }

            return rta;
        }

        /// <summary>
        /// Formatea la llamada eliminando caracteres que no son numeros. 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>retorna el numero sin caracteres especiales o -1 si no es valido.</returns>
        private static string FormatearLlamada(string numero)//Devuelve solamente el numero sin otros caracteres
        {
            string[] arrayNumero = null;
           
            if (ValidarLlamada(numero))
            {
                arrayNumero = numero.Split('+', '-', ' ');
                return arrayNumero.ToString();
            }
            return "-1";

        }
      
        /// <summary>
        /// Enumerado con los tipos de llamdas.
        /// </summary>
        public enum ETipoLlamada
        {
            Local,LargaDistancia,Internacional
        }

    }
}

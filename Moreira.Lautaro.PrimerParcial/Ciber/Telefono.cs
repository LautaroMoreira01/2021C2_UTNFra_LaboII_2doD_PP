using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Telefono : Equipo
    {
        private ETipo tipo;
        private string numero;
        
        public enum ETipoLlamada //Pasarla a un archivo donde este sola.
        {
            Local, LargaDistancia, Internacional
        }

        /// <summary>
        /// Constructor del telefono
        /// </summary>
        /// <param name="identificador"></param>
        /// <param name="tipo"></param>
        public Telefono( string identificador , ETipo tipo ) : base(identificador)
        {
            this.tipo = tipo;
        }


        /// <summary>
        /// Muestra la informacion del telefono con su llamada.
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()}");
            sb.AppendLine($"Tipo: {Tipo.ToString()}");
            if(numero != null)
            {
                sb.AppendLine($"---------------------Llamada---------------------");
                sb.AppendLine($"Numero destino: {numero}");
                sb.AppendLine($"Tipo de llamda: {TipoLlamada}");

                if (!EstaLibre)
                {
                    sb.AppendLine($"Estado de llamda: En curso");
                }
                else
                {
                    sb.AppendLine($"Duracion de llamda: {TiempoDeUso.Minutes}:{TiempoDeUso.Seconds}");
                    sb.AppendLine($"Coste de llamda: {CalcularCostoDeUso()}");
                    sb.AppendLine($"Estado de llamda: Finalizada");
                }
            }
            return sb.ToString();
        }
        //public string MostrarInformacionLlamadaParaFinalizar()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append($"{base.Mostrar()}");
        //    sb.AppendLine($"Tipo: {Tipo.ToString()}");
        //    if (numero != null)
        //    {
        //        sb.AppendLine($"---------------------Llamada---------------------");
        //        sb.AppendLine($"Numero destino: {numero}");
        //        sb.AppendLine($"Tipo de llamda: {TipoLlamada}");

        //        sb.AppendLine($"Estado de llamda: En curso");
                
        //        else
        //        {
        //            sb.AppendLine($"Duracion de llamda: {TiempoDeUso.Minutes}:{TiempoDeUso.Seconds}");
        //            sb.AppendLine($"Coste de llamda: {CalcularCostoDeUso()}");
        //            sb.AppendLine($"Estado de llamda: Finalizada");
        //        }
        //    }
        //    return sb.ToString();

        //}
        protected override float CalcularCostoDeUso()
        {

            return (float)(CostoPorZona * (((int)TiempoDeUso.TotalSeconds) + (((int)TiempoDeUso.TotalMinutes) * 60)));
        }
    
        /// <summary>
        /// Retorna el numero de la llamada si no fue inicializada retorna -1.
        /// </summary>
        public string NumeroLlamada
        {
            get
            {
                if(numero != null)
                {
                    return numero;
                }
                else
                {
                    return "-1";
                }
            }
            set
            {
                if (ValidarNumeroLlamada(value))
                {
                    numero = value;
                }
                
            }  
        }

        public ETipo Tipo
        {
            get { return tipo; }
        }

        /// <summary>
        /// Valida si la llamada no contiene caracteres incorrectos
        /// </summary>
        /// <param name="numero">numero a validar</param>
        /// <returns>true si es valida, false si no lo es.</returns>


        public static bool ValidarNumeroLlamada(string numero)
        {
            bool rta = true;
            int aux = 0;
            if(numero.Length >= 12)
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    if ((numero[i] != '+' && numero[i] != '-' && numero[i] != ' ') && int.TryParse(numero[i].ToString(), out aux) == false)
                    {
                    rta = false;
                    }
                }
            }
            else
            {
                rta = false;
            }

            return rta;
        }
        private static string FormatearNumero(string numero)
        {
            string[] arrayNumero = null;
            string rta = "";

            if (ValidarNumeroLlamada(numero))
            {
                arrayNumero = numero.Split('+', '-', ' ');
                rta = string.Concat(arrayNumero);
                //rta = arrayNumero.Join("", arrayNumero);
            }
            return rta;

        }
        /// <summary>
        /// Sobrescritura del metodo tostring 
        /// </summary>
        /// <returns>Informacion del telefono en string</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Devuelve el costo por minuto de la llamada dependiendo la zona
        /// </summary>

        private float CostoPorZona
        {
            get
            {
                ETipoLlamada tipoDeLlamada = TipoLlamada;
                if (tipoDeLlamada == ETipoLlamada.Internacional)
                {
                    return 5.00F;
                }
                else if (tipoDeLlamada == ETipoLlamada.LargaDistancia)
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
        /// Retorna el tipo de la llamada.
        /// </summary>
        public ETipoLlamada TipoLlamada
        {
            get
            {
                string auxLlamada;

                auxLlamada = FormatearNumero(numero);

                if (auxLlamada.StartsWith("54011") || auxLlamada.StartsWith("5411"))
                {
                    return ETipoLlamada.Local;
                }
                else if (auxLlamada.StartsWith("54") == true && (auxLlamada.StartsWith("54011") == false || auxLlamada.StartsWith("5411") == false) )
                {
                    return ETipoLlamada.LargaDistancia;
                }
                else
                {
                    return ETipoLlamada.Internacional;
                }
            }

        }
        public override string FinalizarSesion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------Llamada-----------");
            sb.AppendLine($"Tipo de llamada: {TipoLlamada}");
            sb.AppendLine($"Costo por minuto: {CostoPorZona}");
            sb.AppendLine(base.FinalizarSesion());
            
            return sb.ToString() ;
        }
        /// <summary>
        /// Enum con los tipos de telefonos
        /// </summary>
        public enum ETipo
        {
            None,ADisco, Teclado
        }

    }
}

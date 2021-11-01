using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {

        protected bool estaLibre;
        protected string identificador;
        protected Cliente cliente;
        protected TimeSpan tiempoDeUso;
        protected DateTime inicioDeUso;

        /// <summary>
        /// Constructor de la clase Equipo, inicializa el estado en true y el cliente en null.
        /// </summary>
        /// <param name="identificador"></param>
        public Equipo(string identificador)
        {
            estaLibre = true;
            this.identificador = identificador;
            //inicioDeUso = DateTime.Now;//Para las computadoras y telefonos que no tienen un tiempo determinado.
        }

        /// <summary>
        /// getter y setter que develve o asigna si un equipo esta libre 
        /// </summary>
        public bool EstaLibre
        {
            get { return estaLibre; }
            set { estaLibre = value;}
        
        }

        /// <summary>
        /// Propiedad que retorna el costo de uso del equipo
        /// </summary>
        public float CostoDeUso
        {
            get { return CalcularCostoDeUso(); } 
        }


        /// <summary>
        /// Retorna o asigna el cliente de la computadora.
        /// </summary>
        public Cliente Cliente 
        {
            get 
            { 
                return cliente; 
            }
            set
            {
                if (estaLibre)
                {
                    cliente = value; 
                } 
            } 
        }
        
        /// <summary>
        /// Retorna el identificador del equipo
        /// </summary>
        public string Identificador
        {
            get { return identificador; }
        }
        
        /// <summary>
        /// Devuelve la informacion del equipo.
        /// </summary>
        /// <returns>Informacion del equipo</returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name.ToUpper()}");
            sb.AppendLine($"Identificador: {this.identificador.ToUpper()}");
            if (estaLibre)
            {
                sb.AppendLine($"Estado: LIBRE.");
            }
            else
            {
                sb.AppendLine($"Estado: OCUPADO.");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Propiedad que calcula el tiempo de uso del equipo.
        /// </summary>
        public TimeSpan TiempoDeUso 
        {
            get
            {
                if(tiempoDeUso == new TimeSpan(0, 0, 0, 0, 0))
                {
                    return  DateTime.Now - inicioDeUso;
                }
                return tiempoDeUso;
            }
            set
            {
                tiempoDeUso = new TimeSpan(0, (int)value.TotalMinutes , (int)value.TotalSeconds );
            }

        }

        /// <summary>
        /// Finaliza la sesion del equipo retornando informacion del costo de uso neto y bruto
        /// </summary>
        /// <returns>string con la informacion de la llamada finalizada</returns>
        public virtual string FinalizarSesion()
        {
            StringBuilder sb = new StringBuilder();

            if(!EstaLibre)
            {
                EstaLibre = true;
                sb.AppendFormat($"Tiempo de uso: {TiempoDeUso.Minutes}:{TiempoDeUso.Seconds}\n" );
                sb.AppendLine($"Costo de uso (bruto): {CalcularCostoDeUso()}");
                sb.AppendLine($"Costo de uso a pagar (neto): {CalcularCostoDeUso() * 1.21}");
            }
            else
            {
                sb.AppendLine("El equipo no esta siendo utilizado.");
            }
            return sb.ToString();
        }
        
        /// <summary>
        /// Calcula el costo de uso del equipo
        /// </summary>
        /// <returns>float con el costo de uso del equipo</returns>
        protected abstract float CalcularCostoDeUso();

        /// <summary>
        /// si el equipo esta libre asigna un cliente al equipo
        /// </summary>
        /// <param name="cliente">cliente a asignar</param>
        /// <returns>True si el cliente fue asignado false si no</returns>
        public bool AsignarClienteAEquipo(Cliente cliente)
        {
            bool rta = false;

            if (EstaLibre)
            {
                inicioDeUso = DateTime.Now;
                Cliente = cliente;
                EstaLibre = false;
                rta = true;
            }
            return rta;
        }

        //Pensa como refactorizar esto

        /// <summary>
        /// si el equipo esta libre asigna un cliente al equipo
        /// </summary>
        /// <param name="cliente">cliente a asignar</param>
        /// <param name="tiempoDeUso">tiempo de uso del cliente en la maquina</param>
        /// <returns>True si el cliente fue asignado false si no</returns>
        public bool AsignarClienteAEquipo(Cliente cliente , TimeSpan tiempoDeUso)
        {
            bool rta = false;
            if (EstaLibre)
            {
                Cliente = cliente;
                this.tiempoDeUso = tiempoDeUso;
                EstaLibre = false;
                rta = true;
            }
            return rta;
        }

        /// <summary>
        /// Compara dos equipos por tiempo de uso
        /// </summary>
        /// <param name="e1">equipo uno a comparar</param>
        /// <param name="e2">equipo dos a comparar</param>
        /// <returns>1 si el equipo 1 es mas grande que el equipo dos, 0 si son iguales, -1 si el equipo uno es mas chico que el equipo dos </returns>
        public static int CompararEquiposPorMinutosDeUso(Equipo e1, Equipo e2)
        {
            if (e1.TiempoDeUso > e2.TiempoDeUso)
            {
                return 1;
            }
            else if (e1.TiempoDeUso < e2.TiempoDeUso)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
 
    }
}


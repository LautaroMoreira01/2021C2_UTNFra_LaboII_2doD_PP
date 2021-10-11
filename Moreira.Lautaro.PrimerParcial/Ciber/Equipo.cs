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
        protected abstract float CalcularCostoDeUso();

        public bool AsignarClienteAEquipo(Cliente cliente)
        {
            bool rta = false;
            if (EstaLibre)
            {
                Cliente = cliente;
                inicioDeUso = DateTime.Now;
                EstaLibre = false;
                rta = true;
            }
            return rta;
        }
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
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        
        private bool estaLibre;
        private string identificador;
        private Cliente cliente;
        /// <summary>
        /// Constructor de la clase Equipo, inicializa el estado en true y el cliente en null.
        /// </summary>
        /// <param name="identificador"></param>
        public Equipo(string identificador )
        {
            this.estaLibre = true;
            this.identificador = identificador;
            cliente = null;
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
                if (this.estaLibre == true)
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
    }
}


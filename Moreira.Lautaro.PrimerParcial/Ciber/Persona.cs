using System;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected long dni ;
        /// <summary>
        /// Propiedad que retorna la edad de la persona
        /// </summary>
        public int Edad { get {return edad ; }  }
        /// <summary>
        /// Propiedad que retorna el dni de la persona
        /// </summary>
        public long Dni{ get {return dni ; }  }
        /// <summary>
        /// Propiedad que retorna el nomnre de la persona
        /// </summary>
        public string Nombre { get {return nombre; }  }
        /// <summary>
        /// Propiedad que retorna el apellido de la persona
        /// </summary>
        public string Apellido { get {return apellido; }  }

        /// <summary>
        /// Constructor de persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, string apellido, int edad , long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        //El método Mostrar de Persona ¿qué muestra?. El nombre tiene que ser descriptivo
        /// <summary>
        /// Metodo mostrar  de persona que retorna la informacion.
        /// </summary>
        /// <returns>Informacion de la persona en un string</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {Nombre}, ");
            sb.Append($"Apellido: {apellido}, ");
            sb.Append($"Edad: {edad}, ");
            sb.AppendLine($"DNI: {dni}");

            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del operador == que compara las personas por nombre y dni
        /// </summary>
        /// <param name="p1">Primera persona a comparar</param>
        /// <param name="p2">Segunda persona a comparar</param>
        /// <returns>True si son iguales, de contrario false.</returns>
        public static bool operator ==(Persona p1 , Persona p2)
        {
            return (p1.nombre == p2.nombre && p1.dni == p2.dni);            
        }
        /// <summary>
        /// Sobrecarga del operador != que compara dos personas
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>True si son distintas, false si son iguales</returns>
        public static bool operator !=(Persona p1 , Persona p2)
        {
            return !(p1 == p2);            
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override int GetHashCode()
        {
            return this.Nombre.GetHashCode() + this.apellido.GetHashCode();
        }
    }
}

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

        public int Edad { get {return edad ; }  }
        public long Dni{ get {return dni ; }  }
        public string Nombre { get {return nombre; }  }
        public string Apellido { get {return apellido; }  }

        public Persona(string nombre, string apellido, int edad , long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }
        //Capaz este no va 
        public Persona(string nombre, int edad, long dni) : this(nombre , "" , edad , dni)
        {
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.Append($"Edad: {edad}");
            sb.Append($"DNi: {dni}");

            return sb.ToString();
        }

        public static bool operator ==(Persona p1 , Persona p2)
        {
            return (p1.nombre == p2.nombre && p1.dni == p2.dni);            
        }
        public static bool operator !=(Persona p1 , Persona p2)
        {
            return !(p1 == p2);            
        }

    }
}

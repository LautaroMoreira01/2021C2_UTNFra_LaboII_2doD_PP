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

        //El método Mostrar de Persona ¿qué muestra?. El nombre tiene que ser descriptivo.
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"------------------------------------------");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"DNI: {dni}");

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

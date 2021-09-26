using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int posicionEnLaFila;
        List<List<string>> requerimientos; 

//        private int posicionEnLaFila;
//      preguntar si los requerimientos se cargan cuando inicializan la clase o cuando se crea el programa
        public Cliente(string nombre, string apellido, int edad , long dni) : base(nombre, apellido, edad , dni)
        {}
        public int PosicionEnLaFila
        {
            get { return posicionEnLaFila; }
            set { posicionEnLaFila = value; }
        }
        public List<List<string>> Requerimientos
        {
            get {return this.requerimientos; }
        }

        public override string Mostrar()
        {

            return base.Mostrar();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}

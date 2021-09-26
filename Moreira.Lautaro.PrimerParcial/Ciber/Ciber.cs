using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciber
    {
        private List<Cliente> clientes; // Tiene que ser una queue
        private List<Computadora> computadoras;
        private List<Telefono> telefonos;
        private Usuario empleado;

        public Ciber(List<Cliente> clientes, List<Computadora> computadoras, List<Telefono> telefonos, Usuario empleado)
        {
            this.clientes = clientes;
            this.computadoras = computadoras;
            this.telefonos = telefonos;
            this.empleado = empleado;
        
        }
    }
}

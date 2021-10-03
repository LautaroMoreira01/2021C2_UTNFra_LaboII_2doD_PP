using System;
using System.Collections.Generic;
using Entidades;

namespace TestFuncionalidadesCiber
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario("ElPibe", "QueAtiende", 24, 40325651);

            Queue<Cliente> clientes = new Queue<Cliente>();
 
            Cliente c1 = new Cliente("Lautaro", "Moreira", 20, 45689465);
            Cliente c2 = new Cliente("Juan", "Perez", 25, 23214567);
            Cliente c3 = new Cliente("Carlos", "Riquelme", 40, 15023456);

            clientes.Enqueue(c1);
            clientes.Enqueue(c2);
            clientes.Enqueue(c3);

    

            //Ciber elVicio = new Ciber(clientes,usuario);

            Console.WriteLine(elVicio.MostrarClientesEnEspera());
            Console.WriteLine(elVicio.MostrarComputadoras());
            Console.WriteLine(elVicio.MostrarTelefonos());

            Console.ReadKey();

        }
    }
}

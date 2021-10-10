using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciber
    {
        //private List<Computadora> historialComputadoras;
       // private List<Telefono> historialTelefonos;

        private Queue<Cliente> clientes; 
        private List<Computadora> computadoras;
        private List<Telefono> telefonos;
        private Usuario empleado;

        public Ciber(Queue<Cliente> clientes, List<Computadora> computadoras, List<Telefono> telefonos, Usuario empleado)
        {
            this.clientes = clientes;
            this.computadoras = computadoras;
            this.telefonos = telefonos;
            this.empleado = empleado;
        
        }
        /// <summary>
        /// Muestra los clientes en espera
        /// </summary>
        /// <returns>String con los clientes en espera</returns>
        public string MostrarClientesEnEsperaSinRequerimientos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"----------------------------------Clientes en espera----------------------------------");

            foreach (Cliente item in clientes)
            {
                if (item.EnEspera)
                {
                    sb.Append($"{item.Mostrar()}");
                }
            }

            return sb.ToString();
        }
        public string MostrarClientesEnEsperaConRequerimientos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"----------------------------------Clientes en espera----------------------------------");

            foreach (Cliente item in clientes)
            {
                if (item.EnEspera)
                {
                    sb.Append($"{item.MostrarClienteConRequerimientos()}");
                }
            }

            return sb.ToString();
        }
        /// <summary>
        /// Muestra la informacion de las computadoras
        /// </summary>
        /// <returns></returns>
        public string MostrarComputadoras()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"----------------------------------Computadoras----------------------------------");

            foreach (Computadora item in computadoras)
            {
                if (item.EstaLibre)
                {
                    sb.Append($"{item}");
                }
            }

            return sb.ToString();
        }
        /// <summary>
        /// Muestra la iformacion de los telefonos
        /// </summary>
        /// <returns></returns>
        public string MostrarTelefonos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"----------------------------------Telefonos----------------------------------");

            foreach (Telefono item in telefonos)
            {
                if (item.EstaLibre)
                {
                    sb.Append($"{item}");
                }
            }

            return sb.ToString();
        }
        public bool VerificarSiLaComputadoraTieneLosRequisitosDelCliente(Computadora computadora, Cliente cliente )
        {
            bool aux = false;
            bool cumpleRequerimientosHardware = true;
            bool cumpleRequerimientosSoftware = true;
            bool cumpleRequerimientosJuegos = true;
            bool cumpleRequerimientosPerifericos = true;
            bool cumpleTodosRequerimientos = false ;

            if (cliente.RequerimientosHarware != null && cliente.RequerimientosHarware.Count > 0 && computadora.ListHardware != null)
            {
                foreach (Hardware hardwareCliente in cliente.RequerimientosHarware)
                { 
                    foreach(Hardware harwareComputadora in computadora.ListHardware)
                    {
                        if(hardwareCliente == harwareComputadora)
                        {
                            aux = true;
                            break;
                        }

                    }

                    if (!aux)
                    {
                        cumpleRequerimientosHardware = false;
                    }

                    aux = false;
                }

            }
            if (cliente.RequerimientosSoftware!= null && computadora.ListSoftware!= null)
            {
                foreach (Software softwareCliente in cliente.RequerimientosSoftware)
                {
                    foreach (Software softwareComputadora in computadora.ListSoftware)
                    {
                        if ( softwareCliente == softwareComputadora)
                        {
                            aux = true;
                        }
                    }

                    if (!aux)
                    {
                        cumpleRequerimientosSoftware = false;
                    }
                    aux = false;
                }

            }
            if (cliente.RequerimientosJuegos != null && computadora.ListJuegos != null)
            {
                foreach (Juegos juegosCliente in cliente.RequerimientosJuegos)
                {
                    foreach (Juegos juegosComputadora in computadora.ListJuegos)
                    {
                        if ( juegosCliente == juegosComputadora)
                        {
                            aux = true;
                        }

                    }

                    if (!aux)
                    {
                        cumpleRequerimientosJuegos= false;
                    }
                    aux = false;
                }
            }
            if (cliente.RequerimientosPerifericos != null && computadora.ListPerifericos != null)
            {
                foreach (Perifericos perifericosCliente in cliente.RequerimientosPerifericos)
                {
                    foreach (Perifericos perifericosComputadora in computadora.ListPerifericos)
                    {
                        if ( perifericosComputadora == perifericosCliente)
                        {
                            aux = true;
                        }

                    }

                    if (!aux)
                    {
                        cumpleRequerimientosPerifericos = false;
                    }
                    aux = false;
                }

            }

            if(cumpleRequerimientosHardware && cumpleRequerimientosJuegos && cumpleRequerimientosPerifericos && cumpleRequerimientosSoftware)
            {
                cumpleTodosRequerimientos = true;
            }


            return cumpleTodosRequerimientos;
        }


        public List<Computadora> ListaComputadoras 
        {
            get { return computadoras; }
        }
        public List<Telefono> ListaTelefonos
        {
            get { return telefonos; }
        }
        public Queue<Cliente> ListaClientes
        {
            get { return clientes ; }
        }

    }
}

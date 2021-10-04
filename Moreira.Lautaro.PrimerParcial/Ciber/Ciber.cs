﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciber
    {
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
        public string MostrarClientesEnEspera()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"----------------------------------Clientes en espera----------------------------------");

            foreach (Cliente item in clientes)
            {
                if (item.EnEspera)
                {
                    sb.Append($"{item}");
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciber
    {

        private Queue<Cliente> clientes; 
        private List<Cliente> historialClientes;
        private List<Telefono> historialTelefonos;
        private List<Computadora> historialComputadoras;
        private List<Computadora> computadoras;
        private Telefono[] telefonos;
        private Usuario empleado;

        /// <summary>
        /// Constructor privado de ciber que inicializa las listas.
        /// </summary>
        private Ciber()
        {
            historialComputadoras = new List<Computadora>();
            historialTelefonos = new List<Telefono>();
            historialClientes = new List<Cliente>();
        }

        /// <summary>
        /// Constructor de ciber que carga las listas y el usuario.
        /// </summary>
        /// <param name="clientes"> carga la lista de clientes</param>
        /// <param name="computadoras">carga la lista de computadoras</param>
        /// <param name="telefonos">carga la lista de telefonos</param>
        /// <param name="empleado">empleados</param>
        public Ciber(Queue<Cliente> clientes, List<Computadora> computadoras, List<Telefono> telefonos, Usuario empleado) : this()
        {
            this.clientes = clientes;
            this.computadoras = computadoras;
            this.telefonos = telefonos.ToArray();
            this.empleado = empleado;
            CargarHistorial();
        }

        /// <summary>
        /// Carga el historial del ciber
        /// </summary>
        private void CargarHistorial()
        {
            ClienteComputadora c1 = new ClienteComputadora("Ricardo", "Montaner", 45, 35545445);
            ClienteComputadora c2 = new ClienteComputadora("Juan", "Perez", 12, 45221321);
            ClienteComputadora c3 = new ClienteComputadora("Martin", "Gonzales", 15, 43265454);
            ClienteComputadora c4 = new ClienteComputadora("Pablo", "Gomez", 25, 45213215);
            ClienteComputadora c5 = new ClienteComputadora("Brian", "Vilardo", 20, 45545445);
            ClienteComputadora c6 = new ClienteComputadora("Mauro", "Monzon", 25, 43548987);
            ClienteComputadora c7 = new ClienteComputadora("Damian", "Perez", 45, 12654789);
            ClienteComputadora c8 = new ClienteComputadora("Tomas", "Gonzales", 44, 15578945);
            ClienteComputadora c9 = new ClienteComputadora("Lucas", "Palacios", 42, 12154879);
            ClienteComputadora c10 = new ClienteComputadora("Marcelo", "Birriel", 31, 15489789);
            ClienteTelefono c11 = new ClienteTelefono("Pablo", "Moreira", 25, 12345789, ETipo.Teclado);
            ClienteTelefono c12 = new ClienteTelefono("karina", "Perez", 14, 15879874, ETipo.Teclado);
            ClienteTelefono c13 = new ClienteTelefono("Victoria", "Jara", 12, 35545445, ETipo.ADisco);
            ClienteTelefono c14 = new ClienteTelefono("Agustin", "Moreira", 47, 47854213);
            ClienteTelefono c15 = new ClienteTelefono("Luis", "Perez", 52, 25365897);

            if (c1 + Hardware.Ram64MB) { }
            if (c1 + Hardware.PlacaVideo) { }
            if (c1 + Juegos.HalfLife) { }
            if (c1 + Software.Office) { }
            if (c2 + Software.Office) { }
            if (c3 + Hardware.LectorDisquetes) { }
            if (c3 + Juegos.Halo) { }
            if (c4 + Hardware.PlacaVideo) { }
            if (c4 + Juegos.TheSimpsonsHitAndRun) { }
            if (c5 + Perifericos.Auriculares) { }
            if (c5 + Perifericos.Microfono) { }
            if (c6 + Juegos.TheSims) { }
            if (c6 + Perifericos.Microfono) { }
            if (c8 + Hardware.PlacaVideo) { }
            if (c8 + Juegos.HalfLife) { }
            if (c8 + Perifericos.Microfono) { }

            Computadora computadora1 = new Computadora(
            new List<Hardware>() { Hardware.CPUAMDPhenom, Hardware.Ram64MB, Hardware.LectorDisquetes, Hardware.PlacaVideo },
            new List<Juegos>() { Juegos.TonyHawkProSkaterII, Juegos.TheSims, Juegos.GTAIII, Juegos.ResidentEvil },
            new List<Software>() { Software.InternetExplorer, Software.NetScape, Software.MSN, Software.Office },
            new List<Perifericos>() { Perifericos.Auriculares, Perifericos.Microfono },
            "C01");
            Computadora computadora2 = new Computadora(
                new List<Hardware>() { Hardware.CPUCore2Quad, Hardware.Ram32MB, Hardware.LectorCd, Hardware.TarjetaSonido },
                new List<Juegos>() { Juegos.DiabloII, Juegos.GodOfWar, Juegos.HalfLife },
                new List<Software>() { Software.InternetExplorer, Software.MSN, Software.Paint ,Software.Office },
                new List<Perifericos>() { Perifericos.Camara, Perifericos.Parlantes, Perifericos.Microfono, Perifericos.joystick },
                "C02");
            Computadora computadora3 = new Computadora(
                new List<Hardware>() { Hardware.CPUAMDPhenom, Hardware.Ram64MB, Hardware.LectorDisquetes, Hardware.TarjetaSonido },
                new List<Juegos>() { Juegos.Halo, Juegos.ResidentEvil, Juegos.HalfLife },
                new List<Software>() { Software.InternetExplorer, Software.MSN, Software.Paint },
                new List<Perifericos>() { Perifericos.Parlantes, Perifericos.Microfono, Perifericos.joystick },
                "C03");
            Computadora computadora4 = new Computadora(
                new List<Hardware>() { Hardware.CPUCore2Quad, Hardware.Ram64MB, Hardware.PlacaVideo },
                new List<Juegos>() { Juegos.Halo, Juegos.WOW, Juegos.TheSimpsonsHitAndRun },
                new List<Software>() { Software.InternetExplorer, Software.MSN, Software.Paint },
                new List<Perifericos>() { Perifericos.Camara, Perifericos.Auriculares, Perifericos.Microfono, Perifericos.joystick },
                "C04");
            Computadora computadora5 = new Computadora(
                new List<Hardware>() { Hardware.CPUCore2Quad, Hardware.Ram32MB, Hardware.TarjetaSonido },
                new List<Juegos>() { Juegos.MetalGearSolid, Juegos.WOW, Juegos.ResidentEvil },
                new List<Software>() { Software.InternetExplorer, Software.Encarta, Software.NetScape },
                new List<Perifericos>() { Perifericos.Camara, Perifericos.Auriculares, Perifericos.Microfono, Perifericos.joystick },
                "C05");
            Computadora computadora6 = new Computadora(
                new List<Hardware>() { Hardware.CPUAMDPhenom, Hardware.Ram32MB, Hardware.TarjetaSonido, Hardware.PlacaVideo },
                new List<Juegos>() { Juegos.ResidentEvil, Juegos.TheSims, Juegos.GTAIII, Juegos.SnowBros },
                new List<Software>() { Software.InternetExplorer, Software.Ares, Software.NetScape, Software.Office },
                new List<Perifericos>() { Perifericos.Parlantes, Perifericos.Camara, Perifericos.Microfono },
                "C06");
            Computadora computadora7 = new Computadora(
                new List<Hardware>() { Hardware.CPUCore2Quad, Hardware.Ram32MB, Hardware.TarjetaSonido },
                new List<Juegos>() { },
                new List<Software>() { Software.InternetExplorer, Software.MSN, Software.Paint },
                new List<Perifericos>() { Perifericos.Camara, Perifericos.Parlantes, Perifericos.Microfono, Perifericos.joystick },
                "C07");
            Computadora computadora8 = new Computadora(
                new List<Hardware>() { Hardware.CPUAMDPhenom, Hardware.Ram32MB, Hardware.TarjetaSonido, Hardware.PlacaVideo },
                new List<Juegos>() { Juegos.Halo, Juegos.ResidentEvil, Juegos.HalfLife, Juegos.GTAIII, Juegos.DBZBudokaiTenkaichi3 },
                new List<Software>() { Software.InternetExplorer, Software.MSN, Software.Paint, Software.Encarta, Software.MySpace },
                new List<Perifericos>() { Perifericos.Parlantes, Perifericos.Microfono, Perifericos.joystick, Perifericos.Auriculares },
                "C08");
            Computadora computadora9 = new Computadora(
                new List<Hardware>() { Hardware.CPUCore2Quad, Hardware.Ram64MB, Hardware.PlacaVideo },
                new List<Juegos>() { Juegos.Halo, Juegos.WOW, Juegos.TheSimpsonsHitAndRun },
                new List<Software>() { Software.InternetExplorer, Software.MSN, Software.Paint },
                new List<Perifericos>() { Perifericos.Camara, Perifericos.Auriculares, Perifericos.Microfono, Perifericos.joystick },
                "C09");
            Computadora computadora10 = new Computadora(
                new List<Hardware>() { Hardware.CPUCore2Quad, Hardware.Ram32MB, Hardware.TarjetaSonido },
                new List<Juegos>() { Juegos.MetalGearSolid, Juegos.WOW, Juegos.ResidentEvil },
                new List<Software>() { Software.InternetExplorer, Software.Encarta, Software.NetScape },
                new List<Perifericos>() { Perifericos.Camara, Perifericos.Auriculares, Perifericos.Microfono },
                "C10");

            historialClientes.Add(c1);
            historialClientes.Add(c2);
            historialClientes.Add(c3);
            historialClientes.Add(c4);
            historialClientes.Add(c5);
            historialClientes.Add(c6);
            historialClientes.Add(c7);
            historialClientes.Add(c8);
            historialClientes.Add(c9);
            historialClientes.Add(c10);
            historialClientes.Add(c11);
            historialClientes.Add(c12);
            historialClientes.Add(c13);
            historialClientes.Add(c14);
            historialClientes.Add(c15);

            historialComputadoras.Add(computadora1);
            historialComputadoras.Add(computadora2);
            historialComputadoras.Add(computadora3);
            historialComputadoras.Add(computadora4);
            historialComputadoras.Add(computadora5);
            historialComputadoras.Add(computadora6);
            historialComputadoras.Add(computadora7);
            historialComputadoras.Add(computadora8);
            historialComputadoras.Add(computadora9);
            historialComputadoras.Add(computadora10);

            
            historialComputadoras[0].AsignarClienteAEquipo(c1, new TimeSpan(0, 2, 45));
            historialComputadoras[1].AsignarClienteAEquipo(c2, new TimeSpan(0, 1, 32));
            historialComputadoras[2].AsignarClienteAEquipo(c3, new TimeSpan(0, 3, 0));
            historialComputadoras[3].AsignarClienteAEquipo(c4, new TimeSpan(0, 4, 0));
            historialComputadoras[4].AsignarClienteAEquipo(c5, new TimeSpan(0, 3, 12));
            historialComputadoras[5].AsignarClienteAEquipo(c6, new TimeSpan(0, 1, 45));
            historialComputadoras[6].AsignarClienteAEquipo(c7, new TimeSpan(0, 1, 10));
            historialComputadoras[7].AsignarClienteAEquipo(c8, new TimeSpan(0, 2, 10));
            historialComputadoras[8].AsignarClienteAEquipo(c9, new TimeSpan(0, 4, 35));
            historialComputadoras[9].AsignarClienteAEquipo(c10, new TimeSpan(0, 3, 5));

            Telefono t1 = new Telefono("T01", ETipo.ADisco);
            Telefono t2 = new Telefono("T02", ETipo.Teclado);
            Telefono t3 = new Telefono("T03", ETipo.ADisco);
            Telefono t4 = new Telefono("T04", ETipo.Teclado);
            Telefono t5 = new Telefono("T05", ETipo.Teclado);

            historialTelefonos.Add(t1);
            historialTelefonos.Add(t2);
            historialTelefonos.Add(t3);
            historialTelefonos.Add(t4);
            historialTelefonos.Add(t5);

            historialTelefonos[0].AsignarClienteAEquipo(c11, new TimeSpan(0, 0, 55));
            historialTelefonos[0].NumeroLlamada = "5401142157898";
            historialTelefonos[0].EstaLibre = true;
            historialTelefonos[1].AsignarClienteAEquipo(c12, new TimeSpan(0, 0, 12));
            historialTelefonos[1].NumeroLlamada = "4411144557898";
            historialTelefonos[1].EstaLibre = true;
            historialTelefonos[2].AsignarClienteAEquipo(c13, new TimeSpan(0, 0, 35));
            historialTelefonos[2].NumeroLlamada = "544578987854";
            historialTelefonos[2].EstaLibre = true;
            historialTelefonos[3].AsignarClienteAEquipo(c14, new TimeSpan(0, 0, 24));
            historialTelefonos[3].NumeroLlamada = "2145879887544";
            historialTelefonos[3].EstaLibre = true;
            historialTelefonos[4].AsignarClienteAEquipo(c15, new TimeSpan(0, 0, 13));
            historialTelefonos[4].NumeroLlamada = "1245876545452";
            historialTelefonos[4].EstaLibre = true;
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
                    sb.Append($"{item.MostrarInformacionPersonal()}");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Muestra los clientes con los requerimientos que poseen
        /// </summary>
        /// <returns>retorna un string con los datos del cliente y sus requerimientos.</returns>
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
        /// <summary>
        /// Verifica si la computadora tiene los componentes que pide el cliente
        /// </summary>
        /// <param name="computadora">computadora a verificar</param>
        /// <param name="cliente">cliente que pide los requerimientos</param>
        /// <returns>true si cumple todos los requerimientos false si no los cumple</returns>
        public bool VerificarSiLaComputadoraTieneLosRequisitosDelCliente(Computadora computadora, ClienteComputadora cliente )
        {
            bool cumpleRequerimientosHardware = VerificarSiCumpleRequisitosHardware(cliente, computadora);
            bool cumpleRequerimientosSoftware = VerificarSiCumpleRequisitosSoftware(cliente , computadora);
            bool cumpleRequerimientosJuegos = VerificarSiCumpleRequisitosJuegos(cliente, computadora);
            bool cumpleRequerimientosPerifericos = VerificarSiCumpleRequisitosPerifericos(cliente, computadora);
            bool cumpleTodosRequerimientos = false ;

            if(cumpleRequerimientosHardware && cumpleRequerimientosJuegos && cumpleRequerimientosPerifericos && cumpleRequerimientosSoftware)
            {
                cumpleTodosRequerimientos = true;
            }

            return cumpleTodosRequerimientos;
        }

        /// <summary>
        /// Verifica si la computadora cumple con los requerimientos de hardware del cliente
        /// </summary>
        /// <param name="cliente">cliente que pide los requerimientos</param>
        /// <param name="computadora">computadora a verificar</param>
        /// <returns>true si cumple los requerimientos false si no los cumple</returns>
        private bool VerificarSiCumpleRequisitosHardware(ClienteComputadora cliente , Computadora computadora)
        {
            bool aux = false;
            bool rta = true;
            if (cliente.RequerimientosHarware != null && cliente.RequerimientosHarware.Count > 0 && computadora.ListHardware != null)
            {
                foreach (Hardware hardwareCliente in cliente.RequerimientosHarware)
                {
                    foreach (Hardware harwareComputadora in computadora.ListHardware)
                    {
                        if (hardwareCliente == harwareComputadora)
                        {
                            aux = true;
                            break;
                        }

                    }

                    if (!aux)
                    {
                        rta = false;
                    }

                    aux = false;
                }

            }
            return rta;
        }

        /// <summary>
        /// Verifica si la computadora cumple con los requerimientos de software del cliente
        /// </summary>
        /// <param name="cliente">cliente que pide los requerimientos</param>
        /// <param name="computadora">computadora a verificar</param>
        /// <returns>true si cumple los requerimientos false si no los cumple</returns>
        private bool VerificarSiCumpleRequisitosSoftware(ClienteComputadora cliente, Computadora computadora)
        {
            bool aux = false;
            bool rta = true;
            if (cliente.RequerimientosSoftware != null && computadora.ListSoftware != null)
            {
                foreach (Software softwareCliente in cliente.RequerimientosSoftware)
                {
                    foreach (Software softwareComputadora in computadora.ListSoftware)
                    {
                        if (softwareCliente == softwareComputadora)
                        {
                            aux = true;
                        }
                    }

                    if (!aux)
                    {
                        rta = false;
                    }
                    aux = false;
                }

            }
            return rta;
        }

        /// <summary>
        /// Verifica si la computadora cumple con los requerimientos de juegos del cliente
        /// </summary>
        /// <param name="cliente">cliente que pide los requerimientos</param>
        /// <param name="computadora">computadora a verificar</param>
        /// <returns>true si cumple los requerimientos false si no los cumple</returns>
        private bool VerificarSiCumpleRequisitosJuegos(ClienteComputadora cliente, Computadora computadora)
        {
            bool aux = false;
            bool rta = true;

            if (cliente.RequerimientosJuegos != null && computadora.ListJuegos != null)
            {
                foreach (Juegos juegosCliente in cliente.RequerimientosJuegos)
                {
                    foreach (Juegos juegosComputadora in computadora.ListJuegos)
                    {
                        if (juegosCliente == juegosComputadora)
                        {
                            aux = true;
                        }

                    }

                    if (!aux)
                    {
                        rta = false;
                    }
                    aux = false;
                }
            }
            return rta;
        }

        /// <summary>
        /// Verifica si la computadora cumple con los requerimientos de perifericos del cliente
        /// </summary>
        /// <param name="cliente">cliente que pide los requerimientos</param>
        /// <param name="computadora">computadora a verificar</param>
        /// <returns>true si cumple los requerimientos false si no los cumple</returns>
        private bool VerificarSiCumpleRequisitosPerifericos(ClienteComputadora cliente, Computadora computadora)
        {
            bool aux = false;
            bool rta = true;
            if (cliente.RequerimientosPerifericos != null && computadora.ListPerifericos != null)
            {
                foreach (Perifericos perifericosCliente in cliente.RequerimientosPerifericos)
                {
                    foreach (Perifericos perifericosComputadora in computadora.ListPerifericos)
                    {
                        if (perifericosComputadora == perifericosCliente)
                        {
                            aux = true;
                        }

                    }

                    if (!aux)
                    {
                        rta = false;
                    }
                    aux = false;
                }

            }

            return rta;
        }


        /// <summary>
        /// Verifica si el telefono cumple con los requerimientos del cliente
        /// </summary>
        /// <param name="cliente">cliente que pide el requerimientos</param>
        /// <param name="tel"> telefono a verificar</param>
        /// <returns>true si cumple el requerimiento, false si no lo cumple</returns>1
        public bool VerificarSiElTelefonoCumpleConLosRequisitosDelCliente(Telefono tel, ClienteTelefono cliente)
        {
            if (cliente.RequerimientoTipoTelefono == ETipo.None  || tel.Tipo == cliente.RequerimientoTipoTelefono)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Calcula la ganancia de las computadoras
        /// </summary>
        /// <returns> float, ganancias totales</returns>
        public float CalcularGananciasPorComputadora()
        {
            float ganancias = 0;
            foreach(Computadora compu in historialComputadoras)
            {
                ganancias += compu.CostoDeUso;
            }
            return ganancias;
        }

        /// <summary>
        /// Calcula la ganancia de los telefonos
        /// </summary>
        /// <returns> float, ganancias totales</returns>
        public float CalcularGananciasPorTelefono()
        {
            float ganancias = 0;
            foreach (Telefono tel in historialTelefonos)
            {
                ganancias += tel.CostoDeUso;
            }
            return ganancias;

        }

        /// <summary>
        /// Calcula las ganancias totales y por tipo de llamada
        /// </summary>
        /// <returns>string con la informacion de ganancias</returns>
        public string CalcularGananciasDeTotalesYRecaudacionPorTipoDeLlamada()
        {
            StringBuilder sb = new StringBuilder();

            float total = 0;
            float totalLocal = 0;
            float totalInternacional = 0;
            float totalLargaDistacia = 0;
            
            TimeSpan horasLocal = new TimeSpan(0,0,0);
            TimeSpan horasInternacional = new TimeSpan(0,0,0);
            TimeSpan horasLargaDistacia = new TimeSpan(0,0,0);

            foreach (Telefono tel in historialTelefonos)
            {
                switch (tel.TipoLlamada)
                {
                    case Telefono.ETipoLlamada.Local:
                        totalLocal += tel.CostoDeUso;
                        horasLocal += tel.TiempoDeUso;
                        break;
                    case Telefono.ETipoLlamada.LargaDistancia:
                        totalLargaDistacia += tel.CostoDeUso;
                        horasLargaDistacia += tel.TiempoDeUso;
                        break;
                    case Telefono.ETipoLlamada.Internacional:
                        totalInternacional += tel.CostoDeUso;
                        horasInternacional += tel.TiempoDeUso;
                        break;
                }
            }

            total = totalInternacional + totalLargaDistacia + totalLocal;

            sb.AppendLine($"Precio y horas por tipos de llamada.");
            sb.AppendLine($"Precio por llamadas internacionales: {totalInternacional}");
            sb.AppendLine($"Total horas de llamadas internacionales: {horasInternacional.Minutes}:{horasInternacional.Seconds}");
            sb.AppendLine($"Precio por llamadas de larga distacia: {totalLargaDistacia}");
            sb.AppendLine($"Total horas de llamadas larga distacia: {horasLargaDistacia.Minutes}:{horasLargaDistacia.Seconds}");
            sb.AppendLine($"Precio por llamadas locales: {totalLocal}");
            sb.AppendLine($"Total horas de llamadas locales: {horasLocal.Minutes}:{horasLocal.Seconds}");
         
            return sb.ToString();
        }


        /// <summary>
        /// Muestra los telefonos ordenados de forma descendiente por minutos de uso
        /// </summary>
        /// <returns>string con los telenfonos ordenados de forma descendiente</returns>
        public string MostrarTelefonosOrdenadosDeFormaDescendente()
        {
            StringBuilder sb = new StringBuilder();
            List<Telefono> aux = HistorialTelefonos;

            sb.AppendLine($"----------------------------------Telefonos ordenados por minutos de uso----------------------------------");

            Telefono.OrdenarTelefonosPorMinutosDeUso(aux);

            aux.Reverse();

            foreach (Telefono item in aux)
            {
                sb.Append($"{item.ToString()}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Muestra las ganancias totales y las clasifica por tipo de servicio (telefono/computadora)
        /// </summary>
        /// <returns>string con las ganancias totales y clasificadas por servicio</returns>
        public string MostrarGananciasTotalesYPorClasificadasPorServicio()
        {
            StringBuilder sb = new StringBuilder();

            float gananciasPorComputadoras = CalcularGananciasPorComputadora();
            float gananciasPorTelefonos = CalcularGananciasPorTelefono();

            sb.AppendLine($"----------------------------------Ganancias----------------------------------");

            sb.AppendLine($"Ganancias por computadoras: {gananciasPorComputadoras}");
            sb.AppendLine($"Ganancias por telefonos: {gananciasPorTelefonos}");
            sb.AppendLine($"Ganancias totales: {gananciasPorTelefonos + gananciasPorComputadoras}");

            return sb.ToString();
        }

        /// <summary>
        /// Muestra las computadoras ordenadas por minutos de uso en forma descendiente.
        /// </summary>
        /// <returns>string con las computadoras ordenadas de forma descendiente</returns>
        public string MostrarComputadorasOrdenadasDeFormaDescendente()
        {
            StringBuilder sb = new StringBuilder();
            List<Computadora> aux = HistorialComputadoras;

            sb.AppendLine($"----------------------------------Computadoras ordenadas por minutos de uso----------------------------------");

            Computadora.OrdenarComputadorasPorMinutosDeUso(aux);

            aux.Reverse();

            foreach (Computadora item in aux)
            {
                sb.Append($"{item.ToString()}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// busca cual es el software mas pedido por los clientes.
        /// </summary>
        /// <returns>keyValuePair<Software , int>, El software mas pedido y la cantidad </returns>
        private KeyValuePair<Software, int> ConsultarSoftwareMasPedido()
        {
            Dictionary<Software, int> lista = new Dictionary<Software, int>();
            KeyValuePair<Software, int> softwareMasSolicitado = default;
            bool existe = false;

            foreach (Cliente cliente in historialClientes)
            {
                if ( cliente is ClienteComputadora && ((ClienteComputadora)cliente).RequerimientosSoftware != null)
                {
                    foreach (Software software in ((ClienteComputadora)cliente).RequerimientosSoftware)
                    {
                        foreach (KeyValuePair<Software, int> kvp in lista)
                        {
                            if (software == kvp.Key)
                            {
                                lista[software] += kvp.Value + 1;
                                existe = true;
                            }
                        }

                        if (existe == false)
                        {
                            lista.Add(software, 1);
                        }
                    }
                }

            }

            foreach (KeyValuePair<Software, int> kvp in lista)
            {
                if (softwareMasSolicitado.Equals(default(KeyValuePair<string, int>)) || softwareMasSolicitado.Value < kvp.Value)
                {
                    softwareMasSolicitado = kvp;
                }
            }

            return softwareMasSolicitado;

        }

        /// <summary>
        /// busca cual es el periferico mas pedido por los clientes.
        /// </summary>
        /// <returns>keyValuePair<Periferico, int>, El periferico mas pedido y la cantidad </returns>
        private KeyValuePair<Perifericos, int> ConsultarPerifericoMasPedido()
        {
            Dictionary<Perifericos, int> lista = new Dictionary<Perifericos, int>();
            KeyValuePair<Perifericos, int> perifericoMasSolicitado = default;
            bool existe = false;

            foreach (Cliente  cliente in historialClientes)
            {
                if (cliente is ClienteComputadora && ((ClienteComputadora)cliente).RequerimientosPerifericos != null)
                {
                    foreach (Perifericos periferico in ((ClienteComputadora)cliente).RequerimientosPerifericos)
                    {
                        foreach (KeyValuePair<Perifericos, int> kvp in lista)
                        {
                            if (periferico == kvp.Key)
                            {
                                lista[periferico] += kvp.Value + 1;
                                existe = true;
                            }
                        }

                        if (existe == false)
                        {
                            lista.Add(periferico, 1);
                        }
                    }

                }
            }

            foreach (KeyValuePair<Perifericos, int> kvp in lista)
            {
                if (perifericoMasSolicitado.Equals(default(KeyValuePair<string, int>)) || perifericoMasSolicitado.Value < kvp.Value)
                {
                    perifericoMasSolicitado = kvp;
                }
            }

            return perifericoMasSolicitado;

        }

        /// <summary>
        /// busca cual es el Juegos mas pedido por los clientes.
        /// </summary>
        /// <returns>keyValuePair<Juegos , int>, El Juegos mas pedido y la cantidad </returns>
        private KeyValuePair<Juegos, int> ConsultarJuegoMasPedido()
        {
            Dictionary<Juegos, int> lista = new Dictionary<Juegos, int>();
            KeyValuePair<Juegos, int> juegoMasSolicitado = default;
            bool existe = false;

            foreach (Cliente cliente in historialClientes)
            {
                if (cliente is ClienteComputadora && ((ClienteComputadora)cliente).RequerimientosJuegos != null)
                {
                    foreach (Juegos juego in ((ClienteComputadora)cliente).RequerimientosJuegos)
                    { 
                        foreach (KeyValuePair<Juegos, int> kvp in lista)
                        {
                            if (juego == kvp.Key) 
                            {
                                lista[juego] += kvp.Value + 1;
                                existe = true;
                            }
                        }
                    
                        if (existe == false)
                        {
                            lista.Add(juego, 1);
                        }
                    }

                }
            }

            foreach (KeyValuePair<Juegos, int> kvp in lista)
            {
                if (juegoMasSolicitado.Equals(default(KeyValuePair<string, int>)) || juegoMasSolicitado.Value < kvp.Value)
                {
                    juegoMasSolicitado = kvp;
                }
            }

            return juegoMasSolicitado;

        }

        /// <summary>
        /// Muestra el sofrware mas pedido por los clientes
        /// </summary>
        /// <returns>string con el software mas pedido  y la cantidad</returns>
        public string MostrarSoftwareMasPedido()
        {
            StringBuilder sb = new StringBuilder();
            
            KeyValuePair<Software, int> sofwareMasPedido = ConsultarSoftwareMasPedido();

            sb.AppendLine($"El software mas pedido es {sofwareMasPedido.Key} con {sofwareMasPedido.Value}");

            return sb.ToString();
        }


        /// <summary>
        /// Muestra el juego mas pedido por los clientes
        /// </summary>
        /// <returns>string con el juego mas pedido  y la cantidad</returns>
        public string MostrarJuegoMasPedido()
        {
            StringBuilder sb = new StringBuilder();
            KeyValuePair<Juegos, int> juegoMasPedido = ConsultarJuegoMasPedido();

            sb.AppendLine($"El juego mas pedido es {juegoMasPedido.Key} con {juegoMasPedido.Value}");

            return sb.ToString();
        }

        /// <summary>
        /// Muestra el periferico mas pedido por los clientes
        /// </summary>
        /// <returns>string con el periferico mas pedido  y la cantidad</returns>
        public string MostrarPerifericoMasPedido()
        {
            StringBuilder sb = new StringBuilder();
            KeyValuePair<Perifericos, int> perifericoMasPedido = ConsultarPerifericoMasPedido();

            sb.AppendLine($"El periferico mas pedido es {perifericoMasPedido.Key} con {perifericoMasPedido.Value}");

            return sb.ToString();
        }

        /// <summary>
        /// Propiedad que retorna la lista de computadoras
        /// </summary>
        public List<Computadora> ListaComputadoras 
        {
            get { return computadoras; }
        }
        /// <summary>
        /// Propiedad que retorna la lista de telefonos
        /// </summary>
        public List<Telefono> ListaTelefonos
        {
            get { return telefonos.ToList(); }
        }
        
        /// <summary>
        /// Propiedad que retorna la lista de historial de computadoras
        /// </summary>
        public List<Computadora> HistorialComputadoras 
        {
            get { return historialComputadoras; }
        }

        /// <summary>
        /// Propiedad que retorna la lista de historial de telefonos
        /// </summary>
        public List<Telefono> HistorialTelefonos
        {
            get { return historialTelefonos; }
        }

        /// <summary>
        /// Propiedad que retorna la lista de clientes en espera
        /// </summary>
        public Queue<Cliente> ListaClientes
        {
            get { return clientes ; }
        }

        /// <summary>
        /// Propiedad que retorna el historial de clientes
        /// </summary>
        public List<Cliente> HistorialClientes
        {
            get { return HistorialClientes; }
        }

        /// <summary>
        /// Indexador que retorna el telefono en ese indice
        /// </summary>
        /// <param name="index">indice del telefono a buscar</param>
        /// <returns>telefono en el indice ingresado</returns>
        public Telefono this[int index]
        {
            get { return telefonos[index]; }
        }

        /// <summary>
        /// propiedad que retorna el usuario del ciber
        /// </summary>
        public Usuario Usuario 
        {
            get { return empleado; }
        }
    }
}

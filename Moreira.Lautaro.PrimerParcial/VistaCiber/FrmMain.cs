using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaCiber
{
    public partial class FrmMain : Form
    {

        #region clientes
        ClienteComputadora c1 = new ClienteComputadora("Lautaro", "Moreira", 32, 43368964);
        ClienteTelefono c2 = new ClienteTelefono("Mauricio", "Cerizza", 18, 54785432);
        ClienteComputadora c3 = new ClienteComputadora("Esteban", "Martinez" , 18 , 12654789);
        ClienteComputadora c4 = new ClienteComputadora("Nicolas", "Alvares" , 17 , 32147852);
        ClienteComputadora c5 = new ClienteComputadora("Franco", "Torres", 25 , 36547892);
        ClienteComputadora c6 = new ClienteComputadora("Ignacio", "Sosa" , 30 , 12457865);
        ClienteTelefono c7 = new ClienteTelefono("Ricardo", "Fort" , 33 , 25468975);
        ClienteComputadora c8 = new ClienteComputadora("Juan", "Roman" , 42 , 32456987);

        ClienteTelefono c9 = new ClienteTelefono("Tobias", "Perez" , 42 , 12548796);
        Queue<Cliente> clientes = new Queue<Cliente>();
        #endregion
        #region computadoras

        Computadora computadora1 = new Computadora(
            new List<Hardware>() { Hardware.CPUAMDPhenom , Hardware.Ram64MB , Hardware.LectorDisquetes , Hardware.PlacaVideo},
            new List<Juegos>() { Juegos.TonyHawkProSkaterII , Juegos.TheSims , Juegos.GTAIII, Juegos.ResidentEvil },
            new List<Software>() {Software.InternetExplorer , Software.NetScape , Software.MSN , Software.Office },
            new List<Perifericos>() { Perifericos.Auriculares , Perifericos.Microfono},
            "C01");
        Computadora computadora2 = new Computadora(
            new List<Hardware>(){ Hardware.CPUCore2Quad , Hardware.Ram32MB , Hardware.LectorCd , Hardware.TarjetaSonido },
            new List<Juegos>(){ Juegos.DiabloII , Juegos.GodOfWar , Juegos.HalfLife},
            new List<Software>() { Software.InternetExplorer , Software.MSN , Software.Paint },
            new List<Perifericos>() { Perifericos.Camara , Perifericos.Parlantes , Perifericos.Microfono ,  Perifericos.joystick},
            "C02");
        Computadora computadora3 = new Computadora(
            new List<Hardware>() { Hardware.CPUAMDPhenom , Hardware.Ram64MB, Hardware.LectorDisquetes, Hardware.TarjetaSonido},
            new List<Juegos>() { Juegos.Halo, Juegos.ResidentEvil, Juegos.HalfLife },
            new List<Software>() { Software.InternetExplorer, Software.MSN, Software.Paint },
            new List<Perifericos>() { Perifericos.Parlantes, Perifericos.Microfono, Perifericos.joystick },
            "C03");
        Computadora computadora4 = new Computadora(
            new List<Hardware>() { Hardware.CPUCore2Quad, Hardware.Ram64MB , Hardware.PlacaVideo},
            new List<Juegos>() { Juegos.Halo, Juegos.WOW, Juegos.TheSimpsonsHitAndRun},
            new List<Software>() { Software.InternetExplorer, Software.MSN, Software.Paint },
            new List<Perifericos>() { Perifericos.Camara , Perifericos.Auriculares, Perifericos.Microfono, Perifericos.joystick },
            "C04");
        Computadora computadora5 = new Computadora(
            new List<Hardware>() { Hardware.CPUCore2Quad, Hardware.Ram32MB, Hardware.TarjetaSonido},
            new List<Juegos>() { Juegos.MetalGearSolid, Juegos.WOW, Juegos.ResidentEvil},
            new List<Software>() { Software.InternetExplorer, Software.Encarta, Software.NetScape},
            new List<Perifericos>() { Perifericos.Camara , Perifericos.Auriculares, Perifericos.Microfono, Perifericos.joystick },
            "C05");
        Computadora computadora6 = new Computadora(
            new List<Hardware>() { Hardware.CPUAMDPhenom, Hardware.Ram32MB,  Hardware.TarjetaSonido, Hardware.PlacaVideo},
            new List<Juegos>() { Juegos.ResidentEvil , Juegos.TheSims , Juegos.GTAIII, Juegos.SnowBros },
            new List<Software>() {Software.InternetExplorer , Software.Ares , Software.NetScape, Software.Office },
            new List<Perifericos>() { Perifericos.Parlantes , Perifericos.Camara , Perifericos.Microfono},
            "C06");
        Computadora computadora7 = new Computadora(
            new List<Hardware>(){ Hardware.CPUCore2Quad , Hardware.Ram32MB , Hardware.TarjetaSonido },
            new List<Juegos>(){},
            new List<Software>() { Software.InternetExplorer , Software.MSN , Software.Paint },
            new List<Perifericos>() { Perifericos.Camara , Perifericos.Parlantes , Perifericos.Microfono ,  Perifericos.joystick},
            "C07");
        Computadora computadora8 = new Computadora(
            new List<Hardware>() { Hardware.CPUAMDPhenom, Hardware.Ram32MB, Hardware.TarjetaSonido , Hardware.PlacaVideo},
            new List<Juegos>() { Juegos.Halo, Juegos.ResidentEvil, Juegos.HalfLife , Juegos.GTAIII , Juegos.DBZBudokaiTenkaichi3 },
            new List<Software>() { Software.InternetExplorer, Software.MSN, Software.Paint , Software.Encarta, Software.MySpace},
            new List<Perifericos>() { Perifericos.Parlantes, Perifericos.Microfono, Perifericos.joystick , Perifericos.Auriculares },
            "C08");
        Computadora computadora9 = new Computadora(
            new List<Hardware>() { Hardware.CPUCore2Quad, Hardware.Ram64MB , Hardware.PlacaVideo},
            new List<Juegos>() { Juegos.Halo, Juegos.WOW, Juegos.TheSimpsonsHitAndRun},
            new List<Software>() { Software.InternetExplorer, Software.MSN, Software.Paint },
            new List<Perifericos>() { Perifericos.Camara , Perifericos.Auriculares, Perifericos.Microfono, Perifericos.joystick },
            "C09");
        Computadora computadora10 = new Computadora(
            new List<Hardware>() { Hardware.CPUCore2Quad, Hardware.Ram32MB, Hardware.TarjetaSonido},
            new List<Juegos>() { Juegos.MetalGearSolid, Juegos.WOW, Juegos.ResidentEvil},
            new List<Software>() { Software.InternetExplorer, Software.Encarta, Software.NetScape},
            new List<Perifericos>() { Perifericos.Camara , Perifericos.Auriculares, Perifericos.Microfono },
            "C10");

        List<Computadora> computadoras = new List<Computadora>();
        #endregion

        
        Ciber elVicio;
        #region telefonos

        Telefono t1 = new Telefono("T01" , ETipo.ADisco);
        Telefono t2 = new Telefono("T02" , ETipo.Teclado);
        Telefono t3 = new Telefono("T03" , ETipo.ADisco);
        Telefono t4 = new Telefono("T04" , ETipo.Teclado);
        Telefono t5 = new Telefono("T05" , ETipo.Teclado);
        List<Telefono> telefonos = new List<Telefono>();
        #endregion

        /// <summary>
        /// Constructor del formulario principal
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load el formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            clientes.Enqueue(c1);
            if (c1 + Hardware.Ram64MB) { }
            if (c1 + Hardware.PlacaVideo) { }

            clientes.Enqueue(c2);

            clientes.Enqueue(c3);
            if (c3 + Hardware.PlacaVideo) { }
            if (c3 + Juegos.DiabloII) { }

            clientes.Enqueue(c4);
            if (c4 + Hardware.LectorCd) { }
            if (c4 + Juegos.AgeOfEmpiresII) { }

            clientes.Enqueue(c5);
            if (c5 + Perifericos.Auriculares) { }
            if (c5 + Perifericos.Microfono) { }

            clientes.Enqueue(c6);
            if (c6 + Perifericos.joystick) { }
            if (c6 + Juegos.DBZBudokaiTenkaichi3) { }

            clientes.Enqueue(c7);

            clientes.Enqueue(c8);
            if (c8 + Hardware.LectorDisquetes) { }

            clientes.Enqueue(c9);


            computadoras.Add(computadora1);
            computadoras.Add(computadora2);
            computadoras.Add(computadora3);
            computadoras.Add(computadora4);
            computadoras.Add(computadora5);
            computadoras.Add(computadora6);
            computadoras.Add(computadora7);
            computadoras.Add(computadora8);
            computadoras.Add(computadora9);
            computadoras.Add(computadora10);

            telefonos.Add(t1);
            telefonos.Add(t2);
            telefonos.Add(t3);
            telefonos.Add(t4);
            telefonos.Add(t5);

            Usuario empleado = new Usuario("Lautaro", "Moreira", 20, 45665454 , 2.5F);

            elVicio = new Ciber(clientes, computadoras, telefonos, empleado);

            tsInformacion.Text = $"Lautaro Moreira. {DateTime.Now.ToShortDateString()}";
        }

        private void btnMostrarComputadoras_Click(object sender, EventArgs e)
        {
            FrmEquipos frmEquipos = new FrmEquipos(elVicio);
            frmEquipos.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial(elVicio);
            frmHistorial.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message = "Este es el form principal, encontraras tres botones, en el primero podras ir a la parte de maquinas" +
                " para asignar o finalizar maquinas.\n" +
                "En el segundo se encuentra el historial del ciber donde consultaras datos importantes.\n" +
                "Y en el tercero y ultimo se encuentra la parte de usuario, para ver horas trabajadas, salario o informacion del empleado.";

            MessageBox.Show(message, "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnCalculadoraDeSalario_Click(object sender, EventArgs e)
        {
            FrmCalculadoraSalario frmCalculadora = new FrmCalculadoraSalario(elVicio.Usuario);
            frmCalculadora.ShowDialog();
        }
    }
}

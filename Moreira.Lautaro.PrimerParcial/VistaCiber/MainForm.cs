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
    public partial class MainForm : Form
    {
        //Centrar todos los forms.
        //hacer modales los que sean necesarios.
        #region clientes
        Cliente c1 = new Cliente("Lautaro", "Moreira", 32, 43368964);
        
        Cliente c2 = new Cliente("Juan", "Roman" , 42 , 43368964);
        Cliente c3 = new Cliente("Esteban", "Martinez" , 18 , 43368964);
        Cliente c4 = new Cliente("Nicolas", "Alvares" , 17 , 43368964);
        Cliente c5 = new Cliente("Franco", "Torres", 25 , 43368964);
        Cliente c6 = new Cliente("Ignacio", "Sosa" , 30 , 43368964);
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

        Telefono t1 = new Telefono("T01" , Telefono.ETipo.ADisco);
        Telefono t2 = new Telefono("T02" , Telefono.ETipo.Teclado);
        Telefono t3 = new Telefono("T03" , Telefono.ETipo.ADisco);
        Telefono t4 = new Telefono("T04" , Telefono.ETipo.Teclado);
        Telefono t5 = new Telefono("T05" , Telefono.ETipo.Teclado);
        List<Telefono> telefonos = new List<Telefono>();
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            clientes.Enqueue(c1);
            if (c1 + Hardware.Ram64MB);
            if (c1 + Hardware.PlacaVideo);

            clientes.Enqueue(c2);
            clientes.Enqueue(c3);
            clientes.Enqueue(c4);
            clientes.Enqueue(c5);
            clientes.Enqueue(c6);

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

            Usuario empleado = new Usuario("Lautaro", "Moreira", 20, 45665454);

            elVicio = new Ciber(clientes , computadoras , telefonos , empleado);
        }
        private void button1_Click(object sender, EventArgs e)//Eliminar en el codigo de el form
        {

        }

        private void btnMostrarComputadoras_Click(object sender, EventArgs e)
        {
            FrmEquipos frmEquipos = new FrmEquipos(elVicio);
            frmEquipos.Show();
        }
    }
}

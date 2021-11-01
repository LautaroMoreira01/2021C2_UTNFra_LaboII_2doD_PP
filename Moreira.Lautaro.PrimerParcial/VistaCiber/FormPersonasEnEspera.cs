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
    public partial class FormPersonasEnEspera : Form
    {
        private Ciber ciber1; 
        public FormPersonasEnEspera(Ciber ciber)
        {
            InitializeComponent();
            this.ciber1= ciber;
        }

        private void btnMostrarConRequerimientos_Click(object sender, EventArgs e)
        {
            if (btnMostrarSinRequerimientos.Enabled == false)
            {
                btnMostrarSinRequerimientos.Enabled = true;
            }
            this.btnMostrarConRequerimientos.Enabled = false;

            this.rtbListaClientesEnEspera.Text = ciber1.MostrarClientesEnEsperaConRequerimientos(); 
        }

        private void btnMostrarSinRequerimientos_Click(object sender, EventArgs e)
        {
            if (btnMostrarConRequerimientos.Enabled == false)
            {
                btnMostrarConRequerimientos.Enabled = true;
            }

            btnMostrarSinRequerimientos.Enabled = false;

            this.rtbListaClientesEnEspera.Text = ciber1.MostrarClientesEnEsperaSinRequerimientos();


        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message = "Este formulario te permitira visualizar los clientes que se encuentran en espera.\n" +
                "- Boton \"Mostrar clientes sin requerimientos\": Te permitira vizualizar una lista de clientes solamente con su informacion personal (dni, nombre, apellido, edad).\n" +
                "- Boton \"Mostrar clientes con requerimientos\": Te permitira vizualizar una lista de clientes la informacion personal y los requerimientos que tengan.";

            MessageBox.Show(message, "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}

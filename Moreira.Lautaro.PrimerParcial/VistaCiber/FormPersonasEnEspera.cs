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
        private void FormPersonasEnEspera_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnMostrarConRequerimientos_Click(object sender, EventArgs e)
        {
            if (btnMostrarSinRequerimientos.Enabled == false)
            {
                btnMostrarSinRequerimientos.Enabled = true;
            }
            this.btnMostrarConRequerimientos.Enabled = false;

            this.rtbListaClientesEnEspera.Text = ciber1.MostrarClientesEnEsperaConRequerimientos(); //Mostrar los clientes en espera con requerimientos.
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
    }
}

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
    public partial class FrmHistorial : Form
    {
        private Ciber ciber;

        public FrmHistorial(Ciber ciber)
        {
            InitializeComponent();
            this.ciber = ciber;  
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
        }

        private void lbFormasDeOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbFormasDeOrdenar.SelectedIndex)
            {
                case 0:
                    rtbHistorial.Text = ciber.MostrarComputadorasOrdenadasDeFormaDescendente();
                    break;
                case 1:
                    rtbHistorial.Text = ciber.MostrarTelefonosOrdenadosDeFormaDescendente();
                    break;
                case 2:
                    rtbHistorial.Text = ciber.MostrarGananciasTotalesYPorClasificadasPorServicio();
                    break;
                case 3:
                    rtbHistorial.Text = ciber.CalcularGananciasDeTotalesYRecaudacionPorTipoDeLlamada();
                    break;
                case 4:
                    rtbHistorial.Text = ciber.MostrarSoftwareMasPedido();
                    break;
                case 5:
                    rtbHistorial.Text = ciber.MostrarPerifericoMasPedido();
                    break;
                case 6:
                    rtbHistorial.Text = ciber.MostrarJuegoMasPedido();
                    break;

            }
        }

        private void nupTamanioFuente_ValueChanged(object sender, EventArgs e)
        {
            rtbHistorial.Font = new Font("Segoe", (float)nupTamanioFuente.Value);
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("En la lista de la izquierda podras seleccionar una opcion a mostrar, en el cuadro de abajo se mostrara la informacion solicitada." +
                "\nPara aumentar el tamaño de la letra puedes modificarla en el selector de numeros y automaticamente sera modificado en el cuadro.");
            MessageBox.Show(sb.ToString() , "Ayuda" , MessageBoxButtons.OKCancel , MessageBoxIcon.Information);
        }
    }
}

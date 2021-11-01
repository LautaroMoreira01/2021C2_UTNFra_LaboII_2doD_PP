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
    public partial class frmComputadora : Form
    {
        Computadora computadora;
        Cliente cliente;
        DialogResult confirmarAsigancion;
        DialogResult confirmarFinalizarSesion;
        public frmComputadora(Computadora computadora, Cliente cliente)
        {
            InitializeComponent();
            this.computadora = computadora;
            this.cliente = cliente;
        }

        private void frmComputadora_Load(object sender, EventArgs e)
        {
            this.rtbInformacionComputadora.Text = computadora.MostrarComputadoraConHardwareYSoftware();
            cbTiempoSolicitado.SelectedItem = "Ingresar tiempo";
            btnCerrar.Enabled = false;
            btnCerrar.Visible = false;
            if (computadora.EstaLibre)
            {
                btnFinalizar.Visible = false;
            }
            else
            {
                btnFinalizar.Location = btnCerrar.Location;
                btnAsignarCliente.Visible = false;
                btnAsignarCliente.Enabled = false;
                lblHoras.Visible = false;
                lblMinutos.Visible = false;
                nupHoras.Visible = false;
                nupMinutos.Visible = false;
                lblTiempoSolicitado.Visible = false;
                cbTiempoSolicitado.Visible = false;
            }
        }

        private void cbTiempoSolicitado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTiempoSolicitado.SelectedItem.ToString() == "Libre")
            {
                lblHoras.Visible = false;
                lblMinutos.Visible = false;
                nupHoras.Visible = false;
                nupMinutos.Visible = false;

            }
            else
            {
                lblHoras.Visible = true ;
                lblMinutos.Visible = true;
                nupHoras.Visible = true;
                nupMinutos.Visible = true;

            }
        }

        private void btnAsignarCliente_Click(object sender, EventArgs e)
        {
           
            if (cbTiempoSolicitado.SelectedIndex == 0)
            {
                if (nupHoras.Value >= 0 && (nupHoras.Value >= 1 || nupMinutos.Value >= 30))
                {
                    computadora.AsignarClienteAEquipo(cliente, new TimeSpan(0, (int)nupHoras.Value, (int)nupMinutos.Value));
                    confirmarAsigancion = DialogResult.Yes;
                    Close();
                }
            }
            else
            {
                computadora.AsignarClienteAEquipo(cliente);
                confirmarAsigancion = DialogResult.Yes;
                Close();
            }

        }

        private void nupMinutos_ValueChanged(object sender, EventArgs e)
        {
            if(nupMinutos.Value >= 60)
            {
                nupHoras.Value += 1;
                nupMinutos.Value = 0;
            }
        }
        public DialogResult ConfirmarAsignacion 
        {
            get { return confirmarAsigancion; }
        }
        public DialogResult ConfirmarFinalizarSesion 
        {
            get { return confirmarFinalizarSesion; }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            
            
            rtbInformacionComputadora.Text = computadora.FinalizarSesion();
            btnFinalizar.Enabled = false;
            btnFinalizar.Visible = false;
            btnCerrar.Enabled = true;
            btnCerrar.Visible = true;

            confirmarFinalizarSesion = DialogResult.Yes;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string messageAsignar = "Para asignar el cliente seleccionado tiene dos opciones.\n" +
                "libre: la maquina empezara a contar el tiempo desde que el cliente fue asignado.\n" + 
                "ingresar tiempo: Habra dos nuevos elementos donde se debera ingresar el tiempo (horas y minutos)."; 

            string messageCerrar = "- Boton \"Cerrar\": cerrara el formulario.";
            string messageLiberar = "- Boton \"Finalizar\": Liberara la computadora mostrando el tiempo utilizado y el precio a pagar.";


            if (btnAsignarCliente.Enabled == true)
            {
                MessageBox.Show(messageAsignar, "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (btnCerrar.Enabled == true)
            {
                MessageBox.Show(messageCerrar, "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(messageLiberar, "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }
    }
}

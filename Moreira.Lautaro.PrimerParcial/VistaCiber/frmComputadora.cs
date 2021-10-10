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
                btnFinalizar.Location = new  Point(63, 339);
                btnAsignarCliente.Visible = false;
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
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea asignar el cliente a la maquina?", "Confirmar.", MessageBoxButtons.YesNoCancel);

            if (cbTiempoSolicitado.SelectedIndex == 0)
            {
                if (nupHoras.Value >= 0 && (nupHoras.Value >= 1 || nupMinutos.Value >= 30))
                {
                    if (dialogResult == DialogResult.Yes)
                    {
                        computadora.AsignarClienteAEquipo(cliente, new TimeSpan(0, (int)nupHoras.Value, (int)nupMinutos.Value));
                        confirmarAsigancion = DialogResult.Yes;
                        this.Close();
                    }
                }
            }
            else if(dialogResult == DialogResult.Yes)
            {
                computadora.AsignarClienteAEquipo(cliente);
                confirmarAsigancion = DialogResult.Yes;
                this.Close();
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
            DialogResult dr = MessageBox.Show("Esta seguro que desea finalizar la sesion?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                rtbInformacionComputadora.Text = computadora.FinalizarSesion();
                btnFinalizar.Enabled = false;
                btnFinalizar.Visible = false;
                btnCerrar.Enabled = true;
                btnCerrar.Visible = true;

                confirmarFinalizarSesion = dr;
            }
        }


        private void frmComputadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

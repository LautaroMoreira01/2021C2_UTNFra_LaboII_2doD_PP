using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaCiber
{
    public partial class FrmTelefono : Form
    {
        Telefono telefono;
        Cliente cliente;
        DialogResult confirmarAsigancion;
        DialogResult confirmarFinalizarSesion;
        public FrmTelefono(Telefono telefono , Cliente cliente) 
        {
            InitializeComponent();
            this.telefono = telefono;
            this.cliente = cliente;
        }

        private void FrmTelefono_Load(object sender, EventArgs e)
        {
            rtbInformacionTelefono.Text = telefono.ToString();
            btnCerrar.Visible = false;
            btnCerrar.Enabled = false;
            if (telefono.EstaLibre)
            {
                btnLiberar.Visible = false;

            }
            else
            {
                btnLiberar.Location = new Point(102, 268);
                btnAsignar.Visible = false;
                btnAsignar.Enabled = false;
                lblCodigoPais.Visible = false;
                lblNumero.Visible = false;
                lblPrefijo.Visible = false;
                tbCodigoPais.Visible = false;
                tbPrefijoLocalidad.Visible = false;
                tbRestoDelNumero.Visible = false;
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            DialogResult dialogResult;
            sb.Append(tbCodigoPais.Text);
            sb.Append(tbPrefijoLocalidad.Text);
            sb.Append(tbRestoDelNumero.Text);

            if (Telefono.ValidarNumeroLlamada(sb.ToString()))
            {
                telefono.NumeroLlamada= sb.ToString();

                dialogResult = MessageBox.Show("Seguro que desea asignar el cliente?", "Confirmar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    telefono.AsignarClienteAEquipo(cliente);
                    rtbInformacionTelefono.Text = telefono.ToString();
                    confirmarAsigancion = DialogResult.Yes;
                    btnAsignar.Enabled = false;
                    btnAsignar.Visible = false;
                    btnCerrar.Visible = true;
                    btnCerrar.Enabled = true;
                    
                }
            }
            else
            {
                MessageBox.Show("Numero no valido!!!!!", "ERROR!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DialogResult ConfirmarAsignacion
        {
            get {return confirmarAsigancion ; }
        }
        public DialogResult ConfirmarFinalizarSesion 
        {
            get { return confirmarFinalizarSesion; } 
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea finalizar la sesion?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                rtbInformacionTelefono.Text = telefono.FinalizarSesion();
                btnLiberar.Enabled = false;
                btnLiberar.Visible = false;
                btnCerrar.Enabled = true;
                btnCerrar.Visible = true;

                confirmarFinalizarSesion = dr;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnHelp_Click(object sender, EventArgs e)
        {
            string messageCerrar = "- Boton \"Cerrar\": cerrara el formulario.";
            string messageLiberar = "- Boton \"Liberar\": Liberara la cabina telefonica mostrando el tiempo utilizado y el precio a pagar.";

            string messageAsignar = "- Codigo pais: Aqui ingresaras el codigo pais del numero telefonico.\n" +
                "- Prefijo localidad: Aqui ingresaras el prefijo de la localidad del numero telefonico.\n" +
                "- Numero: Aqui ingresaras el resto del numero telefonico.\n" +
                "Boton \"Asignar\": Le permitira asignar el cliente a la cabina.";
            
            if(btnAsignar.Enabled == true)
            {
                MessageBox.Show(messageAsignar, "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }else if (btnCerrar.Enabled == true)
            {
                MessageBox.Show(messageCerrar, "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show(messageLiberar, "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}

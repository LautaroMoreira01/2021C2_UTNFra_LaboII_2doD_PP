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
        public FrmTelefono(Telefono telefono , Cliente cliente) 
        {
            InitializeComponent();
            this.telefono = telefono;
            this.cliente = cliente;
        }

        private void FrmTelefono_Load(object sender, EventArgs e)
        {
            rtbInformacionTelefono.Text = telefono.ToString();
            btnLiberar.Visible = false;
            btnLiberar.Enabled = false;
            btnAsignar.Enabled = true;
            btnAsignar.Visible = true;
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
                    btnLiberar.Visible = true;
                    btnLiberar.Enabled = true;
                    //this.Close();
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

        private void btnLiberar_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FrmEquipos : Form
    {
        private Ciber ciber;
        private Cliente clienteSeleccionado;

        private Color rojo = Color.FromArgb(245, 37, 22);
        private Color verde = Color.FromArgb(75, 192, 17);
        private Color naranja = Color.FromArgb(245, 125, 12);
        public FrmEquipos(Ciber ciber)
        {
            InitializeComponent();
            this.ciber= ciber;
        }

        private void FrmEquipos_Load(object sender, EventArgs e)
        {
            foreach ( Button button in gbComputadoras.Controls)
            {
                for (int i = 0; i < ciber.ListaComputadoras.Count ; i++)
                {
                    if(ciber.ListaComputadoras[i].Identificador == button.Text)
                    {
                        if (ciber.ListaComputadoras[i].EstaLibre)
                        {
                            CambiarColorYEstadoDeBoton(button, verde, false);

                        }
                        else
                        {
                            CambiarColorYEstadoDeBoton(button, rojo, false);
                        }
                    }     
                }
            }

            foreach (Button button in gbTelefonos.Controls)
            {
                for (int i = 0; i < ciber.ListaTelefonos.Count; i++)
                {
                    if (ciber.ListaTelefonos[i].Identificador == button.Text)
                    {
                        if (ciber.ListaTelefonos[i].EstaLibre)
                        {
   
                            CambiarColorYEstadoDeBoton(button, verde ,true);

                        }
                        else
                        {
                            CambiarColorYEstadoDeBoton(button, rojo, false);

                        }
                    }
                }
            }
            CargarListaClientes();

        }


        private void btnClientesEnEspera_Click(object sender, EventArgs e)
        {
            FormPersonasEnEspera frmPersonasEnEspera = new FormPersonasEnEspera(ciber);
            frmPersonasEnEspera.ShowDialog();
        }

        private void lbClientesEnEspera_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach(Cliente cliente in ciber.ListaClientes)
            {

                if (cliente == (Persona)lbClientesEnEspera.SelectedItem)
                {
                    clienteSeleccionado = cliente;
                    break;
                }

            }

            foreach (Button button in gbComputadoras.Controls)
            {
                for (int i = 0; i < ciber.ListaComputadoras.Count; i++)
                {
                    if(ciber.ListaComputadoras[i].Identificador == button.Text && ciber.ListaComputadoras[i].EstaLibre)
                    {
                        if ( ciber.VerificarSiLaComputadoraTieneLosRequisitosDelCliente(ciber.ListaComputadoras[i], clienteSeleccionado))
                        {
                            button.BackColor = verde;
                            if (button.Enabled == false)
                            {
                                button.Enabled = true;
                            }
                            break;
                        }
                        else
                        {
                            CambiarColorYEstadoDeBoton(button, naranja, false);
                            break;

                        }

                    }
                }
                

            }
        }



        private void btnFinalizarEquipo_Click(object sender, EventArgs e)
        {
            foreach (Button button in gbComputadoras.Controls)
            {
                for (int i = 0; i < gbComputadoras.Controls.Count ; i++)
                {
                    if(ciber.ListaComputadoras[i].Identificador == button.Text && ciber.ListaComputadoras[i].EstaLibre == false)
                    {
                        button.Enabled = true;
                        break;
                    }else if(ciber.ListaComputadoras[i].Identificador == button.Text && ciber.ListaComputadoras[i].EstaLibre)
                    {
                        button.Enabled = false;
                        break;
                    }

                }
            }
            foreach (Button button in gbTelefonos.Controls)
            {
                for (int i = 0; i < gbTelefonos.Controls.Count; i++)
                {
                    if (ciber.ListaTelefonos[i].Identificador == button.Text && ciber.ListaTelefonos[i].EstaLibre == false)
                    {
                        button.Enabled = true;
                        break;
                    }
                    else if (ciber.ListaTelefonos[i].Identificador == button.Text && ciber.ListaTelefonos[i].EstaLibre)
                    {
                        button.Enabled = false;
                        break;
                    }

                }
            }

        }
        private void btnComputadora1_Click(object sender, EventArgs e)
        {
            frmComputadora frmComputadora = new frmComputadora(ciber.ListaComputadoras[0], clienteSeleccionado);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnComputadora1, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;

            }
            if(frmComputadora.ConfirmarFinalizarSesion == DialogResult.Yes)
            {
                CambiarColorYEstadoDeBoton(btnComputadora1, verde, true);

            }
        }


        private void btnComputadora2_Click(object sender, EventArgs e)
        {
            frmComputadora frmComputadora = new frmComputadora(ciber.ListaComputadoras[1], clienteSeleccionado);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnComputadora2, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;

            }
        }

        private void btnComputadora3_Click(object sender, EventArgs e)
        {
            frmComputadora frmComputadora = new frmComputadora(ciber.ListaComputadoras[2], clienteSeleccionado);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnComputadora3, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;

            }
        }

        private void btnComputadora4_Click(object sender, EventArgs e)
        {
            frmComputadora frmComputadora = new frmComputadora(ciber.ListaComputadoras[3], clienteSeleccionado);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnComputadora4, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;

            }
        }

        private void btnComputadora5_Click(object sender, EventArgs e)
        {
            frmComputadora frmComputadora = new frmComputadora(ciber.ListaComputadoras[4], clienteSeleccionado);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnComputadora5, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;

            }
        }

        private void btnComputadora6_Click(object sender, EventArgs e)
        {
            frmComputadora frmComputadora = new frmComputadora(ciber.ListaComputadoras[5], clienteSeleccionado);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnComputadora6, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;

            }
        }

        private void btnComputadora7_Click(object sender, EventArgs e)
        {
            frmComputadora frmComputadora = new frmComputadora(ciber.ListaComputadoras[6], clienteSeleccionado);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnComputadora7, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;

            }
        }

        private void btnComputadora8_Click(object sender, EventArgs e)
        {
            frmComputadora frmComputadora = new frmComputadora(ciber.ListaComputadoras[7], clienteSeleccionado);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnComputadora8, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;

            }
        }

        private void btnComputadora9_Click(object sender, EventArgs e)
        {
            frmComputadora frmComputadora = new frmComputadora(ciber.ListaComputadoras[8], clienteSeleccionado);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnComputadora9, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;

            }
        }

        private void btnComputadora10_Click(object sender, EventArgs e)
        {
            frmComputadora frmComputadora = new frmComputadora(ciber.ListaComputadoras[9], clienteSeleccionado);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnComputadora10, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;

            }
        }
        private void RefrescarListBoxClientesEnEspera()
        {
            lbClientesEnEspera.Items.Clear();
            CargarListaClientes();
        }

        private void CargarListaClientes()
        {
            foreach (Cliente cliente in ciber.ListaClientes)
            {
                lbClientesEnEspera.Items.Add(cliente);
            }
        }
        private void CambiarColorYEstadoDeBoton(Button boton, Color color, bool estado)
        {
            if (color != boton.BackColor)
            {
                boton.BackColor = color;
            }
            if (boton.Enabled != estado)
            {
                boton.Enabled = estado;
            }
        }

        private void btnTelefono1_Click(object sender, EventArgs e)
        {
            FrmTelefono frmTelefono = new FrmTelefono(ciber.ListaTelefonos[0], clienteSeleccionado);
          DialogResult dialogResult = frmTelefono.ShowDialog();

            if (frmTelefono.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(btnTelefono1, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;
            }
            
        }
    }
}

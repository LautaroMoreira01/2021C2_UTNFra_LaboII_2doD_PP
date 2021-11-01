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
        private Equipo equipoFinalizado;

        private Color rojo = Color.FromArgb(245, 37, 22);
        private Color verde = Color.FromArgb(75, 192, 17);
        private Color naranja = Color.FromArgb(245, 125, 12);
        public FrmEquipos(Ciber ciber)
        {
            InitializeComponent();
            this.ciber = ciber;
        }
        public Equipo EquipoFinalizado 
        { 
            get 
            { 
                return equipoFinalizado; 
            }
            set
            {
                equipoFinalizado = value;
            }
        }
        
        private void FrmEquipos_Load(object sender, EventArgs e)
        {
            ActualizarFormulario();
            CargarListaClientes();
        }

        private void ActualizarFormulario()
        {
            foreach (Button button in gbComputadoras.Controls)
            {
                for (int i = 0; i < ciber.ListaComputadoras.Count; i++)
                {
                    if (ciber.ListaComputadoras[i].Identificador == button.Text)
                    {
                        if (ciber.ListaComputadoras[i].EstaLibre)
                        {
                            CambiarColorYEstadoDeBoton(button, verde, false);

                        }
                        else
                        {
                            CambiarColorYEstadoDeBoton(button, rojo, false);
                        }
                        toolTip1.SetToolTip(button, ciber.ListaComputadoras[i].ToString());
                    }
                }
            }

            foreach (Button button in gbTelefonos.Controls)
            {
                for (int i = 0; i < ciber.ListaTelefonos.Count; i++)
                {
                    if (ciber[i].Identificador == button.Text)
                    {
                        if (ciber[i].EstaLibre)
                        {

                            CambiarColorYEstadoDeBoton(button, verde, false);

                        }
                        else
                        {
                            CambiarColorYEstadoDeBoton(button, rojo, false);

                        }
                        toolTip1.SetToolTip(button, ciber[i].ToString());
                    }
                }
            }
        }
        private void btnClientesEnEspera_Click(object sender, EventArgs e)
        {
            FormPersonasEnEspera frmPersonasEnEspera = new FormPersonasEnEspera(ciber);
            frmPersonasEnEspera.ShowDialog();
        }

        private void lbClientesEnEspera_SelectedIndexChanged(object sender, EventArgs e)
        {

            clienteSeleccionado = (Cliente)lbClientesEnEspera.SelectedItem;

            if (clienteSeleccionado is ClienteComputadora)
            {

                foreach (Button button in gbTelefonos.Controls)
                {
                    CambiarColorYEstadoDeBoton(button, rojo, false);
                }

                foreach (Button button in gbComputadoras.Controls)
                {
                    for (int i = 0; i < ciber.ListaComputadoras.Count; i++)
                    {
                        if (ciber.ListaComputadoras[i].Identificador == button.Text && ciber.ListaComputadoras[i].EstaLibre)
                        {
                            if (ciber.VerificarSiLaComputadoraTieneLosRequisitosDelCliente(ciber.ListaComputadoras[i],(ClienteComputadora)clienteSeleccionado))
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
            else
            {
                foreach (Button button in gbComputadoras.Controls)
                {
                    CambiarColorYEstadoDeBoton(button, rojo, false);
                }

                foreach (Button button in gbTelefonos.Controls)
                {
                    for (int i = 0; i < ciber.ListaTelefonos.Count; i++)
                    {
                        if (ciber[i].Identificador == button.Text && ciber[i].EstaLibre)
                        {
                            if (ciber.VerificarSiElTelefonoCumpleConLosRequisitosDelCliente(ciber[i], (ClienteTelefono)clienteSeleccionado))
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
                    if (ciber[i].Identificador == button.Text && ciber[i].EstaLibre == false)
                    {
                        button.Enabled = true;
                        break;
                    }
                    else if (ciber[i].Identificador == button.Text && ciber[i].EstaLibre)
                    {
                        button.Enabled = false;
                        break;
                    }

                }
            }

        }
        private void btnComputadora1_Click(object sender, EventArgs e)
        {
            LlamarFormComputadora(ciber.ListaComputadoras[0], clienteSeleccionado, btnComputadora1);
        }

        private void btnComputadora2_Click(object sender, EventArgs e)
        {
            LlamarFormComputadora(ciber.ListaComputadoras[1], clienteSeleccionado, btnComputadora2);
           
        }

        private void btnComputadora3_Click(object sender, EventArgs e)
        {
            LlamarFormComputadora(ciber.ListaComputadoras[2], clienteSeleccionado, btnComputadora3);
        }

        private void btnComputadora4_Click(object sender, EventArgs e)
        {
            LlamarFormComputadora(ciber.ListaComputadoras[3], clienteSeleccionado, btnComputadora4);
        }

        private void btnComputadora5_Click(object sender, EventArgs e)
        {
            LlamarFormComputadora(ciber.ListaComputadoras[4], clienteSeleccionado, btnComputadora5);

        }

        private void btnComputadora6_Click(object sender, EventArgs e)
        {
            LlamarFormComputadora(ciber.ListaComputadoras[5], clienteSeleccionado, btnComputadora6);

        }

        private void btnComputadora7_Click(object sender, EventArgs e)
        {
            LlamarFormComputadora(ciber.ListaComputadoras[6], clienteSeleccionado, btnComputadora7);

        }

        private void btnComputadora8_Click(object sender, EventArgs e)
        {
            LlamarFormComputadora(ciber.ListaComputadoras[7], clienteSeleccionado, btnComputadora8);
        }

        private void btnComputadora9_Click(object sender, EventArgs e)
        {
            LlamarFormComputadora(ciber.ListaComputadoras[8], clienteSeleccionado, btnComputadora9);

        }

        private void btnComputadora10_Click(object sender, EventArgs e)
        {
            LlamarFormComputadora(ciber.ListaComputadoras[9], clienteSeleccionado, btnComputadora10);
        }

        private void btnTelefono1_Click(object sender, EventArgs e)
        {
            LlamarFormTelefono(ciber[0], clienteSeleccionado, btnTelefono1);
        }


        private void btnTelefono2_Click(object sender, EventArgs e)
        {
            LlamarFormTelefono(ciber[1], clienteSeleccionado, btnTelefono2);

        }

        private void btnTelefono3_Click(object sender, EventArgs e)
        {
            LlamarFormTelefono(ciber[2], clienteSeleccionado, btnTelefono3);
        }

        private void btnTelefono4_Click(object sender, EventArgs e)
        {
            LlamarFormTelefono(ciber[3], clienteSeleccionado, btnTelefono4);
        }

        private void btnTelefono5_Click(object sender, EventArgs e)
        {
            LlamarFormTelefono(ciber[4], clienteSeleccionado, btnTelefono5);
        }
        private void LlamarFormTelefono(Telefono telefono, Cliente cliente, Button button)
        {
            FrmTelefono frmTelefono = new FrmTelefono(telefono, cliente);
            DialogResult dialogResult = frmTelefono.ShowDialog();

            if (frmTelefono.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(button, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;
            }
            if (frmTelefono.ConfirmarFinalizarSesion == DialogResult.Yes)
            {
                CambiarColorYEstadoDeBoton(button, verde, true);
                ciber.HistorialTelefonos.Add(telefono);

            }
            ActualizarFormulario();

        }

        private void LlamarFormComputadora(Computadora computadora, Cliente cliente, Button button)
        {

            frmComputadora frmComputadora = new frmComputadora(computadora, cliente);
            DialogResult dialogResult = frmComputadora.ShowDialog();
            if (frmComputadora.ConfirmarAsignacion == DialogResult.Yes)
            {
                ciber.ListaClientes.Dequeue();
                CambiarColorYEstadoDeBoton(button, rojo, false);
                RefrescarListBoxClientesEnEspera();
                lbClientesEnEspera.SelectedItem = null;
            }
            if (frmComputadora.ConfirmarFinalizarSesion == DialogResult.Yes)
            {

                CambiarColorYEstadoDeBoton(button, verde, true);
                ciber.HistorialComputadoras.Add(computadora);
            }

            ActualizarFormulario();
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message = "Colores de las maquinas:\n" +
                "Verde: Maquina disponible que cumple los requierimientos del usuario\n" +
                "Naranaja: Maquina que se encuentra disponible pero no cumple los requirimientos del usuario\n" +
                "Rojo:Maqiuna que no se encuentra disponible.\n" +
                "- Si seleccionas un cliente y mantienes el puntero sobre los botones habilitados te aparecera un cuadro con la informacion de la computadora.\n" +
                "- Para asignar un cliente a una maquina debes seleccionar el cliente en el cuadro de la izquierda y" +
                "luego seleccionar la maquina que se encuentre en color verde, se abrira un nuevo formulario donde encontraras la informacion de la maquina " +
                "y podras asignar al usuario antes seleccionado.\n" +
                "- Para mostrar los clientes en espera presiona el boton \"Mostrar clientes en espera\" que abrira un nuevo formulario.\n" +
                "- Para finalizar cualquier maquina deberas presionar el boton \"Finalizar\", se habilitaran los equipos que estan siendo" +
                "utilizados, al seleccionar el que se quiera se habilitara la opcion finalizar en el equipo.";
                
            MessageBox.Show(message , "Help" , MessageBoxButtons.OKCancel , MessageBoxIcon.Information);
        }
    }
}

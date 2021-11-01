using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaCiber
{
    public partial class FrmCalculadoraSalario : Form
    {
        private Usuario usuario;
        public FrmCalculadoraSalario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario; 
        }

        private void FrmCalculadoraSalario_Load(object sender, EventArgs e)
        {
            tbApellido.Text = usuario.Apellido;
            tbNombre.Text = usuario.Nombre;
            tbEdad.Text = usuario.Edad.ToString();
            tbDni.Text = usuario.Dni.ToString();

        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            float salarioPorHora;
            bool numeroValido = false;

            if(float.TryParse(tbSalarioPorHora.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out salarioPorHora))
            {
                numeroValido = true;
            }

            if(tbSalarioPorHora.Text != string.Empty && numeroValido)
            {
                usuario.SalarioPorHora = salarioPorHora;
                usuario.DiasTrabajados = (int)nupDiasTrabajados.Value;
                usuario.HorasTrabajadas = (int)nupHorasTrabajadas.Value;

                usuario.CalcularSalarioBruto();

                if (cbxJubilacion.Checked)
                {
                    usuario.AplicarImpuesto(usuario.SalarioMensualBruto, 11);
                }
                if (cbxObraSocial.Checked)
                {
                    usuario.AplicarImpuesto(usuario.SalarioMensualBruto, 3);
                }
                if (cbxSindicato.Checked)
                {
                    usuario.AplicarImpuesto(usuario.SalarioMensualBruto, 5);
                }
                if (cbxImpuestoALasGanancias.Checked && usuario.SalarioMensualBruto > 500)
                {
                    usuario.AplicarImpuesto(usuario.SalarioMensualBruto, 10);
                }

                rtbInformacionSalario.Text = MostrarInfomacionSalario();

            }
            else if(!numeroValido)
            {
                MessageBox.Show("El campo salario por hora debe ser solamente numeros por favor ingrese un salario valido.", "Campo invalido", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El campo salario por hora no puede estar vacio por favor ingrese un salario.", "Campo vacio", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            
        }

        private string MostrarInfomacionSalario()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Salario por hora: {usuario.SalarioPorHora}");
            sb.AppendLine($"Horas trabajadas por dia: {usuario.HorasTrabajadas}");
            sb.AppendLine($"Dias trabajados en el mes: {usuario.DiasTrabajados}");
            sb.AppendLine($"Salario mensual bruto: (sin impuestos): {usuario.SalarioMensualBruto}");
            
            sb.AppendLine($"----------------Impuestos aplicados----------------");
            if (cbxJubilacion.Checked)
            {
                sb.AppendLine($"Jubilacion (11%): {usuario.CalcularImpuesto(usuario.SalarioMensualBruto , 11)}");

            }
            if (cbxObraSocial.Checked)
            {
                sb.AppendLine($"Obra social (3%): {usuario.CalcularImpuesto(usuario.SalarioMensualBruto, 3)}");

            }
            if (cbxSindicato.Checked)
            {
                sb.AppendLine($"Sindicato (5%): {usuario.CalcularImpuesto(usuario.SalarioMensualBruto, 5)}");

            }
            if (cbxImpuestoALasGanancias.Checked && usuario.SalarioMensualBruto > 500)
            {
                sb.AppendLine($"Impuesto a las ganancias (10%): {usuario.CalcularImpuesto(usuario.SalarioMensualBruto, 10)}");
            }

            sb.AppendLine($"Salario mensual neto (con impuestos): {usuario.SalarioMensualNeto}");


            return sb.ToString();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            string message = "En este form podras calcular el salario del usuario ingresando el salario a pagar por hora, las horas trabajadas en el dia y los dias trabajados en el mes. \n" +
                "tambien podras ingresar los impuestos si es que esta en blanco.\n" +
                "Los impuestos que podras seleccionar son:\n" +
                "- Jubilacion\n" +
                "- Aportes al sindicato\n" +
                "- Aporte de obra social\n" +
                "- Impuesto a las ganancias (solamente se aplicara si el salario neto es mayor a 500)\n" +
                "Para que se realice el calculo deberas presionar el boton \"Calcular salario\" que realizara las cuentas correspondientes y la informacion sera mostrada en el cuadro blanco.";

            MessageBox.Show(message, "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
        }
    }
}

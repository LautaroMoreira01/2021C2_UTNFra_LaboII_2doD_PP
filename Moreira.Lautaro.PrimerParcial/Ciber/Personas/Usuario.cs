using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        private float salarioHora;
        private int horasTrabajadas;
        private int  diasTrabajados;
        private float salarioMensualNeto;
        private float salarioMensualBruto;
        
        /// <summary>
        /// Constructor de Usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="salarioHora"></param>
        public Usuario(string nombre, string apellido, int edad, long dni , float salarioHora) 
            : base( nombre , apellido , edad , dni)
        {
            this.salarioHora = salarioHora;
            salarioMensualBruto = 0;
        }
        
        /// <summary>
        /// Sobrescritura del metodo tostring
        /// </summary>
        /// <returns>informacion del usuario.</returns>
        public override string ToString()
        {
            return MostrarInformacionPersonal();
        }

        /// <summary>
        /// Calcula el salario bruto del usuario (sin impuestos)
        /// </summary>
        public void CalcularSalarioBruto()
        {
            salarioMensualBruto = (salarioHora * horasTrabajadas) * diasTrabajados;
            salarioMensualNeto = salarioMensualBruto;

        }

        /// <summary>
        /// Calcula el valor del impuesto
        /// </summary>
        /// <param name="salarioBruto">salario total sin impuestos</param>
        /// <param name="impuesto">porcentaje del impuesto a calcular</param>
        /// <returns>valor del impuesto</returns>
        public float CalcularImpuesto(float salarioBruto, int impuesto)
        {

            return (salarioBruto * ((float)impuesto / 100));

        }

        /// <summary>
        /// Aplica el impuesto al salario neto
        /// </summary>
        /// <param name="salarioBruto">Salario sin impuestos</param>
        /// <param name="impuesto">porcentaje del impuesto a aplicar</param>
        public void AplicarImpuesto(float salarioBruto, int impuesto)
        {
            salarioMensualNeto -=  CalcularImpuesto(salarioBruto , impuesto);
        }

        /// <summary>
        /// Propiedad que retorna el salario por hora del usuario
        /// </summary>
        public float SalarioPorHora 
        {
            get {return salarioHora; }
            set { salarioHora = value; }
        }

        /// <summary>
        /// Retorna o asinga las horas trabajadas
        /// </summary>
        public int HorasTrabajadas 
        {
            get {return horasTrabajadas; }
            set
            {
                if (value <= 10 && value > 0 )
                {
                    horasTrabajadas = value;
                }
                else
                {
                    horasTrabajadas = -1;
                }
            }
        }

        /// <summary>
        /// asina o retorna la cantidad de dias trabajados
        /// </summary>
        public int DiasTrabajados
        {
            get {return diasTrabajados; }
            set
            {
                if (value <= 31 && value > 0 )
                {
                    diasTrabajados = value;
                }
                else
                {
                    diasTrabajados = -1;
                }
            }
        }

        /// <summary>
        /// asigna o retorna la el salario neto
        /// </summary>
        public float SalarioMensualNeto
        {
            get {return salarioMensualNeto; }
            set
            {
                salarioMensualNeto = value;
            }
        }

        /// <summary>
        /// asigna o retorna la el salario bruto
        /// </summary>
        public float SalarioMensualBruto
        {
            get {return salarioMensualBruto; }
            set
            {
                salarioMensualBruto = value;
            }
        }

    }
}

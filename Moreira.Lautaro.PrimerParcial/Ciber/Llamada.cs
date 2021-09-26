
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Llamada
    {
    
        private string numero;
        private float costoLlamada;
        private float duracionLlamada;//VER COMO CALCULAR LA DURACION
        //Podes calcular un random entre 1 y 60 que lo vas a poner y esos van a ser los segundos que va a durar la llamda
        //Puede ser con dos dateTime y un timeSpan
        //o con un timer.
        private ETipoLlamada tipoLlamada;

        public Llamada(string numero)
        {
            this.numero = numero;
            this.tipoLlamada = TipoLlamada;
        }

        public string NumeroDestino
        {
            get {return numero; } 
        }

        public ETipoLlamada TipoLlamada
        {
            get          
            {
                ETipoLlamada llamada = ETipoLlamada.Local;

                //numero.Split('-');//Decirle al usuario que tiene que poner el numero sin( -(giones) +(mas) o " " (Espacios))
                
                for (int i = 0; i < numero.Length; i++)
                {
                    if (numero[0] != '5')
                    {
                        llamada = ETipoLlamada.Internacional;
                    }
                    else if (numero[2] != '0' && (numero[2] != '1' && numero[3] != '1'))
                    {
                        llamada = ETipoLlamada.LargaDistancia;
                    }
                    else
                    {
                        llamada = ETipoLlamada.Local;
                    }

                }
                return llamada;

            }

        }

        //Podes hacerlo una propiedad que se fije el costo por zona y lo devuelva
        private float Costo()
        {
            if(this.TipoLlamada == ETipoLlamada.Internacional)
            {
                return 5.00F;
            }else if (this.TipoLlamada == ETipoLlamada.LargaDistancia)
            {
                return 2.50F;
            }
            else
            {
                return 1.00F;
            }
        }

        public float CostoLlamada
        {
            get
            {
                return this.Costo() * this.duracionLlamada;
            }
        }
        //private float CalcularCostoPorLlamada()
        //{
        //    if(this.TipoLlamada == ETipoLlamada.Internacional)
        //    {
        //        return 5.00F;
        //    }else if (this.TipoLlamada == ETipoLlamada.LargaDistancia)
        //    {
        //        return 2.50F;
        //    }
        //    else
        //    {
        //        return 1.00F;
        //    }
        //}

        //Metodo finalizar llamada.

        public enum ETipoLlamada
        {
            Local,LargaDistancia,Internacional
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        //public override int GetHashCode()
        //{ }
    }
}

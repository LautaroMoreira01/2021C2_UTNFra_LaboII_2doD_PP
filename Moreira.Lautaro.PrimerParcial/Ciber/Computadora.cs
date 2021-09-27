using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora
    {
        private bool estado; //Puedo hacer una clase base con estado identificador propiedades y metodos que sean iguales en computadora y telefono
        // PAra no hacer siempre lo mismo.
        //Nose como llamarla 
        //Electronico?
        //
       
        private string identificador;
        private TimeSpan tiempoDeUso;
        private const float costoDeUso = 0.50F;
        private List<Hardware> listHardware;
        private List<Juegos> listJuegos;
        private List<Software> listSoftware;
        private List<Perifericos> listPerifericos;
        private SistemaOperativo so;

        public Computadora(List<Hardware> hardware , List<Juegos> juegos , List<Software> software 
            , List<Perifericos> perifericos  , SistemaOperativo so , string identificador , TimeSpan tiempoDeUso)
        {
            this.listHardware = hardware ;
            this.listJuegos = juegos ;
            this.listSoftware = software;
            this.listPerifericos = perifericos;
            this.so = so;
            this.estado = true;
            this.identificador = identificador;
            this.tiempoDeUso = tiempoDeUso;
        }

        public bool Estado
        {
            get {return estado; }
            set { estado = value;  }
        
        }
        public string Identificador
        {
            get { return identificador; }
        }

        
        private float CalcularCostoDeUso()
        {
            //Pasar todo a segundos y buscar si es modulo de 30?
            int minutosDeUso = tiempoDeUso.Seconds;
            float costo ;
            costo = (minutosDeUso / 30) * costoDeUso;//Divide por 30 la todo el total de minutos y te da cuantos 30 minutos hay
            

            if(minutosDeUso % 30 > 0) //Por mas que los minutos de uso sean menores a 30 te los cobra
                //Si hay sobrante de minutos "redondea" para arriba y te suma otra media hora de costo de uso
            {
                costo += costoDeUso;
            }

            
            return costo; //
        }
        //Deberia mostrar la computadora con el cliente que la esta usando?
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Computadora: {identificador}");
            sb.AppendLine($"Sistema operativo: {so}");
            sb.AppendLine($"Estado: {Estado}");
            sb.AppendLine($"tiempo de uso: {tiempoDeUso}");

            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Hardware:");
            foreach (Hardware item in listHardware)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Software:");
            foreach (Software item in listSoftware)
            {
                sb.AppendLine($"{item.ToString()}");
            
            }
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Juegos:");
            foreach (Juegos item in listJuegos)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            sb.AppendLine($"--------------------------------------");

            sb.AppendLine($"Perifericos:");
            foreach (Perifericos item in listPerifericos)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            sb.AppendLine($"--------------------------------------");
            return sb.ToString();

        }


        public override string ToString()
        {
            return Mostrar();
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

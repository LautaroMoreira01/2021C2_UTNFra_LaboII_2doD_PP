using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora
    {
        private const float costoDeUso = 0.50F;
        private bool estado;
        private string identificador;
        private List<Hardware> listHardware;
        private List<Juegos> listJuegos;
        private List<Software> listSoftware;
        private List<Perifericos> listPerifericos;
        private SistemaOperativo so;

        public Computadora(List<Hardware> hardware , List<Juegos> juegos , List<Software> software 
            , List<Perifericos> perifericos  , SistemaOperativo so , string identificador)
        {
            this.listHardware = hardware ;
            this.listJuegos = juegos ;
            this.listSoftware = software;
            this.listPerifericos = perifericos;
            this.so = so;
            this.estado = true;
            this.identificador = identificador;
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
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Computadora: {identificador}");
            sb.AppendLine($"Sistema operativo: {so}");
            sb.AppendLine($"Estado: {Estado}");
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

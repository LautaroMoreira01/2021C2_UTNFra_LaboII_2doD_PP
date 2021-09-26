using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Telefono
    {

        private bool estado;
        private string identificador;
        private Llamada llamada;
        private ETipo tipo;

        public Telefono(bool estado, string identificador, ETipo tipo)
        {
            this.estado = estado;
            this.identificador = identificador;
            this.tipo = tipo;
        }

        public enum ETipo
        {
            ADisco, Teclado
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }

        }
        public string Identificador
        {
            get { return identificador; }
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Computadora: {identificador}");
            sb.AppendLine($"Tipo: {tipo.ToString()}");
            sb.AppendLine($"Estado: {Estado}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        


    }
}

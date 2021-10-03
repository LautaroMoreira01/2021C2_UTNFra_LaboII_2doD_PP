using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private List<Software> requerimientoSoftware;
        private List<Hardware> requerimientoHardware;
        private List<Juegos> requerimientoJuegos;
        private List<Perifericos> requerimientoPerifericos;
        private Telefono.ETipo requerimientoTipoTelefono;

        private bool enEspera;//En espera true o ya fue atendido false 
 
        public Cliente(string nombre, string apellido, int edad , long dni) : base(nombre, apellido, edad , dni)
        {
            enEspera = true;
        }
        public Cliente(string nombre, string apellido, int edad, long dni , Telefono.ETipo requerimientoTipoTelefono) : base(nombre, apellido, edad, dni)
        {
            this.requerimientoTipoTelefono = requerimientoTipoTelefono;
        }
        #region Constructores para computadora.


        public Cliente(string nombre, string apellido, int edad, long dni 
            , List<Software> requerimientoSoftware
            , List<Hardware> requerimientoHardware
            , List<Juegos> requerimientoJuegos
            , List<Perifericos> requerimientoPerifericos
            ) : this(nombre , apellido , edad , dni)
        {
            this.requerimientoSoftware = requerimientoSoftware;
            this.requerimientoHardware = requerimientoHardware;
            this.requerimientoJuegos = requerimientoJuegos;
            this.requerimientoPerifericos = requerimientoPerifericos;
        }

        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Hardware> requerimientoHardware
            , List<Juegos> requerimientoJuegos
            , List<Perifericos> requerimientoPerifericos)
            : this(nombre, apellido, edad, dni, new List<Software>(), requerimientoHardware, requerimientoJuegos, requerimientoPerifericos)
        { }
        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Software> requerimientoSoftware
            , List<Juegos> requerimientoJuegos
            , List<Perifericos> requerimientoPerifericos)
            : this(nombre, apellido, edad, dni, requerimientoSoftware, new List<Hardware>(), requerimientoJuegos, requerimientoPerifericos)
        { }

        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Software> requerimientoSoftware
            , List<Hardware> requerimientoHardware
            , List<Perifericos> requerimientoPerifericos)
            : this(nombre, apellido, edad, dni, requerimientoSoftware, requerimientoHardware, new List<Juegos>(), requerimientoPerifericos)
        { }
        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Software> requerimientoSoftware
            , List<Hardware> requerimientoHardware
            , List<Juegos> requerimientoJuegos)
            : this(nombre, apellido, edad, dni, requerimientoSoftware, requerimientoHardware, requerimientoJuegos, new List<Perifericos>())
        { }

        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Software> requerimientosoftware
            , List<Hardware> requerimientohardware)
            : this(nombre, apellido, edad, dni, requerimientosoftware, requerimientohardware , new List<Perifericos>())
        { }

        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Software> requerimientoSoftware
            , List<Perifericos> requerimientoPerifericos)
            : this(nombre, apellido, edad, dni, requerimientoSoftware, new List<Hardware>(), requerimientoPerifericos)
        { }
        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Software> requerimientoSoftware
            , List<Juegos> requerimientoJuegos)
            : this(nombre, apellido, edad, dni, requerimientoSoftware,requerimientoJuegos, new List<Perifericos>())
        { }

        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Hardware> requerimientoHardware
            , List<Juegos> requerimientoJuegos)
            : this(nombre, apellido, edad, dni,  requerimientoHardware, requerimientoJuegos, new List<Perifericos>())
        { }
        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Hardware> requerimientoHardware
            , List<Perifericos> requerimientoPerifericos)
            : this(nombre, apellido, edad, dni, requerimientoHardware, new List<Juegos>(), requerimientoPerifericos)
        { }

        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Juegos> requerimientoJuegos
            , List<Perifericos> requerimientoPerifericos)
            : this(nombre, apellido, edad, dni, new List<Software>(), requerimientoJuegos, requerimientoPerifericos)
        { }
        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Software> requerimientoSoftware)
            : this(nombre, apellido, edad, dni, requerimientoSoftware, new List<Perifericos>())
        { }
        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Hardware> requerimientoHardware)
            : this(nombre, apellido, edad, dni, new List<Software>(), requerimientoHardware)
        { }
        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Juegos> requerimientoJuegos)
            : this(nombre, apellido, edad, dni,  requerimientoJuegos, new List<Perifericos>())
        { }
        public Cliente(string nombre, string apellido, int edad, long dni
            , List<Perifericos> requerimientoPerifericos)
            : this(nombre, apellido, edad, dni, new List<Software>(), requerimientoPerifericos)
        { }
        #endregion

        public bool EnEspera
        {
            get {return enEspera; }
            set { enEspera = value; } 
        }
        public override string Mostrar()
        {
            return base.Mostrar();
        }

    }
}

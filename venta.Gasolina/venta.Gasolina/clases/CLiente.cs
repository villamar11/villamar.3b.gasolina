using System;
using System.Collections.Generic;
using System.Text;

namespace venta.Gasolina.clases
{
    public class CLiente
    {
        private String apellidos;

        public String APELLIDOS
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private String nombres;

        public String NOMBRE
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private int cedula;

        public int CEDULA
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private String dirección;

        public String DIRECCIÓN
        {
            get { return dirección; }
            set { dirección = value; }
        }

        public CLiente(string aPELLIDOS, string nOMBRE, int cEDULA, string dIRECCIÓN)
        {
            APELLIDOS = aPELLIDOS;
            NOMBRE = nOMBRE;
            CEDULA = cEDULA;
            DIRECCIÓN = dIRECCIÓN;
        }



        // public CLiente(string apellidos, string nombres, int cedula, string dirección)
        // {
        //  this.apellidos = apellidos;
        //this.nombres = nombres;
        //this.cedula = cedula;
        //this.dirección = dirección;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace venta.Gasolina.clases
{
   public class GAsolina
    {


        
        private String tipo;

        public String TIPO
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private int galones;

        public int GALONES
        {
            get { return galones; }
            set { galones = value; }
        }



        private float precio;

        public float PRECIO
        {
            get
            {
                if (TIPO == "SUPER") 
                {
                    precio = 2f;
                    return precio;
                }
                else
                {
                    if (TIPO == "Extra")
                    
                        precio = 1.5f;
                        return precio;

                    
                }

            }

        }



        public float SUBTOTAL
        {
            get { return PRECIO * GALONES; }
            
        }
       

        public float IVA
        {
            get { return SUBTOTAL* 0.12f; }
            
        }
        

        public float TOTALPAGO
        {
            get { return SUBTOTAL + IVA ; }
           
        }

        public GAsolina(string tipo, int galones, float precio)
        {
            this.tipo = tipo;
            this.galones = galones;
            this.precio = precio;
        }

        
    }
}

using System;
using venta.Gasolina.clases;
namespace venta.Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            CLiente informacioncliente = new CLiente("villamar", "lisseth", 1314844406,"montecristi");
            GAsolina infogasolina = new GAsolina("Extra", 3,5);
          


            Console.WriteLine("  ***************FACTURA GASOLINA *************** ");
            Console.WriteLine();
            Console.WriteLine(" INGRESE LOS DATOS DEL CLIENTE  ");
            Console.WriteLine("____________________________________");
           

            Console.Write(" APELLIDOS: ");
            informacioncliente.APELLIDOS = Console.ReadLine();
            Console.Write(" NOMBRES : "+" ");
            informacioncliente.NOMBRE = Console.ReadLine();
            Console.Write(" # CÉDULA: "+" ");
            informacioncliente.CEDULA = int.Parse(Console.ReadLine());
            Console.Write(" DIRECCIÓN: "+" ");
            informacioncliente.DIRECCIÓN = Console.ReadLine();

            Console.WriteLine(" ---------- INFORMACIÓN DE LA VENTA ---------- ");
            Console.WriteLine(" TIPO DE GASOLINA INGRESE SEGUN DESEE:  EXTRA , SUPER  ");
            infogasolina.TIPO = Console.ReadLine();
            Console.WriteLine(" CANTIDAD DE GALONES:"+"   ");
            infogasolina.GALONES = int.Parse(Console.ReadLine());
            Console.WriteLine(" PRECIO POR GALÓN: " + infogasolina.PRECIO);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(  "   "+ "   " + "SUBTOTAL: " + infogasolina.SUBTOTAL);
            Console.WriteLine("   " + "   " + "IVA: " + infogasolina.IVA);
            Console.WriteLine("   " + "   " + " TOTAL: " + infogasolina.TOTALPAGO);
            Console.WriteLine("   " + "   " + "GRACIAS PRO SU CONSUMO, TENGA UN BUEN DÍA ");



        }
        
    }
}

using System;
using venta.Gasolina.clases;
namespace venta.Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            CLiente datocliente = new CLiente("villamar", "lisseth", 1314844406,"montecristi");
            GAsolina datogasolina = new GAsolina("Extra", 3, 2.5f);

            Console.WriteLine(" ---------- FACTURA GASOLINA ---------- ");
            Console.WriteLine(" ---------- INFORMACION DEL CLIENTE ---------- ");
            Console.WriteLine(" APELLIDOS: ");
            datocliente.APELLIDOS = Console.ReadLine();
            Console.WriteLine(" NOMBRES: ");
            datocliente.NOMBRE = Console.ReadLine();
            Console.WriteLine(" # CEDULA: ");
            datocliente.CEDULA = int.Parse(Console.ReadLine());
            Console.WriteLine(" DIRECCION: ");
            datocliente.DIRECCIÓN = Console.ReadLine();

            Console.WriteLine(" ---------- INFORMACION DE LA VENTA ---------- ");
            Console.WriteLine(" TIPO DE GASOLINA INGRESE SEGUN DESEE:  EXTRA , SUPER  ");
            datogasolina.TIPO = Console.ReadLine();
            Console.WriteLine(" CANTIDAD DE GALONES: ");
            datogasolina.GALONES = int.Parse(Console.ReadLine());
            Console.WriteLine(" PRECIO POR GALON: " + datogasolina.PRECIO);

            Console.WriteLine(" -------------------- SUBTOTAL: " + datogasolina.SUBTOTAL);
            Console.WriteLine(" -------------------- IVA: " + datogasolina.IVA);
            Console.WriteLine(" -------------------- TOTAL: " + datogasolina.TOTALPAGO);



        }
        
    }
}

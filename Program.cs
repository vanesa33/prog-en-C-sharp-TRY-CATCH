using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;


namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio, total;
            int cantidad;

            try
            {
                Console.WriteLine("cantidad: ");
                cantidad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Precio: ");
                precio = Convert.ToDouble(Console.ReadLine());

                total = precio * cantidad;

                Console.WriteLine("el total es: " + total);
            }

             catch(Exception error)
            {

                Console.WriteLine("ha ocurrido un error" + error.Message);
            }


            Console.ReadKey();

        }
    }
}

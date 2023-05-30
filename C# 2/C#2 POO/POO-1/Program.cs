using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];
            for(int x=0; x < articulos.Length; x++)
            {
                articulos[x] = new Articulo();
            }

            for(int x=0; x < articulos.Length; x++)
            {
                Console.WriteLine("Ingresa los datos del articulo...");
                Console.WriteLine("Codigo: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Codigo de Marca: ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = int.Parse(Console.ReadLine());

                // primera parte
             
            }
            // Segunda parte..
            Venta venta = new Venta();

            Console.WriteLine("Ingresa los datos de la venta: ");
            Console.WriteLine("Cliente: ");
            venta.CodCliente = int.Parse(Console.ReadLine());

            while (venta.CodCliente != 0)
            {
                Console.WriteLine("Codigo de Articulo: ");
                venta.CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                // procesos

                //pedir again
                Console.WriteLine("Ingresa los datos de la venta: ");
                Console.WriteLine("Cliente: ");
                venta.CodCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}

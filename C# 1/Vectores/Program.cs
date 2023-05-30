using System;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            // float prom=0, acu=0;
            // float[] numeros= new float[10];

            // for(int x=0; x<10 ; x++){
            //     Console.WriteLine("Ingrese un numero:");
            //     numeros[x] = int.Parse(Console.ReadLine());
            // }
            // for (int y=0 ; y<10 ; y++){
            //     acu += numeros[y];
            //     prom = acu / 10;
            // }
            // Console.WriteLine("El promedio es "+prom);

            // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.

            int cant, n;
            int[] articulos = new int[15];

            for(int x=0 ; x<15 ; x++){
                articulos[x] = 0;
            }

            Console.WriteLine("Ingresá Nº de artículo: ");
            n= int.Parse(Console.ReadLine());
            Console.WriteLine("Y la cantidad: ");
            cant= int.Parse(Console.ReadLine());

            while (n != 0){
                
                articulos[n-1] += cant;

                Console.WriteLine("Ingresá Nº de artículo: ");
                n= int.Parse(Console.ReadLine());
                Console.WriteLine("Y la cantidad: ");
                cant= int.Parse(Console.ReadLine());
            }
            // A
            int maxCant, maxArt;
            maxCant= articulos[0];
            maxArt= 1;

            for (int x=0 ; x<15 ; x++){
                if (articulos[x] > maxCant){
                    maxCant= articulos[x];
                    maxArt= x+1;
                } 
            }
            Console.WriteLine("El producto con mas ventas registradas es el Nº"+maxArt+" con "+maxCant+" ventas.");

            // B
            for(int x=0 ; x<15 ; x++){
                if (articulos[x] == 0){
                    Console.WriteLine("El artículo Nº"+ (x+1) +" no ha registrado ventas.");
                }
            }
            // C
            Console.WriteLine("El articulo Nº10, registró "+articulos[9]+" ventas.");
        }
    }
}

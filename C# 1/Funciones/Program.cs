using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // PUNTO 1
            // int cant, precio, total;

            // Console.WriteLine("Ingrese precio: ");
            // precio= int.Parse(Console.ReadLine());
            // Console.WriteLine("Cantidad: ");
            // cant= int.Parse(Console.ReadLine());

            // total= multiplicar(precio, cant);
            // Console.WriteLine("El total es $"+total);


            // PUNTO 2
            // int n, con=0;

            // for(int x=0 ; x<20 ; x++)
            // {
            //     Console.WriteLine("Ingresa nro: ");
            //     n= int.Parse(Console.ReadLine());

            //     if(par(n) == true)
            //         con++;
            // }
            // Console.WriteLine("Se ingresaron "+con+" nros pares.");


            // PUNTO 3
            // int n, conprimo=0, totPrimos=0, promedio;
            // bool bPrimo= false;

            // Console.WriteLine("ingresa un numero: ");
            // n= int.Parse(Console.ReadLine());

            // while(n != 0)
            // {
            //     bPrimo= primo(n);

            //     if(bPrimo == true)
            //     {
            //         conprimo++;
            //         totPrimos += n;
            //     }
            //     Console.WriteLine("ingresa un numero: ");
            //     n= int.Parse(Console.ReadLine());
            // }
            // promedio= totPrimos / conprimo;
            // Console.WriteLine("El promedio es "+promedio+", calculado entre "+conprimo+" numeros primos.");


            // PUNTO 4
            // int n;
            // int estado=0;

            // Console.WriteLine("Ingresa un nro a evaluar: ");
            // n= int.Parse(Console.ReadLine());

            // posNegZero(n, ref estado);
            // if(estado == 1)
            //     Console.WriteLine("El numero es positivo.");
            // else if(estado == 0)
            //     Console.WriteLine("El numero es cero.");
            // else Console.WriteLine("El numero es negativo.");
        }
        // Functions
        // Producto
        static int multiplicar(int a, int b)
        {
            int r;
            r= a * b;
            return r;
        }
        // Par
        static bool par(int a)
        {
            
            if (a % 2 == 0)
            {
                return true;
            }   return false;
        }
        // Primo
        static bool primo(int a)
        {
            int con=0;
            for(int x=0 ; x<a ; x++)
            {
                if(a == 1)
                    con++;
                if(a % (x+1) ==0)
                    con++;
            }
            if(con == 2)
                return true;
            else 
                return false;
        }
        // Positivo Negativo o Cero.
        static void posNegZero(int n, ref int estado)
        {
            if(n > 0)
                estado= 1;
            else if(n < 0)
                estado= -1;
        }
    }
}

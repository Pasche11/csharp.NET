using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,r;
            int op;
            r=0;

            Console.WriteLine("Ingresa un numero");
            n1= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro");
            n2= int.Parse(Console.ReadLine());

            Console.WriteLine("Que operacion hago?");
            Console.WriteLine("OPCIONES:");
            Console.WriteLine("1:suma");/* reveer orden del programa para hacer algo mas acercado a una verdadera calculadora */
            Console.WriteLine("2:resta");
            Console.WriteLine("3:multiplica");
            Console.WriteLine("4:divide");
            op= int.Parse(Console.ReadLine());
            if (op== 1) {
                r= n1+n2;
            } else if (op== 2) {
                r= n1-n2;
            } else if (op== 3) {
                r= n1*n2;
            } else if (op== 4) {
                r= n1/n2;
            }
            Console.WriteLine("El resultado es: "+r);
        }
    }
}

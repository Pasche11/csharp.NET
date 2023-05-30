using System;

namespace TPfinal_PaschettaGaston
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
                // a. El mayor de los números pares.
                // b. La cantidad de números impares.
                // c. El menor de los números primos.
            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            bool bPar = false, bPrimo = false;
            int n, parMax=0, impares=0, minPrimo=0, con=0;
 
            /* ----- Estructura gral. ----- */
            while(n != 0){
                if(n % 2 == 0){

                    if(bPar==false){

                        parMax= n;
                        bPar= true;
                    }{
                        if(n > parMax)
                            parMax= n;
                    }
                }else
                    impares++;
                // lectura de funcion
                Console.WriteLine("PRIMO ALERT: "+esPrimo(n)+"\n");
                if(esPrimo(n) == true){
                    if(bPrimo==false){
                        minPrimo = n;
                        bPrimo= true;
                    }else
                        if(n < minPrimo)
                            minPrimo = n;
                }

                con++;
                Console.WriteLine("Continúe: ");
                n= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Para tu lista de "+con+" números, los resultados son:\n");
            Console.WriteLine("Maximo número PAR: "+parMax);
            Console.WriteLine("Cantidad de IMPARES: "+impares);
            Console.WriteLine("Mínimo número PRIMO: "+minPrimo+"\n");
        }
        // PRIMOS function
        static bool esPrimo(int n){            
            int con =0;
            for(int x=1 ; x<=n ; x++){
                if(n % x == 0)
                    con++;                
            }
            if(con != 2)
                return false;
            else
                return true;
        }
    }
}

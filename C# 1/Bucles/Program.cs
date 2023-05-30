using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.

            // for (int x=0 ; x<10 ; x++){
            //     Console.WriteLine(x+1);
            // }

            // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            // int n, max=0;
            // for (int x=0 ; x<10 ; x++){
            //     Console.WriteLine("Ingresa un nro: ");
            //     n= int.Parse(Console.ReadLine());
            //     if(max == 0){
            //         max = n;
            //     }else{
            //         if(n > max)
            //             max = n;
            //     }
            // }
            // Console.WriteLine("El numero mas grande de los 10 ingresados es: " + max);

            // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            // int edad;
            // float pEdad, mayores=0, edades=0;
            // Console.WriteLine("Ingresa 20 edades");
            // Console.WriteLine();
            // for(int x=0 ; x<20 ; x++){
            //     edad= int.Parse(Console.ReadLine());
                
            //     if(edad >= 18){
            //         mayores++;
            //         edades += edad;
            //     }
            // }
            // pEdad= edades / mayores;
            // Console.WriteLine("La edad promedio entre "+mayores+" mayores, es de "+pEdad+" años.");

            // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.
            // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            // int n, con=0;
            
            // Console.WriteLine("Ingresa un numero para saber si es primo o no.");
            // n = int.Parse(Console.ReadLine());

            // for(int x=0 ; x<=n ; x++){
            //     if(x > 0 && x <= n){
            //         if(n % x == 0)
            //             con++;
            //     }
            // }
            // if(con == 2){
            //     Console.WriteLine("El numero ingresado ES PRIMO.");
            // }else{
            //     Console.WriteLine("El numero ingresado NO ES PRIMO.");
            // }

            // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

            int n, par=0, imp=0, parMax=0, parMin=0;
            
            for(int x=0 ; x<10 ; x++){
                n= int.Parse(Console.ReadLine());
                if(n % 2 == 0){
                    if(par==0){
                        parMax= n;
                    }{
                        if(n > parMax)
                            parMax= n;
                    }
                    par++;
                }else{
                    if(imp==0){
                        parMin= n;
                    }{
                        if(n < parMin)
                            parMin= n;
                    }
                    imp++;
                }
            }
            Console.WriteLine("El maximo de los "+par+" pares es "+parMax+" y el menor de los "+imp+" impares es "+parMin);
        }
    }
}

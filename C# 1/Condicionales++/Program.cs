using System;

namespace Condicionales__
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            // La resta si el primero es mayor que el segundo.
            // La suma si son iguales.
            // El producto si el primero es menor.
            // int a,b,r;
            // Console.WriteLine("Ingrese un número");
            // a= int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese un segundo número");
            // b= int.Parse(Console.ReadLine());
            // if (a>b)
            //     r= a-b;
            // else if (a==b)
            //     r= a+b;
            // else
            //     r= a*b;
            //     Console.WriteLine(r);

            // 2. Un importante negocio de desinfectante líquido realiza descuentos
            //  dependiendo de la cantidad de litros vendidos según la siguiente escala:

            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            // Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros
            // vendidos y calcule y emita el importe con el descuento  aplicado..\


            float imp,lts;
            string desc;
            desc= "0%";

            Console.WriteLine("Ingrese el monto de compra:");
            imp= float.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantos litros lleva?");
            lts= float.Parse(Console.ReadLine());
            if (lts >=500)
            {
                imp= imp*0.75f;
                desc="25%";
            }else if (lts >=300 && lts <500)
            {
                imp= imp*0.85f;
                desc="15%";
            }else if (lts >=100 && lts <300)
            {
                imp= imp*0.90f;
                desc= "10%";
            }
            Console.WriteLine("El importe final es: $"+imp+", y lleva un "+desc+" de descuento.");
            Console.WriteLine("Gracias por su compra de "+lts+"lts.");


            // 3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar.
            // Para ello existe la siguiente escala de precios:

            //               i5 (1)	 i7 (2)  i9 (3)
            // 8 RAM (1)	USD 800	USD 900	USD 1200
            // 16 RAM (2)	USD 900	USD 1000 USD 1400
            // 32 RAM (3)	USD 1000 USD 1400 USD 2000
            // Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea,
            // lo cual tiene un costo  adicional de USD 300.
            // Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM,
            // y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

            int micro,ram,dis,pc;
            pc=0;

            Console.WriteLine("Elija un microprocesador");
            Console.WriteLine("Ingrese una opcion:");
            Console.WriteLine("(1):i5 (2):i7 (3):i9");
            micro= int.Parse(Console.ReadLine());

            Console.WriteLine("Ahora elija su cantidad de memoria RAM (GB's):");
            Console.WriteLine("Ingrese una opcion:");
            Console.WriteLine("(1):8GB (2):16GB (3):32GB");
            ram= int.Parse(Console.ReadLine());

            Console.WriteLine("¿Extiende el tamaño del disco duro?");
            Console.WriteLine("(1):Si (0):No");
            dis= int.Parse(Console.ReadLine());

            if (micro==1&&ram==1){
                pc= 800;
            }else if(micro==2&&ram==1){
                pc= 900;}
                else if(micro==3&&ram==1){
                pc= 1200;}
                else if(micro==1&&ram==2){
                pc= 900;}
                else if(micro==2&&ram==2){
                pc= 1000;}
                else if(micro==3&&ram==2){
                pc= 1400;}
                else if(micro==1&&ram==3){
                pc= 1000;}
                else if(micro==2&&ram==3){
                pc= 1400;}
                else if(micro==3&&ram==3){
                pc= 2000;}

                if (dis==1){
                    pc= pc+ 300;}

                Console.WriteLine("El costo total de la pc armada es de: $"+pc+"USD.");
        }
    }
}

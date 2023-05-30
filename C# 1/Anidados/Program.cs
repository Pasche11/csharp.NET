using System;

namespace Anidados
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            // int n, con=0, primos=0;
            // Console.WriteLine("Ingresa 10 numeros");
            // for(int x=0 ; x<10 ; x++){                
            //     n= int.Parse(Console.ReadLine());
            //     for(int y=1 ; y<=n ; y++){                    
            //         if(n % y == 0){
            //             con++;
            //         }                              
            //     }
            //     if(con==2){
            //         primos++;
            //         con=0;
            //     }                              
            // }
            // Console.WriteLine(primos+" numeros son PRIMOS.");

            // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            // int n=0, con, imp, porcentaje=0, maxI=0, orden=0, min;
            // string nombre= "void", maxN= "void", A, B, C, D, E;
            // bool banMIN;

            // for (int x=1 ; x<=5 ; x++){
            //     imp=0;
            //     con=0;
            //     banMIN= true;

            //     Console.WriteLine("Ingrese un nombre al SUBLOTE Nº"+x+".\n");
            //     nombre = Console.ReadLine();
            //     if(x==1)
            //         A= nombre;
            //     else if(x==2)
            //         B= nombre;
            //     else if(x==3)
            //         C= nombre;
            //     else if(x==4)
            //         D= nombre;
            //     else if(x==5)
            //         E= nombre;
                
            //         Console.WriteLine("Ingrese numeros para el grupo Nº"+x+" "+nombre+". Para terminar ingrese 0.\n");
            //         n = int.Parse(Console.ReadLine());
            //         min = n;
            //         while(n != 0){
                        
            //             con++;
            //             if(n % 2 != 0)
            //                 imp++;
                        
            //             // ORDEN
            //             if(n <= min)
            //                 min= n;
            //             else
            //                 banMIN= false;

            //             Console.WriteLine("Continue, para finalizar ingrese 0.");
            //             n = int.Parse(Console.ReadLine());
            //         }
            //     // ORDEN
            //     if(banMIN== true)
            //         orden++;

            //     porcentaje= (imp * 100) / con;
            //     Console.WriteLine("Porcentaje de "+nombre+" es "+porcentaje+"%.\n");
            //     if (porcentaje > maxI){
            //         maxI= porcentaje;
            //         maxN= nombre;
            //         Console.WriteLine("Ahora, el máximo porcentaje es para "+nombre+", con un "+porcentaje+"%.\n");
            //     }
            // }
            // Console.WriteLine("El máximo porcentaje es para "+maxN+" con un "+maxI+"% de numeros impares.\n");
            // Console.WriteLine("Además, "+orden+"/5 grupos, estan ordenados de mayor a menor.");

            // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
            // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            // int n=0, n2, con;

            // Console.WriteLine("BIENVENIDO\n");
            // Console.WriteLine("Ingrese [1] para empezar, o [2] para salir.");
            // n2= int.Parse(Console.ReadLine());
            // if(n2 == 1){
                
            //     while(n >= 0){
            //         con=0;
            //         Console.WriteLine("Ingrese un nro. positivo, para cambiar de grupo ingrese 0, para terminar ingrese un nro. negativo.");
            //         n= int.Parse(Console.ReadLine());

            //         while(n > 0){
            //             con++;
            //         Console.WriteLine("Continue, para confirmar la lista ingrese 0.");
            //         n= int.Parse(Console.ReadLine());
            //         Console.WriteLine(con);
            //         }

            //     }
            // }else{
            //     Console.WriteLine("Arios :(");

            /* -------------------- */
            /* - CORTE  DE CONTROL -*/
            /* -------------------- */
            
            // int nf;
            // float mf, iva;
            // char tp, tpnow;

            // Console.WriteLine("Ingrese Nº de Factura:");
            // nf= int.Parse(Console.ReadLine());
            // Console.WriteLine("¿ [A] [B] [C] ?");
            // tp= char.Parse(Console.ReadLine());
            // Console.WriteLine("Indique $$ neto (SIN IVA):");
            // mf= float.Parse(Console.ReadLine());

            // while (nf != 0){
            //     tpnow= tp;
            //     while (tp == tpnow){
            //         Console.WriteLine("Ingrese Nº de Factura:");
            //         nf= int.Parse(Console.ReadLine());
            //         Console.WriteLine("¿ [A] [B] [C] ?");
            //         tp= char.Parse(Console.ReadLine());
            //         Console.WriteLine("Indique $$ neto (SIN IVA):");
            //         mf= float.Parse(Console.ReadLine());
            
            // int zona, zonaNow, cliente, usuarios;
            // float consumo, precio, factura=0, facturacionTotal=0;

            // Console.WriteLine("Ingrese el numero de ZONA:");
            // zona= int.Parse(Console.ReadLine());
            
            
            // while(zona > 0){
            //     Console.WriteLine("Ingrese el numero de CLIENTE:");
            //     cliente= int.Parse(Console.ReadLine());
            //     Console.WriteLine("Ingrese el consumo anual:");
            //     consumo= float.Parse(Console.ReadLine());

                
            //     zonaNow = zona;
            //     usuarios = 0;
            //     while(zona == zonaNow){
                                       
            //         if(consumo >= 50000)
            //             precio= 0.15f;
            //         else if(consumo < 50000 && consumo >35000)
            //             precio= 0.12f;
            //         else
            //             precio= 0.10f;
                    
            //         usuarios++;
            //         factura += consumo*precio;
            //         facturacionTotal += factura;                    

            //         Console.WriteLine("Ingrese el numero de ZONA:");
            //         zona= int.Parse(Console.ReadLine());                    
            //         Console.WriteLine("Ingrese el numero de CLIENTE:");
            //         cliente= int.Parse(Console.ReadLine());
            //         Console.WriteLine("Ingrese el consumo anual:");
            //         consumo= float.Parse(Console.ReadLine());
            //     }

            //     Console.WriteLine("[ZONA: "+zona+"]\n");
            //     Console.WriteLine(usuarios+" usuarios registrados.");
            //     Console.WriteLine("Total facturado: $"+factura);

            // }

            // 3. Hacer un programa para ingresar los valores de los pesos de distintas
            // encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
            // ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que
            // pueden transportar hasta 200 kilos en total.
            // Por ejemplo:
            // 10, 20, 140, 70, 100, 40, 10, 50, 80, 90, 30, 40, 50, -10.
            // Camión 1. Camión 2 Camión 3 Camión 4 Camión 5
            // Se pide determinar e informar:
            // a. El número de camión y peso total de encomiendas (Camión 1: 170kg,
            // Camión 2: 170kg, etc.).
            // b. El número de camión que transporta mayor cantidad de encomiendas
            // (en el ejemplo anterior sería el camión 3 con 4 encomiendas).
            // c. La cantidad de camiones que se terminaron cargando.

            int camion=1, esteCamion, con=0;            
            float kg, kgtotales=0, kgmax=0;

            Console.WriteLine("Ingrese el peso de cada encomienda, al finalizar, ingrese un peso negativo:");
            Console.WriteLine("EJEMPLO: -1kg.\n\n");
            kg= float.Parse(Console.ReadLine());
            
            while(kg >= 0){
                
                // corte de ctrl
                esteCamion= camion;

                    // proceso x camion
                while(camion == esteCamion){
                    if(kgtotales + kg >200){
                        // SE LLENO EL CAMION
                        Console.WriteLine("CAMION "+camion+": "+kgtotales+"kg.");
                        camion++;
                        con++;
                            // maximo
                        if(kgtotales > kgmax)
                            kgmax = kgtotales;

                        kgtotales=0;                        
                    }else if(kgtotales + kg <=200f){
                        kgtotales += kg;
                        Console.WriteLine("Continue:");
                        kg= float.Parse(Console.ReadLine());
                    }                                     
                }
                Console.WriteLine("Se cargaron "+con+" camiones.");
                Console.WriteLine("De los cuales el mas pesado va con "+kgmax+" kg.");
                

            }


        }
    }            
}



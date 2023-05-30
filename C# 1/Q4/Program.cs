using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {   

            int items;
            float alto =0 , ancho=0 , cant=0;
            string producto= "DEFAULT", productoFinal= "ERROR";
            float m2, m2T, mL, mLT, precio, precioFinal;
            float espesor;
            
            Console.WriteLine("BIENVENIDO\n");
            Console.WriteLine("Para comenzar, indique la cantidad de ITEMS(#) que tenes en tu listado de vidrios.\n");
            items= int.Parse(Console.ReadLine());
            
            for(int y = 0 ; y<items ; y++){
                Console.WriteLine("ITEM Nº: "+ (y+1));
                Console.WriteLine();
                for(int x = 0 ; x<4 ; x++){
                    if(x == 0){
                        // INGRESO ANCHO
                        Console.WriteLine("Ingrese la medida del lado ANCHO en milimetros: ");
                        ancho= float.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }else if(x == 1){
                        // INGRESO ALTO
                        Console.WriteLine("Ingrese el ALTO: ");
                        alto= float.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }else if(x == 2){
                        // INGRESO CANTIDAD DE PIEZAS
                        Console.WriteLine("Indique cuantas piezas necesita: ");
                        cant= float.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }else if(x == 3){
                        /* -------------------- */
                        /* LA PARTE DIVERTIDA: */
                        /* -------------------- */
                        Console.WriteLine("INDIQUE EL TIPO DE PRODUCTO:");
                        Console.WriteLine();
                       Console.WriteLine("[!]Atencion[!] El texto que escriba debe ser exactamente igual a la opcion que desee elegir [NO CAPS SENSE]");
                        Console.WriteLine();
                        Console.WriteLine("[OPCIONES]");
                        Console.WriteLine("- DVH");
                        Console.WriteLine("- LAMINADO");
                        Console.WriteLine("- TEMPLADO");
                        Console.WriteLine("- FLOAT");
                        Console.WriteLine();                    
                        producto= Console.ReadLine();                    
                    }                
                }
                m2= (alto * ancho) / 1000000;
                m2T= m2 * cant;
                mL= (alto / 1000)*2 + (ancho / 1000)*2;
                mLT= mL * cant;

                if(producto == "TEMPLADO" || producto == "templado")
                    productoFinal= "TEMPLADO";
                else if(producto == "DVH" || producto == "dvh")
                    productoFinal= "DVH";
                else if(producto == "LAMINADO" || producto == "laminado")
                    productoFinal= "LAMINADO";
                else if(producto == "FLOAT" || producto == "float")
                    productoFinal= "TEMPLADO";
            
                Console.WriteLine();
                Console.WriteLine("[!] PARTE 1 DEL PROGRAMA [!]");
                Console.WriteLine();
                Console.WriteLine("[CANTIDAD: "+cant+"]");
                Console.WriteLine();
                Console.WriteLine("[ML: "+mL+"] [M2: "+m2+"] [M2 TOTALES:"+m2T+"]");
                Console.WriteLine();
                Console.WriteLine("[TIPO DE PRODUCTO: "+productoFinal+"]");
                Console.WriteLine();

                /* ----- PARTE 2 ----- */
                // ESPESOR
                // PRODUCTO FINAL EXACTO
                // PRECIO EN PARTE 3
                espesor= 0;
                if(productoFinal != "DVH"){
                    if(productoFinal == "TEMPLADO"){
                        /* ----- TEMPLADOS.cfg ----- */
                        Console.WriteLine("Ha seleccionado: TEMPLADO");
                        Console.WriteLine();
                        Console.WriteLine("[!] Indique el espesor: ");
                        Console.WriteLine();
                        Console.WriteLine("[OPCIONES]");
                        Console.WriteLine("[4] 4mm.");
                        Console.WriteLine("[5] 5mm.");
                        Console.WriteLine("[6] 6mm.");
                        Console.WriteLine("[8] 8mm.");
                        Console.WriteLine("[10] 10mm.");
                        Console.WriteLine();
                        espesor= float.Parse(Console.ReadLine());

                        if(espesor == 10){
                            productoFinal= "TEMP INC 10mm.";
                            Console.WriteLine("El producto "+productoFinal+" se ha añadido a la lista con éxito.");
                            Console.WriteLine();

                        }else if(espesor == 8){
                            productoFinal= "TEMP INC 8mm.";
                            Console.WriteLine("El producto "+productoFinal+" se ha añadido a la lista con éxito.");
                            Console.WriteLine();

                        }else if(espesor == 6){
                            productoFinal= "TEMP INC 6mm.";
                            Console.WriteLine("El producto "+productoFinal+" se ha añadido a la lista con éxito.");
                            Console.WriteLine();

                        }else if(espesor == 5){
                            productoFinal= "TEMP INC 4mm.";
                            Console.WriteLine("El producto "+productoFinal+" se ha añadido a la lista con éxito.");
                            Console.WriteLine();

                        }else if(espesor == 4){
                            productoFinal= "TEMP INC 4mm.";
                            Console.WriteLine("El producto "+productoFinal+" se ha añadido a la lista con éxito.");
                            Console.WriteLine();
                        
                        }else{
                            /* ----- VALIDACION ----- */
                        }
                    }else if(productoFinal == "LAMINADO"){
                        /* ----- LAMINADOS.cfg ----- */
                        Console.WriteLine("Ha seleccionado: LAMINADO");
                        Console.WriteLine();
                        Console.WriteLine("[!] Indique el espesor: ");
                        Console.WriteLine();
                        Console.WriteLine("[OPCIONES]");
                        Console.WriteLine("[6] 3+3");
                        Console.WriteLine("[8] 4+4");
                        Console.WriteLine("[10] 5+5");
                        Console.WriteLine("[12] 6+6");
                        Console.WriteLine();
                        espesor= float.Parse(Console.ReadLine());

                        if(espesor == 6){
                            productoFinal= "LAMINADO INC 3+3mm.";
                            Console.WriteLine("El producto "+productoFinal+" se ha añadido a la lista con éxito.");
                            Console.WriteLine();

                        }else if(espesor == 8){
                            productoFinal= "LAMINADO INC 4+4mm.";
                            Console.WriteLine("El producto "+productoFinal+" se ha añadido a la lista con éxito.");
                            Console.WriteLine();

                        }else if(espesor == 10){
                            productoFinal= "LAMINADO INC 5+5mm.";
                            Console.WriteLine("El producto "+productoFinal+" se ha añadido a la lista con éxito.");
                            Console.WriteLine();

                        }else if(espesor == 12){
                            productoFinal= "LAMINADO INC 6+6mm.";
                            Console.WriteLine("El producto "+productoFinal+" se ha añadido a la lista con éxito.");
                            Console.WriteLine();

                        }else{
                            /* ----- VALIDACION ----- */
                        }
                    }else if(productoFinal == "FLOAT"){
                        /* ----- FLOAT.cfg ----- */
                    }            
                }else{
                    /* ----- ----- DVH.cfg ----- ----- */
                }
                float peso= (m2 * espesor) * 2.5f, pesoFinal= 0;
                pesoFinal += peso; 
                Console.WriteLine();
                Console.WriteLine("PARTE 2");
                Console.WriteLine();
                Console.WriteLine("SELECCIONASTE: "+productoFinal);
                Console.WriteLine("ESPESOR: "+espesor+"mm.");
                Console.WriteLine("PESO (KG): "+peso+"kilogramos.");
                Console.WriteLine();
                Console.WriteLine("[ML: "+mL+"] [M2: "+m2+"] [M2 TOTALES: "+m2T+"]");
                Console.WriteLine();

                 /* ----- PARTE 3 PRECIO DEL ITEM ----- */

                // precio=

                Console.WriteLine("Confirma ITEM Nº1?");
                Console.WriteLine();
                Console.WriteLine("SI [S]");
                Console.WriteLine("NO [N]");
                Console.WriteLine();

                string confirm= "0";
                confirm= Console.ReadLine();

                if(confirm == "s" || confirm == "S"){
                    
                }else if(confirm == "n" || confirm == "N"){
                    
                }else{
                    Console.WriteLine("ERROR: Reinicie el programa.");
                }

                /* ----- PARTE 4 PRESUPUESTO FINAL (PRECIO TOTAL + IVA)----- */


                /* ----- ----- PROGRAMAR SISTEMA DE GUARDADO Y MUESTREO DE PRECIOS. [(INDIVIDUALES(P3) Y FINAL(P4)] ----- ----- */
                // 
            }
        }
    }
}

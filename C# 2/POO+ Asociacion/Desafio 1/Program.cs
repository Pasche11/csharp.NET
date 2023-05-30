using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int op;
            //string contacto;
            ////Primer telefono
            //Console.WriteLine("Ingresa Marca y Modelo:");
            //string marca = Console.ReadLine();
            //string modelo = Console.ReadLine();
            //Telefono t1 = new Telefono(marca, modelo);
            //Console.WriteLine("Tu telefono es..\nMarca: " + marca + "\nY modelo: " + modelo);
            //Console.WriteLine("Apreta cualq tecla para continuar..");
            //Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine("Ingresa contacto, o deja vacio: ");
            //contacto = Console.ReadLine();
            //if (contacto.Length > 0)
            //{
            //    Console.WriteLine(t1.Llamar(contacto));
            //}
            //else Console.WriteLine(t1.Llamar());
            //Console.ReadKey();'

            //Lista Dinamica a base de VECTOR :D
            Console.WriteLine("Ingresa Nº de personas a ingresar: ");
            int cantPersonas = int.Parse(Console.ReadLine());
            Persona[] personasTodas = new Persona[cantPersonas];

            for (int x = 0; x < cantPersonas; x++)
            {
                personasTodas[x] = new Persona();
            }
            for (int x = 0; x < cantPersonas; x++)
            {
                int con = 0;
                con++;
                Console.WriteLine("Ingresa nombre: ");
                personasTodas[x].nombre = Console.ReadLine();
                Console.WriteLine("Ingresa edad: ");
                personasTodas[x].edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa altura en cm: ");
                personasTodas[x].altura = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el sexo: ");
                personasTodas[x].sexo = Console.ReadLine();
                Console.WriteLine("Ingresa sueldo en U$D: ");
                personasTodas[x].Sueldo = float.Parse(Console.ReadLine());
                //Asociacion de AGREGACION TELEFONO...
                Console.WriteLine("POSEE TELEFONO??\n1. SI\n2. NO");
                string yn= Console.ReadLine();
                if(yn == "1")
                {
                    Console.WriteLine("Ingrese....\nMarca:");
                    string marca= Console.ReadLine();
                    Console.WriteLine("Modelo:");
                    string modelo= Console.ReadLine();
                    personasTodas[x].Tel = new Telefono(marca,modelo);
                    //Mensaje de Confirmacion de entrada:
                    Console.WriteLine("La persona Nº" + (x + 1) + " posee un Telefono:\nMarca: " + marca + "\nModelo: " + modelo);
                    Console.WriteLine(personasTodas[x].Tel);
                }
                Console.WriteLine("Por ultimo, ingresa el DNI: ");
                personasTodas[x].DNI = (Console.ReadLine());
                if (personasTodas[x].DNI.Length != 8)
                {
                    Console.WriteLine("DEPORTADO X INDOCUMENTADO");
                }
                if (x != cantPersonas -1)
                {
                    Console.WriteLine("SIGUIENTE PERSONA!");
                }
            }
            Console.WriteLine("Se ingresaron "+cantPersonas+".\n");
            for (int x = 0; x < cantPersonas; x++)
            {
                Console.WriteLine("La persona Nº" + (x + 1)+": ");
                Console.WriteLine("Se llama: " + personasTodas[x].nombre);
                Console.WriteLine("Su DNI: "+ personasTodas[x].DNI);
                Console.WriteLine("Tiene un telefono de marca " + personasTodas[x].Tel.Marca + "y modelo " + personasTodas[x].Tel.Modelo);
            }
            
        }
    }
}

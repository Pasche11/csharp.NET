using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Persona
    {
        //Atributos y propiedades de Persona
        public string nombre { get; set; }
        public int edad { get; set; }
        public float altura { get; set; }
        public string sexo { get; set; }

        private float sueldo;
        private string dni;

        public string DNI
        {
            get { return dni; }
            set
            {
                if (value.Length == 8)
                {
                    dni = value;
                }
                else dni = "Deportado por indocumentado :D";
            }
        }
        public float Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        //Asociacion por Agregacion..
        public Telefono Tel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
        //solo getter con set x construccion
        private string marca;
        private string modelo;
        public Telefono(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        public string Marca { get { return marca; } }
        public string Modelo { get { return modelo; } }
        
        //getter y setter cortos
        public string  NroTel { get; set; }

        //getter y setter especificos (LARGOS)
        private int codOperador;
        public int CodOperador
        {
            get { return codOperador; }
            set
            {
                if (codOperador > 0 && codOperador < 4)
                {
                    codOperador = value;
                }else codOperador = 0;
            }
        }

        //METODOS (Comportamiento)
        public string Llamar() { return "Realizando llamada..."; }
        public string Llamar(string contacto) { return "Llamando a " + contacto; }
    }
}

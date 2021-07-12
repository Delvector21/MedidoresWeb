using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidores_DAL.DTO
{
    public class Punto
    {
        private string codigo;
        private string tipo;
        private Int32 capacidad;
        private string vidautil;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Vidautil { get => vidautil; set => vidautil = value; }
    }
}

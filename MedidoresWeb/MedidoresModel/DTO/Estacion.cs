using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    class Estacion
    {
        private string codigo;
        private string direccion;
        private Int32 capacidad;
        private string region;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Region { get => region; set => region = value; }
    }
}

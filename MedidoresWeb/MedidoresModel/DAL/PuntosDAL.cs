using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    class PuntosDAL
    {
        private static List<Punto> puntos = new List<Punto>();
        
        public void Add(Punto p)
        {
            puntos.Add(p);

        }

        public List<Punto> GetAll()
        {
            return puntos;
        }

        public void Delete(string codigo)
        {
            Punto punto = puntos.Find(p => p.Codigo == codigo);
            puntos.Remove(punto);
        }

        public List<Punto> Filtrar(string tipo)
        {
            return puntos.FindAll(p => p.Tipo == tipo);
        }
    }
}

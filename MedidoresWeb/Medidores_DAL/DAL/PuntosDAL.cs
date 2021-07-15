using Medidores_DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidores_DAL.DAL
{
    public class PuntosDAL
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

        public Punto GetPunto(string codigo)
        {
            return puntos.Find(p => p.Codigo == codigo);
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

        public void Editar(Punto p)
        {
            puntos.Single(pto => pto.Codigo == p.Codigo).Capacidad = p.Capacidad;
            puntos.Single(pto => pto.Codigo == p.Codigo).Tipo = p.Tipo;
            puntos.Single(pto => pto.Codigo == p.Codigo).Vidautil = p.Vidautil;
            
        }
    }
}

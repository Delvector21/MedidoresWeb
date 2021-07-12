using Medidores_DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidores_DAL.DAL
{
    public class EstacionesDAL
    {
        private static List<Estacion> estaciones = new List<Estacion>();

        


        public void Add(Estacion e)
        {
            estaciones.Add(e);
        }

        public List<Estacion> GetAll()
        {
            return estaciones;
        }

        public void Delete(string codigo)
        {
            Estacion estacion = estaciones.Find(e => e.Codigo == codigo);
            estaciones.Remove(estacion);
        }

    }
}

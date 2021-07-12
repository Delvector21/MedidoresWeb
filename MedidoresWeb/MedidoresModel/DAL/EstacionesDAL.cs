using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    class EstacionesDAL
    {
        private static List<Estacion> estaciones = new List<Estacion>();

        private List<string> regiones = new List<string>()
        {
            "Región de Arica y Parinacota",
            "Región de Tarapacá",
             "Región de Antofagasta",
             "Región de Atacama",
             "Región de Coquimbo",
             "Región de Valparaíso",
             "Región Metropolitana de Santiago",
             "Región del Libertador General Bernardo O’Higgins",
             "Región del Maule",
             "Región del Ñuble",
             "Región del Biobío",
             "Región de La Araucanía",
             "Región de Los Ríos",
             "Región de Los Lagos",
             "Región de Aysén del General Carlos Ibáñez del Campo",
             "Región de Magallanes y la Antártica Chilena"
        };

        public List<string> GetRegiones()
        {
            return regiones;
        }


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

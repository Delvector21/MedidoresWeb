using Medidores_DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidores_DAL.DAL

{
    public class RegionesDAL
    {
        private List<Region> regiones = new List<Region>()
        {
            new Region()
            {
                Nombre="Región de Arica y Parinacota",
                Codigo=15
            },
            new Region()
            {
                Nombre="Región de Tarapaca",
                Codigo=01
            },
            new Region()
            {
                Nombre="Región de Antofagasta",
                Codigo=02
            },
            new Region()
            {
                Nombre="Región de Atacama",
                Codigo=03
            },
            new Region()
            {
                Nombre="Región de Coquimbo",
                Codigo=04
            },
            new Region()
            {
                Nombre="Región de Valparaíso",
                Codigo=05
            },
            new Region()
            {
                Nombre="Región Metropolitana de Santiago",
                Codigo=13
            },
            new Region()
            {
                Nombre="Región del Libertador General Bernardo O’Higgins",
                Codigo=06
            },
            new Region()
            {
                Nombre="Región del Maule",
                Codigo=07
            },
            new Region()
            {
                Nombre="Región del Ñuble",
                Codigo=16
            },
            new Region()
            {
                Nombre="Región del Biobío",
                Codigo=08
            },
            new Region()
            {
                Nombre="Región de La Araucanía",
                Codigo=09
            },
            new Region()
            {
                Nombre="Región de Los Ríos",
                Codigo=15
            },
            new Region()
            {
                Nombre="Región de Los Lagos",
                Codigo=10
            },
            new Region()
            {
                Nombre="Región de Aysén del General Carlos Ibáñez del Campo",
                Codigo=11
            },
            new Region()
            {
                Nombre="Región de Magallanes y la Antártica Chilena",
                Codigo=12
            }
             
        };

        public List<Region> GetRegiones()
        {
            return regiones;
        }
    }
}

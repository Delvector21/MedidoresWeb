
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDAL.DAL
{
    


    public class EstacionesDAL
    {
        public Medidores_dbEntities dbEntites = new Medidores_dbEntities();


        public void Add(Estacion e)
        {
            dbEntites.Estacion.Add(e);  //equivalente al insert
            dbEntites.SaveChanges();  //equivalente al commit
        }

        public List<Estacion> GetAll()
        {
            return dbEntites.Estacion.ToList(); //equivalente select * from estacion
        }

        public void Delete(string codigo)
        {
            Estacion estacion = dbEntites.Estacion.Find(codigo); //busco el obejto a eliminar
            dbEntites.Estacion.Remove(estacion);
            dbEntites.SaveChanges();
        }

        public Estacion GetEstacion(string codigo)
        {
            return dbEntites.Estacion.Find(codigo);
        }
    }
}

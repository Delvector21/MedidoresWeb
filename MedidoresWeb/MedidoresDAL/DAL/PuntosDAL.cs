using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDAL.DAL
{
    public class PuntosDAL
    {
        public Medidores_dbEntities dbEntites = new Medidores_dbEntities();

        public void Add(Punto p)
        {
            dbEntites.Punto.Add(p);
            dbEntites.SaveChanges();

        }

        public List<Punto> GetAll()
        {
            return dbEntites.Punto.ToList();
        }

        public Punto GetPunto(string codigo)
        {
            return dbEntites.Punto.Find(codigo);
        }

        public void Delete(string codigo)
        {
            Punto punto = dbEntites.Punto.Find(codigo);
            dbEntites.Punto.Remove(punto);
            dbEntites.SaveChanges();
        }

        public List<Punto> Filtrar(string tipo)
        {
            //LINQ lenguaje de consultas para objetos
            var query = from p in dbEntites.Punto where p.tipo == tipo select p;
            return query.ToList();

        }

        public void Editar(Punto p)
        {
            Punto pto = dbEntites.Punto.Find(p.codigo);
            pto.capacidad = p.capacidad;
            pto.tipo = p.tipo;
            pto.vidautil = p.vidautil;
            dbEntites.SaveChanges();
            
        }
    }
}

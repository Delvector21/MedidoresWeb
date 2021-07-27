
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDAL.DAL

{
    public class RegionesDAL
    {
        public Medidores_dbEntities dbEntites = new Medidores_dbEntities();

        public List<Region> GetRegiones()
        {
            return dbEntites.Region.ToList();
        }
    }
}

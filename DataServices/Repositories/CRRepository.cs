using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using ModelServices.Interfaces.Repositories;
using EntitiesServices.Work_Classes;
using System.Data.Entity;

namespace DataServices.Repositories
{
    public class CRRepository : RepositoryBase<vwContasAReceber>, ICRRepository
    {
        public List<vwContasAReceber> GetAllItens()
        {
            IQueryable<vwContasAReceber> query = Db.vwContasAReceber;
            return query.ToList();
        }
    }
}
 
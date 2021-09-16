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

        public List<vwContasAReceber> GetByData(DateTime data)
        {
            IQueryable<vwContasAReceber> query = Db.vwContasAReceber;
            query = query.Where(p => p.Data_de_Vencimento.Month == data.Month & p.Data_de_Vencimento.Year == data.Year);
            return query.ToList();
        }
    }
}
 
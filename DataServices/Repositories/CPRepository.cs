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
    public class CPRepository : RepositoryBase<vwContasAPagar>, ICPRepository
    {
        public List<vwContasAPagar> GetAllItens()
        {
            IQueryable<vwContasAPagar> query = Db.vwContasAPagar;
            return query.ToList();
        }

        public List<vwContasAPagar> GetByData(DateTime data)
        {
            IQueryable<vwContasAPagar> query = Db.vwContasAPagar;
            query = query.Where(p => p.Data_de_Vencimento.Month == data.Month & p.Data_de_Vencimento.Year == data.Year);
            return query.ToList();
        }

    }
}
 
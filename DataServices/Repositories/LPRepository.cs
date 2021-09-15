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
    public class LPRepository : RepositoryBase<vwLancamentosAPagar>, ILPRepository
    {
        public List<vwLancamentosAPagar> GetAllItens()
        {
            IQueryable<vwLancamentosAPagar> query = Db.vwLancamentosAPagar;
            return query.ToList();
        }
    }
}
 
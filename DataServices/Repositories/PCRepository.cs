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
    public class PCRepository : RepositoryBase<vwParcelamento>, IPCRepository
    {
        public List<vwParcelamento> GetAllItens()
        {
            IQueryable<vwParcelamento> query = Db.vwParcelamento;
            return query.ToList();
        }
    }
}
 
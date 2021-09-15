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
    }
}
 
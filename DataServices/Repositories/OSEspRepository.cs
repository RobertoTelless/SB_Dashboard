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
    public class OSEspRepository : RepositoryBase<vwOrdemServicoEspecialidade>, IOSEspRepository
    {
        public List<vwOrdemServicoEspecialidade> GetAllItens()
        {
            IQueryable<vwOrdemServicoEspecialidade> query = Db.vwOrdemServicoEspecialidade;
            return query.ToList();
        }
    }
}
 
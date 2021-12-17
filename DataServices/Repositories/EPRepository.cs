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
    public class EPRepository : RepositoryBase<vwExecutandoPositivo>, IEPRepository
    {
        public List<vwExecutandoPositivo> GetAllItens()
        {
            IQueryable<vwExecutandoPositivo> query = Db.vwExecutandoPositivo;
            return query.ToList();
        }

        public List<vwExecutandoPositivo> ExecuteFilter(DateTime? emissaoInicio, DateTime? emissaoFinal, DateTime? vencInicio, DateTime? vencFinal, DateTime? recInicio, DateTime? recFinal, String centroLucro, String sacado, Int32? prob)
        {
            List<vwExecutandoPositivo> lista = new List<vwExecutandoPositivo>();
            IQueryable<vwExecutandoPositivo> query = Db.vwExecutandoPositivo;
            if (vencInicio != null & vencFinal != null)
            {
                query = query.Where(p => p.DataPrevisaoRecebimento >= vencInicio & p.DataPrevisaoRecebimento <= vencFinal);
            }
            else if (vencInicio != null & vencFinal == null)
            {
                query = query.Where(p => p.DataPrevisaoRecebimento >= vencInicio);
            }
            else if (vencInicio == null & vencFinal != null)
            {
                query = query.Where(p => p.DataPrevisaoRecebimento <= vencFinal);
            }
            if (query != null)
            {
                query = query.OrderByDescending(a => a.DataPrevisaoRecebimento);
                lista = query.ToList<vwExecutandoPositivo>();
            }
            return lista;
        }

    }
}
 
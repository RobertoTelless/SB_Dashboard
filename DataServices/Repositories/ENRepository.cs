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
    public class ENRepository : RepositoryBase<vwExecutandoNegativo>, IENRepository
    {
        public List<vwExecutandoNegativo> GetAllItens()
        {
            IQueryable<vwExecutandoNegativo> query = Db.vwExecutandoNegativo;
            return query.ToList();
        }

        public List<vwExecutandoNegativo> ExecuteFilter(DateTime? emissaoInicio, DateTime? emissaoFinal, DateTime? vencInicio, DateTime? vencFinal, DateTime? recInicio, DateTime? recFinal, String centroLucro, String sacado, Int32? prob)
        {
            List<vwExecutandoNegativo> lista = new List<vwExecutandoNegativo>();
            IQueryable<vwExecutandoNegativo> query = Db.vwExecutandoNegativo;
            if (vencInicio != null & vencFinal != null)
            {
                query = query.Where(p => p.DataPrevisaoPagamento >= vencInicio & p.DataPrevisaoPagamento <= vencFinal);
            }
            else if (vencInicio != null & vencFinal == null)
            {
                query = query.Where(p => p.DataPrevisaoPagamento >= vencInicio);
            }
            else if (vencInicio == null & vencFinal != null)
            {
                query = query.Where(p => p.DataPrevisaoPagamento <= vencFinal);
            }
            if (query != null)
            {
                query = query.OrderByDescending(a => a.DataPrevisaoPagamento);
                lista = query.ToList<vwExecutandoNegativo>();
            }
            return lista;
        }

    }
}
 
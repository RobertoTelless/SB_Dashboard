using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ApplicationServices.Interfaces
{
    public interface ICPAppService : IAppServiceBase<vwContasAPagar>
    {
        List<vwContasAPagar> GetAllItens();
        List<vwContasAPagar> GetByData(DateTime data);
        Int32 ExecuteFilter(DateTime? emissaoInicio, DateTime? emissaoFinal, DateTime? vencInicio, DateTime? vencFinal, DateTime? pagInicio, DateTime? pagFinal, String centroCusto, String beneficiario, out List<vwContasAPagar> objeto);
    }
}

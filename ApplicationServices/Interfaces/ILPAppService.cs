using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ApplicationServices.Interfaces
{
    public interface ILPAppService : IAppServiceBase<vwLancamentosAPagar>
    {
        List<vwLancamentosAPagar> GetAllItens();
    }
}

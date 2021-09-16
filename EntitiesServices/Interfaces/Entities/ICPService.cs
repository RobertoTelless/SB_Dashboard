using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;

namespace ModelServices.Interfaces.EntitiesServices
{
    public interface ICPService : IServiceBase<vwContasAPagar>
    {
        List<vwContasAPagar> GetAllItens();
        List<vwContasAPagar> GetByData(DateTime data);
    }
}

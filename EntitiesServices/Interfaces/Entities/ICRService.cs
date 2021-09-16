using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;

namespace ModelServices.Interfaces.EntitiesServices
{
    public interface ICRService : IServiceBase<vwContasAReceber>
    {
        List<vwContasAReceber> GetAllItens();
        List<vwContasAReceber> GetByData(DateTime data);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IOSEspRepository : IRepositoryBase<vwOrdemServicoEspecialidade>
    {
        List<vwOrdemServicoEspecialidade> GetAllItens();
    }
}

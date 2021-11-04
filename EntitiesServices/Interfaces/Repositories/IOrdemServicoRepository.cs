using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.DTO;

namespace ModelServices.Interfaces.Repositories
{
    public interface IOrdemServicoRepository : IRepositoryBase<OrdemServico>
    {
        List<OrdemServico> GetAllItens();
        List<OrdemServico> GetOSAtraso(DateTime hoje);
        List<OrdemServico> GetAllItensIniciadas();
        List<OrdemServico> GetOSPendencias();
        List<OrdemServico> GetOSPesquisa();
        List<OrdemServico> GetOSAvaliacao();

    }
}

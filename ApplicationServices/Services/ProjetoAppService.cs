using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;
using ApplicationServices.Interfaces;
using ModelServices.Interfaces.EntitiesServices;
using CrossCutting;
using System.Text.RegularExpressions;

namespace ApplicationServices.Services
{
    public class ProjetoAppService : AppServiceBase<Projeto>, IProjetoAppService
    {
        private readonly IProjetoService _baseService;

        public ProjetoAppService(IProjetoService baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        public List<Projeto> GetAllItens()
        {
            return _baseService.GetAllItens();
        }
    }
}

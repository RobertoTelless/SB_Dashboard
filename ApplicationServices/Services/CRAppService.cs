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
    public class CRAppService : AppServiceBase<vwContasAReceber>, ICRAppService
    {
        private readonly ICRService _baseService;

        public CRAppService(ICRService baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        public List<vwContasAReceber> GetAllItens()
        {
            return _baseService.GetAllItens();
        }
    }
}

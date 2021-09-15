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
    public class PCAppService : AppServiceBase<vwParcelamento>, IPCAppService
    {
        private readonly IPCService _baseService;

        public PCAppService(IPCService baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        public List<vwParcelamento> GetAllItens()
        {
            return _baseService.GetAllItens();
        }
    }
}

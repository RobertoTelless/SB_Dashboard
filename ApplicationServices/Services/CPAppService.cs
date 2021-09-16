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
    public class CPAppService : AppServiceBase<vwContasAPagar>, ICPAppService
    {
        private readonly ICPService _baseService;

        public CPAppService(ICPService baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        public List<vwContasAPagar> GetAllItens()
        {
            return _baseService.GetAllItens();
        }

        public List<vwContasAPagar> GetByData(DateTime data)
        {
            return _baseService.GetByData(data);
        }
    }
}

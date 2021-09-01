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
    public class DashboardAppService : AppServiceBase<Funcao>, IDashboardAppService
    {
        private readonly IDashboardService _baseService;

        public DashboardAppService(IDashboardService baseService) : base(baseService)
        {
            _baseService = baseService;
        }

    }
}

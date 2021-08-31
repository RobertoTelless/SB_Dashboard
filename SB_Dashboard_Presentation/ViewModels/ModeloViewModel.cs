using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using EntitiesServices.Model;
using System.Web;
using EntitiesServices.Attributes;

namespace SB_Dashboard_Presentation.ViewModels
{
    public class ModeloViewModel
    {
        [Key]
        public int Filtro { get; set; }
        public String MesAno { get; set; }
        public Decimal Valor { get; set; }
        public String Observacao { get; set; }

    }
}
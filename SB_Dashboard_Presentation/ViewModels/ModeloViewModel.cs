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
        public DateTime FiltroData { get; set; }
        public String FiltroTexto { get; set; }
        public String MesAno { get; set; }
        public Decimal Valor { get; set; }
        public String Observacao { get; set; }
        public bool Check
        {
            get
            {
                if (Filtro == 1)
                {
                    return true;
                }
                return false;
            }
            set
            {
                Filtro = (value == true) ? 1 : 0;
            }
        }

    }
}
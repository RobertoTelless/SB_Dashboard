//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiesServices.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdemServicoVisitaItem
    {
        public int Id { get; set; }
        public int Visita { get; set; }
        public string Categoria { get; set; }
        public decimal Quantidade { get; set; }
        public Nullable<int> Unidade { get; set; }
        public string Descricao { get; set; }
        public int Posicao { get; set; }
        public decimal ValorMo { get; set; }
        public decimal ValorMa { get; set; }
    
        public virtual OrdemServicoVisita OrdemServicoVisita { get; set; }
        public virtual Unidade Unidade1 { get; set; }
    }
}
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
    
    public partial class OrdemServicoPesquisa
    {
        public int Id { get; set; }
        public int OrdemServico { get; set; }
        public string Satisfacao { get; set; }
        public string ObsSatisfacao { get; set; }
        public string Recomendacao { get; set; }
        public string ObsRecomendacao { get; set; }
        public string Pontualidade { get; set; }
        public string ObsPontualidade { get; set; }
        public string Postura { get; set; }
        public string ObsPostura { get; set; }
        public string ObsGerais { get; set; }
    
        public virtual OrdemServico OrdemServico1 { get; set; }
    }
}

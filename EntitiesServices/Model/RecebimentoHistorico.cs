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
    
    public partial class RecebimentoHistorico
    {
        public int Id { get; set; }
        public int Recebimento { get; set; }
        public Nullable<System.DateTime> DataVencimento { get; set; }
        public Nullable<decimal> ValorBruto { get; set; }
        public System.DateTime EditadoEm { get; set; }
        public int EditadoPor { get; set; }
        public Nullable<decimal> ValorLiquido { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
        public virtual Recebimento Recebimento1 { get; set; }
    }
}

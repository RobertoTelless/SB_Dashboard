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
    
    public partial class PagamentoComunicacao
    {
        public int Id { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public string Texto { get; set; }
        public int Pagamento { get; set; }
        public int Remetente { get; set; }
    
        public virtual Pagamento Pagamento1 { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}

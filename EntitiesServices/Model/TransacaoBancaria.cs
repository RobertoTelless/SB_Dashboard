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
    
    public partial class TransacaoBancaria
    {
        public int Id { get; set; }
        public int Beneficiario { get; set; }
        public System.DateTime Data { get; set; }
        public System.DateTime ContaBancaria { get; set; }
        public decimal Valor { get; set; }
        public int Tipo { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
    }
}

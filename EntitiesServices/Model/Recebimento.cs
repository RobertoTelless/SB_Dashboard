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
    
    public partial class Recebimento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recebimento()
        {
            this.RecebimentoHistorico = new HashSet<RecebimentoHistorico>();
            this.RecebimentoDocumento = new HashSet<RecebimentoDocumento>();
        }
    
        public int Id { get; set; }
        public Nullable<int> OrdemServico { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public System.DateTime DataEmissao { get; set; }
        public System.DateTime DataVencimento { get; set; }
        public Nullable<System.DateTime> DataRecebimento { get; set; }
        public string NotaFiscal { get; set; }
        public string Observacao { get; set; }
        public Nullable<int> ContaBancaria { get; set; }
        public int Sacado { get; set; }
        public int Projeto { get; set; }
        public Nullable<System.DateTime> DataSignificativa { get; set; }
    
        public virtual EmpresaContaBancaria EmpresaContaBancaria { get; set; }
        public virtual OrdemServico OrdemServico1 { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Projeto Projeto1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecebimentoHistorico> RecebimentoHistorico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecebimentoDocumento> RecebimentoDocumento { get; set; }
    }
}
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
    
    public partial class CaixinhaLancada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaixinhaLancada()
        {
            this.CaixinhaLancadaAprovacao = new HashSet<CaixinhaLancadaAprovacao>();
        }
    
        public int Id { get; set; }
        public Nullable<int> OrdemServico { get; set; }
        public string Descricao { get; set; }
        public System.DateTime DataLancamento { get; set; }
        public decimal Valor { get; set; }
        public string NotaFiscal { get; set; }
        public Nullable<System.DateTime> AprovadoEm { get; set; }
        public Nullable<int> Pagamento { get; set; }
        public int Beneficiario { get; set; }
        public string ComprovanteURL { get; set; }
        public string ComprovanteNome { get; set; }
        public int Versao { get; set; }
        public Nullable<int> Categoria { get; set; }
        public Nullable<int> AprovadoPor { get; set; }
        public Nullable<System.DateTime> AprovadoFinanceiroEm { get; set; }
        public Nullable<int> AprovadoFinanceiroPor { get; set; }
    
        public virtual CaixinhaCategoria CaixinhaCategoria { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaixinhaLancadaAprovacao> CaixinhaLancadaAprovacao { get; set; }
        public virtual OrdemServico OrdemServico1 { get; set; }
        public virtual Pagamento Pagamento1 { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
        public virtual Pessoa Pessoa2 { get; set; }
    }
}
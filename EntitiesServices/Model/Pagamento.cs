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
    
    public partial class Pagamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pagamento()
        {
            this.CaixinhaLancada = new HashSet<CaixinhaLancada>();
            this.PagamentoDocumento = new HashSet<PagamentoDocumento>();
            this.PagamentoHistorico = new HashSet<PagamentoHistorico>();
            this.PagamentoComunicacao = new HashSet<PagamentoComunicacao>();
            this.PagamentoRateio = new HashSet<PagamentoRateio>();
            this.PagamentoRecibo = new HashSet<PagamentoRecibo>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> DataPagamento { get; set; }
        public System.DateTime DataVencimento { get; set; }
        public int Beneficiario { get; set; }
        public decimal Total { get; set; }
        public Nullable<int> Categoria { get; set; }
        public Nullable<int> OrdemServico { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> Parcelamento { get; set; }
        public Nullable<int> Recorrencia { get; set; }
        public Nullable<int> Parcela { get; set; }
        public Nullable<int> MeioPagamento { get; set; }
        public Nullable<int> ContaBancaria { get; set; }
        public bool Provisionado { get; set; }
        public bool Protesto { get; set; }
        public int Criticidade { get; set; }
        public int CadastradoPor { get; set; }
        public System.DateTime CadastradoEm { get; set; }
        public Nullable<System.DateTime> DataEmissao { get; set; }
        public Nullable<int> OrcamentoTerceiro { get; set; }
        public string NotaFiscal { get; set; }
        public bool Caixinha { get; set; }
        public Nullable<int> FaturadoPara { get; set; }
        public Nullable<int> Projeto { get; set; }
        public decimal Encargos { get; set; }
        public bool Fixo { get; set; }
        public bool Liberar { get; set; }
        public Nullable<bool> Adm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaixinhaLancada> CaixinhaLancada { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual EmpresaContaBancaria EmpresaContaBancaria { get; set; }
        public virtual MeioPagamento MeioPagamento1 { get; set; }
        public virtual OrcamentoTerceiro OrcamentoTerceiro1 { get; set; }
        public virtual OrdemServico OrdemServico1 { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
        public virtual PagamentoCategoria PagamentoCategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagamentoDocumento> PagamentoDocumento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagamentoHistorico> PagamentoHistorico { get; set; }
        public virtual Parcelamento Parcelamento1 { get; set; }
        public virtual Projeto Projeto1 { get; set; }
        public virtual Recorrencia Recorrencia1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagamentoComunicacao> PagamentoComunicacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagamentoRateio> PagamentoRateio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagamentoRecibo> PagamentoRecibo { get; set; }
    }
}
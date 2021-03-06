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
    
    public partial class DocumentoFiscal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentoFiscal()
        {
            this.ArquivoProcessamento = new HashSet<ArquivoProcessamento>();
        }
    
        public int Id { get; set; }
        public int Empresa { get; set; }
        public int Cliente { get; set; }
        public int OrdemServico { get; set; }
        public string PrestadorCNPJ { get; set; }
        public string PrestadorInscricao { get; set; }
        public string RPSSerie { get; set; }
        public Nullable<long> RPSNumero { get; set; }
        public int RPSTipo { get; set; }
        public int RPSStatus { get; set; }
        public string ServicoCodigo { get; set; }
        public string ServicoDiscriminacao { get; set; }
        public decimal ServicoAliquota { get; set; }
        public decimal Servicos { get; set; }
        public decimal Deducoes { get; set; }
        public decimal AliquotaPIS { get; set; }
        public decimal PIS { get; set; }
        public decimal AliquotaCOFINS { get; set; }
        public decimal COFINS { get; set; }
        public decimal AliquotaINSS { get; set; }
        public decimal INSS { get; set; }
        public decimal AliquotaIR { get; set; }
        public decimal IR { get; set; }
        public decimal AliquotaCSLL { get; set; }
        public decimal CSLL { get; set; }
        public decimal AliquotaISSRetido { get; set; }
        public decimal ISSRetido { get; set; }
        public string TomadorCPFCNPJ { get; set; }
        public string TomadorRazaoSocial { get; set; }
        public string TomadorTipoLogradouro { get; set; }
        public string TomadorLogradouro { get; set; }
        public string TomadorNumeroEndereco { get; set; }
        public string TomadorComplementoEndereco { get; set; }
        public string TomadorBairro { get; set; }
        public string TomadorCidade { get; set; }
        public string TomadorUF { get; set; }
        public string TomadorCEP { get; set; }
        public string TomadorEmail { get; set; }
        public Nullable<System.DateTime> DataEmissao { get; set; }
        public string TomadorInscricaoEstadual { get; set; }
        public string TomadorInscricaoMunicipal { get; set; }
        public string IntermediarioInscricaoMunicipal { get; set; }
        public Nullable<bool> ISSRetidoIntermediario { get; set; }
        public string MatriculaObra { get; set; }
        public decimal PercentualCargaTributaria { get; set; }
        public decimal CargaTributaria { get; set; }
        public string IntermediarioCPFCNPJ { get; set; }
        public string IntermediarioEmail { get; set; }
        public string ControleChaveRps { get; set; }
        public string ControleChaveNfe { get; set; }
        public string ControleCodigoVerificacao { get; set; }
        public string Status { get; set; }
        public string ServicoDescricao { get; set; }
        public Nullable<int> ContaBancaria { get; set; }
        public string Loja { get; set; }
        public Nullable<System.DateTime> Vencimento { get; set; }
        public Nullable<int> FormaPagamento { get; set; }
        public string UrlImpressao { get; set; }
        public Nullable<int> NaturezaOperacao { get; set; }
        public Nullable<int> LocalIncidencia { get; set; }
        public Nullable<int> OrdemServicoParcelamento { get; set; }
        public string PrestacaoUF { get; set; }
        public string PrestacaoMunicipio { get; set; }
        public Nullable<decimal> PrestacaoMunicipioAliquota { get; set; }
        public string FonteCargaTributaria { get; set; }
        public decimal BaseCalculo { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorISS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArquivoProcessamento> ArquivoProcessamento { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual EmpresaContaBancaria EmpresaContaBancaria { get; set; }
        public virtual Empresa Empresa1 { get; set; }
        public virtual FatServicosPmsp FatServicosPmsp { get; set; }
        public virtual OrdemServico OrdemServico1 { get; set; }
    }
}

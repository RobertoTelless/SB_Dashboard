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
    
    public partial class PessoaContato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PessoaContato()
        {
            this.Contrato = new HashSet<Contrato>();
            this.Contrato1 = new HashSet<Contrato>();
            this.OrdemServico = new HashSet<OrdemServico>();
            this.PesquisaSatisfacaoGestor = new HashSet<PesquisaSatisfacaoGestor>();
            this.PesquisaSatisfacaoGestorLog = new HashSet<PesquisaSatisfacaoGestorLog>();
            this.PessoaContatoMarcadorPesquisa = new HashSet<PessoaContatoMarcadorPesquisa>();
        }
    
        public int Id { get; set; }
        public int Pessoa { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Nullable<int> Marcador { get; set; }
        public string Observacao { get; set; }
        public Nullable<int> Departamento { get; set; }
        public string Senha { get; set; }
        public bool Os { get; set; }
        public bool Financeiro { get; set; }
        public byte VersaoSenha { get; set; }
        public Nullable<int> MarcadorPesquisa { get; set; }
        public Nullable<bool> Ativo { get; set; }
        public Nullable<bool> ReceberEmail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato1 { get; set; }
        public virtual DepartamentoOrganizacao DepartamentoOrganizacao { get; set; }
        public virtual MarcadorContato MarcadorContato { get; set; }
        public virtual MarcadorPesquisa MarcadorPesquisa1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdemServico> OrdemServico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PesquisaSatisfacaoGestor> PesquisaSatisfacaoGestor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PesquisaSatisfacaoGestorLog> PesquisaSatisfacaoGestorLog { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaContatoMarcadorPesquisa> PessoaContatoMarcadorPesquisa { get; set; }
    }
}

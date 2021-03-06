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
    
    public partial class Orcamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orcamento()
        {
            this.OrcamentoRecurso = new HashSet<OrcamentoRecurso>();
            this.OrcamentoMaterial = new HashSet<OrcamentoMaterial>();
            this.OrcamentoServico = new HashSet<OrcamentoServico>();
            this.OrcamentoTerceiro = new HashSet<OrcamentoTerceiro>();
            this.OrdemServico2 = new HashSet<OrdemServico>();
            this.OrcamentoAlbum = new HashSet<OrcamentoAlbum>();
        }
    
        public int Id { get; set; }
        public int OrdemServico { get; set; }
        public int Criador { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> Lpu { get; set; }
        public Nullable<bool> Externo { get; set; }
    
        public virtual ModeloLPU ModeloLPU { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrcamentoRecurso> OrcamentoRecurso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrcamentoMaterial> OrcamentoMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrcamentoServico> OrcamentoServico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrcamentoTerceiro> OrcamentoTerceiro { get; set; }
        public virtual OrdemServico OrdemServico1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdemServico> OrdemServico2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrcamentoAlbum> OrcamentoAlbum { get; set; }
    }
}

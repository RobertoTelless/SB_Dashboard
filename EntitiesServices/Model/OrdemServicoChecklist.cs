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
    
    public partial class OrdemServicoChecklist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdemServicoChecklist()
        {
            this.ChecklistPendencia = new HashSet<ChecklistPendencia>();
            this.OrdemServicoChecklistHistorico = new HashSet<OrdemServicoChecklistHistorico>();
            this.OrdemServicoChecklistAlbum = new HashSet<OrdemServicoChecklistAlbum>();
        }
    
        public int Id { get; set; }
        public int OrdemServico { get; set; }
        public System.DateTime DataVencimento { get; set; }
        public string Items { get; set; }
        public Nullable<System.DateTime> PreenchidoEm { get; set; }
        public Nullable<int> PreenchidoPor { get; set; }
        public string Assinatura { get; set; }
        public Nullable<System.DateTime> ValidadoEm { get; set; }
        public Nullable<int> ValidadoPor { get; set; }
        public string AssinaturaValidacao { get; set; }
        public Nullable<bool> Visita { get; set; }
        public Nullable<int> Ordem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChecklistPendencia> ChecklistPendencia { get; set; }
        public virtual OrdemServico OrdemServico1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdemServicoChecklistHistorico> OrdemServicoChecklistHistorico { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdemServicoChecklistAlbum> OrdemServicoChecklistAlbum { get; set; }
    }
}
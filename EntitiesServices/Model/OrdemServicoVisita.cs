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
    
    public partial class OrdemServicoVisita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdemServicoVisita()
        {
            this.OrdemServicoVisitaAlbum = new HashSet<OrdemServicoVisitaAlbum>();
            this.OrdemServicoVisitaItem = new HashSet<OrdemServicoVisitaItem>();
        }
    
        public int Id { get; set; }
        public int OrdemServico { get; set; }
        public string Descricao { get; set; }
        public int Execucao { get; set; }
    
        public virtual OrdemServico OrdemServico1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdemServicoVisitaAlbum> OrdemServicoVisitaAlbum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdemServicoVisitaItem> OrdemServicoVisitaItem { get; set; }
    }
}

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
    
    public partial class CaixinhaCategoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaixinhaCategoria()
        {
            this.CaixinhaLancada = new HashSet<CaixinhaLancada>();
        }
    
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> Categoria { get; set; }
    
        public virtual PagamentoCategoria PagamentoCategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaixinhaLancada> CaixinhaLancada { get; set; }
    }
}

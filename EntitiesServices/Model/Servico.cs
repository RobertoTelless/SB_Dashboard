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
    
    public partial class Servico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> Categoria { get; set; }
        public Nullable<int> Tipo { get; set; }
        public Nullable<int> SubTipo { get; set; }
    
        public virtual ServicoCategoria ServicoCategoria { get; set; }
        public virtual ServicoSubTipo ServicoSubTipo { get; set; }
        public virtual ServicoTipo ServicoTipo { get; set; }
    }
}
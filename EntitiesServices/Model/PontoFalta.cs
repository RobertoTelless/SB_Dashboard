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
    
    public partial class PontoFalta
    {
        public int Id { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public System.DateTime Data { get; set; }
        public bool DiaTodo { get; set; }
        public int DuracaoHoras { get; set; }
        public int DiasRepeticao { get; set; }
        public string Descricao { get; set; }
        public int PessoaId { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
    }
}

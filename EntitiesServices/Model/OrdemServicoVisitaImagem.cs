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
    
    public partial class OrdemServicoVisitaImagem
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public int Album { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Caminho { get; set; }
    
        public virtual OrdemServicoVisitaAlbum OrdemServicoVisitaAlbum { get; set; }
    }
}

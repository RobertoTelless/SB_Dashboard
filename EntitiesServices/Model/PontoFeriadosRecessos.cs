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
    
    public partial class PontoFeriadosRecessos
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int TipoFeriadosRecessos { get; set; }
        public System.DateTime Data { get; set; }
        public int Recorrencia { get; set; }
        public int Quantidade { get; set; }
    }
}

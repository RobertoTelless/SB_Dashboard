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
    
    public partial class ContratoEquipeEspecialidade
    {
        public int Contrato { get; set; }
        public int Pessoa { get; set; }
        public int Especialidade { get; set; }
    
        public virtual Contrato Contrato1 { get; set; }
        public virtual EspecialidadePreventiva EspecialidadePreventiva { get; set; }
        public virtual Pessoa Pessoa1 { get; set; }
    }
}

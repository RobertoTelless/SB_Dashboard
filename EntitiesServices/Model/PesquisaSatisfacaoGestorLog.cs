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
    
    public partial class PesquisaSatisfacaoGestorLog
    {
        public int Id { get; set; }
        public int PessoaContato { get; set; }
        public int PesquisaSatisfacaoGestorJornada { get; set; }
        public System.DateTime DataEnvio { get; set; }
        public bool Sucesso { get; set; }
    
        public virtual PesquisaSatisfacaoGestorJornada PesquisaSatisfacaoGestorJornada1 { get; set; }
        public virtual PessoaContato PessoaContato1 { get; set; }
    }
}

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
    
    public partial class EmpresaDocumentoBlob
    {
        public int Id { get; set; }
        public int EmpresaDocumento { get; set; }
        public string NomeArquivo { get; set; }
        public string Caminho { get; set; }
    
        public virtual EmpresaDocumento EmpresaDocumento1 { get; set; }
    }
}
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
    
    public partial class vwContasAPagar
    {
        public Nullable<int> Ordem_de_Servico { get; set; }
        public string Centro_de_Custos { get; set; }
        public string Descricao { get; set; }
        public string Nota_Fiscal { get; set; }
        public string Beneficario { get; set; }
        public string Centro_de_Lucro { get; set; }
        public System.DateTime Data_de_Vencimento { get; set; }
        public Nullable<System.DateTime> Data_de_Emissao { get; set; }
        public Nullable<System.DateTime> Data_de_Pagamento { get; set; }
        public decimal Valor { get; set; }
        public decimal Encargos { get; set; }
        public bool Despesa { get; set; }
        public string Protesto_ { get; set; }
        public int Criticidade { get; set; }
        public string Faturado_Para { get; set; }
        public string Pago_ { get; set; }
        public string Certa_Variavel { get; set; }
        public string Tipo_OS { get; set; }
        public string Liberado_para_pagamento_ { get; set; }
        public string Tipo_Equipe { get; set; }
        public string Centro_Custo_Reduzido { get; set; }
        public string Adm_Produção { get; set; }
    }
}
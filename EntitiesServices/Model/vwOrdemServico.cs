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
    
    public partial class vwOrdemServico
    {
        public int Num { get; set; }
        public string Centro_de_Lucro { get; set; }
        public string Ocorrencia { get; set; }
        public string Tipo { get; set; }
        public string Situacao { get; set; }
        public string Cliente { get; set; }
        public string Especialidade { get; set; }
        public Nullable<System.DateTime> Data_Significativa { get; set; }
        public Nullable<System.DateTime> Data_de_Visita__Previsao_ { get; set; }
        public Nullable<System.DateTime> Data_de_Execucao_Inicio__Previsao_ { get; set; }
        public Nullable<System.DateTime> Data_de_Execucao_Fim__Previsao_ { get; set; }
        public Nullable<System.DateTime> Data_Execucao_Inicio { get; set; }
        public Nullable<System.DateTime> Data_Execucao_Fim { get; set; }
        public string Ordem_de_Compra { get; set; }
        public string Equipe { get; set; }
        public string Vistoriadores { get; set; }
        public string Observacao { get; set; }
        public System.DateTime Data_de_Cadastro { get; set; }
        public Nullable<System.DateTime> Data_de_Visita { get; set; }
        public string Com_Ordem_de_Compra { get; set; }
        public string Cadastrado_Por { get; set; }
        public string Aprovado_Por { get; set; }
        public Nullable<decimal> Valor_do_Orcamento { get; set; }
        public Nullable<decimal> Despesa { get; set; }
        public Nullable<decimal> Lancamentos { get; set; }
        public string Solicitante { get; set; }
        public string Tipo_Equipe { get; set; }
        public string Status_Negocio { get; set; }
        public string Motivo_Perda { get; set; }
        public Nullable<decimal> Valor_Restante_Terceiro { get; set; }
        public decimal Valor_Restante_Parcelamento { get; set; }
        public Nullable<int> Janela_Emissao_Ate { get; set; }
        public Nullable<int> Prazo_Pagamento { get; set; }
        public Nullable<int> Probabilidade { get; set; }
        public Nullable<System.DateTime> Data_Previsao_Recebimento { get; set; }
        public Nullable<System.DateTime> Data_Previsao_Pagamento { get; set; }
        public Nullable<System.DateTime> Data_Previsao_Emissao { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATIMO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FAT_FATURAMENTO
    {
        public int ID { get; set; }
        public int ID_OSSB { get; set; }
        public decimal VALOR_BRUTO { get; set; }
        public Nullable<System.DateTime> DATA_EMISSAO_NF { get; set; }
        public Nullable<int> NUMERO_NF { get; set; }
        public string COD_VERIFICACAO_NF { get; set; }
        public int ID_EMPRESA { get; set; }
        public System.DateTime DATA_CADASTRO { get; set; }
        public string DESCRICAO_NF { get; set; }
        public string FLAG_CANCELADA { get; set; }
        public int NUMERO_RPS { get; set; }
        public string ID_SERVICO_PMSP { get; set; }
        public int ID_CLIENTE { get; set; }
        public string NUM_SERIE_RPS { get; set; }
        public Nullable<decimal> VALOR_MAO_DE_OBRA { get; set; }
        public Nullable<int> ID_TIPOPAGTO { get; set; }
        public Nullable<int> ID_SITUACAOPAGTO { get; set; }
        public Nullable<decimal> VALOR_SERVICO { get; set; }
        public string CAMINHO_PDF_NF { get; set; }
        public Nullable<int> LOTE_EMISSAO_PMSP { get; set; }
        public string CONREC_HISTORICO { get; set; }
        public Nullable<System.DateTime> CONREC_DATAVENCTO { get; set; }
        public string CONREC_CAMINHO_PDF_BOLETO { get; set; }
        public Nullable<decimal> VALOR_LIQUIDO { get; set; }
        public Nullable<System.DateTime> CONREC_DATAPAGTO { get; set; }
        public string CONREC_TIPOPAGTO { get; set; }
    
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual OSSB OSSB { get; set; }
    }
}
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
    
    public partial class OSSB_MATERIAL
    {
        public int ID { get; set; }
        public int OSSB { get; set; }
        public string DESCRICAO { get; set; }
        public decimal QUANTIDADE { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public int UNIDADE { get; set; }
        public Nullable<int> FORNECEDOR { get; set; }
        public System.DateTime DATA { get; set; }
        public Nullable<decimal> VALOR_COMPRADO { get; set; }
        public Nullable<System.DateTime> DATA_COMPRADO { get; set; }
        public string LOCAL_ENTREGA { get; set; }
        public string OBSERVACAO { get; set; }
    
        public virtual OSSB OSSB1 { get; set; }
        public virtual PESSOA PESSOA { get; set; }
        public virtual UNIDADE UNIDADE1 { get; set; }
    }
}

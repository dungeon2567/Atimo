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
    
    public partial class DESPESA_RECORRENTE
    {
        public int ID { get; set; }
        public int DESPESA { get; set; }
        public decimal VALOR { get; set; }
        public int DIA { get; set; }
        public int PESSOA { get; set; }
        public int PROJETO { get; set; }
        public int CRITICIDADE { get; set; }
    
        public virtual DESPESA DESPESA1 { get; set; }
        public virtual PESSOA PESSOA1 { get; set; }
        public virtual PROJETO PROJETO1 { get; set; }
    }
}

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
    
    public partial class OSSB_CHECK_LIST
    {
        public int ID { get; set; }
        public System.DateTime AGENDADO { get; set; }
        public Nullable<System.DateTime> VISITADO { get; set; }
        public Nullable<int> ANEXO { get; set; }
        public int OSSB { get; set; }
    
        public virtual ANEXO ANEXO1 { get; set; }
        public virtual OSSB OSSB1 { get; set; }
    }
}

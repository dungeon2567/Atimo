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
    
    public partial class CLIENTE_COMO_CONHECEU
    {
        public int ID { get; set; }
        public int CLIENTE { get; set; }
        public int COMO_CONHECEU { get; set; }
        public string OUTROS { get; set; }
    
        public virtual PESSOA PESSOA { get; set; }
        public virtual COMO_CONHECEU COMO_CONHECEU1 { get; set; }
    }
}

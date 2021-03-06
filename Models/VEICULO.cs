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
    
    public partial class VEICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEICULO()
        {
            this.PATRIMONIO = new HashSet<PATRIMONIO>();
            this.RATEIO = new HashSet<RATEIO>();
            this.VEICULO_MULTA = new HashSet<VEICULO_MULTA>();
        }
    
        public int ID { get; set; }
        public Nullable<int> MARCA { get; set; }
        public Nullable<int> MODELO { get; set; }
        public int ANO { get; set; }
        public string CHASSI { get; set; }
        public string PLACA { get; set; }
        public string COMBUSTIVEL { get; set; }
        public decimal SEGURO { get; set; }
        public decimal IPVA { get; set; }
        public string OBSERVACAO { get; set; }
        public string SITUACAO { get; set; }
    
        public virtual MARCA MARCA1 { get; set; }
        public virtual MODELO MODELO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PATRIMONIO> PATRIMONIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RATEIO> RATEIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEICULO_MULTA> VEICULO_MULTA { get; set; }
    }
}

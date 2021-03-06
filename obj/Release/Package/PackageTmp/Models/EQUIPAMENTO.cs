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
    
    public partial class EQUIPAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EQUIPAMENTO()
        {
            this.PATRIMONIO = new HashSet<PATRIMONIO>();
            this.RATEIO = new HashSet<RATEIO>();
        }
    
        public int ID { get; set; }
        public int GRUPO { get; set; }
        public int TIPO { get; set; }
        public Nullable<int> MARCA { get; set; }
        public Nullable<int> MODELO { get; set; }
        public string DESCRICAO { get; set; }
        public string FABRICANTE { get; set; }
        public string NUM_SERIE { get; set; }
        public string OBSERVACAO { get; set; }
        public string SITUACAO { get; set; }
    
        public virtual GRUPO GRUPO1 { get; set; }
        public virtual MARCA MARCA1 { get; set; }
        public virtual MODELO MODELO1 { get; set; }
        public virtual TIPO TIPO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PATRIMONIO> PATRIMONIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RATEIO> RATEIO { get; set; }
    }
}

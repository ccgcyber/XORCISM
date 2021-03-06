//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class REPUTATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REPUTATION()
        {
            this.ADDRESSREPUTATION = new HashSet<ADDRESSREPUTATION>();
            this.DOMAINNAMEREPUTATION = new HashSet<DOMAINNAMEREPUTATION>();
        }
    
        public int ReputationID { get; set; }
        public string ReputationGUID { get; set; }
        public string ReputationTitle { get; set; }
        public string ReputationDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADDRESSREPUTATION> ADDRESSREPUTATION { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOMAINNAMEREPUTATION> DOMAINNAMEREPUTATION { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}

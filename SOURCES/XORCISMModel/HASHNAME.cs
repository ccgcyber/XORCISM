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
    
    public partial class HASHNAME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HASHNAME()
        {
            this.HASHVALUE = new HashSet<HASHVALUE>();
        }
    
        public int HashNameID { get; set; }
        public string HashingAlgorithmName { get; set; }
        public string HashingAlgorithmDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> TrustLevelID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<int> EnumerationVersionID { get; set; }
    
        public virtual ENUMERATIONVERSION ENUMERATIONVERSION { get; set; }
        public virtual TRUSTLEVEL TRUSTLEVEL { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HASHVALUE> HASHVALUE { get; set; }
    }
}
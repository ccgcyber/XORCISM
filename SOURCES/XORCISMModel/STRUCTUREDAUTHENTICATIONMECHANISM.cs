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
    
    public partial class STRUCTUREDAUTHENTICATIONMECHANISM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STRUCTUREDAUTHENTICATIONMECHANISM()
        {
            this.ACCOUNTAUTHENTICATION = new HashSet<ACCOUNTAUTHENTICATION>();
        }
    
        public int StructuredAuthenticationMechanismID { get; set; }
        public string StructuredAuthenticationMechanismGUID { get; set; }
        public string StructuredAuthenticationMechanismDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ValidityID { get; set; }
        public Nullable<int> TrustLevelID { get; set; }
        public Nullable<int> TrustReasonID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACCOUNTAUTHENTICATION> ACCOUNTAUTHENTICATION { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual TRUSTLEVEL TRUSTLEVEL { get; set; }
        public virtual TRUSTREASON TRUSTREASON { get; set; }
        public virtual VALIDITY VALIDITY { get; set; }
    }
}

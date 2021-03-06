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
    
    public partial class PROTOCOL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROTOCOL()
        {
            this.DPE = new HashSet<DPE>();
            this.ENDPOINT = new HashSet<ENDPOINT>();
            this.NETWORKCONNECTION = new HashSet<NETWORKCONNECTION>();
            this.NETWORKCONNECTION1 = new HashSet<NETWORKCONNECTION>();
            this.NETWORKCONNECTION2 = new HashSet<NETWORKCONNECTION>();
            this.NETWORKROUTE = new HashSet<NETWORKROUTE>();
            this.PORT = new HashSet<PORT>();
            this.PROTOCOLCOMMAND = new HashSet<PROTOCOLCOMMAND>();
            this.PROTOCOLREFERENCE = new HashSet<PROTOCOLREFERENCE>();
            this.PROTOCOLFORPROTOCOL = new HashSet<PROTOCOLFORPROTOCOL>();
            this.PROTOCOLFORPROTOCOL1 = new HashSet<PROTOCOLFORPROTOCOL>();
            this.RULEPROTOCOL = new HashSet<RULEPROTOCOL>();
            this.SIGNATURE = new HashSet<SIGNATURE>();
        }
    
        public int ProtocolID { get; set; }
        public string ProtocolAbbreviation { get; set; }
        public string ProtocolName { get; set; }
        public string ProtocolDescription { get; set; }
        public string ProtocolRFC { get; set; }
        public string ProtocolBAF { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<int> OSILayerID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DPE> DPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENDPOINT> ENDPOINT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NETWORKCONNECTION> NETWORKCONNECTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NETWORKCONNECTION> NETWORKCONNECTION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NETWORKCONNECTION> NETWORKCONNECTION2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NETWORKROUTE> NETWORKROUTE { get; set; }
        public virtual OSILAYER OSILAYER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PORT> PORT { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROTOCOLCOMMAND> PROTOCOLCOMMAND { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROTOCOLREFERENCE> PROTOCOLREFERENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROTOCOLFORPROTOCOL> PROTOCOLFORPROTOCOL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROTOCOLFORPROTOCOL> PROTOCOLFORPROTOCOL1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RULEPROTOCOL> RULEPROTOCOL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SIGNATURE> SIGNATURE { get; set; }
    }
}

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
    
    public partial class X509CERTIFICATESTANDARDEXTENSION
    {
        public int X509CertificateStandardExtensionID { get; set; }
        public int X509CertificateID { get; set; }
        public string X509CertificateGUID { get; set; }
        public int X509V3ExtensionID { get; set; }
        public string X509V3ExtensionGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual X509CERTIFICATE X509CERTIFICATE { get; set; }
        public virtual X509V3EXTENSION X509V3EXTENSION { get; set; }
    }
}

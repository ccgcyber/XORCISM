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
    
    public partial class ACTIONACTIONNAME
    {
        public int ActionActionNameID { get; set; }
        public int ActionID { get; set; }
        public string ActionGUID { get; set; }
        public int ActionNameID { get; set; }
        public string ActionNameGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual ACTION ACTION { get; set; }
        public virtual ACTIONNAME ACTIONNAME { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}

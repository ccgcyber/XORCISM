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
    
    public partial class LIBRARY
    {
        public int LibraryID { get; set; }
        public string LibraryName { get; set; }
        public string LibraryVersion { get; set; }
        public string LibraryDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
    
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}

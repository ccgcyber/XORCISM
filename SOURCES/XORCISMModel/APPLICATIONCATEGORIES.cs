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
    
    public partial class APPLICATIONCATEGORIES
    {
        public int ApplicationCategoriesID { get; set; }
        public int ApplicationID { get; set; }
        public string ApplicationGUID { get; set; }
        public int ApplicationCategoryID { get; set; }
        public string ApplicationCategoryGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<int> RepositoryID { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual APPLICATION APPLICATION { get; set; }
        public virtual APPLICATIONCATEGORY APPLICATIONCATEGORY { get; set; }
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual REPOSITORY REPOSITORY { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XTHREATModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class THREATCAMPAIGNTAG
    {
        public int ThreatCampaignTagID { get; set; }
        public int ThreatCampaignID { get; set; }
        public string ThreatCampaignGUID { get; set; }
        public int TagID { get; set; }
        public string TagGUID { get; set; }
        public Nullable<int> ConfidentialityLevelID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual THREATCAMPAIGN THREATCAMPAIGN { get; set; }
    }
}
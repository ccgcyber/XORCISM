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
    
    public partial class CHANGECONTROL
    {
        public int ChangeControlID { get; set; }
        public Nullable<int> SecurityControlID { get; set; }
    
        public virtual SECURITYCONTROL SECURITYCONTROL { get; set; }
    }
}
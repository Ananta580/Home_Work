//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Home_Work.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile_Training
    {
        public int ID { get; set; }
        public string CertificationName { get; set; }
        public string InstituteName { get; set; }
        public string Skills { get; set; }
        public Nullable<System.DateTime> ComletedDate { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Profile_User Profile_User { get; set; }
    }
}
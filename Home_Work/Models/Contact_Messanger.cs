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
    
    public partial class Contact_Messanger
    {
        public int ID { get; set; }
        public Nullable<int> MessageID { get; set; }
        public Nullable<int> SenderID { get; set; }
        public Nullable<int> RecieverID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Contact_Message Contact_Message { get; set; }
        public virtual Profile_User Profile_User { get; set; }
        public virtual Profile_User Profile_User1 { get; set; }
    }
}

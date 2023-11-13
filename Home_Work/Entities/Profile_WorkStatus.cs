
namespace Home_Work.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile_WorkStatus
    {
        public int ID { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> JobId { get; set; }
        public string Status { get; set; }
        public string Approved { get; set; }
    
        public virtual Job_Post Job_Post { get; set; }
        public virtual Profile_User Profile_User { get; set; }
    }
}

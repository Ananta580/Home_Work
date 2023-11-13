
namespace Home_Work.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job_HomeBase
    {
        public int ID { get; set; }
        public Nullable<int> PostId { get; set; }
        public string JobLocation { get; set; }
        public Nullable<decimal> ContactNo { get; set; }
        public Nullable<decimal> CountryCode { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Job_Post Job_Post { get; set; }
    }
}

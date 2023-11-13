
namespace Home_Work.Models
{
    using System;

    public partial class Profile_Work
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Responsibility { get; set; }
        public DateTime? StartDate { get; set; }
        public int? UserID { get; set; }

        public virtual Profile_User Profile_User { get; set; }
    }
}

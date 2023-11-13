
namespace Home_Work.Models
{
    using System;

    public partial class Profile_Education
    {
        public int ID { get; set; }
        public string SchoolName { get; set; }
        public string Affiliation { get; set; }
        public string Level { get; set; }
        public DateTime? PassOutDate { get; set; }
        public int? UserID { get; set; }

        public virtual Profile_User Profile_User { get; set; }
    }
}

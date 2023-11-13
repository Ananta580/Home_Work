
namespace Home_Work.Models
{
    using System;

    public partial class Profile_Training
    {
        public int ID { get; set; }
        public string CertificationName { get; set; }
        public string InstituteName { get; set; }
        public string Skills { get; set; }
        public DateTime? ComletedDate { get; set; }
        public int? UserID { get; set; }

        public virtual Profile_User Profile_User { get; set; }
    }
}

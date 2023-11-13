
namespace Home_Work.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Profile_User
    {
        public Profile_User()
        {
            this.Contact_Messanger = new HashSet<Contact_Messanger>();
            this.Contact_Messanger1 = new HashSet<Contact_Messanger>();
            this.Job_Post = new HashSet<Job_Post>();
            this.Portfolio_Image = new HashSet<Portfolio_Image>();
            this.Profile_Education = new HashSet<Profile_Education>();
            this.Profile_Portfolio = new HashSet<Profile_Portfolio>();
            this.Profile_Training = new HashSet<Profile_Training>();
            this.Profile_Work = new HashSet<Profile_Work>();
            this.Profile_WorkStatus = new HashSet<Profile_WorkStatus>();
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public decimal? Phone { get; set; }
        public decimal? CountryCode { get; set; }

        public virtual ICollection<Contact_Messanger> Contact_Messanger { get; set; }
        public virtual ICollection<Contact_Messanger> Contact_Messanger1 { get; set; }
        public virtual ICollection<Job_Post> Job_Post { get; set; }
        public virtual ICollection<Portfolio_Image> Portfolio_Image { get; set; }
        public virtual ICollection<Profile_Education> Profile_Education { get; set; }
        public virtual ICollection<Profile_Portfolio> Profile_Portfolio { get; set; }
        public virtual ICollection<Profile_Training> Profile_Training { get; set; }
        public virtual ICollection<Profile_Work> Profile_Work { get; set; }
        public virtual ICollection<Profile_WorkStatus> Profile_WorkStatus { get; set; }
    }
}

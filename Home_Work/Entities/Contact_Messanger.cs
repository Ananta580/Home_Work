
namespace Home_Work.Models
{
    using System;

    public partial class Contact_Messanger
    {
        public int ID { get; set; }
        public int? MessageID { get; set; }
        public int? SenderID { get; set; }
        public int? RecieverID { get; set; }
        public DateTime? Date { get; set; }

        public virtual Contact_Message Contact_Message { get; set; }
        public virtual Profile_User Profile_User { get; set; }
        public virtual Profile_User Profile_User1 { get; set; }
    }
}

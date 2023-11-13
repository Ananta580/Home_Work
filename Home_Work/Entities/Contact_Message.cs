
namespace Home_Work.Models
{
    using System.Collections.Generic;

    public partial class Contact_Message
    {
        public Contact_Message()
        {
            this.Contact_Messanger = new HashSet<Contact_Messanger>();
        }

        public int ID { get; set; }
        public string Message { get; set; }

        public virtual ICollection<Contact_Messanger> Contact_Messanger { get; set; }
    }
}

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
    
    public partial class Contact_Message
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contact_Message()
        {
            this.Contact_Messanger = new HashSet<Contact_Messanger>();
        }
    
        public int ID { get; set; }
        public string Message { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact_Messanger> Contact_Messanger { get; set; }
    }
}
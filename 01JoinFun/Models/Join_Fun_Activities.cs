//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace _01JoinFun.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Join_Fun_Activities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Join_Fun_Activities()
        {
            this.Activity_Details = new HashSet<Activity_Details>();
            this.Bookmark_Details = new HashSet<Bookmark_Details>();
            this.Hash_Tag = new HashSet<Hash_Tag>();
            this.Member_Remarks = new HashSet<Member_Remarks>();
            this.Message_Board = new HashSet<Message_Board>();
            this.Photos_of_Activities = new HashSet<Photos_of_Activities>();
        }
    
        public string actId { get; set; }
        public string actClassId { get; set; }
        public string hostId { get; set; }
        public string actTopic { get; set; }
        public System.DateTime actTime { get; set; }
        public System.DateTime actDeadline { get; set; }
        public string actDescription { get; set; }
        public short ageRestrict { get; set; }
        public short gender { get; set; }
        public short maxNumPeople { get; set; }
        public short maxBudget { get; set; }
        public short actCounty { get; set; }
        public short actDistrict { get; set; }
        public string actRoad { get; set; }
        public short paymentTerm { get; set; }
        public bool acceptDrop { get; set; }
        public int clickTimes { get; set; }
        public bool keepAct { get; set; }
    
        public virtual Activity_Class Activity_Class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity_Details> Activity_Details { get; set; }
        public virtual Age_Restriction Age_Restriction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bookmark_Details> Bookmark_Details { get; set; }
        public virtual Budget_Restriction Budget_Restriction { get; set; }
        public virtual County County { get; set; }
        public virtual District District { get; set; }
        public virtual Gender_Restriction Gender_Restriction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hash_Tag> Hash_Tag { get; set; }
        public virtual People_Restriction People_Restriction { get; set; }
        public virtual Payment_Restriction Payment_Restriction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Member_Remarks> Member_Remarks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message_Board> Message_Board { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photos_of_Activities> Photos_of_Activities { get; set; }
    }
}

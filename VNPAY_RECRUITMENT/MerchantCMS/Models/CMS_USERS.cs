//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VNPRECRUITMENT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CMS_USERS
    {
        public int USER_ID { get; set; }
        public string USERNAME { get; set; }
        public string EMAIL { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string FULLNAME { get; set; }
        public string PASSWORD { get; set; }
        public string ISAPPROVED { get; set; }
        public string ISLOCKEDOUT { get; set; }
        public Nullable<System.DateTime> LASTLOGIN { get; set; }
        public int ROLE_ID { get; set; }
        public string ISDELETED { get; set; }
        public Nullable<System.DateTime> CREATED_ON { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> MODIFIED_ON { get; set; }
        public string MODIFIED_BY { get; set; }
    }
}

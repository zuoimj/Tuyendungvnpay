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
    
    public partial class JobPosition
    {
        public int JOB_ID { get; set; }
        public int POSITION_ID { get; set; }
        public bool ISDELETED { get; set; }
    
        public virtual Job Job { get; set; }
        public virtual Position Position { get; set; }
    }
}

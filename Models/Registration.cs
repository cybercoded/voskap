//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TL_LMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public string reg_id { get; set; }
        public string student_id { get; set; }
        public string teacher_id { get; set; }
        public string course_id { get; set; }
        public string reg_date { get; set; }
        public double reg_fee { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
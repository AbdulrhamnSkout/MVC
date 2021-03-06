//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Course
    {
        [Required(ErrorMessage ="this field is required")]
        [Key]
        [RegularExpression("^[0-9]{4}$", ErrorMessage = "Error not valid course number")]
        public string cid { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, ErrorMessage = "Error 2")]
        public string coursename { get; set; }

        [Required(ErrorMessage = "this field is required")]
        public Nullable<System.DateTime> dexam1 { get; set; }
        
        [Required(ErrorMessage = "this field is required")]
        public string room1 { get; set; }
        [Required(ErrorMessage = "this field is required")]
        public Nullable<System.DateTime> dexam2 { get; set; }
        [Required(ErrorMessage = "this field is required")]
        public string room2 { get; set; }
        [Required(ErrorMessage = "this field is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "the Lecturer name must be at least two letters")]
        public string Lecturer { get; set; }

        public string shid { get; set; }
    }
}

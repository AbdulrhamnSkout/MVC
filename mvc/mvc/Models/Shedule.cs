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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Shedule
    {
        public string shid { get; set; }
        [Key,Column(Order =0)]
        public string day { get; set; }
        [Key,Column(Order =1)]
        public string starthour { get; set; }
        [Key,Column(Order =2)]
        public string endhour { get; set; }
        [Key,Column(Order =3)]
        public string room { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebKamp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AdminKamp
    {
        [Required]
        public string KullanıcıAdı { get; set; }
        [Required]
        public string Şifre { get; set; }
        public int KullanıcıId { get; set; }
    
        public virtual Kamp Kamp { get; set; }
    }
}

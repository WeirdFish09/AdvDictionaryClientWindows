using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AdvDictionaryClientCore.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Word {get; set;}
        
    }    
}
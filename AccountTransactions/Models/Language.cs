using System;
using System.ComponentModel.DataAnnotations;

namespace AdvDictionaryClientCore.Models
{
    public class Language
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name {get; set;}
        public User User {get; set;}
        
    }    
}
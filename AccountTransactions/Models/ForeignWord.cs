using System;
using System.ComponentModel.DataAnnotations;

namespace AdvDictionaryClientCore.Models
{
    public class ForeignWord
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Word {get; set;}
        
    }    
}
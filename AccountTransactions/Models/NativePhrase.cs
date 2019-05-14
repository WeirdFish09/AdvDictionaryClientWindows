using System;
using System.ComponentModel.DataAnnotations;

namespace AdvDictionaryClientCore.Models
{
    public class NativePhrase
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Phrase {get; set;}
        
    }    
}
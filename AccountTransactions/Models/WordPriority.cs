using System;
using System.ComponentModel.DataAnnotations;

namespace AdvDictionaryClientCore.Models
{
    public class WordPriority
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public NativePhrase NativePhrase {get; set;}

        public Language Language{get; set;}

        public ForeignWord ForeignWord{get; set;}
        
    }    
}
using System;

namespace AccountTransactions
{
    public class WordPriority
    {
        public NativePhrase Phrase {get; set;}
        public Language Language{get; set;}
        public ForeignWord Word{get; set;}
        public int Value { get; set; }
    }    
}
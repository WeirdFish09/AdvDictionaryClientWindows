using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AccountTransactions
{
    public class User : IdentityUser
    {
        public string NativePhrase {get; set;}
    }    
}
using System;
using System.Collections;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebApplication_WebForms.Models
{
    public class  User
    {
        public int CacEdipi { get; set; }
        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public string? Email {get; set; }
        public ICollection<string> Caveats { get; set; } = null!;
    }
}

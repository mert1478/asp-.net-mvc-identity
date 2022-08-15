using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Areas.Identity
{
    public class CustomUser:IdentityUser
    {
        
        public string Name { get; set; }

        
        public string Surname { get; set; }

        
        public string Adress { get; set; }

        
        public string Gender { get; set; }
        
        
        public DateTime DateOfBirth { get; set; }


    }
}

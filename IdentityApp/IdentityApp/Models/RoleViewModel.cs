using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Models
{
    public class RoleViewModel
    {
        [Required]
        public string name { get; set; }
    }
}

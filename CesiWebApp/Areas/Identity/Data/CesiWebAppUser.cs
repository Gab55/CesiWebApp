using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CesiWebApp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the CesiWebAppUser class
    public class CesiWebAppUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "varchar(50)")]
        public string Pseudo { get; set; }

    }
}

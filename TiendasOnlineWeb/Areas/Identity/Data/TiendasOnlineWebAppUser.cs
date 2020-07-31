using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TiendasOnlineWeb.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the TiendasOnlineWebAppUser class
    public class TiendasOnlineWebAppUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName= "nvarchar(110)")]
        public string Nombre { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(110)")]
        public string Apellido { get; set; }

    }
}

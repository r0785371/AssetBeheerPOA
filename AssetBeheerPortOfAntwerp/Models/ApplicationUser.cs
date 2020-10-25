using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetBeheerPortOfAntwerp.Models
{
    public class ApplicationUser : IdentityUser
    {
        //Wanneer user zijn account delete zullen alle properties gemarkeerd met 
        //personaldata gedelete worden. Met dit attribuut zal bij een download van
        //u user deze properties er bij zitten.
        [PersonalData]
        public DateTime CareerStartedDate { get; set; }

        [PersonalData]
        public String Department { get; set; }

        [PersonalData]
        public String FullName { get; set; }
    }
}

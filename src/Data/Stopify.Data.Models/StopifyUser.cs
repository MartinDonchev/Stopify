using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stopify.Data.Models
{
    public class StopifyUser : IdentityUser
    {
        public StopifyUser()
        {

        }

        public string FullName { get; set; }
    }
}

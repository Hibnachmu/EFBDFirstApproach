﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EFDBFirstApproach.Identity
{
    public class ApplicationUser:IdentityUser 
    {
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
         
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace MyCDLibrarySecurity.Data
{
    public class Role: IdentityRole<int>
    {
        public class Constants
        {
            public const string Admin = "admin";
            public const string User = "user";
            public const string Guest = "guest";
        }
    }
}

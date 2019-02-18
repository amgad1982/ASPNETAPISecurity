using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecureApi.Security
{
    public class AspNetIdentityAuthcCtx : IdentityDbContext<IdentityUser>
    {
        public AspNetIdentityAuthcCtx() : base("AuthContext")
        {
        }
    }
}
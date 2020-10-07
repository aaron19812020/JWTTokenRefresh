using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyLolo.JWT.Server.Tool
{
    using global::FlyLolo.JWT.Server.Models;
    using System.Security.Claims;

    namespace FlyLolo.JWT.Server
    {
        //public interface ITokenHelper
        //{
        //    Token CreateToken(User user);

        //}

        public interface ITokenHelper
        {
            ComplexToken CreateToken(User user);
            ComplexToken CreateToken(Claim[] claims);
            Token RefreshToken(ClaimsPrincipal claimsPrincipal);

        }
    }

}

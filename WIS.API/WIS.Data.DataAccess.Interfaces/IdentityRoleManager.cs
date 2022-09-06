using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIS.Data.DataAccess.Interfaces
{
    public class IdentityRoleManager : RoleManager<IdentityRole>
    {
        public IdentityRoleManager(
            IRoleStore<IdentityRole> storAccsessor,
            IEnumerable<IRoleValidator<IdentityRole>> userValidators,
            ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errorDescriber,
            ILogger<RoleManager<IdentityRole>> logger) : base(
                storAccsessor,
                userValidators,
                keyNormalizer,
                errorDescriber,
                logger)


        {

        }
    }
}

using RubiconeX_Server.DataAccess.Core.Interfaces.Context;
using Microsoft.EntityFrameworkCore;
using RubiconeX_Server.DataAccess.Core.Models;
using System.Threading.Tasks;
using System.Threading;

namespace RubiconeX_Server.DataAccess.DbContext
{
    public class RubiconeXContext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubiconeXContext(DbContextOptions<RubiconeXContext> options): base(options)
        { 
        }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }


    }
}

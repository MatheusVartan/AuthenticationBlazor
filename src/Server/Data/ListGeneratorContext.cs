using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ListGeneratorBlazor.Server.Data
{
    public class ListGeneratorContext : IdentityDbContext
    {
        public ListGeneratorContext(DbContextOptions<ListGeneratorContext> options) : base(options)
        {

        }
    }
}

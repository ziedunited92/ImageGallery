using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peak.IDP.Entities
{
    public class PeakClientContext : DbContext
    { 
    public PeakClientContext(DbContextOptions<PeakClientContext> options)
          : base(options)
    {

    }

    

    public DbSet<Client> Clients { get; set; }
        public DbSet<ClientSecret> Secrets { get; set; }
        public DbSet<ClientGrantType> AllowedGrantTypes { get; set; }
        public DbSet<ClientRedirectUri> RedirectUris { get; set; }
        public DbSet<ClientPostLogoutRedirectUri> PostLogoutRedirectUris { get; set; }
        public DbSet<ClientScope> AllowedScopes { get; set; }
        public DbSet<ClientIdPRestriction> IdentityProviderRestrictions { get; set; }
        public DbSet<ClientClaim> Claims { get; set; }
        public DbSet<ClientCorsOrigin> AllowedCorsOrigins { get; set; }
        public DbSet<ClientProperty> Properties { get; set; }




    }
}


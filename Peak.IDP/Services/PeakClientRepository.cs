using IdentityServer4.Models;
using Microsoft.EntityFrameworkCore;
using Peak.IDP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;
using Client = Peak.IDP.Entities.Client;


namespace Peak.IDP.Services
{
    public class PeakClientRepository : IPeakClientRepository
        
    {
        private readonly PeakClientContext _peakClientContext;

        public PeakClientRepository(PeakClientContext peakClientContext)
        {
            _peakClientContext = peakClientContext;
        }
      
        public bool Enabled(string ClientId)
        {
            var Client = GetClientByClientId(ClientId);
            return Client.Enabled;
        }
        public Client GetClientByClientId(string clientId)
        {
            return _peakClientContext.Clients.FirstOrDefault(u => u.ClientId == clientId);
        }

        
        public string GetProtocolType()
        {
           return   "oidc"; 
        }
        public IEnumerable<ClientSecret> GetClientSecrets()
        {
            return _peakClientContext.Secrets;  
        }

        public bool RequireClientSecret ()
        {
            return true;
        }
        
        public Client GetClientByClientName(string clientname)
        {
            return _peakClientContext.Clients.FirstOrDefault(u => u.ClientName == clientname);
        }
        public string Description ()
        {
            return "This is our Honour Client";
        }
        public string ClientUri ()
        {
            return "https://localhost:44344/";
        }
        
        public string LogoUri()
        {
            return "https://localhost:44344/";
        }
        
        public bool RequireConsent()
        {
            return true;
        }
        
        public bool AllowRememberConsent()
        {
            return true;
        }
        
        public bool AlwaysIncludeUserClaimsInIdToken()
        {
            return false;
        }
        
        public IEnumerable<ClientGrantType> AllowedGrantTypes()
        {
            return _peakClientContext.AllowedGrantTypes;
        }
        
        public bool RequirePkce()
        {
            return false;
        }
        
        public bool AllowPlainTextPkce()
        {
            return false;
        }
        
        public bool AllowAccessTokensViaBrowser()
        {
            return true;
        }
        
        public IEnumerable<ClientRedirectUri> RedirectUris()
        {
            return _peakClientContext.RedirectUris;
        }
        
        public IEnumerable<ClientPostLogoutRedirectUri> PostLogoutRedirectUris()
        {
            return _peakClientContext.PostLogoutRedirectUris;
        }
        
        public string FrontChannelLogoutUri()
        {
            return "https://localhost:44344/";
        }
        
        public bool FrontChannelLogoutSessionRequired()
        {
            return true;
        }
        
        public string BackChannelLogoutUri()
        {
            return "https://localhost:44344/";
        }
        
        public bool BackChannelLogoutSessionRequired()
        {
            return true;
        }
        
        public bool AllowOfflineAccess()
        {
            return true;
        }
        
        public IEnumerable<ClientScope> AllowedScopes()
        {
            return _peakClientContext.AllowedScopes;
        }
        
        public int IdentityTokenLifetime()
        {
            return 300;
        }
        public int AccessTokenLifetime()
        {
            return 3600;
        }
        public int AuthorizationCodeLifetime()
        {
            return 300;
        }
        public int ConsentLifetime()
        {
            return 0;
        }
        public int AbsoluteRefreshTokenLifetime()
        {
            return 2592000;
        }
        public int SlidingRefreshTokenLifetime()
        {
            return 1296000;
        }
        public int RefreshTokenUsage()
        {
            return (int)TokenUsage.OneTimeOnly;
        }
        
        public bool UpdateAccessTokenClaimsOnRefresh()
        {
            return true;
        }
        public int RefreshTokenExpiration()
        {
            return (int)TokenExpiration.Absolute;
        }
        public int AccessTokenType()
        {
            return (int)0;
        }
        public bool EnableLocalLogin()
        {
            return true;
        }
        public IEnumerable<ClientIdPRestriction> IdentityProviderRestrictions()
        {
            return _peakClientContext.IdentityProviderRestrictions;
        }
        
        
        public bool IncludeJwtId()
        {
            return true;
        }
        
        public IEnumerable<ClientClaim> Claims()
        {
            return _peakClientContext.Claims;
        }
        
        public bool AlwaysSendClientClaims()
        {
            return false;
        }
        
        public string ClientClaimsPrefix()
        {
            return "client_";
        }
        
        public string PairWiseSubjectSalt()
        {
            return "Client";
        }
        public IEnumerable<ClientProperty> Properties()
        {
            return _peakClientContext.Properties;
        }
        public IEnumerable<ClientCorsOrigin> AllowedCorsOrigins()
        {
            return _peakClientContext.AllowedCorsOrigins;
        }

        public bool Save()
        {
            return (_peakClientContext.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_peakClientContext != null)
                {
                    _peakClientContext.Dispose();
                    
                }
            }
        }

       
    }
}

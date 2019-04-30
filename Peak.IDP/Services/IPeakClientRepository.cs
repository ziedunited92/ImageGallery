using IdentityServer4.Models;
using Peak.IDP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client = Peak.IDP.Entities.Client;

namespace Peak.IDP.Services
{
    public interface IPeakClientRepository
    {
        bool Enabled(string ClientId);
        Client GetClientByClientId(string clientId);
        string GetProtocolType();
       IEnumerable<ClientSecret> GetClientSecrets();
       bool RequireClientSecret();
       Client GetClientByClientName(string clientname);
       string Description();
        string ClientUri();
        string LogoUri();
      bool RequireConsent();
     bool AllowRememberConsent();
     bool AlwaysIncludeUserClaimsInIdToken();
      IEnumerable<ClientGrantType> AllowedGrantTypes();
      bool RequirePkce();
     bool AllowPlainTextPkce();
     bool AllowAccessTokensViaBrowser();
     IEnumerable<ClientRedirectUri> RedirectUris();
     IEnumerable<ClientPostLogoutRedirectUri> PostLogoutRedirectUris();
        string FrontChannelLogoutUri();
      bool FrontChannelLogoutSessionRequired();
        string BackChannelLogoutUri();
      bool BackChannelLogoutSessionRequired();
        bool AllowOfflineAccess();
      IEnumerable<ClientScope> AllowedScopes();
       int IdentityTokenLifetime();
        int AccessTokenLifetime();
        int AuthorizationCodeLifetime();
        int ConsentLifetime();
        int AbsoluteRefreshTokenLifetime();
        int SlidingRefreshTokenLifetime();
     int RefreshTokenUsage();
        bool UpdateAccessTokenClaimsOnRefresh();
        int RefreshTokenExpiration();
        int AccessTokenType();
     bool EnableLocalLogin();
     IEnumerable<ClientIdPRestriction> IdentityProviderRestrictions();
     bool IncludeJwtId();
     IEnumerable<ClientClaim> Claims();
      bool AlwaysSendClientClaims();
     string ClientClaimsPrefix();
        string PairWiseSubjectSalt();
     IEnumerable<ClientProperty> Properties();
    IEnumerable<ClientCorsOrigin> AllowedCorsOrigins();
      bool Save();
       
    }
}

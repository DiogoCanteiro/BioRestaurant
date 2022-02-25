using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Services.Identity
{
    public class Config
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiScope> GetApiScopes =>
        new List<ApiScope>
        {
            new ApiScope("BioAdmin", "Bio server"),
            new ApiScope("read", "Read your data"),
            new ApiScope("write", "Write your data"),
            new ApiScope("delete", "Delete your data")
        };

        public static IEnumerable<Client> GetClients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes =
                    {
                        "read",
                        "write",
                        "profile"
                    }
                },
                 new Client
                {
                    ClientId = "BioAdmin",
                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris =
                    {
                         "https://localhost:44308/signin-oidc"
                    },
                    PostLogoutRedirectUris =
                    {
                         "https://localhost:44308/signout-callback-oidc"
                    },
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes =
                    {
                       IdentityServerConstants.StandardScopes.OpenId,
                       IdentityServerConstants.StandardScopes.Profile,
                       IdentityServerConstants.StandardScopes.Email,
                       "BioAdmin"
                    }
                }
            };
    }
}

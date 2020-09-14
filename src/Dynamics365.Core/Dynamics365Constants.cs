using System;
using System.Collections.Generic;
using CluedIn.Core.Net.Mail;
using CluedIn.Core.Providers;

namespace CluedIn.Crawling.Dynamics365.Core
{
    public class Dynamics365Constants
    {
        public struct KeyName
        {
            public const string ApiKey = nameof(ApiKey);
            public const string Url = nameof(Url);
            public const string DeltaCrawlEnabled = nameof(DeltaCrawlEnabled);
            public const string UserName = nameof(UserName);
            public const string Password = nameof(Password);
            public const string ClientId = nameof(ClientId);
            public const string ClientSecret = nameof(ClientSecret);
        }

        // TODO Complete the following section
        // Please see https://cluedin-io.github.io/CluedIn.Documentation/docs/1-Integration/build-integration.html
        public const string CrawlerDescription = "Dynamics365 is a ... to be completed ...";
        public const string Instructions = "Provide authentication instructions here, if applicable";
        public const IntegrationType Type = IntegrationType.Cloud;
        public const string Uri = "http://www.sampleurl.com"; //Uri of remote tool if applicable

        // To change the icon see embedded resource
        // src\Dynamics365.Provider\Resources\cluedin.png
        public const string IconResourceName = "Resources.cluedin.png";

        public static IList<string> ServiceType = new List<string> { "" };
        public static IList<string> Aliases = new List<string> { "" };
        public const string Category = "";
        public const string Details = "";
        public static AuthMethods AuthMethods = new AuthMethods()
        {
            token = new Control[]
            {
                new Control()
                {
                    displayName = "ClientCredentials",
                    isRequired = true,
                    name = "ClientCredentials",
                    type = "text"
                }
            },
            credentials = new Control[]
            {
                new Control()
                {
                    displayName = "UserCredential - userName",
                    isRequired = true,
                    name = "userName",
                    type = "text"
                },
                new Control()
                {
                    displayName = "UserCredential - password",
                    isRequired = true,
                    name = "password",
                    type = "text"
                }
            },
            oauth = new OAuth()
            {
                initial = "",
                callback = "",
                oauthCallBackKey = ""
            }
        };


        public const bool SupportsConfiguration = true;
        public const bool SupportsWebHooks = false;
        public const bool SupportsAutomaticWebhookCreation = true;

        public const bool RequiresAppInstall = false;
        public const string AppInstallUrl = null;
        public const string ReAuthEndpoint = null;

        #region Autogenerated constants
        public const string CodeOrigin = "Dynamics365";
        public const string ProviderRootCodeValue = "Dynamics365";
        public const string CrawlerName = "Dynamics365Crawler";
        public const string CrawlerComponentName = "Dynamics365Crawler";
        public static readonly Guid ProviderId = Guid.Parse("1f93371f-7e58-40fd-8ac4-f54b0a93ec64");
        public const string ProviderName = "Dynamics365";


        public const string ClientID = "";
        public const string ClientSecret = "";


        public static readonly ComponentEmailDetails ComponentEmailDetails = new ComponentEmailDetails
        {
            Features = new Dictionary<string, string>
            {
                                       { "Tracking",        "Expenses and Invoices against customers" },
                                       { "Intelligence",    "Aggregate types of invoices and expenses against customers and companies." }
                                   },
            Icon = ProviderIconFactory.CreateConnectorUri(ProviderId),
            ProviderName = ProviderName,
            ProviderId = ProviderId,
            Webhooks = SupportsWebHooks
        };

        public static IProviderMetadata CreateProviderMetadata()
        {
            return new ProviderMetadata
            {
                Id = ProviderId,
                ComponentName = CrawlerName,
                Name = ProviderName,
                Type = Type.ToString(),
                SupportsConfiguration = SupportsConfiguration,
                SupportsWebHooks = SupportsWebHooks,
                SupportsAutomaticWebhookCreation = SupportsAutomaticWebhookCreation,
                RequiresAppInstall = RequiresAppInstall,
                AppInstallUrl = AppInstallUrl,
                ReAuthEndpoint = ReAuthEndpoint,
                ComponentEmailDetails = ComponentEmailDetails
            };
        }
        #endregion
    }
}

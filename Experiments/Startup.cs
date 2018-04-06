using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using IdentityServer3.Core.Configuration;

[assembly: OwinStartup(typeof(Experiments.Startup))]

namespace Experiments
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var ISfactory = new IdentityServerServiceFactory();
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            var options = new IdentityServerOptions()
            {
                SigningCertificate = new System.Security.Cryptography.X509Certificates.X509Certificate2(@"\Certificate\Fortinet_CA_SSLProxy.cer"),
                RequireSsl = false,
                Factory = ISfactory

            };

            app.UseIdentityServer(options);
        }
    }
}

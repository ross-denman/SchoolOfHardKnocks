using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SchoolOfHardKnocks___Mail_and_messenger_API.Startup))]

namespace SchoolOfHardKnocks___Mail_and_messenger_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

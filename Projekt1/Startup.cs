﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekt1.Startup))]
namespace Projekt1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

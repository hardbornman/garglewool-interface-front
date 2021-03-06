﻿using Abp.Modules;
using Abp.Reflection.Extensions;
using GargleWool.Web.Core;
using GargleWool.Web.Core.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ServiceOAuth
{
    [DependsOn(
        typeof(GargleWoolWebCoreModule))]
    public class IdentityServerModule:AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IdentityServerModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IdentityServerModule).GetAssembly());
        }
    }
}
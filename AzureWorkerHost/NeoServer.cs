﻿using System;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace AzureWorkerHost
{
    public class NeoServer
    {
        readonly NeoServerConfiguration configuration;
        readonly IRoleEnvironment roleEnvironment;

        public NeoServer(
            NeoServerConfiguration configuration,
            IRoleEnvironment roleEnvironment)
        {
            this.configuration = configuration;
            this.roleEnvironment = roleEnvironment;
        }

        public NeoServer(NeoServerConfiguration configuration)
            : this(configuration,
                new RoleEnvironmentWrapper())
        {}

        public void DownloadNeo()
        {
            LocalResource localResource;
            try
            {
                localResource = roleEnvironment.GetLocalResource(configuration.NeoLocalResourceName);
            }
            catch (RoleEnvironmentException ex)
            {
                throw new ApplicationException(
                    string.Format(ExceptionMessages.NeoLocalResourceNotFound, configuration.NeoLocalResourceName),
                    ex);
            }
            var localResourcePath = localResource.RootPath;
            throw new NotImplementedException();
        }
    }
}
using System;

namespace Neo4j.Server.AzureWorkerHost.Legacy
{
    [Obsolete]
    internal class ConfigConstants
    {
        public static string Neo4JEndpoint
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public static object LocalNeo4JInstallation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public static string DriveConnectionString
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
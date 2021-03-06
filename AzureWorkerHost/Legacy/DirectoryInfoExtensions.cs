using System;
using System.IO;
using System.Linq;

namespace Neo4j.Server.AzureWorkerHost.Legacy
{
    [Obsolete]
    public static class DirectoryInfoExtensions
    {
        public static FileInfo FindFile(this DirectoryInfo directoryInfo, string fileName)
        {
            return directoryInfo
                .GetFiles("*.*", SearchOption.AllDirectories)
                .Single(fi => fi.Name == fileName);
        }

        public static DirectoryInfo FindDirectoryThatEndsWith(this DirectoryInfo directoryInfo, string directoryPathEnd)
        {
            return directoryInfo
                .GetDirectories("*", SearchOption.AllDirectories)
                .Single(di => di.Name.EndsWith(directoryPathEnd));
        }
    }
}
using System;

using R5T.Gepidia;


namespace R5T.Antium
{
    /// <summary>
    /// Provides the deployment destination file system site.
    /// </summary>
    public interface IDeploymentDestinationFileSystemSiteProvider
    {
        FileSystemSite GetDeploymentDestinationFileSystemSite();
    }
}

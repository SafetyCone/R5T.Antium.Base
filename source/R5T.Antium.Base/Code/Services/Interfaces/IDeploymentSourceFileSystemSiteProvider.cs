using System;

using R5T.Gepidia;


namespace R5T.Antium
{
    /// <summary>
    /// Provides the deployment source file system site.
    /// </summary>
    public interface IDeploymentSourceFileSystemSiteProvider
    {
        FileSystemSite GetDeploymentSourceFileSystemSite();
    }
}

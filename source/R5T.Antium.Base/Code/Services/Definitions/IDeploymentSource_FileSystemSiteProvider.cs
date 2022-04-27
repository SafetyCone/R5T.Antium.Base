using System;

using R5T.Gepidia;

using R5T.T0064;


namespace R5T.Antium
{
    /// <summary>
    /// Provides the deployment source file system site.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IDeploymentSource_FileSystemSiteProvider : IServiceDefinition
    {
        FileSystemSite GetDeploymentSourceFileSystemSite();
    }
}

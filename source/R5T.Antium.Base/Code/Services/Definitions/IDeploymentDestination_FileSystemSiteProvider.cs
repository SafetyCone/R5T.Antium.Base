using System;

using R5T.Gepidia;

using R5T.T0064;


namespace R5T.Antium
{
    /// <summary>
    /// Provides the deployment destination file system site.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IDeploymentDestination_FileSystemSiteProvider : IServiceDefinition
    {
        FileSystemSite GetDeploymentDestinationFileSystemSite();
    }
}

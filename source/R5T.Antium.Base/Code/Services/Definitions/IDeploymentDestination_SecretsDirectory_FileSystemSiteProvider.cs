using System;

using R5T.Gepidia;

using R5T.T0064;


namespace R5T.Antium
{
    [ServiceDefinitionMarker]
    public interface IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider : IServiceDefinition
    {
        FileSystemSite GetDeploymentDestinationSecretsDirectoryFileSystemSite();
    }
}

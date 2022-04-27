using System;

using R5T.Gepidia;

using R5T.T0064;


namespace R5T.Antium
{
    [ServiceDefinitionMarker]
    public interface IDeploymentSource_SecretsDirectory_FileSystemSiteProvider : IServiceDefinition
    {
        FileSystemSite GetDeploymentSourceSecretsDirectoryFileSystemSite();
    }
}

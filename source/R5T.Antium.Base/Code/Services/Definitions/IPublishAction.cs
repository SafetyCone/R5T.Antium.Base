using System;

using R5T.T0064;


namespace R5T.Antium
{
    /// <summary>
    /// Operator that will publish a project.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IPublishAction : IServiceDefinition
    {
        void Publish();
    }
}

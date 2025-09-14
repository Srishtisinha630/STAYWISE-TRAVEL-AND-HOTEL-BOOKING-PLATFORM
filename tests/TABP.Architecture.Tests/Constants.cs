namespace TABP.Architecture.Tests
{
    /// <summary>
    /// Holds constant values used across architecture tests.
    /// These constants represent the assemblies and namespaces 
    /// that define the structure of the application.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The name of the Domain assembly (contains core business entities and rules).
        /// </summary>
        public const string DomainAssembly = "TABP.Domain";

        /// <summary>
        /// The name of the Application assembly (contains business logic and use cases).
        /// </summary>
        public const string ApplicationAssembly = "TABP.Application";

        /// <summary>
        /// The name of the Infrastructure assembly (handles external resources like DB, email, etc.).
        /// </summary>
        public const string InfrastructureAssembly = "TABP.Infrastructure";


        /// <summary>
        /// The namespace for the Application layer.
        /// </summary>
        public const string ApplicationNamespace = "TABP.Application";

        /// <summary>
        /// The namespace for the Infrastructure layer.
        /// </summary>
        public const string InfrastructureNamespace = "TABP.Infrastructure";

        /// <summary>
        /// The namespace for the API layer (controllers, endpoints).
        /// </summary>
        public const string ApiNamespace = "TABP.Api";
    }
}

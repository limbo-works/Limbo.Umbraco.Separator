using System;
using Umbraco.Cms.Core.Semver;

namespace Limbo.Umbraco.Separator {

    /// <summary>
    /// Static class with various information and constants about the package.
    /// </summary>
    public static class SeparatorPackage {

        /// <summary>
        /// Gets the alias of the package.
        /// </summary>
        public const string Alias = "Limbo.Umbraco.Separator";

        /// <summary>
        /// Gets the friendly name of the package.
        /// </summary>
        public const string Name = "Limbo Separator";

        /// <summary>
        /// Gets the version of the package.
        /// </summary>
        public static readonly Version Version = typeof(SeparatorPackage).Assembly.GetName().Version;

        /// <summary>
        /// Gets the semantic version of the package.
        /// </summary>
        public static readonly SemVersion SemVersion = SemVersion.Parse(Version.ToString());

        /// <summary>
        /// Gets the URL of the GitHub repository for this package.
        /// </summary>
        public const string GitHubUrl = "https://github.com/limbo-works/Limbo.Umbraco.Separator";

        /// <summary>
        /// Gets the URL of the issue tracker for this package.
        /// </summary>
        public const string IssuesUrl = "https://github.com/limbo-works/Limbo.Umbraco.Separator/issues";
        
        /// <summary>
        /// Gets the URL of the documentation for this package.
        /// </summary>
        public const string DocumentationUrl = "https://github.com/limbo-works/Limbo.Umbraco.Separator#documentation";

    }

}
using System.Collections.Generic;
using System.Reflection;
using Umbraco.Cms.Core.Manifest;

namespace Limbo.Umbraco.Separator {

    /// <inheritdoc />
    public class SeparatorManifestFilter : IManifestFilter {

        /// <inheritdoc />
        public void Filter(List<PackageManifest> manifests) {

            // Initialize a new manifest filter for this package
            PackageManifest manifest = new() {
                AllowPackageTelemetry = true,
                PackageName = SeparatorPackage.Name,
                Version = SeparatorPackage.InformationalVersion,
                BundleOptions = BundleOptions.Independent,
                Stylesheets = new[] {
                    $"/App_Plugins/{SeparatorPackage.Alias}/Styles/Default.css"
                }
            };

            // The "PackageId" property isn't available prior to Umbraco 12, and since the package is build against
            // Umbraco 10, we need to use reflection for setting the property value for Umbraco 12+. Ideally this
            // shouldn't fail, but we might at least add a try/catch to be sure
            try {
                PropertyInfo? property = manifest.GetType().GetProperty("PackageId");
                property?.SetValue(manifest, SeparatorPackage.Alias);
            } catch {
                // We don't really care about the exception
            }

            // Append the manifest
            manifests.Add(manifest);

        }

    }

}
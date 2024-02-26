using System.Collections.Generic;
using Umbraco.Cms.Core.Manifest;

namespace Limbo.Umbraco.Separator;

/// <inheritdoc />
public class SeparatorManifestFilter : IManifestFilter {

    /// <inheritdoc />
    public void Filter(List<PackageManifest> manifests) {

        // Initialize a new manifest filter for this package
        PackageManifest manifest = new() {
            AllowPackageTelemetry = true,
            PackageId = SeparatorPackage.Alias,
            PackageName = SeparatorPackage.Name,
            Version = SeparatorPackage.InformationalVersion,
            BundleOptions = BundleOptions.Independent,
            Stylesheets = new[] {
                $"/App_Plugins/{SeparatorPackage.Alias}/Styles/Default.css"
            }
        };

        // Append the manifest
        manifests.Add(manifest);

    }

}
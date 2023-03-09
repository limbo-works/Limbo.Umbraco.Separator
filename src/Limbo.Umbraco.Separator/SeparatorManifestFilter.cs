using System.Collections.Generic;
using Umbraco.Cms.Core.Manifest;

namespace Limbo.Umbraco.Separator {

    /// <inheritdoc />
    public class SeparatorManifestFilter : IManifestFilter {

        /// <inheritdoc />
        public void Filter(List<PackageManifest> manifests) {
            manifests.Add(new PackageManifest {
                AllowPackageTelemetry = true,
                PackageName = SeparatorPackage.Name,
                Version = SeparatorPackage.InformationalVersion,
                BundleOptions = BundleOptions.Independent,
                Stylesheets = new[] {
                    $"/App_Plugins/{SeparatorPackage.Alias}/Default.css"
                }
            });
        }

    }

}
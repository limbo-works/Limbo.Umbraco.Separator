using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Manifest;
using Umbraco.Cms.Infrastructure.Manifest;

#pragma warning disable CS1591

namespace Limbo.Umbraco.Separator;

public class SeparatorPackageManifestReader : IPackageManifestReader {

    public async Task<IEnumerable<PackageManifest>> ReadPackageManifestsAsync() {

        List<object> extensions = [];

        string cacheBuster = Guid.NewGuid().ToString();

        extensions.Add(new {
            alias = SeparatorEditor.EditorAlias,
            name = "Limbo Separator",
            type = "propertyEditorSchema",
            meta = new {
                icon = "icon-width",
                group = "Limbo",
                valueType = "STRING",
                propertyEditorUids = new[] {
                    $"{SeparatorEditor.EditorAlias}.Ui"
                }
            }
        });

        extensions.Add(new {
            alias = $"{SeparatorEditor.EditorAlias}.Ui",
            name = "Limbo Separator UI",
            element = $"/App_Plugins/{SeparatorPackage.Alias}/Separator.js?v={cacheBuster}",
            type = "propertyEditorUi",
            meta = new {
                label = "Limbo Separator",
                icon = "icon-width",
                group = "Limbo",
                propertyEditorSchemaAlias = SeparatorEditor.EditorAlias,
                hideLabel = true
            }
        });

        List<PackageManifest> temp = [
            new() {
                Id = SeparatorPackage.Alias,
                Name = SeparatorPackage.Name,
                AllowTelemetry = true,
                Version = SeparatorPackage.InformationalVersion,
                Extensions = extensions.ToArray()
            }
        ];

        return await Task.FromResult(temp);

    }

}
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Infrastructure.Manifest;

#pragma warning disable CS1591

namespace Limbo.Umbraco.Separator;

public class SeparatorComposer : IComposer {

    public void Compose(IUmbracoBuilder builder) {
        builder.Services.AddSingleton<IPackageManifestReader, SeparatorPackageManifestReader>();
    }

}
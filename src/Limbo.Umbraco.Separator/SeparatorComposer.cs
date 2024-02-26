using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

#pragma warning disable CS1591

namespace Limbo.Umbraco.Separator;

public class SeparatorComposer : IComposer {

    public void Compose(IUmbracoBuilder builder) {

        builder.ManifestFilters().Append<SeparatorManifestFilter>();

    }

}
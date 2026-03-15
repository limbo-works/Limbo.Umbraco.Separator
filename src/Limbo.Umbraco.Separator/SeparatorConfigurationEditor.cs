using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Separator;

/// <summary>
/// Represents the configuration editor for a <see cref="SeparatorEditor"/>.
/// </summary>
public class SeparatorConfigurationEditor : ConfigurationEditor<SeparatorConfiguration> {

    /// <inheritdoc />
    public SeparatorConfigurationEditor(IIOHelper ioHelper) : base(ioHelper) { }

}
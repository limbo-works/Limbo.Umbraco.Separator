using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;

namespace Limbo.Umbraco.Separator {
    
    /// <summary>
    /// Represents the configuration editor for a <see cref="SeparatorDataEditor"/>.
    /// </summary>
    public class SeparatorConfigurationEditor : ConfigurationEditor<SeparatorConfiguration> {

        /// <inheritdoc />
        public SeparatorConfigurationEditor(IIOHelper ioHelper, IEditorConfigurationParser editorConfigurationParser) : base(ioHelper, editorConfigurationParser) { }

    }

}
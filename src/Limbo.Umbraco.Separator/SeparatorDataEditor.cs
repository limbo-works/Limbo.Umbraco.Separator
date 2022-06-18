using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;

#pragma warning disable CS1591

namespace Limbo.Umbraco.Separator {

    /// <summary>
    /// Represents a separator property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Limbo Separator", EditorView, Group = "Limbo", Icon = "icon-navigation-horizontal color-limbo", HideLabel = true)]
    public class SeparatorDataEditor : DataEditor {
        
        private readonly IIOHelper _ioHelper;
        private readonly IEditorConfigurationParser _editorConfigurationParser;

        #region Constants

        internal const string EditorAlias = "Limbo.Umbraco.Separator";

        internal const string EditorView = "/App_plugins/Limbo.Umbraco.Separator/Views/Separator.html";

        #endregion

        #region Constructors

        public SeparatorDataEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper, IEditorConfigurationParser editorConfigurationParser) : base(dataValueEditorFactory) {
            _ioHelper = ioHelper;
            _editorConfigurationParser = editorConfigurationParser;
        }

        #endregion

        #region Member methods

        /// <inheritdoc/>
        protected override IConfigurationEditor CreateConfigurationEditor() => new SeparatorConfigurationEditor(_ioHelper, _editorConfigurationParser);

        #endregion

    }

}
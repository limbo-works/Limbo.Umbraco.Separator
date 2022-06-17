using Umbraco.Cms.Core.PropertyEditors;

#pragma warning disable CS1591

namespace Limbo.Umbraco.Separator {

    /// <summary>
    /// Represents a separator property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Limbo Separator", EditorView, Group = "Limbo", Icon = "icon-navigation-horizontal color-limbo", HideLabel = true)]
    public class SeparatorDataEditor : DataEditor {

        internal const string EditorAlias = "Limbo.Separator";

        internal const string EditorView = "/App_plugins/Limbo.Umbraco.Separator/Views/Separator.html";

        public SeparatorDataEditor(IDataValueEditorFactory dataValueEditorFactory) : base(dataValueEditorFactory) { }

    }

}
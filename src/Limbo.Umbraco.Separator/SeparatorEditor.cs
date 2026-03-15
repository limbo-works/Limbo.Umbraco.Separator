using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

#pragma warning disable CS1591

namespace Limbo.Umbraco.Separator;

/// <summary>
/// Represents a separator property editor.
/// </summary>
[DataEditor(EditorAlias)]
public class SeparatorEditor : DataEditor {

    private readonly IIOHelper _ioHelper;

    #region Constants

    public const string EditorAlias = "Limbo.Umbraco.Separator";

    #endregion

    #region Constructors

    public SeparatorEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory) {
        _ioHelper = ioHelper;
    }

    #endregion

    #region Member methods

    /// <inheritdoc/>
    protected override IConfigurationEditor CreateConfigurationEditor() => new SeparatorConfigurationEditor(_ioHelper);

    #endregion

}
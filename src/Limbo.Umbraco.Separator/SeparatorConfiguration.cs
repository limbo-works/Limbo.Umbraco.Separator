using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Separator {

    /// <summary>
    /// Class representing the configuration for a <see cref="SeparatorDataEditor"/>.
    /// </summary>
    public class SeparatorConfiguration {

        /// <summary>
        /// Gets or sets the fallback text of the textarea.
        /// </summary>
        [ConfigurationField("className", "CSS class name", "textstring", Description = "Enter a CSS class name to be used for the separator.")]
        public string? ClassName { get; set; }

    }

}
using Umbraco.Cms.Core.WebAssets;

#pragma warning disable CS1591

namespace Limbo.Umbraco.Separator {

    public class SeparatorAssetFile : IAssetFile {

        public string FilePath { get; set; }

        public AssetType DependencyType => AssetType.Css;

        public SeparatorAssetFile() {
            FilePath = "/App_Plugins/Limbo.Umbraco.Separator/Styles/Default.css";
        }

    }

}
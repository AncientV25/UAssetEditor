using Usmap.NET;

namespace UAssetEditor.Properties;

public class SoftObjectProperty : AbstractProperty
{
    public override void Read(Reader reader, UsmapPropertyData? data, UAsset? asset = null)
    {
        var assetPathName = new FName(reader, asset.NameMap).Name;
        var subPathString = FString.Read(reader);
        Value = $"{assetPathName}.{subPathString}";
    }
}
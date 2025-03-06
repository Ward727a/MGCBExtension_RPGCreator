using Microsoft.Xna.Framework.Content.Pipeline;
using System.IO;
using TImport = MGCBExtension_RPGCreator.TXTExt.TXTAsset;

namespace MGCBExtension_RPGCreator.TXTExt
{
    [ContentImporter(".txt", DisplayName = "TXT Importer", DefaultProcessor = "TXT Processor")]
    public class TXTImporter : ContentImporter<TImport>
    {
        public override TImport Import(string filename, ContentImporterContext context)
        {
            string filepath = Path.Combine(Path.GetDirectoryName(filename), filename);

            context.Logger.LogMessage($"Importing txt file: {filepath}");


            TXTAsset asset = new TXTAsset();
            asset.Name = Path.GetFileName(filename);
            asset.Content = File.ReadAllText(filepath);
            
            return asset;
        }
    }
}

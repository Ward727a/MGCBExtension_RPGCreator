using Microsoft.Xna.Framework.Content.Pipeline;
using System;
using System.ComponentModel;
using TInput = MGCBExtension_RPGCreator.TXTExt.TXTAsset;
using TOutput = MGCBExtension_RPGCreator.TXTExt.TXTAsset;

namespace MGCBExtension_RPGCreator.TXTExt
{
    [ContentProcessor(DisplayName = "TXT Processor")]
    internal class TXTProcessor : ContentProcessor<TInput, TOutput>
    {
        [DisplayName("Runtime Identifier")]
        public string Identifier { get; set; }
        public override TOutput Process(TInput input, ContentProcessorContext context)
        {
            if(Identifier == string.Empty)
            {
                throw new Exception("No Runtime Type was specified for the content.");
            }
            input.RuntimeIdentifier = Identifier;
            return input;
        }
    }
}

using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TInput = MGCBExtension_RPGCreator.TXTExt.TXTAsset;

namespace MGCBExtension_RPGCreator.TXTExt
{
    [ContentTypeWriter]
    internal class TXTWriter : ContentTypeWriter<TInput>
    {
        string _runTimeIdentifier;

        protected override void Write(ContentWriter output, TInput value)
        {
            output.Write(value.Name);
            output.Write(value.Content);
            _runTimeIdentifier = value.RuntimeIdentifier;
        }
        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return _runTimeIdentifier ?? base.GetRuntimeType(targetPlatform);
        }

        public override string GetRuntimeType(TargetPlatform targetPlatform)
        {
            return typeof(TXTAsset).AssemblyQualifiedName;
        }
    }
}

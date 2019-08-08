﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ManiaPlanetSharp.GameBox
{
    public class GbxBlockSkinClass
        : GbxBodyClass
    {
        public string Text { get; set; }
        public string Ignored { get; set; }
        public GbxFileReference Pack { get; set; }
        public GbxFileReference ParentPack { get; set; }
    }

    public class GbxBlockSkinClassParserA
        : GbxBodyClassParser<GbxBlockSkinClass>
    {
        protected override int Chunk => 0x03059000;

        protected override GbxBlockSkinClass ParseChunkInternal(GbxReader reader)
        {
            return new GbxBlockSkinClass()
            {
                Text = reader.ReadString(),
                Ignored = reader.ReadString()
            };
        }
    }

    public class GbxBlockSkinClassParserB
        : GbxBodyClassParser<GbxBlockSkinClass>
    {
        protected override int Chunk => 0x03059001;

        protected override GbxBlockSkinClass ParseChunkInternal(GbxReader reader)
        {
            return new GbxBlockSkinClass()
            {
                Text = reader.ReadString(),
                Pack = reader.ReadFileReference()
            };
        }
    }

    public class GbxBlockSkinClassParserC
        : GbxBodyClassParser<GbxBlockSkinClass>
    {
        protected override int Chunk => 0x03059002;

        protected override GbxBlockSkinClass ParseChunkInternal(GbxReader reader)
        {
            return new GbxBlockSkinClass()
            {
                Text = reader.ReadString(),
                Pack = reader.ReadFileReference(),
                ParentPack = reader.ReadFileReference()
            };
        }
    }
}

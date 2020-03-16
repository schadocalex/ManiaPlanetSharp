﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ManiaPlanetSharp.GameBox.Parsing.Chunks
{
    [Chunk(0x03043024)]
    public class CustomMusicChunk
        : Chunk
    {
        [Property]
        public FileReference CustomMusic { get; set; }
    }
}

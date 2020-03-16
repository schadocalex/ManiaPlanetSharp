﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ManiaPlanetSharp.GameBox
{
    public class FileReference
    {
        public byte Version { get; set; }
        public byte[] Checksum { get; set; }
        public string FilePath { get; set; }
        public bool IsRelativePath => this.Version < 2;
        public string LocatorUrl { get; set; }
    }
}
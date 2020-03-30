﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ManiaPlanetSharp.GameBox.Parsing
{
    /// <summary>
    /// Manages global settings for the GameBox parser
    /// </summary>
    public static class GlobalParserSettings
    {
        /// <summary>
        /// The maximum size in bytes for which the body of a GameBox file will be analyzed. If the body size of a GameBox file exceeds this limit, an exception will be thrown.
        /// </summary>
        public static uint MaximumUncompressedGameBoxBodySize { get; set; } = 100000000; //100MB

        private static bool usePrecompiledParsers = true;
        /// <summary>
        /// Specifies whether precompiled parsers from the ManiaPlanetSharp.GameBox.AutoGenerated assembly should be used, should they be present. This is primarily for development and testing purposes, as the proper way to disable the use of precompiled parsers is to just not include the additional assembly and not change any settings here.
        /// </summary>
        public static bool UsePrecompiledParsersIfPresent
        {
            get
            {
                return usePrecompiledParsers;
            }
            set
            {
                if (value != UsePrecompiledParsersIfPresent)
                {
                    usePrecompiledParsers = value;
                    if (UsePrecompiledParsersIfPresent)
                    {
                        ParserFactory.InitializePrecompiledParsers();
                    }
                    else
                    {
                        ParserFactory.ClearParsers();
                    }
                }
            }
        }

        private static bool useDynamicallyCompiledChunkParsers = false;
        /// <summary>
        /// Specifies whether dynamically generated and compiled parsers should be used. This is primarily for development and testing purposes.
        /// </summary>
        public static bool UseDynamicallyCompiledChunkParsers
        {
            get
            {
                return useDynamicallyCompiledChunkParsers;
            }
            set
            {
                if (value != UseDynamicallyCompiledChunkParsers)
                {
                    useDynamicallyCompiledChunkParsers = value;
                    if (!UseDynamicallyCompiledChunkParsers)
                    {
                        ParserFactory.ClearParsers();
                    }
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using ManiaPlanetSharp.GameBox.Parsing.Chunks;

namespace ManiaPlanetSharp.GameBox.Parsing.ParserGeneration.AutoGenerated
{
	public static partial class AutoGeneratedParsers
	{
		public static Dictionary<Type, IChunkParser<Chunk>> ChunkParsers { get; } = new Dictionary<Type, IChunkParser<Chunk>> {
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorBasicMetadataChunk), new CollectorBasicMetadataChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorBrowserMetadataChunk), new CollectorBrowserMetadataChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorCatalogChunk), new CollectorCatalogChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorDefaultSkinChunk), new CollectorDefaultSkinChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorDescriptionChunk), new CollectorDescriptionChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorIconChunk), new CollectorIconChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorIconMetadataChunk), new CollectorIconMetadataChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorLightmapCacheIdChunk), new CollectorLightmapCacheIdChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorListChunk), new CollectorListChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorMetadataChunk), new CollectorMetadataChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorNameChunk), new CollectorNameChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapAuthorChunk), new MapAuthorChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCheckpointsChunk), new MapCheckpointsChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapChunk), new MapChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCommonChunk), new MapCommonChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCommunityChunk), new MapCommunityChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCoordinateChunk), new MapCoordinateChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCustomMusicChunk), new MapCustomMusicChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapDescriptionChunk), new MapDescriptionChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapEmbeddedItemsChunk), new MapEmbeddedItemsChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapGmCamArchiveChunk), new MapGmCamArchiveChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapModpackChunk), new MapModpackChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPasswordChunk), new MapPasswordChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPasswordChunkOld), new MapPasswordChunkOldParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPlaymodeChunk), new MapPlaymodeChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapThumbnailChunk), new MapThumbnailChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimeChunk), new MapTimeChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimelimitChunk), new MapTimelimitChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimelimitTimeChunk), new MapTimelimitTimeChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTipChunk), new MapTipChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapVehicleChunk), new MapVehicleChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.MapVersionChunk), new MapVersionChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectAnchorChunk), new ObjectAnchorChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectBannerProfileChunk), new ObjectBannerProfileChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectCameraIndexChunk), new ObjectCameraIndexChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectGroundPointChunk), new ObjectGroundPointChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectItemTypeChunk), new ObjectItemTypeChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectModelChunk), new ObjectModelChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectTypeChunk), new ObjectTypeChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectUnknownChunk), new ObjectUnknownChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectUsabilityChunk), new ObjectUsabilityChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.GameSkinChunk), new GameSkinChunkParser() },
			{ typeof(ManiaPlanetSharp.GameBox.Parsing.Chunks.WaypointSpecialPropertyChunk), new WaypointSpecialPropertyChunkParser() },
		};
	}



	public class CollectorBasicMetadataChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorBasicMetadataChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E00100BU, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorBasicMetadataChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorBasicMetadataChunk() { Id = chunkId };
			result.Name = reader.ReadLookbackString();
			result.Collection = reader.ReadLookbackString();
			result.Author = reader.ReadLookbackString();
			return result;
        }
	}

	public class CollectorBrowserMetadataChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorBrowserMetadataChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E001009U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorBrowserMetadataChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorBrowserMetadataChunk() { Id = chunkId };
			result.PagePath = reader.ReadString();
			result.HasIconFid = reader.ReadBool();
			if (result.HasIconFid)
			{
			    result.Icon = reader.ReadFileReference();
			}
			result.Unused = reader.ReadLookbackString();
			return result;
        }
	}

	public class CollectorCatalogChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorCatalogChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E001007U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorCatalogChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorCatalogChunk() { Id = chunkId };
			result.IsInternal = reader.ReadBool();
			result.Unused1 = reader.ReadUInt32();
			result.CatalogPosition = reader.ReadUInt32();
			result.Unused2 = reader.ReadUInt32();
			result.Unused3 = reader.ReadUInt32();
			result.Unused4 = reader.ReadUInt32();
			return result;
        }
	}

	public class CollectorDefaultSkinChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorDefaultSkinChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E00100FU, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorDefaultSkinChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorDefaultSkinChunk() { Id = chunkId };
			result.DefaultSkinName = reader.ReadString();
			return result;
        }
	}

	public class CollectorDescriptionChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorDescriptionChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E00100DU, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorDescriptionChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorDescriptionChunk() { Id = chunkId };
			result.Description = reader.ReadString();
			return result;
        }
	}

	public class CollectorIconChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorIconChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E001004U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorIconChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorIconChunk() { Id = chunkId };
			result.Width = reader.ReadUInt16();
			result.Height = reader.ReadUInt16();
			result.IconData = reader.ReadRaw((int)(uint)result.IconSize);
			return result;
        }
	}

	public class CollectorIconMetadataChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorIconMetadataChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E00100EU, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorIconMetadataChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorIconMetadataChunk() { Id = chunkId };
			result.UseAutoRenderedIcon = reader.ReadBool();
			result.QuarterRotationY = reader.ReadUInt32();
			return result;
        }
	}

	public class CollectorLightmapCacheIdChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorLightmapCacheIdChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E001006U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorLightmapCacheIdChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorLightmapCacheIdChunk() { Id = chunkId };
			result.FileTime = reader.ReadUInt64();
			return result;
        }
	}

	public class CollectorListChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorListChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x0301B000U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorListChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorListChunk() { Id = chunkId };
			result.Archive = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorStock[reader.ReadUInt32()];
			for (int i = 0; i < result.Archive.Length; i++)
			{
			    result.Archive[i] = ParserFactory.GetCustomStructParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorStock>().Parse(reader);
			}
			return result;
        }
	}

	public class CollectorMetadataChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorMetadataChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E001003U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorMetadataChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorMetadataChunk() { Id = chunkId };
			result.Name = reader.ReadLookbackString();
			result.Collection = reader.ReadLookbackString();
			result.Author = reader.ReadLookbackString();
			result.Version = reader.ReadUInt32();
			result.Path = reader.ReadString();
			if (result.Version == 5)
			{
			    result.Unused1 = reader.ReadLookbackString();
			}
			if (result.Version >= 4)
			{
			    result.Unused2 = reader.ReadLookbackString();
			}
			if (result.Version >= 3)
			{
			    result.Unused3 = reader.ReadUInt32();
			}
			if (result.Version >= 4)
			{
			    result.CatalogPosition = reader.ReadUInt16();
			}
			if (result.Version >= 7)
			{
			    result.Name2 = reader.ReadString();
			}
			if (result.Version >= 8)
			{
			    result.ProductStateB = reader.ReadByte();
			}
			return result;
        }
	}

	public class CollectorNameChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorNameChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E00100CU, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorNameChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.CollectorNameChunk() { Id = chunkId };
			result.Name = reader.ReadString();
			return result;
        }
	}

	public class MapAuthorChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapAuthorChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043008U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapAuthorChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapAuthorChunk() { Id = chunkId };
			result.Version = reader.ReadUInt32();
			result.AuthorVersion = reader.ReadUInt32();
			result.Login = reader.ReadString();
			result.Nick = reader.ReadString();
			result.Zone = reader.ReadString();
			result.ExtraInfo = reader.ReadString();
			return result;
        }
	}

	public class MapCheckpointsChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCheckpointsChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043017U, true) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCheckpointsChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCheckpointsChunk() { Id = chunkId };
			result.Checkpoints = new ManiaPlanetSharp.GameBox.Parsing.Chunks.Checkpoint[reader.ReadUInt32()];
			for (int i = 0; i < result.Checkpoints.Length; i++)
			{
			    result.Checkpoints[i] = ParserFactory.GetCustomStructParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.Checkpoint>().Parse(reader);
			}
			return result;
        }
	}

	public class MapChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x0304301FU, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapChunk() { Id = chunkId };
			result.Uid = reader.ReadLookbackString();
			result.Environment = reader.ReadLookbackString();
			result.Author = reader.ReadLookbackString();
			result.Name = reader.ReadString();
			result.TimeOfDay = reader.ReadLookbackString();
			result.DecorationEnvironment = reader.ReadLookbackString();
			result.DecorationEnvironmentAuthor = reader.ReadLookbackString();
			result.Size = reader.ReadSize3D();
			result.NeedsUnlock = reader.ReadBool();
			result.Version = reader.ReadUInt32();
			result.Blocks = result.ParseBlocks(reader);
			return result;
        }
	}

	public class MapCommonChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCommonChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043003U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCommonChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCommonChunk() { Id = chunkId };
			result.Version = reader.ReadByte();
			result.Uid = reader.ReadLookbackString();
			result.Environment = reader.ReadLookbackString();
			result.Author = reader.ReadLookbackString();
			result.Name = reader.ReadString();
			result.KindB = reader.ReadByte();
			if (result.Version >= 1)
			{
			    result.Locked = reader.ReadBool();
			}
			if (result.Version >= 1)
			{
			    result.Password = reader.ReadString();
			}
			if (result.Version >= 2)
			{
			    result.DecorationTimeOfDay = reader.ReadLookbackString();
			}
			if (result.Version >= 2)
			{
			    result.DecorationEnvironment = reader.ReadLookbackString();
			}
			if (result.Version >= 2)
			{
			    result.DecorationEnvironmentAuthor = reader.ReadLookbackString();
			}
			if (result.Version >= 3)
			{
			    result.Origin = reader.ReadVec2D();
			}
			if (result.Version >= 4)
			{
			    result.Target = reader.ReadVec2D();
			}
			if (result.Version >= 5)
			{
			    result.Unused = reader.ReadRaw((int)16);
			}
			if (result.Version >= 6)
			{
			    result.Type = reader.ReadString();
			}
			if (result.Version >= 6)
			{
			    result.Style = reader.ReadString();
			}
			if (result.Version >= 6 && result.Version <= 8)
			{
			    result.UnusedFlag = reader.ReadBool();
			}
			if (result.Version >= 8)
			{
			    result.LightmapCacheUid = reader.ReadUInt64();
			}
			if (result.Version >= 9)
			{
			    result.LightmapVersion = reader.ReadByte();
			}
			if (result.Version >= 11)
			{
			    result.TitleUid = reader.ReadLookbackString();
			}
			return result;
        }
	}

	public class MapCommunityChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCommunityChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043005U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCommunityChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCommunityChunk() { Id = chunkId };
			result.XmlString = reader.ReadString();
			return result;
        }
	}

	public class MapCoordinateChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCoordinateChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043025U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCoordinateChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCoordinateChunk() { Id = chunkId };
			result.Origin = reader.ReadVec2D();
			result.Target = reader.ReadVec2D();
			return result;
        }
	}

	public class MapCustomMusicChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCustomMusicChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043024U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCustomMusicChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapCustomMusicChunk() { Id = chunkId };
			result.CustomMusic = reader.ReadFileReference();
			return result;
        }
	}

	public class MapDescriptionChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapDescriptionChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043002U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapDescriptionChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapDescriptionChunk() { Id = chunkId };
			result.Version = reader.ReadByte();
			if (result.Version < 3)
			{
			    result.Uid = reader.ReadString();
			}
			if (result.Version < 3)
			{
			    result.Environment = reader.ReadString();
			}
			if (result.Version < 3)
			{
			    result.MapAuthor = reader.ReadString();
			}
			if (result.Version < 3)
			{
			    result.TrackName = reader.ReadString();
			}
			result.Unknown1 = reader.ReadBool();
			if (result.Version >= 1)
			{
			    result.BronzeTime = reader.ReadUInt32();
			}
			if (result.Version >= 1)
			{
			    result.SilverTime = reader.ReadUInt32();
			}
			if (result.Version >= 1)
			{
			    result.GoldTime = reader.ReadUInt32();
			}
			if (result.Version >= 1)
			{
			    result.AuthorTime = reader.ReadUInt32();
			}
			if (result.Version == 2)
			{
			    result.Unknown2 = reader.ReadByte();
			}
			if (result.Version >= 4)
			{
			    result.Cost = reader.ReadUInt32();
			}
			if (result.Version >= 5)
			{
			    result.Multilap = reader.ReadBool();
			}
			if (result.Version == 6)
			{
			    result.Unknown3 = reader.ReadByte();
			}
			if (result.Version >= 7)
			{
			    result.TrackTypeU = reader.ReadUInt32();
			}
			if (result.Version >= 9)
			{
			    result.Unknown4 = reader.ReadUInt32();
			}
			if (result.Version >= 10)
			{
			    result.AuthorScore = reader.ReadUInt32();
			}
			if (result.Version >= 11)
			{
			    result.EditorModeU = reader.ReadUInt32();
			}
			if (result.Version >= 12)
			{
			    result.Unknown5 = reader.ReadBool();
			}
			if (result.Version >= 13)
			{
			    result.Checkpoints = reader.ReadUInt32();
			}
			if (result.Version >= 13)
			{
			    result.Laps = reader.ReadUInt32();
			}
			return result;
        }
	}

	public class MapEmbeddedItemsChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapEmbeddedItemsChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043054U, true) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapEmbeddedItemsChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapEmbeddedItemsChunk() { Id = chunkId };
			result.Version = reader.ReadUInt32();
			result.Unknown = reader.ReadUInt32();
			result.ZipSize = reader.ReadUInt32();
			result.ItemCount = reader.ReadUInt32();
			result.Items = result.ParseItems(reader);
			result.EmbeddedItemSize = reader.ReadUInt32();
			result.ZipFile = reader.ReadRaw((int)(uint)result.EmbeddedItemSize);
			result.UnknownZipRest = result.ParseUnknownZipRest(reader);
			return result;
        }
	}

	public class MapGmCamArchiveChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapGmCamArchiveChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043027U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapGmCamArchiveChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapGmCamArchiveChunk() { Id = chunkId };
			result.HasGmCamArchive = reader.ReadBool();
			if (result.HasGmCamArchive)
			{
			    result.Unknown1 = reader.ReadByte();
			}
			if (result.HasGmCamArchive)
			{
			    result.Unknown2 = new ManiaPlanetSharp.GameBox.Vector3D[3];
			    for (int i = 0; i < result.Unknown2.Length; i++)
			    {
			        result.Unknown2[i] = reader.ReadVec3D();
			    }
			}
			if (result.HasGmCamArchive)
			{
			    result.Unknown3 = reader.ReadVec3D();
			}
			if (result.HasGmCamArchive)
			{
			    result.Unknown4 = reader.ReadFloat();
			}
			if (result.HasGmCamArchive)
			{
			    result.Unknown5 = reader.ReadFloat();
			}
			if (result.HasGmCamArchive)
			{
			    result.Unknown6 = reader.ReadFloat();
			}
			return result;
        }
	}

	public class MapModpackChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapModpackChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043019U, true) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapModpackChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapModpackChunk() { Id = chunkId };
			result.Modpack = reader.ReadFileReference();
			return result;
        }
	}

	public class MapPasswordChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPasswordChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043029U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPasswordChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPasswordChunk() { Id = chunkId };
			result.Password = new System.UInt64[2];
			for (int i = 0; i < result.Password.Length; i++)
			{
			    result.Password[i] = reader.ReadUInt64();
			}
			result.CRC = reader.ReadUInt32();
			return result;
        }
	}

	public class MapPasswordChunkOldParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPasswordChunkOld>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043014U, true) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPasswordChunkOld Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPasswordChunkOld() { Id = chunkId };
			result.Unused = reader.ReadUInt32();
			result.Password = reader.ReadString();
			return result;
        }
	}

	public class MapPlaymodeChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPlaymodeChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x0304301CU, true) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPlaymodeChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapPlaymodeChunk() { Id = chunkId };
			result.PlaymodeU = reader.ReadUInt32();
			return result;
        }
	}

	public class MapThumbnailChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapThumbnailChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043007U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapThumbnailChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapThumbnailChunk() { Id = chunkId };
			result.Version = reader.ReadUInt32();
			if (result.Version > 0)
			{
			    result.ThumbnailData = result.ReadThumbnailData(reader);
			}
			if (result.Version > 0)
			{
			    result.Comment = result.ReadComment(reader);
			}
			return result;
        }
	}

	public class MapTimeChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimeChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x0305B004U, true) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimeChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimeChunk() { Id = chunkId };
			result.BronzeTimeU = reader.ReadUInt32();
			result.SilverTimeU = reader.ReadUInt32();
			result.GoldTimeU = reader.ReadUInt32();
			result.AuthorTimeU = reader.ReadUInt32();
			result.Ignored = reader.ReadUInt32();
			return result;
        }
	}

	public class MapTimelimitChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimelimitChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x0305B008U, true) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimelimitChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimelimitChunk() { Id = chunkId };
			result.TimeLimitU = reader.ReadUInt32();
			result.AuthorTimeU = reader.ReadUInt32();
			return result;
        }
	}

	public class MapTimelimitTimeChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimelimitTimeChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x0305B00AU, true) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimelimitTimeChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTimelimitTimeChunk() { Id = chunkId };
			result.Unknown = reader.ReadUInt32();
			result.BronzeTimeU = reader.ReadUInt32();
			result.SilverTimeU = reader.ReadUInt32();
			result.GoldTimeU = reader.ReadUInt32();
			result.AuthorTimeU = reader.ReadUInt32();
			result.TimeLimitU = reader.ReadUInt32();
			result.AuthorScoreU = reader.ReadUInt32();
			return result;
        }
	}

	public class MapTipChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTipChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x0305B001U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTipChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapTipChunk() { Id = chunkId };
			result.Tip1 = reader.ReadString();
			result.Tip2 = reader.ReadString();
			result.Tip3 = reader.ReadString();
			result.Tip4 = reader.ReadString();
			return result;
        }
	}

	public class MapVehicleChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapVehicleChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x0304300DU, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapVehicleChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapVehicleChunk() { Id = chunkId };
			result.Name = reader.ReadLookbackString();
			result.Collection = reader.ReadLookbackString();
			result.Author = reader.ReadLookbackString();
			return result;
        }
	}

	public class MapVersionChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.MapVersionChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x03043004U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.MapVersionChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.MapVersionChunk() { Id = chunkId };
			result.Version = reader.ReadUInt32();
			return result;
        }
	}

	public class ObjectAnchorChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectAnchorChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E002017U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectAnchorChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectAnchorChunk() { Id = chunkId };
			result.Version = reader.ReadInt32();
			result.IsFreelyAnchorable = reader.ReadBool();
			return result;
        }
	}

	public class ObjectBannerProfileChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectBannerProfileChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E002010U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectBannerProfileChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectBannerProfileChunk() { Id = chunkId };
			result.BannerProfile = reader.ReadFileReference();
			return result;
        }
	}

	public class ObjectCameraIndexChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectCameraIndexChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E002006U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectCameraIndexChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectCameraIndexChunk() { Id = chunkId };
			result.DefaultCameraIndex = reader.ReadUInt32();
			return result;
        }
	}

	public class ObjectGroundPointChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectGroundPointChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E002012U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectGroundPointChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectGroundPointChunk() { Id = chunkId };
			result.GroundPoint = reader.ReadVec3D();
			result.PainterGroundMargin = reader.ReadFloat();
			result.OrbitalCenterHeightFromGround = reader.ReadFloat();
			result.OrbitalRadiusBase = reader.ReadFloat();
			result.OrbitalPreviewAngle = reader.ReadFloat();
			return result;
        }
	}

	public class ObjectItemTypeChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectItemTypeChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E002000U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectItemTypeChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectItemTypeChunk() { Id = chunkId };
			result.ItemTypeU = reader.ReadUInt32();
			return result;
        }
	}

	public class ObjectModelChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectModelChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E002019U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectModelChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectModelChunk() { Id = chunkId };
			result.Version = reader.ReadInt32();
			result.ShapeName = result.FindShapeName(reader);
			result.TriggerShapeName = result.FindTriggerShapeName(reader);
			result.MeshName = result.FindMeshName(reader);
			return result;
        }
	}

	public class ObjectTypeChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectTypeChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E002015U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectTypeChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectTypeChunk() { Id = chunkId };
			result.ObjectTypeU = reader.ReadUInt32();
			return result;
        }
	}

	public class ObjectUnknownChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectUnknownChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E002001U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectUnknownChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectUnknownChunk() { Id = chunkId };
			result.Unknown = reader.ReadUInt32();
			return result;
        }
	}

	public class ObjectUsabilityChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectUsabilityChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E002018U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectUsabilityChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.ObjectUsabilityChunk() { Id = chunkId };
			result.Version = reader.ReadInt32();
			result.IsUsable = reader.ReadBool();
			return result;
        }
	}

	public class GameSkinChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.GameSkinChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x090F4000U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.GameSkinChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.GameSkinChunk() { Id = chunkId };
			result.Version = reader.ReadByte();
			result.DirectoryName = reader.ReadString();
			if (result.Version >= 1)
			{
			    result.TextureName = reader.ReadString();
			}
			if (result.Version >= 1)
			{
			    result.SceneId = reader.ReadString();
			}
			result.SkinFiles = result.ParseSkinFiles(reader);
			if (result.Version >= 4)
			{
			    result.AlternateDirectoryName = reader.ReadString();
			}
			if (result.Version >= 5)
			{
			    result.UseDefaultSkin = reader.ReadBool();
			}
			return result;
        }
	}

	public class WaypointSpecialPropertyChunkParser
		: PregeneratedChunkParser<ManiaPlanetSharp.GameBox.Parsing.Chunks.WaypointSpecialPropertyChunk>
	{
		public override List<Tuple<uint, bool>> ParseableIds => new List<Tuple<uint, bool>>() { Tuple.Create(0x2E009000U, false) };

        public override ManiaPlanetSharp.GameBox.Parsing.Chunks.WaypointSpecialPropertyChunk Parse(GameBoxReader reader, uint chunkId)
        {
			var result = new ManiaPlanetSharp.GameBox.Parsing.Chunks.WaypointSpecialPropertyChunk() { Id = chunkId };
			result.Version = reader.ReadUInt32();
			if (result.Version == 1)
			{
			    result.Spawn = reader.ReadUInt32();
			}
			if (result.Version > 1)
			{
			    result.Tag = reader.ReadString();
			}
			result.Order = reader.ReadUInt32();
			return result;
        }
	}
}

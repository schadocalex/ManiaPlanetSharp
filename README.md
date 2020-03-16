# ManiaPlanetSharp
A .NET library, written in C#, which provides easy-to-use, object-oriented ways to access various tools and services related to ManiaPlanet.

## License
All of the code in this repository is available under the terms of the [MIT License](https://tldrlegal.com/license/mit-license).

## GameBox file parsing
This library includes one of the most - if not the most - extensive gbx file parsers available. There is a general framework for parsing gbx files and implementations for the parsing of over 100 different chunks present in them. The full structure of data nodes can be obtained via the `GameBoxFileParser.Parse()` method. For easy access to the most commonly needed metadata, there exist special `MetadataProvider` classes which take a `GameBoxFile` and provide direct access to the metadata - no need to dig through data nodes. Furthermore, these metadata provider classes have multiple sources for most of the properties provided, so even if there are some chunks missing in the gbx file, it can mostly still provide all of the metadata properties provided. If the specific property is present multiple times in the file, the metadata provider will try to return the metadata extracted from the hardest to manipulate part of the file, where it is present.

### Auto-generated parsers

This library uses various methods to make implementing chunk and custom struct layouts as easy as possible. For most chunks, it's sufficient to just define the chunk/struct as a class with the fields decorated with the `[Property]` and the chunk/struct with the `[Chunk(0xCHUNKID)]`/`[CustomStruct]` attribute. If the property type is ambiguous to multiple data types in gbx files, you can specify the type as a part of the `[Property]` attribute (a property of type `string` will default to a non-lookback string and a property of a type [derived of] `Node` will default to the node just being there - if you want to parse a lookback-string or node reference, you have to specify it in the attribute). Arrays are supported via the `[Array]` attribute with the length of the array either being read from the file as a `uint` before the start of the array if nothing is specified, hardcoded or read from another property of the chunk. Furthermore, conditional parsing is also available via the `[Condition]` attribute. If a section of your chunk/struct is too complex to be parsed by the automatically generated parser, you can use the `[CustomParserMethod]` attribute to specify a method, which takes a `GameBoxReader` object and returns the parsed value of the property. A great example of how these features can be used is the chunk `0x0304301F`:

```csharp
//The Chunk attribute sets the chunk id/ids that is/are parseable with this layout and whether the chunk is skippable
[Chunk(0x0304301F)]
public class MapChunk
    : Chunk //Chunks have to inherit from Chunk, which is a superclass of Node
{
    //This property is a lookback string instead of a normal string, so we have to specify that
    [Property(SpecialPropertyType.LookbackString)]
    public string Uid { get; set; }

    [Property(SpecialPropertyType.LookbackString)]
    public string Environment { get; set; }

    [Property(SpecialPropertyType.LookbackString)]
    public string Author { get; set; }

    //This property is just a normal string so we don't have to specify anything
    [Property]
    public string Name { get; set; }

    [Property(SpecialPropertyType.LookbackString)]
    public string TimeOfDay { get; set; }

    [Property(SpecialPropertyType.LookbackString)]
    public string DecorationEnvironment { get; set; }

    [Property(SpecialPropertyType.LookbackString)]
    public string DecorationEnvironmentAuthor { get; set; }

    //Some special data types are also supported by the automatic parser, e.g. file references, 2D and 3D size struct and 2D and 3D vectors
    [Property]
    public Size3D Size { get; set; }

    [Property]
    public bool NeedsUnlock { get; set; }

    [Property]
    public uint Version { get; set; }

    //The layout of this property in the file cannot be represented with the attributes, so we specify a custom method to parse this property
    [Property, CustomParserMethod(nameof(MapChunk.ParseBlocks))]
    public Block[] Blocks { get; set; }

    //This is the custom parser method for the property above. It has to be a public instance method that takes a GameBoxReader and returns a value of the same type as the property
    public Block[] ParseBlocks(GameBoxReader reader)
    {
        //The block struct can be parsed by the automatically generated parser
        CustomStructParser<Block> blockParser = ParserFactory.GetCustomStructParser<Block>();

        //This count of blocks that specified the length of the array does not count blocks with empty flags, so we have to read them one by one and check if they are actually counted
        Block[] blocks = new Block[reader.ReadUInt32()];
        for (int i = 0; i < this.Blocks.Length; i++)
        {
            Block block = blockParser.Parse(reader);
            if (block.Flags.HasFlag(BlockFlags.Null))
            {
                i--; //Ignore parsed block
            }
            else
            {
                this.Blocks[i] = block;
            }
        }

        return blocks;
    }
}

//This is a custom struct used in the chunk above - custom structs have to have the CustomStruct attribute to be able to automatically generate parsers for them
[CustomStruct]
public class Block
{
    [Property(SpecialPropertyType.LookbackString)]
    public string Name { get; set; }

    [Property]
    public byte Rotation { get; set; }

    [Property]
    public byte X { get; set; }

    [Property]
    public byte Y { get; set; }

    [Property]
    public byte Z { get; set; }

    //This is a property that can be represented by an enum. The parser does not support enums out of the box, so support is implemented via one property in which the value is put by the parser and a wrapper property that converts that value to the enum type
    [Property]
    public uint FlagsU { get; set; }
    public BlockFlags Flags => (BlockFlags)this.FlagsU;
    
    //This is a conditional property - it only gets parsed if the condition is fulfilled (in this case if the Flags property of the current Block instance has the CustomBlock flag)
    [Property, Condition(nameof(Block.Flags), ConditionOperator.HasFlag, BlockFlags.CustomBlock)]
    public string Author { get; set; }

    //This is a subnode inside of a chunk/struct. If it's not a node reference, nothing special has to be specified and if the type of node/chunk that is present is known, the specific type can be specified
    [Property, Condition(nameof(Block.Flags), ConditionOperator.HasFlag, BlockFlags.CustomBlock)]
    public Node Skin { get; set; }
    
    [Property, Condition(nameof(Block.Flags), ConditionOperator.HasFlag, BlockFlags.HasBlockParameters)]
    public Node BlockParameters { get; set; }
}

//This is just a regular flags enum, nothing special here
[Flags]
public enum BlockFlags
    : uint
{
    Null = uint.MaxValue,
    CustomBlock = 0x8000,
    HasBlockParameters = 0x100000
}
```



## ManiaPlanet text format parser
Status: Planned in the near future

## [ManiaExchange API](https://api.mania-exchange.com/documents/reference)
Status: Implemented, missing new features

## NadeoImporter
Status: Private prototype exists and works, needs proper implementation for MP#

## Dedimania API
Status: Planned

## ManiaPlanet Client Telemetry
Status: Planned
The ManiaPlanet client has a telemetry api which provides access to realtime metadata about races.

## [ManiaPlanet Web Services](https://forum.maniaplanet.com/viewforum.php?f=282)
Status: Not planned currently

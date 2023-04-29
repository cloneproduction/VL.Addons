using System.ComponentModel;


namespace Fuse.Common.TextureFX
{
    [Flags]
    public enum InvertMode
    {
        [Description("RGB")]
        RGB = 0,
        [Description("Red")]
        Red = 1,
        [Description("Green")]
        Green = 2,
        [Description("RedGreen")]
        RedGreen = 3,
        [Description("RedBlue")]
        RedBlue = 4,
        [Description("GreenBlue")]
        GreenBlue = 5,
        [Description("Value")]
        Value = 6,
        [Description("Lightness")]
        Lightness = 7,
        [Description("Saturation")]
        Saturation = 8,
        [Description("Hue")]
        Hue = 9,
        [Description("Cyan")]
        Cyan = 10,
        [Description("Magenta")]
        Magenta = 11,
        [Description("Yellow")]
        Yellow = 12,
        [Description("Black")]
        Black = 13,
    }
}
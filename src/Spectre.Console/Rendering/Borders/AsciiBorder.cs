using System;

namespace Spectre.Console.Rendering
{
    /// <summary>
    /// Represents an old school ASCII border.
    /// </summary>
    public sealed class AsciiBorder : Border
    {
        /// <inheritdoc/>
        protected override string GetBoxPart(BorderPart part)
        {
            return part switch
            {
                BorderPart.HeaderTopLeft => "+",
                BorderPart.HeaderTop => "-",
                BorderPart.HeaderTopSeparator => "-",
                BorderPart.HeaderTopRight => "+",
                BorderPart.HeaderLeft => "|",
                BorderPart.HeaderSeparator => "|",
                BorderPart.HeaderRight => "|",
                BorderPart.HeaderBottomLeft => "|",
                BorderPart.HeaderBottom => "-",
                BorderPart.HeaderBottomSeparator => "+",
                BorderPart.HeaderBottomRight => "|",
                BorderPart.CellLeft => "|",
                BorderPart.CellSeparator => "|",
                BorderPart.CellRight => "|",
                BorderPart.FooterBottomLeft => "+",
                BorderPart.FooterBottom => "-",
                BorderPart.FooterBottomSeparator => "-",
                BorderPart.FooterBottomRight => "+",
                _ => throw new InvalidOperationException("Unknown box part."),
            };
        }
    }
}



using System;

namespace LinenAndBird.Models
{
    public class Hat
    {
        public Guid Id { get; set; }
        public string Designer { get; set; }
        public string Color { get; set; }
        public HatStyle Style { get; set; } = HatStyle.Normal;
    }

    public enum HatStyle
    {
        Normal,
        OpenBack,
        WideBrim,
    }
}

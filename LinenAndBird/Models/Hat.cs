﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinenAndBird.Models
{
    public class Hat
    {
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

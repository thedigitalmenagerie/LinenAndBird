﻿using LinenAndBird.Models;
using System.Collections.Generic;
using System.Linq;

namespace LinenAndBird.DataAccess
{
    public class HatRepository
    {
        static List<Hat> _hats = new List<Hat>
        {
            new Hat
            {
                Color = "Blue",
                Designer = "Charlie",
                Style = HatStyle.OpenBack
            },
            new Hat
            {
                Color = "Black",
                Designer = "Nathan",
                Style = HatStyle.WideBrim
            },
            new Hat
            {
                Color = "Magenta",
                Designer = "Charlie",
                Style = HatStyle.Normal
            },
        };

        internal List<Hat> GetAll()
        {
            return _hats;
        }

        internal void Add(Hat newHat)
        {
            _hats.Add(newHat);
        }

        internal IEnumerable<Hat> GetByStyle(HatStyle style)
        {
            return _hats.Where(hat => hat.Style == style);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileGame
{
    public enum MapLevel
    {
        WorldMap = 0, // ~40 km scale
        RegionMap = 1, // ~4 km scale
        AreaMap = 2, // ~400 m scale
    }

    public class Map
    {
        public string MapName { get; set; }
        public Tile[,] Tiles { get; set; }
        public MapLevel Level { get; set; }

        public Map MapUp { get; set; }
        public Map MapDown { get; set; }
        public Map MapLeft { get; set; }
        public Map MapRight { get; set; }



    }
}

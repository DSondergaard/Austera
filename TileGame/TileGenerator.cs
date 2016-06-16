using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileGame
{
    public class TileGenerator
    {
        private static TileGenerator _instance;
        public static TileGenerator Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TileGenerator();
                return _instance;
            }
        }
    }
}

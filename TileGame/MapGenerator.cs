using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TileGame
{
    public class MapGenerator
    {
        private static MapGenerator _instance;
        public static MapGenerator Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MapGenerator();
                return _instance;
            }
        }

        internal Map GenerateMap(int tileSize, MapLevel level)
        {
            Map m = new Map();
            m.Level = level;
            m.Tiles = new Tile[10,10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    int xc = x * tileSize;
                    int yc = y * tileSize;
                    Tile t = new Tile();
                    t.Name = String.Format("({0},{1})", x, y);
                    t.SetBackground(ImageController.Instance.GetRandomBackgroundImage());
                    t.BorderStyle = BorderStyle.FixedSingle;
                    t.BackgroundImageLayout = ImageLayout.Zoom;
                    t.SizeMode = PictureBoxSizeMode.Zoom;
                    t.SetBounds(xc, yc, tileSize, tileSize);
                    m.Tiles[x, y] = t;
                    MakeRelations(m, t, x, y);
                }
            }
            return m;
        }

        private void MakeRelations(Map m, Tile t, int x, int y)
        {
            if (x > 0)
            {
                t.MakeLeftRelation(m.Tiles[x - 1, y]);
            }
            if (y > 0)
            {
                t.MakeUpRelation(m.Tiles[x, y - 1]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AusteraGame
{
    public class Tile : PictureBox
    {
        public Tile TileUp { get; set; }
        public Tile TileDown { get; set; }
        public Tile TileLeft { get; set; }
        public Tile TileRight { get; set; }
        public int Level { get; set; }


        public void MakeLeftRelation(Tile tile)
        {
            TileLeft = tile;
            tile.TileRight = this;
        }

        public void MakeUpRelation(Tile tile)
        {
            TileUp = tile;
            tile.TileDown = this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TileGame
{
    public class Tile : PictureBox
    {
        public Tile TileUp { get; set; }
        public Tile TileDown { get; set; }
        public Tile TileLeft { get; set; }
        public Tile TileRight { get; set; }

        public Image OriginalBackground { get; set; }
        private Image Icon;

        public Map ParentMap { get; set; }
        public Map SubMap { get; set; }


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

        public void SetIcon(Image icon)
        {
            if(icon != null)
            {
                Icon = icon;
                var target = new Bitmap(this.OriginalBackground);
                var graphics = Graphics.FromImage(target);            
                Bitmap b = new Bitmap(icon);
                b.MakeTransparent(Color.White);
                graphics.DrawImage(b, 0, 0);
                this.BackgroundImage = target;
            }
            else
                this.BackgroundImage = OriginalBackground;

        }

        public void SetBackground(Image background)
        {
            OriginalBackground = background;
            SetIcon(Icon);
        }
    }
}

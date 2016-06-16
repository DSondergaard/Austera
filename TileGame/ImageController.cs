using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace TileGame
{
    public class ImageController
    {
        private static ImageController _instance;
        public static ImageController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ImageController();
                return _instance;
            }
        }
        public Image Hero { get; set; }
        public Image Monster { get; set; }
        public List<Image> Backgrounds { get; set; }
        private Random random = null;

        private ImageController()
        {
            Backgrounds = new List<Image>();
            random = new Random();
            DirectoryInfo dir = new DirectoryInfo(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Pictures");
            var files = dir.GetFiles("Back*");

            foreach (var file in files)
            {
                Backgrounds.Add(Image.FromFile(file.FullName));
            }
            Bitmap b = new Bitmap(dir.FullName + @"\Hero.png");
            b.MakeTransparent(Color.White);
            Hero = b;
            b = new Bitmap(dir.FullName + @"\602.png");
            b.MakeTransparent(Color.White);
            Monster = b;
        }

        internal System.Drawing.Image GetRandomBackgroundImage()
        {
            Image img = Backgrounds[random.Next(Backgrounds.Count)];
            return img;
        }

        internal Image GetFightScene()
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Pictures");
            Bitmap b = new Bitmap(dir.FullName + @"\FightScene.jpg");
            return b;
        }
    }
}

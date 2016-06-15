using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AusteraGame
{
    public class ImageController
    {
        public List<Image> Backgrounds { get; set; }
        public Image Hero { get; set; }
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
        private Random random = null;

        private ImageController()
        {
            Backgrounds = new List<Image>();
            random = new Random();
        }


        internal Image GetRandomBackgroundImage()
        {
            Image img = Backgrounds[random.Next(Backgrounds.Count)];
            return img;
        }
    }
}

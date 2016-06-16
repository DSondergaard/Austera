using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AusteraGame
{
    public partial class Form1 : Form
    {
        Tile currentTile;
        int distanceInMeters = 0;
        int tileSize = 75;
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Pictures");
            var files = dir.GetFiles("Back*");

            foreach (var file in files)
            {
                ImageController.Instance.Backgrounds.Add(Image.FromFile(file.FullName));
            }

            
            Bitmap b = new Bitmap(dir.FullName + @"\Hero.png");
            b.MakeTransparent(Color.White);
            ImageController.Instance.Hero = b;
        }

        private void btnGenerateMap_Click(object sender, EventArgs e)
        {
            panMap.Controls.Clear();
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    int xc = x * tileSize;
                    int yc = y * tileSize;
                    Tile t = new Tile();
                    t.Level = 1;
                    t.Name = String.Format("({0},{1})", x, y);
                    t.SetBackground(ImageController.Instance.GetRandomBackgroundImage());
                    t.BorderStyle = BorderStyle.FixedSingle;
                    t.BackgroundImageLayout = ImageLayout.Zoom;
                    t.SizeMode = PictureBoxSizeMode.Zoom;
                    t.SetBounds(xc, yc, tileSize, tileSize);
                    panMap.Controls.Add(t);
                    MakeRelations(t, x, y);
                }
            }
            
            btnGenerateMap.Enabled = false;
        }
         
        private void MakeRelations(Tile t, int x, int y)
        {
            if (x > 0)
            {
                t.MakeLeftRelation((Tile)panMap.Controls.Find(String.Format("({0},{1})", x - 1, y), true)[0]);
            }
            if (y > 0)
            {
                t.MakeUpRelation((Tile)panMap.Controls.Find(String.Format("({0},{1})", x, y - 1), true)[0]);
            }
        }

        private void btnPlaceHero_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(10);
            int y = random.Next(10);
            MoveTo(x, y);
            btnPlaceHero.Enabled = false;
            labScale.Text = CalculateScale();
        }

        private string CalculateScale()
        {
            switch (currentTile.Level)
            {
                case 1: return "40 km";
                case 2: return "4 km";
                case 3: return "400 m";
                case 4: return "40 m";
                case 5: return "4 m";
                case 6: return "1,5 m";
            }
            return "";
        }

        private void MoveTo(Point p)
        {
            MoveTo(p.X, p.Y);
        }

        private void MoveTo(int x, int y)
        {
            if (currentTile != null)
            {
                currentTile.Image = null;
                currentTile.Invalidate();
            }
            var tile = (Tile)panMap.Controls.Find(String.Format("({0},{1})", x, y), true)[0];
            tile.Image = ImageController.Instance.Hero;
            
            currentTile = tile;
            distanceInMeters += (int)(400000/(Math.Pow((double)10, (double)currentTile.Level)));
            ShowDistance();
            currentTile.Invalidate();
        }

        private void ShowDistance()
        {
            if (distanceInMeters > 1000)
                labDistance.Text = (distanceInMeters / 1000) + " km";
            else
                labDistance.Text = (distanceInMeters) + " m";
        }

        private Point GetCoordsFromTile(Tile t)
        {
            if (t == null)
                t = currentTile;
            Point p = new Point();
            string s = t.Name;
            s = s.Substring(1);
            s = s.Remove(s.Length - 1);
            string[] ss = s.Split(',');
            p.X = Convert.ToInt32(ss[0]);
            p.Y = Convert.ToInt32(ss[1]);

            return p;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                case Keys.Right: MoveTo(GetCoordsFromTile(currentTile.TileRight)); break;
                case Keys.A:
                case Keys.Left: MoveTo(GetCoordsFromTile(currentTile.TileLeft)); break;
                case Keys.W:
                case Keys.Up: MoveTo(GetCoordsFromTile(currentTile.TileUp)); break;
                case Keys.S:
                case Keys.Down: MoveTo(GetCoordsFromTile(currentTile.TileDown)); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(10);
            int y = random.Next(10);
            
            string tileName = String.Format("({0},{1})", x, y);
            Tile t = (Tile)panMap.Controls.Find(tileName, true)[0];
            DirectoryInfo dir = new DirectoryInfo(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Pictures");
            t.SetIcon(Image.FromFile(dir.FullName + @"\IconHouse.jpg"));

            button1.Enabled = false;
        }
        
    }
}

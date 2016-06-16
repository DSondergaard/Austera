using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TileGame.Monsters;

namespace TileGame
{
    public partial class MainWindow : Form
    {
        Hero hero;
        public MainWindow()
        {
            InitializeComponent();
            MapController.Instance.CurrentMap = MapGenerator.Instance.GenerateMap(75, MapLevel.WorldMap);
            LoadMap();
            AddHero();
        }

        private void AddHero()
        {
            hero = new Hero();
            Random random = new Random();
            int x = random.Next(10);
            int y = random.Next(10);
            hero.HeroPosition = new Point(x, y);
            hero.HeroName = "Steve";
            MoveTo(hero.HeroPosition);
        }

        private void LoadMap()
        {            
            Tile[] test = new Tile[100];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    int index = (x * 10) + y;
                    test[index] = MapController.Instance.CurrentMap.Tiles[x, y];
                }
            }
            panMap.Controls.Clear();
            //panMap.Controls.Add(MapController.Instance.CurrentMap.Tiles[x, y]);
            panMap.Controls.AddRange(test);
        }

        private void MoveTo(Point p)
        {
            MoveTo(p.X, p.Y);
        }

        private void MoveTo(int x, int y)
        {
            if (hero.CurrentLocation != null)
            {
                hero.CurrentLocation.Image = null;
                hero.CurrentLocation.Invalidate();
            }
            var tile = (Tile)panMap.Controls.Find(String.Format("({0},{1})", x, y), true)[0];
            tile.Image = hero.HeroImage;

            hero.CurrentLocation = tile;
            hero.HeroPosition = new Point(x, y);
            //distanceInMeters += (int)(400000 / (Math.Pow((double)10, (double)currentTile.Level)));
            //ShowDistance();
            hero.CurrentLocation.Invalidate();
        }

        private void action_KeyDown(object sender, KeyEventArgs e)
        {
            Form f = (Form)sender;
            var p = new Point(hero.HeroPosition.X * 75 + 12, hero.HeroPosition.Y * 75 + 12);
            p = f.PointToScreen(p);
            //

            switch (e.KeyCode)
            {
                case Keys.D:
                case Keys.Right: MoveTo(GetCoordsFromTile(hero.CurrentLocation.TileRight)); break;
                case Keys.A:
                case Keys.Left: MoveTo(GetCoordsFromTile(hero.CurrentLocation.TileLeft)); break;
                case Keys.W:
                case Keys.Up: MoveTo(GetCoordsFromTile(hero.CurrentLocation.TileUp)); break;
                case Keys.S:
                case Keys.Down: MoveTo(GetCoordsFromTile(hero.CurrentLocation.TileDown)); break;
                case Keys.Space: 
                    contextMenuStrip1.Show(p); break;
                case Keys.F:
                    Fight fight = new Fight(hero, new SquidMonster());
                    fight.Show();
                    break;
            }
        }

        private Point GetCoordsFromTile(Tile t)
        {
            if (t == null)
                t = hero.CurrentLocation;
            Point p = new Point();
            string s = t.Name;
            s = s.Substring(1);
            s = s.Remove(s.Length - 1);
            string[] ss = s.Split(',');
            p.X = Convert.ToInt32(ss[0]);
            p.Y = Convert.ToInt32(ss[1]);

            return p;
        }

        private void fightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fight fight = new Fight(hero, new SquidMonster());
            fight.Show();
        }
    }
}

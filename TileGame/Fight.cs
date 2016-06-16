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
    public partial class Fight : Form
    {
        private Hero _hero;
        private Monster _monster;

        public Fight(Hero hero, Monster monster)
        {
            InitializeComponent();
            _hero = hero;
            _monster = monster;
            SetupVisuals();
            SetHealthBars();
        }

        private void UpdateHealthBars()
        {
            int width = CalculateHealthBarWidth(_hero.CurrentHealth, _hero.MaxHealth);
            Bitmap bm = null;
            
            if (width > 0)
            {
                bm = new Bitmap(pbHeroHealth.Image, width, 30);
                pbHeroHealth.Image = bm;
            }
            else
                pbHeroHealth.Image = null;

            width = CalculateHealthBarWidth(_monster.CurrentHealth, _monster.MaxHealth);
            
            
            if (width > 0)
            {
                bm = new Bitmap(pbMonsterHealth.Image, width, 30);
                pbMonsterHealth.Image = bm;
            }
            else
                pbMonsterHealth.Image = null;


            labHeroHealthValue.Text = _hero.CurrentHealth + "\\" + _hero.MaxHealth;
            labMonsterHealthValue.Text = _monster.CurrentHealth + "\\" + _monster.MaxHealth;
        }

        private void SetHealthBars()
        {
            Bitmap Bmp = new Bitmap(300, 30);
            using (Graphics gfx = Graphics.FromImage(Bmp))
            using (SolidBrush brush = new SolidBrush(Color.Chartreuse))
            {
                gfx.FillRectangle(brush, 0, 0, 300, 30);
            }

            pbHeroHealth.Image = Bmp;
            pbMonsterHealth.Image = Bmp;            
            labHeroHealthValue.Text = _hero.CurrentHealth + "\\" + _hero.MaxHealth;
            labMonsterHealthValue.Text = _monster.CurrentHealth + "\\" + _monster.MaxHealth;
        }

        private void SetupVisuals()
        {
            pbFightScene.Image = ImageController.Instance.GetFightScene();

            var target = new Bitmap(ImageController.Instance.GetFightScene());
            var graphics = Graphics.FromImage(target);

            var image = _hero.HeroImage;
            Bitmap b = new Bitmap(image);
            b.MakeTransparent(Color.White);
            graphics.DrawImage(b, 150, 180);

            image = ImageController.Instance.Monster;
            b = new Bitmap(image);
            b = ResizeImage(b, new Size(96, 96));
            b.MakeTransparent(Color.White);
            graphics.DrawImage(b, 500, 90);
            
            pbFightScene.Image = target;

            labHeroHealthValue.Parent = pbHeroHealth;
            labHeroHealthValue.BackColor = Color.Transparent;
            labHeroHealthValue.SetBounds(0, 0, 300, 30);
            labHeroHealthValue.TextAlign = ContentAlignment.MiddleCenter;
            labHeroHealthValue.AutoSize = false;

            labMonsterHealthValue.Parent = pbMonsterHealth;
            labMonsterHealthValue.BackColor = Color.Transparent;
            labMonsterHealthValue.SetBounds(0, 0, 300, 30);
            labMonsterHealthValue.TextAlign = ContentAlignment.MiddleCenter;
            labMonsterHealthValue.AutoSize = false;
            
        }

        public static Bitmap ResizeImage(Bitmap imgToResize, Size size)
        {
            Bitmap b = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage((Image)b))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
            }
            return b;
        }
        
        public void something()
        {
            // Take one damage
            if (_hero.CurrentHealth >= 1)
                _hero.CurrentHealth -= 1;
            int width = CalculateHealthBarWidth(_hero.CurrentHealth, _hero.MaxHealth);
            int height = 30;
            if (width > 0)
            {
                Bitmap bm = new Bitmap(pbHeroHealth.Image, width, 30);
                pbHeroHealth.Image = bm;
            }
            else
                pbHeroHealth.Image = null;
        }

        private int CalculateHealthBarWidth(int currentHealth, int maxHealth)
        {
            if (currentHealth == maxHealth)
                return 300;

            int widthPerHealth = (int)(300 / maxHealth);
            return currentHealth * widthPerHealth;
        }

        private void Fight_KeyDown(object sender, KeyEventArgs e)
        {
            List<string> messages = null;
            switch (e.KeyCode)
            {
                case Keys.A: 
                    messages = _hero.Attack(_monster);
                    UpdateHealthBars();
                    break;
            }
            if(messages != null)
                foreach (string message in messages)
                {
                    tbMessages.AppendText(message+Environment.NewLine);
                }
        }
    }
}

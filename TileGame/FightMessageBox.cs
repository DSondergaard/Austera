using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TileGame
{
    public class FightMessageBox : TextBox
    {
        public FightMessageBox() : base()
        {
            SetStyle(ControlStyles.Selectable, false);
            ReadOnly = true;
            ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        }
    }
}

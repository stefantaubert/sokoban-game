using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LevelDesigner
{
    public class KoordinatenPicBox : PictureBox
    {
        public int x;
        public int y;

        public KoordinatenPicBox(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

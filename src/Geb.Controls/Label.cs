﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Geb.Controls
{
    public class Label : DisplayObject
    {
        public String Text;

        public override void Draw(System.Drawing.Graphics g)
        {
            if (Text == null) return;

            g.DrawString(Text, new System.Drawing.Font("微软雅黑", 10), new SolidBrush(Color.Black), 0, 0);
        }
    }
}

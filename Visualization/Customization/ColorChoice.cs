using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Visualization.Customization
{
    public class ColorChoice
    {
        private Random random = new Random();
        public Color GetRandomColor()
        {
            Color randomColor = Color.FromArgb(random.Next(150,255), random.Next(150,255), random.Next(150,255));
            return randomColor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clrs
{
    class Clr
    {
        private string hex;
        private int red;
        private int green;
        private int blue;
        private System.Drawing.Color color;
        
        public Clr(string h)
        {
            hex = h;
            color = ColorTranslator.FromHtml(hex);
            red = Convert.ToInt16(color.R);
            green = Convert.ToInt16(color.G);
            blue = Convert.ToInt16(color.B);
        }

        public DSCore.Color ByARGB()
        {
            return DSCore.Color.ByARGB(255, red, green, blue);
        }

    }
}

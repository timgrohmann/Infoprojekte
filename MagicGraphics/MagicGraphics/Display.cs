using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

namespace MagicGraphics
{
    class Display
    {
        float scale;
        Vector center;
        PictureBox picBox;
        

        Display(float s, Vector v, PictureBox picBox)
        {
            scale = s;
            center = v;
            this.picBox = picBox;
        }

        Vector toCoordinateSpace(Vector v)
        {
            return Vector.Multiply(Vector.Subtract(v, center),scale);
        }

        Vector toDisplaySpace(Vector v)
        {
            return Vector.Subtract(Vector.Divide(v, scale), center);
        }

        void connectPoints(Vector[] inp)
        {
            Vector[] converted = inp.Select(i => toDisplaySpace(i)).ToArray();
            Pen p = new Pen(Color.Black);
            
        }
    }
}

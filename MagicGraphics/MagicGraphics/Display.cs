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
        Graphics gCont;
        

        public Display(float s, Vector v, Graphics gCont)
        {
            scale = s;
            center = v;
            this.gCont = gCont;
            gCont.Clear(Color.White);
        }

        Vector toCoordinateSpace(Vector v)
        {
            return Vector.Multiply(Vector.Subtract(v, center),scale);
        }

        PointF toDisplaySpace(Vector v)
        {
            v.Y *= -1;
            Vector c = Vector.Add(Vector.Divide(v, scale), center);
        
            return new PointF((float) c.X, (float) c.Y);
        }

        public void connectPoints(Vector[] inp)
        {
            PointF[] converted = inp.Select(i => toDisplaySpace(i)).ToArray();
            Pen p = new Pen(Color.Black);
            
            gCont.DrawLines(p, converted);
        }
    }
}

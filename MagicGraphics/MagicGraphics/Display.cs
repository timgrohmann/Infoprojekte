using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MagicGraphics
{
    class Display
    {
        float scale;
        Vector center;

        Display(float s, Vector v)
        {
            scale = s;
            center = v;
        }

        Vector toCoordinateSpace(Vector v)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenUndObjekte
{
    class MyVector
    {
        public float x;
        public float y;

        public MyVector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float mag()
        {
            return (float) Math.Sqrt(x * x + y * y);
        }

        public float heading()
        {
            return (float) Math.Atan2(y, x);
        }
    }
}

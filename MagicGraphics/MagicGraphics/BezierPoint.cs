using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MagicGraphics
{
    class BezierPoint
    {
        public Vector pos;
        public Vector cPrev;
        public Vector cNext;

        public int detail = 100;

        public bool locked = true;

        BezierPoint prev;
        BezierPoint next;

        public BezierPoint(Vector pos, Vector c1, Vector c2, BezierPoint prev) {
            this.pos = pos;
            cPrev = c1;
            cNext = c2;
            this.prev = prev;
            if (prev != null)
            {
                prev.next = this;
            }
        }

        public void renderTo(Display d) {
            /*if (this.next == null) return;
            let res = [];

            for (let step = 0; step <= steps; step++)
            {
                let ps = [this.pos, this.nextCP(), this.next.prevCP(), this.next.pos];
                while (ps.length > 1)
                {
                    let points2 = [];
                    for (let i = 0; i < ps.length - 1; i++)
                    {
                        points2[i] = this.between(ps[i], ps[i + 1], step / steps);
                    }
                    ps = points2;
                }
                res[step] = ps[0];
            }
            d.connectPoints(res);
            d.drawPointWithControl(this.pos, this.nextCP());
            d.drawPointWithControl(this.next.pos, this.next.prevCP());*/

            if (next == null) return;
            Vector[] res = new Vector[detail];

            for (int i = 0; i < detail; i++)
            {
                List<Vector> l = new List<Vector>();
                l.Add(pos);
                l.Add(nextCP());
                l.Add(prevCP());
                l.Add(next.pos);
            }
        }

        Vector nextCP() {
            return Vector.Add(pos, cNext);
        }

        Vector prevCP()
        {
            return Vector.Add(pos, cPrev);
        }
    }
}

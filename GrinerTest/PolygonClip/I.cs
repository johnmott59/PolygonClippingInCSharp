using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrienerTest
{

    public partial class PolygonClip
    {

#if false
        int I(node *p1, node *p2, node *q1, node *q2,
  float *alpha_p, float *alpha_q, int *xint, int *yint)
{
  float x, y, tp, tq, t, par;

  par = (float) ((p2->x - p1->x)*(q2->y - q1->y) -
                 (p2->y - p1->y)*(q2->x - q1->x));

  if (!par) return 0;                               /* parallel lines */

  tp = ((q1->x - p1->x)*(q2->y - q1->y) - (q1->y - p1->y)*(q2->x - q1->x))/par;
  tq = ((p2->y - p1->y)*(q1->x - p1->x) - (p2->x - p1->x)*(q1->y - p1->y))/par;

  if(tp<0 || tp>1 || tq<0 || tq>1) return 0;

  x = p1->x + tp*(p2->x - p1->x);
  y = p1->y + tp*(p2->y - p1->y);

  *alpha_p = dist(p1->x, p1->y, x, y) / dist(p1->x, p1->y, p2->x, p2->y);
  *alpha_q = dist(q1->x, q1->y, x, y) / dist(q1->x, q1->y, q2->x, q2->y);
  *xint = (int) x;
  *yint = (int) y;

  return 1;
} 

#endif
        int I(Node p1,Node p2,Node q1,Node q2,out float alpha_p,out float alpha_q,out int xint, out int yint)
        {
            alpha_q = 0;
            alpha_p = 0;
            xint = 0;
            yint = 0;

            float x, y, tp, tq, t, par;

            par = (float)((p2.x - p1.x) * (q2.y - q1.y) -
                           (p2.y - p1.y) * (q2.x - q1.x));

            if (par == 0) return 0;                               /* parallel lines */

            tp = ((q1.x - p1.x) * (q2.y - q1.y) - (q1.y - p1.y) * (q2.x - q1.x)) / par;
            tq = ((p2.y - p1.y) * (q1.x - p1.x) - (p2.x - p1.x) * (q1.y - p1.y)) / par;

            if (tp < 0 || tp > 1 || tq < 0 || tq > 1) return 0;

            x = p1.x + tp * (p2.x - p1.x);
            y = p1.y + tp * (p2.y - p1.y);

            alpha_p = dist(p1.x, p1.y, x, y) / dist(p1.x, p1.y, p2.x, p2.y);
            alpha_q = dist(q1.x, q1.y, x, y) / dist(q1.x, q1.y, q2.x, q2.y);
            xint = (int)x;
            yint = (int)y;

            return 1;
        }


    }
}

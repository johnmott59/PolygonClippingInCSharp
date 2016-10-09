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

        /*
 * This is a test for crossing from one polygon to another. I think it determines whether the first point is inside or outside
 */
int test(node *point, node *p)
{
  node *aux, *left, i;
  int type=0;

  left = create(0, point->y, 0, 0, 0, 0, 0, 0, 0, 0.);
  for(aux=p; aux->next; aux=aux->next)
  if(I(left, point, aux, aux->next, &i.alpha, &i.alpha, &i.x, &i.y)) type++;
  return type%2;
} 
#endif

        int test(Node point, Node p)
        {
            Node aux, left, i;
            int type = 0;
            i = new Node();
            /*
             * Note that this create call uses '0' as the x value. This works fine
             * as long as all points are in the first quadrant. If you have negative 
             * points this call should find a point larger or smaller than all
             * points in the test polygon denoted by 'p'
             */
            left = create(0, point.y, null,null,null,null , 0, 0, 0, 0);
            for (aux = p; aux.next != null; aux = aux.next)
            {
                float alpha = 0;
                int x = 0;
                int y = 0;
                if (I(left, point, aux, aux.next, out alpha, out alpha, out x, out y) == 1) type++;
                i.alpha = alpha;
                i.x = x;
                i.y = y;
            }
            return type % 2;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrienerTest
{

    public partial class PolygonClip
    {

        /*
         * Remove the last node from the list. The assumption is that the polygon coming in doesn't have a last point.
         * The processing adds the last point to be the same as the first to close the polygon, then removes it at the end
         */
#if false

void circle(node *p)
{
  node *aux = last_node(p);
  aux->prev->next = p;
  p->prev = aux->prev;
  free(aux);
} 
#endif

        void circle(Node p)
        {
            Node aux = last_node(p);
            aux.prev.next = p;
            p.prev = aux.prev;
        }
    }
}

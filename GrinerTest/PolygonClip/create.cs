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
        node *create(int x, int y, node *next, node *prev, node *nextPoly,
  node *neighbor, int intersect, int entry, int visited, float alpha)
{
  node *newNode = (node *) malloc(sizeof(node));
  newNode->x = x;
  newNode->y = y;
  newNode->next = next;
  newNode->prev = prev;
  if(prev) newNode->prev->next = newNode;
  if(next) newNode->next->prev = newNode;
  newNode->nextPoly = nextPoly;
  newNode->neighbor = neighbor;
  newNode->intersect = intersect;
  newNode->entry = entry;
  newNode->visited = visited;
  newNode->alpha = alpha;
  return newNode;
} 
#endif

        Node create(int x, int y, Node next, Node prev, Node nextPoly, Node neighbor, int intersect, int entry, int visited, float alpha)
        {
            Node newNode = new Node()
            {
                x = x,
                y = y,
                next = next,
                prev = prev,
                nextPoly = nextPoly,
                neighbor = neighbor,
                intersect = intersect,
                alpha = alpha,
                visited = visited,
                entry = entry
            };
            /*
             * Insert into list of prev and next are provided
             */
            
            if (prev != null) newNode.prev.next = newNode;
            if (next != null) newNode.next.prev = newNode;

            return newNode;
        }

    }
}

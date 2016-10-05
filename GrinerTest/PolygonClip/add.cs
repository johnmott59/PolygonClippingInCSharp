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
void add(int SourcePolygon, int x, int y)
{
  node *newNode;
  
        newNode = (node *) malloc(sizeof(node));
        newNode->x = x;
        newNode->y = y;
        newNode->prev = 0;        /* not need to initialize with 0 after malloc ... */
        newNode->nextPoly = 0;
        newNode->neighbor = 0;
        newNode->intersect = 0;
        newNode->entry = 0;
        newNode->visited = 0;
        newNode->alpha = 0.;
        if (SourcePolygon == 1)
        {
                newNode->next = s;
                if (s) s->prev = newNode;
                s = newNode;
        }
        else /* DRAW == 2 */
        {
                newNode->next = c;
                if (c) c->prev = newNode;
                c = newNode;
        }
      
} 


#endif
        public void AddSource(int x, int y)
        {
            Node newNode = create(x, y, null, null, null, null, 0, 0, 0, (float)0.0);

            newNode.next = SubjectPolygon;
            if (SubjectPolygon != null)
            {
                SubjectPolygon.prev = newNode;
            }
            SubjectPolygon = newNode;

        }

        public void AddClip(int x, int y)
        {
            Node newNode = create(x, y, null, null, null, null, 0, 0, 0, (float)0.0);

            newNode.next = ClipPolygon;
            if (ClipPolygon != null)
            {
                ClipPolygon.prev = newNode;
            }
            ClipPolygon = newNode;

        }

    }

    }

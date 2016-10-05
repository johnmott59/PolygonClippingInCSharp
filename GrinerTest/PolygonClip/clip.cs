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
        void clip()
{
  node *auxs, *auxc, *is, *ic;
  int xi, yi, e;
  float alpha_s, alpha_c;

  node *crt, *newNode, *old;
  int forward;

  /*
   * Add nodes at the end of the list that are the same point as the first point. This will create a closed polygon.
   */
  auxs = last_node(s);
  create(s->x, s->y, 0, auxs, 0, 0, 0, 0, 0, 0.);
  auxc = last_node(c);
  create(c->x, c->y, 0, auxc, 0, 0, 0, 0, 0, 0.);
  /*
   * Phase 1. find all intersections
   */
  for(auxs = s; auxs->next; auxs = auxs->next) {
	  if(!auxs->intersect) {
		  for(auxc = c; auxc->next; auxc = auxc->next) {
			  if(!auxc->intersect) {
				  if(I(auxs, next_node(auxs->next), auxc, next_node(auxc->next),
						&alpha_s, &alpha_c, &xi, &yi))
				  {
						is = create(xi, yi, 0, 0, 0, 0, 1, 0, 0, alpha_s);
						ic = create(xi, yi, 0, 0, 0, 0, 1, 0, 0, alpha_c);
						is->neighbor = ic;
						ic->neighbor = is;
						insert(is, auxs, next_node(auxs->next));
						insert(ic, auxc, next_node(auxc->next));
				  }
			  }
		  }
	  }
  }

  e = test(s, c);
  if(pS) e = 1-e;
  /*
   * Phase 2 Trace each polygon once and mark entry and exit points to the other polygon's interior
   */
  for(auxs = s; auxs->next; auxs = auxs->next) {
	  if(auxs->intersect)
	  {
			auxs->entry = e;
			e = 1-e;
	  }
  }

  e=test(c, s);
  if(pC) e = 1-e;
  for(auxc = c; auxc->next; auxc = auxc->next) {
	  if(auxc->intersect)
	  {
			auxc->entry = e;
			e = 1-e;
	  }
  }

  circle(s);
  circle(c);

  /*
   * Phase 3. Create the desired clipping polygon by filtering it out of the enhanced data structures of subject and clip polygon
   */
  while ((crt = first(s)) != s)
  {
        old = 0;
        for(; !crt->visited; crt = crt->neighbor)
        for(forward = crt->entry ;; )
        {
                newNode = create(crt->x, crt->y, old, 0, 0, 0, 0, 0, 0, 0.);
                old = newNode;
                crt->visited = 1;
                crt = forward ? crt->next : crt->prev;
                if(crt->intersect)
                {
                        crt->visited = 1;
                        break;
                }
        }

        old->nextPoly = root;
        root = old;
  }

  
 
} 
#endif

            public void clip()
{
                Node auxs, auxc, _is, ic;
                int xi, yi, e;
                float alpha_s, alpha_c;

                Node crt, newNode, old;
                int forward;

                /*
                 * Add nodes at the end of the list that are the same point as the first point. This will create a closed polygon.
                 */
                auxs = last_node(SubjectPolygon);
                create(SubjectPolygon.x, SubjectPolygon.y, null, auxs, null, null, 0, 0, 0, (float) 0.0);
                auxc = last_node(ClipPolygon);
                create(ClipPolygon.x, ClipPolygon.y, null, auxc, null, null, 0, 0, 0, (float) 0.0);
                /*
                 * Phase 1. find all intersections
                 */
                for (auxs = SubjectPolygon; auxs.next != null; auxs = auxs.next)
                {
                    if (auxs.intersect == 0)
                    {
                        for (auxc = ClipPolygon; auxc.next != null; auxc = auxc.next)
                        {
                            if (auxc.intersect == 0)
                            {
                                if (I(auxs, next_node(auxs.next), auxc, next_node(auxc.next),
                                      out alpha_s, out alpha_c, out xi, out yi) == 1)
                                {
                                    _is = create(xi, yi, null, null, null, null, 1, 0, 0, alpha_s);
                                    ic = create(xi, yi, null, null, null, null, 1, 0, 0, alpha_c);
                                    _is.neighbor = ic;
                                    ic.neighbor = _is;
                                    insert(_is, auxs, next_node(auxs.next));
                                    insert(ic, auxc, next_node(auxc.next));
                                }
                            }
                        }
                    }
                }

                e = test(SubjectPolygon, ClipPolygon);
            /*
             *  Based on the operation determine how the polygon crosses are handled
             */
                switch (Operation)
                {
                    case eOperation.Intersection:
                        e = 1 - e;
                        break;
                    case eOperation.ClipMinusSubject:
                        e = 1 - e;
                        break;
                }

        
                /*
                 * Phase 2 Trace each polygon once and mark entry and exit points to the other polygon's interior
                 */
                for (auxs = SubjectPolygon; auxs.next != null; auxs = auxs.next)
                {
                    if (auxs.intersect == 1)
                    {
                        auxs.entry = e;
                        e = 1 - e;
                    }
                }

                e = test(ClipPolygon, SubjectPolygon);
            /*
             *  Based on the operation determine how the polygon crosses are handled
             */
            switch (Operation)
                {
                    case eOperation.Intersection:
                        e = 1 - e;
                        break;
                    case eOperation.SubjectMinusClip:
                        e = 1 - e;
                        break;
                }

                for (auxc = ClipPolygon; auxc.next != null; auxc = auxc.next)
                {
                    if (auxc.intersect == 1)
                    {
                        auxc.entry = e;
                        e = 1 - e;
                    }
                }
                /*
                 * Remove the points we added at the beginnning to make it a closed polygon
                 */

                circle(SubjectPolygon);
                circle(ClipPolygon);

                /*
                 * Phase 3. Create the desired clipping polygon by filtering it out of the enhanced data structures of subject and clip polygon
                 */
                while ((crt = first(SubjectPolygon)) != SubjectPolygon)
                {
                old = null;
                    for (; crt.visited == 0; crt = crt.neighbor)
                        for (forward = crt.entry; ;)
                        {
                            newNode = create(crt.x, crt.y, old, null, null, null, 0,  0, 0, (float) 0.0);
                            old = newNode;
                            crt.visited = 1;
                            crt = forward == 1 ? crt.next : crt.prev;
                            if (crt.intersect == 1)
                            {
                                crt.visited = 1;
                                break;
                            }
                        }

                    old.nextPoly = ClipResultPolygon;
                    ClipResultPolygon = old;
                }

            }
        }


    }


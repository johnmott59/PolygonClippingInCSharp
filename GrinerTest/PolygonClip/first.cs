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
        node *first(node *p)
{
  node *aux=p;

  if (aux)
  do aux=aux->next;
  while(aux!=p && (!aux->intersect || aux->intersect && aux->visited));
  return aux;
}

#endif

        Node first(Node p)
        {
            Node aux = p;

            if (aux != null)
            {
                do aux = aux.next;
                while (aux != p && (aux.intersect == 0 || (aux.intersect == 1 && aux.visited == 1)));
            }

            return aux;

        }

    }
}

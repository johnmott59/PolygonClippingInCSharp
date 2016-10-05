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

        node *next_node(node *p)
{
  node *aux=p;
  while(aux && aux->intersect) aux=aux->next;
  return aux;
}

#endif

        Node next_node(Node p)
        {
            Node aux = p;
            while (aux != null && aux.intersect == 1)
            {
                aux = aux.next;
            }

            return aux;
        }

    }
}

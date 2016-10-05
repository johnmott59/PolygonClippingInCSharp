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
        node *last_node(node *p)
{
  node *aux=p;
  if(aux) while(aux->next) aux=aux->next;
  return aux;
}


#endif

        Node last_node(Node p)
        {
            Node aux = p;
            if (aux != null)
            {
                while (aux.next != null)
                {
                    aux = aux.next;
                }
            }
            return aux;
        }

    }
}

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
        void insert(node *ins, node *first, node *last)
{
  node *aux=first;
  while(aux != last && aux->alpha < ins->alpha) aux = aux->next;
  ins->next = aux;
  ins->prev = aux->prev;
  ins->prev->next = ins;
  ins->next->prev = ins;
} 
#endif
        void insert(Node ins,Node first,Node last)
        {
            Node aux = first;
            while (aux != last && aux.alpha < ins.alpha) aux = aux.next;
            ins.next = aux;
            ins.prev = aux.prev;
            /*
             * Feb 2017. Check against null pointer
             */
             if (ins.prev != null) {
                ins.prev.next = ins;
             }
             if (ins.next != null) {
                ins.next.prev = ins;
             }    
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrienerTest
{
    public class Node
    {
        public int x { get; set; }
        public int y { get; set; }
        public Node next { get; set; }
        public Node prev { get; set; }
        public Node nextPoly { get; set; }           // pointer to the next polygon
        public Node neighbor { get; set; }      // the coresponding intersection point

        public int intersect { get; set; }      // 1 if an intersection point, 0 otherwise 
        public int entry { get; set; }          // 1 if an entry point, 0 otherwise 
        public int visited { get; set; }        // 1 if the node has been visited, 0 otherwise 
        public float alpha { get; set; }        //  intersection point placement
    }

}

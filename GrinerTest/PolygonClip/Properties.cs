using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrienerTest
{

    public partial class PolygonClip
    {
        public enum eOperation
        {
            Intersection = 1,
            ClipMinusSubject = 2,
            Union = 3,
            SubjectMinusClip = 4
        };

        public eOperation Operation { get; set; } = eOperation.Intersection;

        public Node SubjectPolygon { get; set; }

        public Node ClipPolygon { get; set; }

        public Node ClipResultPolygon { get; set; }  // result of the  clip operation

    }
}

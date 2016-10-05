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
        float dist(float x1, float y1, float x2, float y2)
{
  return sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
} 

#endif
        float dist(float x1,float y1,float x2,float y2)
        {
            return (float) Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }

    }
}

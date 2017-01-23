# PolygonClippingInCSharp
A C# implementation of the Greiner Polygon Clipping Algorithm

I needed a polygon clipper for a project and found this one. I used this one because not only did it have psuedo code in the actual paper
but someone had written a version in C back in 1999. This code is actually a port from the C code.

Note: This implementation assumes that all points are positive. There is a note in the 'test' routine, which checks for
an intersection of a ray and a polygon, on the simple change needed to handle negative point values.

The paper is located here

http://www.inf.usi.ch/hormann/papers/Greiner.1998.ECO.pdf

The project with the C code is located here

http://davis.wpi.edu/~matt/courses/clipping/

The directory PolygonClip contains the 2 classes used for the project, and a Windows Form project demonstrates how to call the class. 

Hope this solves a problem for you :-)

I used this code in my project for procedural mesh generation at www.meshola.com 

John Mott
johnkmott@gmail.com

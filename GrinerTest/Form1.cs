using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace GrienerTest
{

    public partial class Form1 : Form
    {
        public enum eSelectPolygon
        {
            Source = 1,
            Clip = 2
        };

        List<Point> SourceList = new List<Point>();
        List<Point> ClipList = new List<Point>();
        List<Line> ResultLineList = new List<Line>();
        
        eSelectPolygon SelectedPolygon = eSelectPolygon.Source;

        Graphics g;
        Pen SourcePen = new Pen(Color.Blue, 3);
        Pen ClipPen = new Pen(Color.Green, 3);
        Pen ResultPen = new Pen(Color.Red, 3);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            SelectedPolygon = eSelectPolygon.Source;
            lblSelected.Text = "Subject Selected";
        }

        private void btnClip_Click(object sender, EventArgs e)
        {
            SelectedPolygon = eSelectPolygon.Clip ;
            lblSelected.Text = "Clip Selected";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            g = picBox.CreateGraphics();
        }

        public void DrawPoints(bool DrawResult)
        {

            g.Clear(Color.White);

            foreach (Point p in SourceList)
            {
                g.DrawRectangle(Pens.Black, p.X - 3, p.Y - 3, 6, 6);
            }

            foreach (Point p in ClipList)
            {
                g.DrawRectangle(Pens.Black, p.X - 3, p.Y - 3, 6, 6);
            }

            if (SourceList.Count > 1)
            {
                g.DrawLines(SourcePen, SourceList.ToArray());
                g.DrawLine(SourcePen,SourceList.Last().X, SourceList.Last().Y, SourceList.First().X, SourceList.First().Y);
            }

            if (ClipList.Count > 1)
            {
                g.DrawLines(ClipPen, ClipList.ToArray());
                g.DrawLine(ClipPen, ClipList.Last().X, ClipList.Last().Y, ClipList.First().X, ClipList.First().Y);
            }

            if (DrawResult && ResultLineList.Count > 1)
            {
                foreach (Line l in ResultLineList)
                {
                    g.DrawLine(ResultPen, l.From, l.To);
                }
            }
    
        }

        private void picBox_Click(object sender,  EventArgs me)
        {
            MouseEventArgs e = (MouseEventArgs)me;

            switch (SelectedPolygon)
            {
                case eSelectPolygon.Clip:
                    ClipList.Add(new Point(e.X, e.Y));
                    break;
                case eSelectPolygon.Source:
                    SourceList.Add(new Point(e.X, e.Y));
                    break;
            }

            DrawPoints(false);
           
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            SourceList.Clear();
            ClipList.Clear();
            ResultLineList.Clear();

            DrawPoints(true);
        }

        private void btnIntersection_Click(object sender, EventArgs e)
        {
            HandleOption(PolygonClip.eOperation.Intersection);
        }


        private void btnUnion_Click(object sender, EventArgs e)
        {
            HandleOption(PolygonClip.eOperation.Union);
          
        }

        private void btnCminusS_Click(object sender, EventArgs e)
        {
            HandleOption(PolygonClip.eOperation.ClipMinusSubject);
        }

        private void btnSMinusC_Click(object sender, EventArgs e)
        {
            HandleOption(PolygonClip.eOperation.SubjectMinusClip);
        }

        protected void HandleOption(PolygonClip.eOperation op)
        {

            PolygonClip oClip = new PolygonClip() { Operation = op };
            ResultLineList.Clear();

            DrawPoints(false);

            foreach (Point p in SourceList)
            {
                oClip.AddSource(p.X, p.Y);
            }

            foreach (Point p in ClipList)
            {
                oClip.AddClip(p.X, p.Y);
            }

            oClip.clip();

            for (Node poly = oClip.ClipResultPolygon; poly != null; poly = poly.nextPoly)
            {
                Node aux;
                for (aux = poly; aux.next != null; aux = aux.next)
                {
                    ResultLineList.Add(new Line() { From = new Point(aux.x, aux.y), To = new Point(aux.next.x, aux.next.y) });
                }
                ResultLineList.Add(new Line() { From = new Point(aux.x, aux.y), To = new Point(poly.x, poly.y) });
            }

            DrawPoints(true);
        }


    }
}

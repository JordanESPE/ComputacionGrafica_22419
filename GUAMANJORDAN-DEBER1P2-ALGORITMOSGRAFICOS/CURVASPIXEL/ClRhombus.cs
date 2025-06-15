using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURVASPIXEL
{
    internal class ClRhombus
    {
        public Point Center { get; set; }
        public int SizeHorizontal { get; set; }
        public int SizeVertical { get; set; }
        public List<Point> Vertices { get; private set; }

        public ClRhombus()
        {
            Center = new Point(0, 0);
            SizeHorizontal = 80;
            SizeVertical = 120;
            Vertices = new List<Point>();
        }

        public ClRhombus(Point center, int sizeHorizontal, int sizeVertical)
        {
            Center = center;
            SizeHorizontal = sizeHorizontal;
            SizeVertical = sizeVertical;
            Vertices = new List<Point>();
            CalculateVertices();
        }

        public void CalculateVertices()
        {
            Vertices.Clear();

            Vertices.Add(new Point(Center.X, Center.Y - SizeVertical));
            Vertices.Add(new Point(Center.X + SizeHorizontal, Center.Y));
            Vertices.Add(new Point(Center.X, Center.Y + SizeVertical));
            Vertices.Add(new Point(Center.X - SizeHorizontal, Center.Y));
        }

        public static ClRhombus CreateCenteredRombus(int canvasWidth, int canvasHeight)
        {
            Point center = new Point(canvasWidth / 2, canvasHeight / 2);

            int sizeHorizontal = Math.Min(canvasWidth, canvasHeight) / 5;
            int sizeVertical = Math.Min(canvasWidth, canvasHeight) / 3;

            return new ClRhombus(center, sizeHorizontal, sizeVertical);
        }

        public static ClRhombus CreateRombus(Point center, int sizeHorizontal, int sizeVertical)
        {
            return new ClRhombus(center, sizeHorizontal, sizeVertical);
        }

        public void DrawRombus(Graphics graphics, Pen pen)
        {
            if (Vertices.Count != 4)
            {
                CalculateVertices();
            }

            if (Vertices.Count == 4 && graphics != null && pen != null)
            {
                try
                {
                    Point[] points = Vertices.ToArray();
                    graphics.DrawPolygon(pen, points);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error al dibujar rombo: {ex.Message}");
                }
            }
        }

        public static void DrawRombus(Graphics graphics, List<Point> vertices, Pen pen)
        {
            if (vertices.Count != 4 || graphics == null || pen == null) return;

            try
            {
                Point[] points = vertices.ToArray();
                graphics.DrawPolygon(pen, points);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al dibujar rombo estático: {ex.Message}");
            }
        }

        public void FillRombus(Graphics graphics, Brush brush)
        {
            if (Vertices.Count != 4)
            {
                CalculateVertices();
            }

            if (Vertices.Count == 4 && graphics != null && brush != null)
            {
                try
                {
                    Point[] points = Vertices.ToArray();
                    graphics.FillPolygon(brush, points);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error al rellenar rombo: {ex.Message}");
                }
            }
        }

        public bool ContainsPoint(Point point)
        {
            if (Vertices.Count != 4)
            {
                CalculateVertices();
            }

            if (Vertices.Count != 4) return false;

            try
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddPolygon(Vertices.ToArray());
                    return path.IsVisible(point);
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsPointInside(List<Point> vertices, Point point)
        {
            if (vertices.Count != 4) return false;

            try
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddPolygon(vertices.ToArray());
                    return path.IsVisible(point);
                }
            }
            catch
            {
                return false;
            }
        }

        public bool IsWithinBounds(int canvasWidth, int canvasHeight)
        {
            if (Vertices.Count != 4)
            {
                CalculateVertices();
            }

            foreach (Point vertex in Vertices)
            {
                if (vertex.X < 0 || vertex.X >= canvasWidth ||
                    vertex.Y < 0 || vertex.Y >= canvasHeight)
                {
                    return false;
                }
            }
            return true;
        }

        public double GetArea()
        {
            int diagonalHorizontal = SizeHorizontal * 2;
            int diagonalVertical = SizeVertical * 2;
            return (diagonalHorizontal * diagonalVertical) / 2.0;
        }

        public override string ToString()
        {
            return $"Rombo: Centro({Center.X}, {Center.Y}), " +
                   $"Horizontal: {SizeHorizontal}, Vertical: {SizeVertical}, " +
                   $"Área: {GetArea():F2}";
        }

        public void Resize(int newSizeHorizontal, int newSizeVertical)
        {
            SizeHorizontal = newSizeHorizontal;
            SizeVertical = newSizeVertical;
            CalculateVertices();
        }

        public void MoveTo(Point newCenter)
        {
            Center = newCenter;
            CalculateVertices();
        }

        public List<Point> GetVertices()
        {
            if (Vertices.Count != 4)
            {
                CalculateVertices();
            }
            return new List<Point>(Vertices);
        }
    }
}
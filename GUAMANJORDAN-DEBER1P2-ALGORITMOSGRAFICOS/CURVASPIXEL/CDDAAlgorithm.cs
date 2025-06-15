using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURVASPIXEL
{
    internal class CDDAAlgorithm
    {
        public class DDAPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
            public double RealX { get; set; }
            public double RealY { get; set; }
            public int Step { get; set; }

            public DDAPoint(int x, int y, double realX, double realY, int step)
            {
                X = x;
                Y = y;
                RealX = realX;
                RealY = realY;
                Step = step;
            }
        }

        private List<DDAPoint> ddaPoints;
        private int gridSize;
        private int centerX;
        private int centerY;
        private const int MAX_COORDINATE = 20;

        public CDDAAlgorithm()
        {
            ddaPoints = new List<DDAPoint>();
            gridSize = 20;
        }

        public List<DDAPoint> CalculateDDALine(int x0, int y0, int xf, int yf)
        {
            ddaPoints.Clear();

            if (Math.Abs(x0) > MAX_COORDINATE || Math.Abs(y0) > MAX_COORDINATE ||
                Math.Abs(xf) > MAX_COORDINATE || Math.Abs(yf) > MAX_COORDINATE)
            {
                throw new ArgumentException($"Las coordenadas deben estar entre -{MAX_COORDINATE} y {MAX_COORDINATE}");
            }

            int dx = xf - x0;
            int dy = yf - y0;

            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            if (steps == 0)
            {
                ddaPoints.Add(new DDAPoint(x0, y0, x0, y0, 0));
                return ddaPoints;
            }

            double xIncrement = (double)dx / steps;
            double yIncrement = (double)dy / steps;

            double x = x0;
            double y = y0;

            for (int i = 0; i <= steps; i++)
            {
                int roundedX = (int)Math.Round(x);
                int roundedY = (int)Math.Round(y);
                ddaPoints.Add(new DDAPoint(roundedX, roundedY, x, y, i));

                x += xIncrement;
                y += yIncrement;
            }

            return ddaPoints;
        }

        public void DrawDDAVisualization(Graphics g, PictureBox canvas)
        {
            if (canvas == null || g == null) return;

            centerX = canvas.Width / 2;
            centerY = canvas.Height / 2;

            g.Clear(Color.White);
            DrawGrid(g, canvas.Width, canvas.Height);

            if (ddaPoints != null && ddaPoints.Count > 0)
            {
                DrawDDALine(g);
                DrawDDAPoints(g);
                DrawStartEndPoints(g);
            }
        }

        private void DrawGrid(Graphics g, int width, int height)
        {
            Pen gridPen = new Pen(Color.LightGray, 1);
            Pen mainGridPen = new Pen(Color.Gray, 1);
            Pen axisPen = new Pen(Color.Black, 3);

            for (int i = -MAX_COORDINATE; i <= MAX_COORDINATE; i++)
            {
                int x = centerX + (i * gridSize);
                if (x >= 0 && x <= width)
                {
                    Pen currentPen = (i % 5 == 0) ? mainGridPen : gridPen;
                    g.DrawLine(currentPen, x, 0, x, height);
                }
            }

            for (int i = -MAX_COORDINATE; i <= MAX_COORDINATE; i++)
            {
                int y = centerY - (i * gridSize);
                if (y >= 0 && y <= height)
                {
                    Pen currentPen = (i % 5 == 0) ? mainGridPen : gridPen;
                    g.DrawLine(currentPen, 0, y, width, y);
                }
            }

            g.DrawLine(axisPen, centerX, 0, centerX, height);
            g.DrawLine(axisPen, 0, centerY, width, centerY);

            DrawAxisNumbers(g, width, height);

            gridPen.Dispose();
            mainGridPen.Dispose();
            axisPen.Dispose();
        }

        private void DrawAxisNumbers(Graphics g, int width, int height)
        {
            Font font = new Font("Arial", 6, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);

            for (int i = -MAX_COORDINATE; i <= MAX_COORDINATE; i += 5)
            {
                if (i != 0)
                {
                    int x = centerX + (i * gridSize);
                    if (x >= 10 && x <= width - 10)
                    {
                        string text = i.ToString();
                        SizeF textSize = g.MeasureString(text, font);

                        float textX = x - textSize.Width / 2;
                        float textY = centerY + 3;

                        g.FillRectangle(Brushes.White, textX - 1, textY - 1, textSize.Width + 2, textSize.Height + 2);
                        g.DrawString(text, font, brush, textX, textY);
                    }
                }
            }

            for (int i = -MAX_COORDINATE; i <= MAX_COORDINATE; i += 5)
            {
                if (i != 0)
                {
                    int y = centerY - (i * gridSize);
                    if (y >= 10 && y <= height - 10)
                    {
                        string text = i.ToString();
                        SizeF textSize = g.MeasureString(text, font);

                        float textX = centerX - textSize.Width - 3;
                        float textY = y - textSize.Height / 2;

                        g.FillRectangle(Brushes.White, textX - 1, textY - 1, textSize.Width + 2, textSize.Height + 2);
                        g.DrawString(text, font, brush, textX, textY);
                    }
                }
            }

            string originText = "(0,0)";
            SizeF originSize = g.MeasureString(originText, font);
            g.FillRectangle(Brushes.White, centerX + 3, centerY + 3, originSize.Width + 2, originSize.Height + 2);
            g.DrawString(originText, font, brush, centerX + 4, centerY + 4);

            font.Dispose();
            brush.Dispose();
        }

        private void DrawDDALine(Graphics g)
        {
            if (ddaPoints.Count < 2) return;

            Pen linePen = new Pen(Color.Blue, 3);

            Point[] canvasPoints = new Point[ddaPoints.Count];

            for (int i = 0; i < ddaPoints.Count; i++)
            {
                var point = ddaPoints[i];
                canvasPoints[i] = new Point(
                    centerX + (point.X * gridSize),
                    centerY - (point.Y * gridSize)
                );
            }

            if (canvasPoints.Length > 1)
            {
                g.DrawLines(linePen, canvasPoints);
            }

            linePen.Dispose();
        }

        private void DrawDDAPoints(Graphics g)
        {
            Brush pointBrush = new SolidBrush(Color.Red);
            Brush numberBrush = new SolidBrush(Color.White);
            Font pointFont = new Font("Arial", 5, FontStyle.Bold);
            Font numberFont = new Font("Arial", 5, FontStyle.Bold);

            foreach (var point in ddaPoints)
            {
                int canvasX = centerX + (point.X * gridSize);
                int canvasY = centerY - (point.Y * gridSize);

                g.FillEllipse(pointBrush, canvasX - 5, canvasY - 5, 10, 10);
                g.DrawEllipse(Pens.DarkRed, canvasX - 5, canvasY - 5, 10, 10);

                string stepText = point.Step.ToString();
                SizeF stepSize = g.MeasureString(stepText, numberFont);
                g.DrawString(stepText, numberFont, numberBrush,
                           canvasX - stepSize.Width / 2,
                           canvasY - stepSize.Height / 2);

                if (point.Step == 0 || point.Step == ddaPoints.Count - 1 ||
                    (point.Step % 10 == 0 && ddaPoints.Count > 20))
                {
                    string coordText = $"({point.X},{point.Y})";
                    SizeF textSize = g.MeasureString(coordText, pointFont);

                    g.FillRectangle(new SolidBrush(Color.FromArgb(220, Color.Yellow)),
                                   canvasX - textSize.Width / 2 - 1,
                                   canvasY - 18,
                                   textSize.Width + 2,
                                   textSize.Height + 1);

                    g.DrawString(coordText, pointFont, Brushes.DarkBlue,
                               canvasX - textSize.Width / 2,
                               canvasY - 17);
                }
            }

            pointBrush.Dispose();
            numberBrush.Dispose();
            pointFont.Dispose();
            numberFont.Dispose();
        }

        private void DrawStartEndPoints(Graphics g)
        {
            if (ddaPoints.Count == 0) return;

            Brush startBrush = new SolidBrush(Color.Green);
            Brush endBrush = new SolidBrush(Color.Orange);
            Font labelFont = new Font("Arial", 7, FontStyle.Bold);

            var startPoint = ddaPoints.First();
            int startX = centerX + (startPoint.X * gridSize);
            int startY = centerY - (startPoint.Y * gridSize);

            g.FillEllipse(startBrush, startX - 8, startY - 8, 16, 16);
            g.DrawEllipse(Pens.DarkGreen, startX - 8, startY - 8, 16, 16);
            g.DrawString("S", labelFont, Brushes.White, startX - 5, startY - 5);

            var endPoint = ddaPoints.Last();
            int endX = centerX + (endPoint.X * gridSize);
            int endY = centerY - (endPoint.Y * gridSize);

            g.FillEllipse(endBrush, endX - 8, endY - 8, 16, 16);
            g.DrawEllipse(Pens.DarkOrange, endX - 8, endY - 8, 16, 16);
            g.DrawString("F", labelFont, Brushes.White, endX - 5, endY - 5);

            startBrush.Dispose();
            endBrush.Dispose();
            labelFont.Dispose();
        }

        public void ClearData()
        {
            ddaPoints.Clear();
        }

        public bool HasData => ddaPoints.Count > 0;

        public int PointCount => ddaPoints.Count;

        public List<DDAPoint> GetDDAPoints()
        {
            return new List<DDAPoint>(ddaPoints);
        }

        public int GetMaxCoordinate()
        {
            return MAX_COORDINATE;
        }
    }
}
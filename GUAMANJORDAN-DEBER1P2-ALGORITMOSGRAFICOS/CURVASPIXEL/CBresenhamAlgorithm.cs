using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURVASPIXEL
{
    internal class CBresenhamAlgorithm
    {
        public class BresenhamPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Step { get; set; }
            public int DecisionParameter { get; set; }
            public string Phase { get; set; }

            public BresenhamPoint(int x, int y, int step, int decisionParam, string phase)
            {
                X = x;
                Y = y;
                Step = step;
                DecisionParameter = decisionParam;
                Phase = phase;
            }
        }

        private List<BresenhamPoint> bresenhamPoints;
        private int gridSize;
        private int centerX;
        private int centerY;
        private const int MAX_COORDINATE = 20;

        public CBresenhamAlgorithm()
        {
            bresenhamPoints = new List<BresenhamPoint>();
            gridSize = 20;
        }

        public List<BresenhamPoint> CalculateBresenhamLine(int x0, int y0, int x1, int y1)
        {
            bresenhamPoints.Clear();

            if (Math.Abs(x0) > MAX_COORDINATE || Math.Abs(y0) > MAX_COORDINATE ||
                Math.Abs(x1) > MAX_COORDINATE || Math.Abs(y1) > MAX_COORDINATE)
            {
                throw new ArgumentException($"Las coordenadas deben estar entre -{MAX_COORDINATE} y {MAX_COORDINATE}");
            }

            int x, y, dx, dy, pk;
            int incE, incNE, stepx, stepy;

            dx = x1 - x0;
            dy = y1 - y0;

            if (dy < 0)
            {
                dy = -dy;
                stepy = -1;
            }
            else
            {
                stepy = 1;
            }

            if (dx < 0)
            {
                dx = -dx;
                stepx = -1;
            }
            else
            {
                stepx = 1;
            }

            x = x0;
            y = y0;

            int step = 0;
            bresenhamPoints.Add(new BresenhamPoint(x, y, step, 0, "Inicio"));

            if (dx > dy)
            {
                pk = 2 * dy - dx;
                incE = 2 * dy;
                incNE = 2 * (dy - dx);

                while (x != x1)
                {
                    x = x + stepx;
                    step++;

                    if (pk < 0)
                    {
                        pk = pk + incE;
                    }
                    else
                    {
                        y = y + stepy;
                        pk = pk + incNE;
                    }

                    bresenhamPoints.Add(new BresenhamPoint(x, y, step, pk, "dx>dy"));
                }
            }
            else
            {
                pk = 2 * dx - dy;
                incE = 2 * dx;
                incNE = 2 * (dx - dy);

                while (y != y1)
                {
                    y = y + stepy;
                    step++;

                    if (pk < 0)
                    {
                        pk = pk + incE;
                    }
                    else
                    {
                        x = x + stepx;
                        pk = pk + incNE;
                    }

                    bresenhamPoints.Add(new BresenhamPoint(x, y, step, pk, "dy≥dx"));
                }
            }

            return bresenhamPoints;
        }

        public void DrawBresenhamVisualization(Graphics g, PictureBox canvas)
        {
            if (canvas == null || g == null) return;

            centerX = canvas.Width / 2;
            centerY = canvas.Height / 2;

            g.Clear(Color.White);
            DrawGrid(g, canvas.Width, canvas.Height);

            if (bresenhamPoints != null && bresenhamPoints.Count > 0)
            {
                DrawBresenhamLine(g);
                DrawBresenhamPoints(g);
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

        private void DrawBresenhamLine(Graphics g)
        {
            if (bresenhamPoints.Count < 2) return;

            Pen linePen = new Pen(Color.Blue, 3);

            Point[] canvasPoints = new Point[bresenhamPoints.Count];

            for (int i = 0; i < bresenhamPoints.Count; i++)
            {
                var point = bresenhamPoints[i];
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

        private void DrawBresenhamPoints(Graphics g)
        {
            Brush pointBrush = new SolidBrush(Color.Red);
            Brush numberBrush = new SolidBrush(Color.White);
            Font pointFont = new Font("Arial", 5, FontStyle.Bold);
            Font numberFont = new Font("Arial", 6, FontStyle.Bold);

            foreach (var point in bresenhamPoints)
            {
                int canvasX = centerX + (point.X * gridSize);
                int canvasY = centerY - (point.Y * gridSize);

                g.FillEllipse(pointBrush, canvasX - 6, canvasY - 6, 12, 12);
                g.DrawEllipse(Pens.DarkRed, canvasX - 6, canvasY - 6, 12, 12);

                string stepText = point.Step.ToString();
                SizeF stepSize = g.MeasureString(stepText, numberFont);
                g.DrawString(stepText, numberFont, numberBrush,
                           canvasX - stepSize.Width / 2,
                           canvasY - stepSize.Height / 2);

                if (point.Step == 0 || point.Step == bresenhamPoints.Count - 1 ||
                    (point.Step % 5 == 0 && bresenhamPoints.Count > 10))
                {
                    string coordText = $"({point.X},{point.Y})";
                    SizeF textSize = g.MeasureString(coordText, pointFont);

                    g.FillRectangle(new SolidBrush(Color.FromArgb(200, Color.Yellow)),
                                   canvasX - textSize.Width / 2 - 1,
                                   canvasY - 20,
                                   textSize.Width + 2,
                                   textSize.Height + 1);

                    g.DrawString(coordText, pointFont, Brushes.DarkBlue,
                               canvasX - textSize.Width / 2,
                               canvasY - 19);
                }

                if (point.Step > 0)
                {
                    string paramText = $"Pk:{point.DecisionParameter}";
                    SizeF paramSize = g.MeasureString(paramText, pointFont);

                    g.FillRectangle(Brushes.White,
                                   canvasX - paramSize.Width / 2 - 1,
                                   canvasY + 8,
                                   paramSize.Width + 2,
                                   paramSize.Height + 1);

                    g.DrawString(paramText, pointFont,
                               point.DecisionParameter < 0 ? Brushes.Blue : Brushes.Red,
                               canvasX - paramSize.Width / 2,
                               canvasY + 9);
                }
            }

            pointBrush.Dispose();
            numberBrush.Dispose();
            pointFont.Dispose();
            numberFont.Dispose();
        }

        private void DrawStartEndPoints(Graphics g)
        {
            if (bresenhamPoints.Count == 0) return;

            Brush startBrush = new SolidBrush(Color.Green);
            Brush endBrush = new SolidBrush(Color.Orange);
            Font labelFont = new Font("Arial", 8, FontStyle.Bold);

            var startPoint = bresenhamPoints.First();
            int startX = centerX + (startPoint.X * gridSize);
            int startY = centerY - (startPoint.Y * gridSize);

            g.FillEllipse(startBrush, startX - 10, startY - 10, 20, 20);
            g.DrawEllipse(Pens.DarkGreen, startX - 10, startY - 10, 20, 20);
            g.DrawString("S", labelFont, Brushes.White, startX - 6, startY - 6);

            var endPoint = bresenhamPoints.Last();
            int endX = centerX + (endPoint.X * gridSize);
            int endY = centerY - (endPoint.Y * gridSize);

            g.FillEllipse(endBrush, endX - 10, endY - 10, 20, 20);
            g.DrawEllipse(Pens.DarkOrange, endX - 10, endY - 10, 20, 20);
            g.DrawString("F", labelFont, Brushes.White, endX - 6, endY - 6);

            startBrush.Dispose();
            endBrush.Dispose();
            labelFont.Dispose();
        }

        public void ClearData()
        {
            bresenhamPoints.Clear();
        }

        public bool HasData => bresenhamPoints.Count > 0;

        public int PointCount => bresenhamPoints.Count;

        public List<BresenhamPoint> GetBresenhamPoints()
        {
            return new List<BresenhamPoint>(bresenhamPoints);
        }

        public int GetMaxCoordinate()
        {
            return MAX_COORDINATE;
        }
    }
}
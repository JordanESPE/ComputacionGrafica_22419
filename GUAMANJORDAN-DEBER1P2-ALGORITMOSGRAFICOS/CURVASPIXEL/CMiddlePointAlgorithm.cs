using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURVASPIXEL
{
    internal class CMiddlePointAlgorithm
    {
        public class MiddlePointData
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Step { get; set; }
            public int DecisionParameter { get; set; }
            public string Direction { get; set; }

            public MiddlePointData(int x, int y, int step, int decisionParam, string direction)
            {
                X = x;
                Y = y;
                Step = step;
                DecisionParameter = decisionParam;
                Direction = direction;
            }
        }

        public class CircumferencePixel
        {
            public int X { get; set; }
            public int Y { get; set; }

            public CircumferencePixel(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        private List<MiddlePointData> algorithmSteps;
        private List<CircumferencePixel> circumferencePixels;
        private HashSet<Point> circumferenceSet;
        private HashSet<Point> interiorPixels;
        private HashSet<Point> paintedPixels;
        private Timer floodFillTimer;
        private Stack<Point> floodFillStack;
        private Point currentPixel;
        private bool isFloodFillActive;
        private int pixelSize;
        private int centerX;
        private int centerY;
        private int radius;
        private const int GRID_RANGE = 15;
        private bool paintMode = false;
        private PictureBox targetCanvas;
        private Color fillColor = Color.Red;
        private int paintStep;

        public CMiddlePointAlgorithm()
        {
            algorithmSteps = new List<MiddlePointData>();
            circumferencePixels = new List<CircumferencePixel>();
            circumferenceSet = new HashSet<Point>();
            interiorPixels = new HashSet<Point>();
            paintedPixels = new HashSet<Point>();
            floodFillStack = new Stack<Point>();
            pixelSize = 15;
            isFloodFillActive = false;
            paintStep = 0;

            floodFillTimer = new Timer();
            floodFillTimer.Interval = 800;
            floodFillTimer.Tick += FloodFillTimer_Tick;
        }

        public List<MiddlePointData> CalculateMiddlePointCircle(int xc, int yc, int r)
        {
            algorithmSteps.Clear();
            circumferencePixels.Clear();
            circumferenceSet.Clear();
            interiorPixels.Clear();
            paintedPixels.Clear();

            xc = 0;
            yc = 0;
            this.radius = r;

            int x = 0;
            int y = r;
            int p = 1 - r;
            int step = 0;

            algorithmSteps.Add(new MiddlePointData(x, y, step, p, "Inicial"));
            PlotSymmetricPoints(xc, yc, x, y, step);

            while (x < y)
            {
                x++;
                step++;

                if (p < 0)
                {
                    p = p + 2 * x + 1;
                    algorithmSteps.Add(new MiddlePointData(x, y, step, p, "E (Este)"));
                }
                else
                {
                    y--;
                    p = p + 2 * (x - y) + 1;
                    algorithmSteps.Add(new MiddlePointData(x, y, step, p, "SE (Sureste)"));
                }

                PlotSymmetricPoints(xc, yc, x, y, step);
            }

            GenerateInteriorPixels(xc, yc, r);
            circumferencePixels = circumferencePixels.OrderBy(pixel => pixel.X).ThenBy(pixel => pixel.Y).ToList();

            return algorithmSteps;
        }

        private void PlotSymmetricPoints(int xc, int yc, int x, int y, int step)
        {
            if (x == 0)
            {
                AddCircumferencePixel(xc, yc + y);
                AddCircumferencePixel(xc, yc - y);
                AddCircumferencePixel(xc + y, yc);
                AddCircumferencePixel(xc - y, yc);
            }
            else if (x == y)
            {
                AddCircumferencePixel(xc + x, yc + y);
                AddCircumferencePixel(xc - x, yc + y);
                AddCircumferencePixel(xc + x, yc - y);
                AddCircumferencePixel(xc - x, yc - y);
            }
            else
            {
                AddCircumferencePixel(xc + x, yc + y);
                AddCircumferencePixel(xc + y, yc + x);
                AddCircumferencePixel(xc + y, yc - x);
                AddCircumferencePixel(xc + x, yc - y);
                AddCircumferencePixel(xc - x, yc - y);
                AddCircumferencePixel(xc - y, yc - x);
                AddCircumferencePixel(xc - y, yc + x);
                AddCircumferencePixel(xc - x, yc + y);
            }
        }

        private void AddCircumferencePixel(int x, int y)
        {
            Point point = new Point(x, y);

            if (!circumferenceSet.Contains(point))
            {
                circumferencePixels.Add(new CircumferencePixel(x, y));
                circumferenceSet.Add(point);
            }
        }

        private void GenerateInteriorPixels(int xc, int yc, int r)
        {
            interiorPixels.Clear();

            for (int x = -r; x <= r; x++)
            {
                for (int y = -r; y <= r; y++)
                {
                    int distance = x * x + y * y;
                    Point point = new Point(xc + x, yc + y);

                    if (distance < r * r && !circumferenceSet.Contains(point))
                    {
                        interiorPixels.Add(point);
                    }
                }
            }
        }

        private bool IsOriginalColor(int x, int y)
        {
            Point point = new Point(x, y);
            return interiorPixels.Contains(point) && !paintedPixels.Contains(point);
        }

        private bool IsWithinBounds(int x, int y)
        {
            return x >= -GRID_RANGE && x <= GRID_RANGE && y >= -GRID_RANGE && y <= GRID_RANGE;
        }

        private void PaintPixel(int x, int y)
        {
            Point point = new Point(x, y);
            if (!paintedPixels.Contains(point))
            {
                paintedPixels.Add(point);
                paintStep++;
            }
        }

        public void StartFloodFill(int seedX, int seedY, PictureBox canvas)
        {
            if (!IsWithinBounds(seedX, seedY) || !IsOriginalColor(seedX, seedY))
            {
                return;
            }

            targetCanvas = canvas;
            floodFillStack.Clear();
            paintStep = 0;

            floodFillStack.Push(new Point(seedX, seedY));

            isFloodFillActive = true;
            floodFillTimer.Start();

            if (targetCanvas != null)
            {
                targetCanvas.Invalidate();
            }
        }

        private void FloodFillTimer_Tick(object sender, EventArgs e)
        {
            if (floodFillStack.Count == 0)
            {
                floodFillTimer.Stop();
                isFloodFillActive = false;
                return;
            }

            Point current = floodFillStack.Pop();
            int x = current.X;
            int y = current.Y;

            if (!IsWithinBounds(x, y) || !IsOriginalColor(x, y))
            {
                return;
            }

            PaintPixel(x, y);

            if (IsWithinBounds(x - 1, y) && IsOriginalColor(x - 1, y))
            {
                floodFillStack.Push(new Point(x - 1, y));
            }

            if (IsWithinBounds(x, y - 1) && IsOriginalColor(x, y - 1))
            {
                floodFillStack.Push(new Point(x, y - 1));
            }

            if (IsWithinBounds(x + 1, y) && IsOriginalColor(x + 1, y))
            {
                floodFillStack.Push(new Point(x + 1, y));
            }

            if (IsWithinBounds(x, y + 1) && IsOriginalColor(x, y + 1))
            {
                floodFillStack.Push(new Point(x, y + 1));
            }

            if (targetCanvas != null)
            {
                targetCanvas.Invalidate();
            }
        }

        public void SetPaintMode(bool enabled)
        {
            paintMode = enabled;
        }

        public bool IsPaintModeActive => paintMode;

        public void DrawMiddlePointVisualization(Graphics g, PictureBox canvas)
        {
            if (canvas == null || g == null) return;

            centerX = canvas.Width / 2;
            centerY = canvas.Height / 2;

            g.Clear(Color.White);

            DrawPixelGrid(g, canvas.Width, canvas.Height);

            if (circumferencePixels != null && circumferencePixels.Count > 0)
            {
                DrawCircleVisualization(g);
                DrawCircleCenter(g);
                DrawRadiusLine(g);
                DrawPaintedPixels(g);
            }
        }

        private void DrawPixelGrid(Graphics g, int width, int height)
        {
            Pen gridPen = new Pen(Color.LightGray, 1);
            Pen axisPen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 8, FontStyle.Regular);
            Brush textBrush = new SolidBrush(Color.Black);

            for (int x = -GRID_RANGE; x <= GRID_RANGE; x++)
            {
                int canvasX = centerX + (x * pixelSize);
                if (canvasX >= 0 && canvasX <= width)
                {
                    Pen currentPen = (x == 0) ? axisPen : gridPen;
                    g.DrawLine(currentPen, canvasX, 0, canvasX, height);

                    if (x % 5 == 0 && x != 0)
                    {
                        string text = x.ToString();
                        SizeF textSize = g.MeasureString(text, font);
                        g.DrawString(text, font, textBrush,
                                   canvasX - textSize.Width / 2,
                                   centerY + 5);
                    }
                }
            }

            for (int y = -GRID_RANGE; y <= GRID_RANGE; y++)
            {
                int canvasY = centerY - (y * pixelSize);
                if (canvasY >= 0 && canvasY <= height)
                {
                    Pen currentPen = (y == 0) ? axisPen : gridPen;
                    g.DrawLine(currentPen, 0, canvasY, width, canvasY);

                    if (y % 5 == 0 && y != 0)
                    {
                        string text = y.ToString();
                        SizeF textSize = g.MeasureString(text, font);
                        g.DrawString(text, font, textBrush,
                                   centerX - textSize.Width - 5,
                                   canvasY - textSize.Height / 2);
                    }
                }
            }

            g.DrawString("(0,0)", font, textBrush, centerX + 5, centerY + 5);

            gridPen.Dispose();
            axisPen.Dispose();
            font.Dispose();
            textBrush.Dispose();
        }

        private void DrawCircleVisualization(Graphics g)
        {
            Brush borderBrush = new SolidBrush(Color.Blue);
            Brush interiorBrush = new SolidBrush(Color.LightGray);
            Pen pixelBorder = new Pen(Color.Black, 1);

            foreach (var point in interiorPixels)
            {
                Rectangle pixelRect = GetPixelRectangle(point.X, point.Y);
                g.FillRectangle(interiorBrush, pixelRect);
                g.DrawRectangle(pixelBorder, pixelRect);
            }

            foreach (var point in circumferenceSet)
            {
                Rectangle pixelRect = GetPixelRectangle(point.X, point.Y);
                g.FillRectangle(borderBrush, pixelRect);
                g.DrawRectangle(pixelBorder, pixelRect);
            }

            borderBrush.Dispose();
            interiorBrush.Dispose();
            pixelBorder.Dispose();
        }

        private void DrawPaintedPixels(Graphics g)
        {
            Brush paintBrush = new SolidBrush(fillColor);
            Pen pixelBorder = new Pen(Color.Black, 1);

            foreach (var point in paintedPixels)
            {
                Rectangle pixelRect = GetPixelRectangle(point.X, point.Y);
                g.FillRectangle(paintBrush, pixelRect);
                g.DrawRectangle(pixelBorder, pixelRect);
            }

            paintBrush.Dispose();
            pixelBorder.Dispose();
        }

        private Rectangle GetPixelRectangle(int gridX, int gridY)
        {
            int canvasX = centerX + (gridX * pixelSize);
            int canvasY = centerY - (gridY * pixelSize);

            return new Rectangle(
                canvasX - pixelSize / 2,
                canvasY - pixelSize / 2,
                pixelSize,
                pixelSize
            );
        }

        private void DrawCircleCenter(Graphics g)
        {
            Brush centerBrush = new SolidBrush(Color.Green);
            Font labelFont = new Font("Arial", 9, FontStyle.Bold);

            g.FillEllipse(centerBrush, centerX - 4, centerY - 4, 8, 8);
            g.DrawString("Centro", labelFont, centerBrush, centerX + 10, centerY - 10);

            centerBrush.Dispose();
            labelFont.Dispose();
        }

        private void DrawRadiusLine(Graphics g)
        {
            Pen radiusPen = new Pen(Color.Orange, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

            int radiusEndX = centerX;
            int radiusEndY = centerY - (radius * pixelSize);

            g.DrawLine(radiusPen, centerX, centerY, radiusEndX, radiusEndY);

            Font radiusFont = new Font("Arial", 8, FontStyle.Bold);
            g.DrawString($"R={radius}", radiusFont, Brushes.Orange, centerX + 5, (centerY + radiusEndY) / 2);

            radiusFont.Dispose();
            radiusPen.Dispose();
        }

        public Point CanvasToGrid(int canvasX, int canvasY, int canvasCenterX, int canvasCenterY)
        {
            int relativeX = canvasX - canvasCenterX;
            int relativeY = canvasCenterY - canvasY;

            int gridX = (int)Math.Round((double)relativeX / pixelSize);
            int gridY = (int)Math.Round((double)relativeY / pixelSize);

            return new Point(gridX, gridY);
        }

        public List<CircumferencePixel> GetCircumferencePixels()
        {
            return new List<CircumferencePixel>(circumferencePixels);
        }

        public List<MiddlePointData> GetAlgorithmSteps()
        {
            return new List<MiddlePointData>(algorithmSteps);
        }

        public void ClearData()
        {
            floodFillTimer.Stop();
            algorithmSteps.Clear();
            circumferencePixels.Clear();
            circumferenceSet.Clear();
            interiorPixels.Clear();
            paintedPixels.Clear();
            floodFillStack.Clear();
            paintMode = false;
            isFloodFillActive = false;
            paintStep = 0;
        }

        public bool HasData => algorithmSteps.Count > 0;
        public int PointCount => circumferencePixels.Count;
        public int GetMaxCoordinate() => GRID_RANGE;
        public int GetPaintedPixelCount() => paintedPixels.Count;
        public bool IsFloodFillActive() => isFloodFillActive;

        public bool IsPointInsideCircle(int gridX, int gridY)
        {
            return interiorPixels.Contains(new Point(gridX, gridY));
        }
    }
}
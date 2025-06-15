using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CURVASPIXEL
{
    internal class CFloodFill
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private PictureBox pictureBox;
        private int delay;
        private CancellationTokenSource cancellationTokenSource;
        private bool isRunning = false;
        private int pixelCount = 0;

        public CFloodFill(Bitmap bitmap, Graphics graphics, PictureBox pictureBox, int delay = 5)
        {
            this.bitmap = bitmap;
            this.graphics = graphics;
            this.pictureBox = pictureBox;
            this.delay = delay;
            this.cancellationTokenSource = new CancellationTokenSource();
        }

        public async Task<List<Point>> Mi_FloodFill(int x, int y, Color originalColor, Color fillColor, CancellationToken cancellationToken)
        {
            Stack<Point> stack = new Stack<Point>();
            HashSet<Point> visited = new HashSet<Point>();
            List<Point> filledPixels = new List<Point>();

            stack.Push(new Point(x, y));

            while (stack.Count > 0 && !cancellationToken.IsCancellationRequested)
            {
                Point current = stack.Pop();
                int currentX = current.X;
                int currentY = current.Y;

                if (currentX < 0 || currentX >= bitmap.Width ||
                    currentY < 0 || currentY >= bitmap.Height)
                    continue;

                if (visited.Contains(current))
                    continue;

                Color currentColor;
                try
                {
                    currentColor = bitmap.GetPixel(currentX, currentY);
                }
                catch
                {
                    continue;
                }

                if (currentColor.ToArgb() != originalColor.ToArgb())
                    continue;

                visited.Add(current);

                try
                {
                    bitmap.SetPixel(currentX, currentY, fillColor);
                    filledPixels.Add(new Point(currentX, currentY));
                    pixelCount++;
                }
                catch
                {
                    continue;
                }

                if (cancellationToken.IsCancellationRequested)
                    break;

                if (pixelCount % 15 == 0)
                {
                    try
                    {
                        if (pictureBox != null && !pictureBox.IsDisposed)
                        {
                            pictureBox.Invalidate();
                            Application.DoEvents();

                            if (delay > 0 && !cancellationToken.IsCancellationRequested)
                            {
                                await Task.Delay(delay, cancellationToken);
                            }
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        break;
                    }
                    catch { }
                }

                stack.Push(new Point(currentX - 1, currentY));
                stack.Push(new Point(currentX, currentY + 1));
                stack.Push(new Point(currentX + 1, currentY));
                stack.Push(new Point(currentX, currentY - 1));
            }

            return filledPixels;
        }

        public async Task<List<Point>> FloodFillAnimatedAsync(int x, int y, Color fillColor)
        {
            if (isRunning)
            {
                StopFloodFill();
                await Task.Delay(200);
            }

            if (x < 0 || x >= bitmap.Width || y < 0 || y >= bitmap.Height)
            {
                return new List<Point>();
            }

            Color originalColor;
            try
            {
                originalColor = bitmap.GetPixel(x, y);
            }
            catch (Exception)
            {
                return new List<Point>();
            }

            if (originalColor.ToArgb() == fillColor.ToArgb())
                return new List<Point>();

            if (originalColor.ToArgb() == Color.Black.ToArgb())
                return new List<Point>();

            if (originalColor.ToArgb() != Color.White.ToArgb())
            {
                return new List<Point>();
            }

            cancellationTokenSource?.Dispose();
            cancellationTokenSource = new CancellationTokenSource();
            isRunning = true;
            pixelCount = 0;

            List<Point> filledPixels = new List<Point>();

            try
            {
                filledPixels = await Mi_FloodFill(x, y, originalColor, fillColor, cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception)
            {
            }
            finally
            {
                isRunning = false;

                try
                {
                    if (pictureBox != null && !pictureBox.IsDisposed)
                    {
                        pictureBox.Invalidate();
                        Application.DoEvents();
                    }
                }
                catch { }
            }

            return filledPixels;
        }

        public async void FloodFillAnimated(int x, int y, Color fillColor)
        {
            await FloodFillAnimatedAsync(x, y, fillColor);
        }

        public void StopFloodFill()
        {
            if (isRunning && cancellationTokenSource != null)
            {
                try
                {
                    cancellationTokenSource.Cancel();

                    int attempts = 0;
                    while (isRunning && attempts < 50)
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(50);
                        attempts++;
                    }

                    if (pictureBox != null && !pictureBox.IsDisposed)
                    {
                        pictureBox.Invalidate();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        public bool IsRunning() => isRunning;

        public string GetStats()
        {
            return $"Píxeles: {pixelCount}, Estado: {(isRunning ? "Ejecutando" : "Detenido")}";
        }

        public void SetDelay(int newDelay)
        {
            this.delay = Math.Max(0, Math.Min(newDelay, 50));
        }

        public void Dispose()
        {
            try
            {
                StopFloodFill();
                cancellationTokenSource?.Dispose();
            }
            catch { }
        }
    }
}
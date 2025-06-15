using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURVASPIXEL
{
    public partial class frmPoligons : Form
    {
        private ClRhombus rombo;
        private Graphics canvasGraphics;
        private Bitmap canvasBitmap;
        private CFloodFill floodFill;
        private bool romboDrawn = false;
        private bool fillModeActive = false;

        public frmPoligons()
        {
            InitializeComponent();
        }

        private void frmPoligons_Load(object sender, EventArgs e)
        {
            InitializeCanvas();
            SetupPixelDataGridView();
        }

        private void SetupPixelDataGridView()
        {
            dgvPixels.Columns.Clear();

            dgvPixels.Columns.Add("colIndex", "No.");
            dgvPixels.Columns.Add("colX", "X");
            dgvPixels.Columns.Add("colY", "Y");

            dgvPixels.Columns["colIndex"].Width = 60;
            dgvPixels.Columns["colX"].Width = 80;
            dgvPixels.Columns["colY"].Width = 80;

            dgvPixels.AllowUserToAddRows = false;
            dgvPixels.AllowUserToDeleteRows = false;
            dgvPixels.ReadOnly = true;
            dgvPixels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPixels.MultiSelect = false;
            dgvPixels.RowHeadersVisible = false;

            dgvPixels.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dgvPixels.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPixels.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvPixels.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPixels.DefaultCellStyle.Font = new Font("Arial", 8);
            dgvPixels.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPixels.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            dgvPixels.GridColor = Color.Orange;
            dgvPixels.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvPixels.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            foreach (DataGridViewColumn column in dgvPixels.Columns)
            {
                column.ReadOnly = true;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            UpdatePixelCount(0);
        }

        private void UpdatePixelTable(List<Point> filledPixels)
        {
            dgvPixels.Rows.Clear();

            var sortedPixels = filledPixels.OrderBy(p => p.Y).ThenBy(p => p.X).ToList();

            for (int i = 0; i < sortedPixels.Count; i++)
            {
                var pixel = sortedPixels[i];
                int rowIndex = dgvPixels.Rows.Add(i + 1, pixel.X, pixel.Y);

                if (i % 2 == 0)
                {
                    dgvPixels.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }

            UpdatePixelCount(filledPixels.Count);

            if (dgvPixels.Rows.Count > 0)
            {
                dgvPixels.FirstDisplayedScrollingRowIndex = Math.Max(0, dgvPixels.Rows.Count - 10);
            }
        }

        private void UpdatePixelCount(int count)
        {
            lblPixelCount.Text = $"Total Píxeles: {count}";
        }

        private void InitializeCanvas()
        {
            canvasBitmap = new Bitmap(picCanvasPoligon.Width, picCanvasPoligon.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);
            picCanvasPoligon.Image = canvasBitmap;

            try
            {
                floodFill?.StopFloodFill();
                floodFill?.Dispose();
            }
            catch { }

            floodFill = new CFloodFill(canvasBitmap, canvasGraphics, picCanvasPoligon, 5);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    floodFill?.StopFloodFill();
                }
                catch { }

                canvasGraphics.Clear(Color.White);
                dgvPixels.Rows.Clear();
                UpdatePixelCount(0);

                rombo = ClRhombus.CreateCenteredRombus(picCanvasPoligon.Width, picCanvasPoligon.Height);

                using (Pen pen = new Pen(Color.Black, 4))
                {
                    rombo.DrawRombus(canvasGraphics, pen);
                }

                picCanvasPoligon.Invalidate();
                romboDrawn = true;
                fillModeActive = false;
            }
            catch (Exception)
            {
            }
        }

        private void btnFillOut_Click(object sender, EventArgs e)
        {
            if (!romboDrawn || rombo == null)
            {
                return;
            }

            if (floodFill != null && floodFill.IsRunning())
            {
                return;
            }

            fillModeActive = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                btnDraw.Enabled = false;
                btnFillOut.Enabled = false;
                btnReset.Enabled = false;

                if (floodFill != null)
                {
                    try
                    {
                        floodFill.StopFloodFill();

                        int attempts = 0;
                        while (floodFill.IsRunning() && attempts < 30)
                        {
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(100);
                            attempts++;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }

                rombo = null;
                romboDrawn = false;
                fillModeActive = false;
                dgvPixels.Rows.Clear();
                UpdatePixelCount(0);

                try
                {
                    canvasGraphics.Clear(Color.White);
                    picCanvasPoligon.Invalidate();
                    Application.DoEvents();
                }
                catch (Exception)
                {
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                btnDraw.Enabled = true;
                btnFillOut.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                floodFill?.StopFloodFill();
                floodFill?.Dispose();
            }
            catch { }

            this.Close();
        }

        private async void picCanvasPoligon_Click(object sender, EventArgs e)
        {
            if (!romboDrawn || rombo == null)
            {
                return;
            }

            if (!fillModeActive)
            {
                return;
            }

            if (floodFill != null && floodFill.IsRunning())
            {
                return;
            }

            MouseEventArgs mouseArgs = e as MouseEventArgs;
            if (mouseArgs != null)
            {
                int x = mouseArgs.X;
                int y = mouseArgs.Y;
                Point clickPoint = new Point(x, y);

                if (x >= 0 && x < canvasBitmap.Width && y >= 0 && y < canvasBitmap.Height)
                {
                    try
                    {
                        if (rombo == null)
                        {
                            return;
                        }

                        if (!rombo.ContainsPoint(clickPoint))
                        {
                            return;
                        }

                        Color clickedColor = canvasBitmap.GetPixel(x, y);
                        if (clickedColor.ToArgb() != Color.White.ToArgb())
                        {
                            return;
                        }

                        btnDraw.Enabled = false;
                        btnFillOut.Enabled = false;

                        dgvPixels.Rows.Clear();
                        UpdatePixelCount(0);

                        var filledPixels = await floodFill.FloodFillAnimatedAsync(x, y, Color.Orange);

                        try
                        {
                            if (rombo != null && romboDrawn)
                            {
                                using (Pen pen = new Pen(Color.Black, 4))
                                {
                                    rombo.DrawRombus(canvasGraphics, pen);
                                }
                                picCanvasPoligon.Invalidate();
                                fillModeActive = false;

                                if (filledPixels != null && filledPixels.Count > 0)
                                {
                                    UpdatePixelTable(filledPixels);
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }

                        btnDraw.Enabled = true;
                        btnFillOut.Enabled = true;

                    }
                    catch (Exception)
                    {
                        btnDraw.Enabled = true;
                        btnFillOut.Enabled = true;
                    }
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            try
            {
                floodFill?.StopFloodFill();
                floodFill?.Dispose();
                canvasGraphics?.Dispose();
                canvasBitmap?.Dispose();
            }
            catch { }

            base.OnFormClosed(e);
        }
    }
}
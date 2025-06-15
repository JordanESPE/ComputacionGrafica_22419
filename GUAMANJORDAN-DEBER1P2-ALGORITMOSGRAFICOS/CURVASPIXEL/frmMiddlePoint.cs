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
    public partial class frmMiddlePoint : Form
    {
        private CMiddlePointAlgorithm middlePointAlgorithm;

        public frmMiddlePoint()
        {
            InitializeComponent();
            middlePointAlgorithm = new CMiddlePointAlgorithm();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridViewPixels.Columns.Clear();
            dataGridViewPixels.Columns.Add("X", "X");
            dataGridViewPixels.Columns.Add("Y", "Y");

            dataGridViewPixels.Columns["X"].Width = 100;
            dataGridViewPixels.Columns["Y"].Width = 100;

            dataGridViewPixels.BackgroundColor = Color.White;
            dataGridViewPixels.GridColor = Color.LightGray;
            dataGridViewPixels.DefaultCellStyle.Font = new Font("Consolas", 12, FontStyle.Bold);
            dataGridViewPixels.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPixels.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridViewPixels.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridViewPixels.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPixels.RowHeadersVisible = false;
        }

        private void frmMiddlePointcs_Load(object sender, EventArgs e)
        {
            if (picCanvasMiddlePoint != null)
            {
                picCanvasMiddlePoint.Paint += PicCanvasMiddlePoint_Paint;
                picCanvasMiddlePoint.BackColor = Color.White;
            }

            btnPaint.Enabled = false;
            UpdatePaintButtonText();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    textBox3.BackColor = Color.LightPink;
                    return;
                }

                int radius = int.Parse(textBox3.Text);

                if (radius <= 0)
                {
                    textBox3.BackColor = Color.LightPink;
                    return;
                }

                int maxRadius = middlePointAlgorithm.GetMaxCoordinate();
                if (radius > maxRadius)
                {
                    textBox3.BackColor = Color.LightPink;
                    return;
                }

                textBox3.BackColor = Color.White;
                middlePointAlgorithm.CalculateMiddlePointCircle(0, 0, radius);
                UpdatePixelTable();

                btnPaint.Enabled = true;
                UpdatePaintButtonText();

                if (picCanvasMiddlePoint != null)
                {
                    picCanvasMiddlePoint.Invalidate();
                }
            }
            catch (FormatException)
            {
                textBox3.BackColor = Color.LightPink;
            }
            catch (Exception)
            {
                textBox3.BackColor = Color.LightPink;
            }
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!middlePointAlgorithm.HasData)
                {
                    return;
                }

                bool newPaintMode = !middlePointAlgorithm.IsPaintModeActive;
                middlePointAlgorithm.SetPaintMode(newPaintMode);
                UpdatePaintButtonText();
            }
            catch (Exception)
            {
            }
        }

        private void UpdatePaintButtonText()
        {
            if (middlePointAlgorithm.IsPaintModeActive)
            {
                btnPaint.Text = "Desactivar";
                btnPaint.BackColor = Color.LightCoral;
            }
            else
            {
                btnPaint.Text = "Activar";
                btnPaint.BackColor = Color.LightGreen;
            }
        }

        private void picCanvasMiddlePoint_Click(object sender, EventArgs e)
        {
            if (!middlePointAlgorithm.IsPaintModeActive || !middlePointAlgorithm.HasData)
                return;

            MouseEventArgs mouseArgs = e as MouseEventArgs;
            if (mouseArgs == null) return;

            if (middlePointAlgorithm.IsFloodFillActive())
            {
                return;
            }

            int canvasCenterX = picCanvasMiddlePoint.Width / 2;
            int canvasCenterY = picCanvasMiddlePoint.Height / 2;

            Point gridPoint = middlePointAlgorithm.CanvasToGrid(
                mouseArgs.X, mouseArgs.Y, canvasCenterX, canvasCenterY);

            middlePointAlgorithm.StartFloodFill(gridPoint.X, gridPoint.Y, picCanvasMiddlePoint);
        }

        private void UpdatePixelTable()
        {
            dataGridViewPixels.Rows.Clear();
            var circumferencePixels = middlePointAlgorithm.GetCircumferencePixels();

            foreach (var pixel in circumferencePixels)
            {
                dataGridViewPixels.Rows.Add(pixel.X, pixel.Y);
            }

            for (int i = 0; i < dataGridViewPixels.Rows.Count; i++)
            {
                if (i % 2 == 1)
                {
                    dataGridViewPixels.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
                }
            }
        }

        private void PicCanvasMiddlePoint_Paint(object sender, PaintEventArgs e)
        {
            middlePointAlgorithm.DrawMiddlePointVisualization(e.Graphics, picCanvasMiddlePoint);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.BackColor = Color.White;
            textBox3.Focus();
            middlePointAlgorithm.ClearData();
            btnPaint.Enabled = false;
            UpdatePaintButtonText();

            dataGridViewPixels.Rows.Clear();

            this.Text = "Algoritmo Punto Medio - Círculos (Centro: 0,0)";

            if (picCanvasMiddlePoint != null)
            {
                picCanvasMiddlePoint.Invalidate();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                if (!int.TryParse(textBox3.Text, out int value) || value <= 0)
                {
                    textBox3.BackColor = Color.LightPink;
                }
                else
                {
                    textBox3.BackColor = Color.White;
                }
            }
            else
            {
                textBox3.BackColor = Color.White;
            }
        }
    }
}
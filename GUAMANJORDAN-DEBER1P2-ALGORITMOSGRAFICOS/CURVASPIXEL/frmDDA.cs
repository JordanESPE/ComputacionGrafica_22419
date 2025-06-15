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
    public partial class frmDDA : Form
    {
        private CDDAAlgorithm ddaAlgorithm;

        public frmDDA()
        {
            InitializeComponent();
            ddaAlgorithm = new CDDAAlgorithm();
        }

        private void frmDDA_Load(object sender, EventArgs e)
        {
            if (picCanvasDDA != null)
            {
                picCanvasDDA.Paint += PicCanvasDDA_Paint;
                picCanvasDDA.BackColor = Color.White;
            }

            SetupStaticDataGridView();
        }

        private void SetupStaticDataGridView()
        {
            dgvPixels.Columns.Clear();

            dgvPixels.Columns.Add("colStep", "Paso");
            dgvPixels.Columns.Add("colX", "X");
            dgvPixels.Columns.Add("colY", "Y");
            dgvPixels.Columns.Add("colRealX", "X Real");
            dgvPixels.Columns.Add("colRealY", "Y Real");

            dgvPixels.Columns["colStep"].Width = 60;
            dgvPixels.Columns["colX"].Width = 50;
            dgvPixels.Columns["colY"].Width = 50;
            dgvPixels.Columns["colRealX"].Width = 80;
            dgvPixels.Columns["colRealY"].Width = 80;

            dgvPixels.AllowUserToAddRows = false;
            dgvPixels.AllowUserToDeleteRows = false;
            dgvPixels.ReadOnly = true;
            dgvPixels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPixels.MultiSelect = false;
            dgvPixels.RowHeadersVisible = false;

            dgvPixels.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvPixels.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPixels.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvPixels.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPixels.DefaultCellStyle.Font = new Font("Arial", 9);
            dgvPixels.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPixels.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            dgvPixels.GridColor = Color.DarkBlue;
            dgvPixels.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvPixels.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            foreach (DataGridViewColumn column in dgvPixels.Columns)
            {
                column.ReadOnly = true;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtXo.Text) || string.IsNullOrEmpty(txtYo.Text) ||
                    string.IsNullOrEmpty(txtXf.Text) || string.IsNullOrEmpty(txtYf.Text))
                {
                    return;
                }

                int x0 = int.Parse(txtXo.Text);
                int y0 = int.Parse(txtYo.Text);
                int xf = int.Parse(txtXf.Text);
                int yf = int.Parse(txtYf.Text);

                int maxCoord = ddaAlgorithm.GetMaxCoordinate();
                if (Math.Abs(x0) > maxCoord || Math.Abs(y0) > maxCoord ||
                    Math.Abs(xf) > maxCoord || Math.Abs(yf) > maxCoord)
                {
                    return;
                }

                ddaAlgorithm.CalculateDDALine(x0, y0, xf, yf);
                UpdateStaticPixelTable();

                if (picCanvasDDA != null)
                {
                    picCanvasDDA.Invalidate();
                }
            }
            catch (FormatException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void UpdateStaticPixelTable()
        {
            dgvPixels.Rows.Clear();

            if (ddaAlgorithm.HasData)
            {
                var points = ddaAlgorithm.GetDDAPoints();

                foreach (var point in points)
                {
                    int rowIndex = dgvPixels.Rows.Add(
                        point.Step,
                        point.X,
                        point.Y,
                        point.RealX.ToString("F2"),
                        point.RealY.ToString("F2")
                    );

                    if (point.Step == 0)
                    {
                        dgvPixels.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        dgvPixels.Rows[rowIndex].DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                    }
                    else if (point.Step == points.Count - 1)
                    {
                        dgvPixels.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        dgvPixels.Rows[rowIndex].DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                    }
                }

                if (dgvPixels.Rows.Count > 0)
                {
                    dgvPixels.FirstDisplayedScrollingRowIndex = 0;
                }
            }
        }

        private void PicCanvasDDA_Paint(object sender, PaintEventArgs e)
        {
            ddaAlgorithm.DrawDDAVisualization(e.Graphics, picCanvasDDA);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtXo.Clear();
            txtYo.Clear();
            txtXf.Clear();
            txtYf.Clear();
            txtXo.Focus();

            ddaAlgorithm.ClearData();
            dgvPixels.Rows.Clear();

            if (picCanvasDDA != null)
            {
                picCanvasDDA.Invalidate();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtYo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtXf_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtYf_TextChanged(object sender, EventArgs e)
        {
        }

        private void picCanvasDDA_Click(object sender, EventArgs e)
        {
        }
    }
}
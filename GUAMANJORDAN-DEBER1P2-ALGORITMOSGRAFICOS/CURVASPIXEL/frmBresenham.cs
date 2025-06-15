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
    public partial class frmBresenham : Form
    {
        private CBresenhamAlgorithm bresenhamAlgorithm;

        public frmBresenham()
        {
            InitializeComponent();
            bresenhamAlgorithm = new CBresenhamAlgorithm();
        }

        private void frmBresenham_Load(object sender, EventArgs e)
        {
            if (picCanvasBresenham != null)
            {
                picCanvasBresenham.Paint += PicCanvasBresenham_Paint;
                picCanvasBresenham.BackColor = Color.White;
            }

            SetupStaticDataGridView();
        }

        private void SetupStaticDataGridView()
        {
            dgvPixels.Columns.Clear();

            dgvPixels.Columns.Add("colStep", "Paso");
            dgvPixels.Columns.Add("colX", "X");
            dgvPixels.Columns.Add("colY", "Y");
            dgvPixels.Columns.Add("colPk", "Pk");
            dgvPixels.Columns.Add("colDecision", "Decisión");
            dgvPixels.Columns.Add("colAction", "Acción");

            dgvPixels.Columns["colStep"].Width = 50;
            dgvPixels.Columns["colX"].Width = 40;
            dgvPixels.Columns["colY"].Width = 40;
            dgvPixels.Columns["colPk"].Width = 50;
            dgvPixels.Columns["colDecision"].Width = 80;
            dgvPixels.Columns["colAction"].Width = 100;

            dgvPixels.AllowUserToAddRows = false;
            dgvPixels.AllowUserToDeleteRows = false;
            dgvPixels.ReadOnly = true;
            dgvPixels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPixels.MultiSelect = false;
            dgvPixels.RowHeadersVisible = false;

            dgvPixels.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dgvPixels.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPixels.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvPixels.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPixels.DefaultCellStyle.Font = new Font("Arial", 8);
            dgvPixels.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPixels.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;

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

                int maxCoord = bresenhamAlgorithm.GetMaxCoordinate();
                if (Math.Abs(x0) > maxCoord || Math.Abs(y0) > maxCoord ||
                    Math.Abs(xf) > maxCoord || Math.Abs(yf) > maxCoord)
                {
                    return;
                }

                bresenhamAlgorithm.CalculateBresenhamLine(x0, y0, xf, yf);
                UpdateStaticPixelTable();

                if (picCanvasBresenham != null)
                {
                    picCanvasBresenham.Invalidate();
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

            if (bresenhamAlgorithm.HasData)
            {
                var points = bresenhamAlgorithm.GetBresenhamPoints();

                foreach (var point in points)
                {
                    string decision = "";
                    string action = "";

                    if (point.Step == 0)
                    {
                        decision = "Inicio";
                        action = "Punto inicial";
                    }
                    else
                    {
                        if (point.DecisionParameter < 0)
                        {
                            decision = "Pk < 0";
                            action = point.Phase == "dx>dy" ? "Solo avanza X" : "Solo avanza Y";
                        }
                        else
                        {
                            decision = "Pk ≥ 0";
                            action = "Avanza X e Y";
                        }
                    }

                    int rowIndex = dgvPixels.Rows.Add(
                        point.Step,
                        point.X,
                        point.Y,
                        point.Step == 0 ? "P0" : point.DecisionParameter.ToString(),
                        decision,
                        action
                    );

                    if (point.Step == 0)
                    {
                        dgvPixels.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        dgvPixels.Rows[rowIndex].DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
                    }
                    else if (point.Step == points.Count - 1)
                    {
                        dgvPixels.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        dgvPixels.Rows[rowIndex].DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
                    }
                    else if (point.DecisionParameter >= 0)
                    {
                        dgvPixels.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }

                if (dgvPixels.Rows.Count > 0)
                {
                    dgvPixels.FirstDisplayedScrollingRowIndex = 0;
                }
            }
        }

        private void PicCanvasBresenham_Paint(object sender, PaintEventArgs e)
        {
            bresenhamAlgorithm.DrawBresenhamVisualization(e.Graphics, picCanvasBresenham);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtXo.Clear();
            txtYo.Clear();
            txtXf.Clear();
            txtYf.Clear();
            txtXo.Focus();

            bresenhamAlgorithm.ClearData();
            dgvPixels.Rows.Clear();

            if (picCanvasBresenham != null)
            {
                picCanvasBresenham.Invalidate();
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

        private void picCanvasBresenham_Click(object sender, EventArgs e)
        {
        }
    }
}
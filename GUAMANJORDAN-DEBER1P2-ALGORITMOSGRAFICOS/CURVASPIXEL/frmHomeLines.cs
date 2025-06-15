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
    public partial class frmHomeLines : Form
    {
        private frmDDA ddaForm;
        private frmBresenham bresenhamForm;
        private frmMiddlePoint middlePointForm;
        private frmPoligons poligonsForm;

        public frmHomeLines()
        {
            InitializeComponent();
        }

        private void frmHomeLines_Load(object sender, EventArgs e)
        {
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ddaForm == null || ddaForm.IsDisposed)
            {
                ddaForm = new frmDDA();
            }
            ddaForm.Show();
            ddaForm.BringToFront();
        }

        private void bRESENHAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bresenhamForm == null || bresenhamForm.IsDisposed)
            {
                bresenhamForm = new frmBresenham();
            }
            bresenhamForm.Show();
            bresenhamForm.BringToFront();
        }

        private void pUNTOMEDIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (middlePointForm == null || middlePointForm.IsDisposed)
            {
                middlePointForm = new frmMiddlePoint();
            }
            middlePointForm.Show();
            middlePointForm.BringToFront();
        }

        private void aLGORITMOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void aLGORITMODERELLENOToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void rELLENOPORINUNDACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poligonsForm == null || poligonsForm.IsDisposed)
            {
                poligonsForm = new frmPoligons();
            }
            poligonsForm.Show();
            poligonsForm.BringToFront();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ddaForm?.Close();
            bresenhamForm?.Close();
            middlePointForm?.Close();
            poligonsForm?.Close();
            base.OnFormClosed(e);
        }
    }
}
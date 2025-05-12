using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmHome : Form
    {
        // constructor
        public frmHome()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // activa mdi
        }

        // Método para cerrar todos los formularios secundarios abiertos
        private void CloseAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        // triangulo
        private void tRIANGULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmTriangle f = new frmTriangle();
            f.MdiParent = this;
            f.Show();
        }

        // cuadrado
        private void cUADRADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmSquare f = new frmSquare();
            f.MdiParent = this;
            f.Show();
        }

        // rectangulo
        private void rECTANGULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmRectangle f = new frmRectangle();
            f.MdiParent = this;
            f.Show();
        }

        // rombo
        private void rOMBOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmRhombus f = new frmRhombus();
            f.MdiParent = this;
            f.Show();
        }

        // pentagono
        private void pENTAGONOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmPentagon f = new frmPentagon();
            f.MdiParent = this;
            f.Show();
        }

        // hexagono
        private void hEXAGONOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmHexagon f = new frmHexagon();
            f.MdiParent = this;
            f.Show();
        }

        // heptagono
        private void hEPTAGONOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmHeptagon f = new frmHeptagon();
            f.MdiParent = this;
            f.Show();
        }

        // octagono
        private void oCTAGONOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmOctagon f = new frmOctagon();
            f.MdiParent = this;
            f.Show();
        }

        // eneagono
        private void eNEAGONOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmNonagon f = new frmNonagon();
            f.MdiParent = this;
            f.Show();
        }

        // decagono
        private void dECAGONOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmDecagon f = new frmDecagon();
            f.MdiParent = this;
            f.Show();
        }

        // circulo
        private void cIRCULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmCircle f = new frmCircle();
            f.MdiParent = this;
            f.Show();
        }

        // elipse
        private void eLIPSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmEllipse f = new frmEllipse();
            f.MdiParent = this;
            f.Show();
        }

        // ovalo
        private void oVALOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmOval f = new frmOval();
            f.MdiParent = this;
            f.Show();
        }

        // trapecio regular
        private void tRAPECIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmTrapezoid f = new frmTrapezoid();
            f.MdiParent = this;
            f.Show();
        }

        // trapezoide irregular
        private void tRAPEZOIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmIrregularTrapezoid f = new frmIrregularTrapezoid();
            f.MdiParent = this;
            f.Show();
        }

        // trapecio isosceles
        private void tRAPECIOISOSELESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmIsoscelesTrapezoid f = new frmIsoscelesTrapezoid();
            f.MdiParent = this;
            f.Show();
        }

        // deltoide
        private void dELTOIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmKite f = new frmKite();
            f.MdiParent = this;
            f.Show();
        }

        // romboide
        private void rOMBOIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar todos los formularios abiertos primero
            CloseAllChildForms();

            // Crear y mostrar el nuevo formulario
            frmRhomboid f = new frmRhomboid();
            f.MdiParent = this;
            f.Show();
        }

        // submenus sin accion directa
        private void pOLIGONOSToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void cURVASToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void tRAPEToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void oTROSToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void frmHome_Load(object sender, EventArgs e) { }
    }
}
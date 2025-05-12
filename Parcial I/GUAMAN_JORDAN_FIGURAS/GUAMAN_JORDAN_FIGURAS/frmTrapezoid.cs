using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmTrapezoid : Form
    {
        public frmTrapezoid()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // creacion del objeto trapezoide
                CTrapezoid trapezoid = new CTrapezoid
                {
                    BaseMayor = double.Parse(txtMajorBase.Text),
                    BaseMenor = double.Parse(txtMinorBase.Text),
                    LadoIzq = double.Parse(txtSideSideLeft.Text),
                    LadoDer = double.Parse(txtSideSideRigth.Text),
                    Altura = double.Parse(txtHeight.Text)
                };

                // calcular area y perimetro
                txtArea.Text = trapezoid.CalcularArea().ToString("F2");
                txtPerimeter.Text = trapezoid.CalcularPerimetro().ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese solo numeros validos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // limpiar campos
            txtMajorBase.Clear();
            txtMinorBase.Clear();
            txtSideSideLeft.Clear();
            txtSideSideRigth.Clear();
            txtHeight.Clear();
            txtArea.Clear();
            txtPerimeter.Clear();
            txtMajorBase.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // cerrar la aplicacion
            this.Close();
        }

        private void txtMajorBase_TextChanged(object sender, EventArgs e) { }
        private void txtMinorBase_TextChanged(object sender, EventArgs e) { }
        private void txtHeight_TextChanged(object sender, EventArgs e) { }
        private void txtSideSideLeft_TextChanged(object sender, EventArgs e) { }
        private void txtSideSideRigth_TextChanged(object sender, EventArgs e) { }
        private void txtArea_TextChanged(object sender, EventArgs e) { }
        private void txtPerimeter_TextChanged(object sender, EventArgs e) { }

        private void frmTrapezoid_Load(object sender, EventArgs e) { }
    }
}

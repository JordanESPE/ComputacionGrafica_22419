using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmIrregularTrapezoid : Form
    {
        public frmIrregularTrapezoid()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // validaciones
            if (!ValidarCampos())
                return;

            // convertir entradas a double
            double baseMayor = Convert.ToDouble(txtMajorBase.Text);
            double baseMenor = Convert.ToDouble(txtMinorBase.Text);
            double ladoIzquierdo = Convert.ToDouble(txtLeftSize.Text);
            double ladoDerecho = Convert.ToDouble(txtRigthSize.Text);
            double altura = Convert.ToDouble(txtHeight.Text);

            // crear objeto trapezoide
            CIrregularTrapezoid trapezoide = new CIrregularTrapezoid(baseMayor, baseMenor, ladoIzquierdo, ladoDerecho, altura);

            // calcular y mostrar resultados
            txtArea.Text = trapezoide.CalcularArea().ToString("F2");
            txtPerimeter.Text = trapezoide.CalcularPerimetro().ToString("F2");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMajorBase.Clear();
            txtMinorBase.Clear();
            txtLeftSize.Clear();
            txtRigthSize.Clear();
            txtHeight.Clear();
            txtArea.Clear();
            txtPerimeter.Clear();

            txtMajorBase.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtMajorBase.Text) ||
                string.IsNullOrWhiteSpace(txtMinorBase.Text) ||
                string.IsNullOrWhiteSpace(txtLeftSize.Text) ||
                string.IsNullOrWhiteSpace(txtRigthSize.Text) ||
                string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double resultado;
            if (!double.TryParse(txtMajorBase.Text, out resultado) ||
                !double.TryParse(txtMinorBase.Text, out resultado) ||
                !double.TryParse(txtLeftSize.Text, out resultado) ||
                !double.TryParse(txtRigthSize.Text, out resultado) ||
                !double.TryParse(txtHeight.Text, out resultado))
            {
                MessageBox.Show("Por favor, ingresa solo valores numericos validos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Convert.ToDouble(txtMajorBase.Text) <= 0 ||
                Convert.ToDouble(txtMinorBase.Text) <= 0 ||
                Convert.ToDouble(txtLeftSize.Text) <= 0 ||
                Convert.ToDouble(txtRigthSize.Text) <= 0 ||
                Convert.ToDouble(txtHeight.Text) <= 0)
            {
                MessageBox.Show("Todos los valores deben ser mayores a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void frmIrregularTrapezoid_Load(object sender, EventArgs e)
        {
            // inicialización si es necesario
        }
    }
}

using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmRhomboid : Form
    {
        public frmRhomboid()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // validaciones
            if (string.IsNullOrWhiteSpace(txtWidth.Text) ||
                string.IsNullOrWhiteSpace(txtHeigth.Text) ||
                string.IsNullOrWhiteSpace(txtSideSide.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos requeridos.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtWidth.Text, out double width) || width <= 0)
            {
                MessageBox.Show("El ancho debe ser un numero positivo.", "Valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWidth.Focus();
                return;
            }

            if (!double.TryParse(txtHeigth.Text, out double height) || height <= 0)
            {
                MessageBox.Show("La altura debe ser un numero positivo.", "Valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeigth.Focus();
                return;
            }

            if (!double.TryParse(txtSideSide.Text, out double side) || side <= 0)
            {
                MessageBox.Show("El lado debe ser un numero positivo.", "Valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSideSide.Focus();
                return;
            }

            // calculo
            CRhomboid romboide = new CRhomboid();
            romboide.SetWidth(width);
            romboide.SetHeight(height);
            romboide.SetSide(side);

            txtArea.Text = romboide.CalculateArea().ToString("F2");
            txtPerimeter.Text = romboide.CalculatePerimeter().ToString("F2");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // limpia los campos
            txtWidth.Clear();
            txtHeigth.Clear();
            txtSideSide.Clear();
            txtArea.Clear();
            txtPerimeter.Clear();
            txtWidth.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // cierra la aplicacion
            this.Close();
        }

        // los siguientes metodos pueden quedarse vacios si no se usan eventos especiales
        private void txtWidth_TextChanged(object sender, EventArgs e) { }
        private void txtHeigth_TextChanged(object sender, EventArgs e) { }
        private void txtSideSide_TextChanged(object sender, EventArgs e) { }
        private void txtPerimeter_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void frmRhomboid_Load(object sender, EventArgs e) { }
    }
}

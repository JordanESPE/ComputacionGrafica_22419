using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmSquare : Form
    {
        CSquare objSquare = new CSquare();

        public frmSquare()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // validar que el campo no este vacio
                if (string.IsNullOrWhiteSpace(txtSide.Text))
                {
                    MessageBox.Show("Debe ingresar un valor para el lado.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double side = double.Parse(txtSide.Text);

                // validar que el lado sea positivo
                if (side <= 0)
                {
                    MessageBox.Show("El lado debe ser un numero positivo.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                objSquare.SetSide(side);

                double area = objSquare.CalculateArea();
                double perimeter = objSquare.CalculatePerimeter();

                txtArea.Text = area.ToString("F2");
                txtPerimeter.Text = perimeter.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numerico valido para el lado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // limpia los campos
            txtSide.Clear();
            txtArea.Clear();
            txtPerimeter.Clear();
            txtSide.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // cierra la aplicacion
            this.Close();
        }

        private void txtSide_TextChanged(object sender, EventArgs e)
        {
            // limpia area y perimetro al cambiar el lado
            txtArea.Clear();
            txtPerimeter.Clear();
        }

        private void txtPerimeter_TextChanged(object sender, EventArgs e) { }
        private void txtArea_TextChanged(object sender, EventArgs e) { }

        private void frmSquare_Load(object sender, EventArgs e) { }
    }
}

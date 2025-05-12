using System;
using System.Linq;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmOctagon : Form
    {
        // Instancia de la clase COctagon
        private COctagon octagon;

        public frmOctagon()
        {
            InitializeComponent();
            octagon = new COctagon();
        }

        private void txtSide_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(txtSide);
        }

        private void txtApothem_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(txtApothem);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no esten vacios
                if (string.IsNullOrWhiteSpace(txtSide.Text) || string.IsNullOrWhiteSpace(txtApothem.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar y convertir los valores
                if (!double.TryParse(txtSide.Text, out double side) || side <= 0)
                {
                    MessageBox.Show("El valor del lado debe ser un numero positivo.", "Error de validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSide.Focus();
                    return;
                }

                if (!double.TryParse(txtApothem.Text, out double apothem) || apothem <= 0)
                {
                    MessageBox.Show("El valor de la apotema debe ser un numero positivo.", "Error de validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtApothem.Focus();
                    return;
                }

                // Asignar valores al objeto octagon
                octagon.Side = side;
                octagon.Apothem = apothem;

                // Calcular y mostrar resultados
                double perimeter = octagon.CalculatePerimeter();
                double area = octagon.CalculateArea();

                txtPerimeter.Text = perimeter.ToString("F2");
                txtArea.Text = area.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtSide.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario directamente sin confirmación
            this.Close(); // Cierra solo el formulario actual
        }

        private void ClearFields()
        {
            // Limpiar todos los campos de texto
            txtSide.Clear();
            txtApothem.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();

            // Reiniciar el objeto octagon
            octagon = new COctagon();
        }

        private void ValidateInput(TextBox textBox)
        {
            // Validar que solo se ingresen numeros y un punto decimal
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                foreach (char c in textBox.Text)
                {
                    if (!char.IsDigit(c) && c != '.' && c != ',')
                    {
                        // Si encuentra un caracter invalido, eliminar el ultimo caracter
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                        textBox.SelectionStart = textBox.Text.Length;
                        return;
                    }
                }

                // Verificar que solo haya un punto decimal
                int countDots = textBox.Text.Count(c => c == '.' || c == ',');
                if (countDots > 1)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }

        private void txtPerimeter_TextChanged(object sender, EventArgs e)
        {
            // Este metodo no necesita implementacion ya que el campo es de solo lectura
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            // Este metodo no necesita implementacion ya que el campo es de solo lectura
        }

        private void frmOctagon_Load(object sender, EventArgs e)
        {
            // Este método está vacío por ahora
        }
    }
}

using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmTriangle : Form
    {
        private CTriangle triangle;

        public frmTriangle()
        {
            InitializeComponent();
            triangle = new CTriangle();
        }

        private void frmTriangle_Load(object sender, EventArgs e)
        {
            // Inicializacion del formulario
            ClearFields();
            txtSideA.Focus();
        }

        // Validar que solo se ingresen numeros
        private void ValidateInput(TextBox textBox)
        {
            string text = textBox.Text;
            if (text.Length > 0)
            {
                // Verificar si el input es un numero valido
                if (!IsValidInput(text))
                {
                    if (text.Length > 1)
                    {
                        textBox.Text = text.Substring(0, text.Length - 1);
                        textBox.SelectionStart = text.Length - 1;
                    }
                    else
                    {
                        textBox.Clear();
                    }
                }
            }
        }

        // Verifica si el input es un numero valido (permite un punto decimal)
        private bool IsValidInput(string text)
        {
            int decimalPointCount = 0;
            foreach (char c in text)
            {
                if (c == '.')
                {
                    decimalPointCount++;
                    if (decimalPointCount > 1)
                        return false;
                }
                else if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void ClearFields()
        {
            txtSideA.Clear();
            txtSideB.Clear();
            txtSideC.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSideA.Focus();
        }

        private void txtSideA_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(txtSideA);
        }

        private void txtSideB_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(txtSideB);
        }

        private void txtSideC_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(txtSideC);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se ingresaron valores
                if (string.IsNullOrWhiteSpace(txtSideA.Text) ||
                    string.IsNullOrWhiteSpace(txtSideB.Text) ||
                    string.IsNullOrWhiteSpace(txtSideC.Text))
                {
                    MessageBox.Show("Por favor, ingrese valores para todos los lados.",
                                    "Datos incompletos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Obtener los valores
                double sideA = double.Parse(txtSideA.Text);
                double sideB = double.Parse(txtSideB.Text);
                double sideC = double.Parse(txtSideC.Text);

                // Validar que los lados puedan formar un triangulo
                if (!CTriangle.IsValidTriangle(sideA, sideB, sideC))
                {
                    MessageBox.Show("Los lados ingresados no pueden formar un triangulo.\n" +
                                    "Recuerde que la suma de dos lados debe ser mayor que el tercer lado.",
                                    "Triangulo invalido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // Crear un nuevo triangulo
                triangle = new CTriangle(sideA, sideB, sideC);

                // Calcular perimetro y area
                double perimeter = triangle.CalculatePerimeter();
                double area = triangle.CalculateArea();

                // Mostrar resultados
                txtPerimeter.Text = perimeter.ToString("F2");
                txtArea.Text = area.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
            triangle = new CTriangle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario directamente sin confirmación
            this.Close();
        }

        private void txtPerimeter_TextChanged(object sender, EventArgs e) { }
        private void txtArea_TextChanged(object sender, EventArgs e) { }
    }
}

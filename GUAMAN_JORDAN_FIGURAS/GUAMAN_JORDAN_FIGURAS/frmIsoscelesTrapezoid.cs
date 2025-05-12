using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmIsoscelesTrapezoid : Form
    {
        public frmIsoscelesTrapezoid()
        {
            InitializeComponent();
        }

        private void grbOutputs_Enter(object sender, EventArgs e)
        {
            // no se requiere implementacion especifica
        }

        private void txtMajorBase_TextChanged(object sender, EventArgs e)
        {
            // validar que solo se ingresen numeros
            ValidateNumericInput(txtMajorBase);
        }

        private void txtMinorBase_TextChanged(object sender, EventArgs e)
        {
            // validar que solo se ingresen numeros
            ValidateNumericInput(txtMinorBase);
        }

        private void txtSideSide_TextChanged(object sender, EventArgs e)
        {
            // validar que solo se ingresen numeros
            ValidateNumericInput(txtSideSide);
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            // validar que solo se ingresen numeros
            ValidateNumericInput(txtHeight);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // validar que todos los campos tengan valores
            if (string.IsNullOrWhiteSpace(txtMajorBase.Text) ||
                string.IsNullOrWhiteSpace(txtMinorBase.Text) ||
                string.IsNullOrWhiteSpace(txtSideSide.Text) ||
                string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los valores requeridos.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // convertir los valores ingresados a double
                double majorBase = Convert.ToDouble(txtMajorBase.Text);
                double minorBase = Convert.ToDouble(txtMinorBase.Text);
                double sideSide = Convert.ToDouble(txtSideSide.Text);
                double height = Convert.ToDouble(txtHeight.Text);

                // crear el objeto trapecio
                CIsoscelesTrapezoid trapezoid = new CIsoscelesTrapezoid(majorBase, minorBase, sideSide, height);

                // validar que los datos sean coherentes para un trapecio isosceles
                if (!trapezoid.ValidateData())
                {
                    // calcular el valor minimo requerido para el lado lateral
                    double horizontalDiff = (majorBase - minorBase) / 2;
                    double minSideLength = Math.Sqrt(Math.Pow(horizontalDiff, 2) + Math.Pow(height, 2));

                    string mensaje = "Los valores ingresados no corresponden a un trapecio isosceles valido.\n\n" +
                        $"Base Mayor: {majorBase}\n" +
                        $"Base Menor: {minorBase}\n" +
                        $"Lado Lateral: {sideSide}\n" +
                        $"Altura: {height}\n\n" +
                        $"El lado lateral minimo requerido es: {minSideLength:F2}";

                    MessageBox.Show(mensaje, "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // calcular perimetro y area
                double perimeter = trapezoid.CalculatePerimeter();
                double area = trapezoid.CalculateArea();

                // mostrar resultados con dos decimales
                txtPerimeter.Text = perimeter.ToString("F2");
                txtArea.Text = area.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numericos validos.", "Error de formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrReset_Click(object sender, EventArgs e)
        {
            // limpiar todos los campos
            txtMajorBase.Clear();
            txtMinorBase.Clear();
            txtSideSide.Clear();
            txtHeight.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();

            // colocar el focus en el primer campo
            txtMajorBase.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario directamente sin confirmación
            this.Close();
        }

        private void txtPerimeter_TextChanged(object sender, EventArgs e)
        {
            // no se requiere implementacion especifica
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            // no se requiere implementacion especifica
        }

        // metodo para validar que solo se ingresen numeros en los TextBox
        private void ValidateNumericInput(TextBox textBox)
        {
            // guardo la posicion del cursor
            int cursorPosition = textBox.SelectionStart;

            // verificar si el texto es valido para un numero decimal
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // reemplazar comas por puntos para manejar formatos regionales
                textBox.Text = textBox.Text.Replace(',', '.');

                foreach (char c in textBox.Text)
                {
                    if (!char.IsDigit(c) && c != '.')
                    {
                        // si encuentra un caracter no valido, elimina el ultimo caracter
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                        cursorPosition = Math.Max(0, cursorPosition - 1);
                        break;
                    }
                }

                // asegurar que solo haya un punto decimal
                int firstDot = textBox.Text.IndexOf('.');
                int lastDot = textBox.Text.LastIndexOf('.');

                if (firstDot != lastDot)
                {
                    textBox.Text = textBox.Text.Remove(lastDot, 1);
                    cursorPosition = Math.Max(0, cursorPosition - 1);
                }
            }

            // restaurar la posicion del cursor
            textBox.SelectionStart = cursorPosition;
            textBox.SelectionLength = 0;
        }

        private void frmIsoscelesTrapezoid_Load(object sender, EventArgs e)
        {
            // inicializacion si es necesario
        }
    }
}

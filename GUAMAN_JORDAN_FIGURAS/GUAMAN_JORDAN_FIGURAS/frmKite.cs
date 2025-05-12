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
    public partial class frmKite : Form
    {
        public frmKite()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // No se requiere implementacion especifica
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculo (boton Calcular)
            CalculateKite();
        }

        private void txtMajorDiagonal_TextChanged(object sender, EventArgs e)
        {
            // Validar que solo se ingresen numeros
            ValidateNumericInput(txtMajorDiagonal);
        }

        private void txtMinorDiagonal_TextChanged(object sender, EventArgs e)
        {
            // Validar que solo se ingresen numeros
            ValidateNumericInput(txtMinorDiagonal);
        }

        private void txtSide_TextChanged(object sender, EventArgs e)
        {
            // Validar que solo se ingresen numeros
            ValidateNumericInput(txtSide);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Resetear todos los campos
            ResetForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Salir de la aplicacion
            ExitApplication();
        }

        private void txtPerimeter_TextChanged(object sender, EventArgs e)
        {
            // No se requiere implementacion especifica
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            // No se requiere implementacion especifica
        }

        // Metodo para validar entrada numerica
        private void ValidateNumericInput(TextBox textBox)
        {
            // Guardar la posicion del cursor
            int cursorPosition = textBox.SelectionStart;

            // Verificar si el texto es valido para un numero decimal
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // Reemplazar comas por puntos para manejar formatos regionales
                textBox.Text = textBox.Text.Replace(',', '.');

                foreach (char c in textBox.Text)
                {
                    if (!char.IsDigit(c) && c != '.')
                    {
                        // Si encuentra un caracter no valido, elimina el ultimo caracter
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                        cursorPosition = Math.Max(0, cursorPosition - 1);
                        break;
                    }
                }

                // Asegurar que solo haya un punto decimal
                int firstDot = textBox.Text.IndexOf('.');
                int lastDot = textBox.Text.LastIndexOf('.');

                if (firstDot != lastDot)
                {
                    textBox.Text = textBox.Text.Remove(lastDot, 1);
                    cursorPosition = Math.Max(0, cursorPosition - 1);
                }
            }

            // Restaurar la posicion del cursor
            textBox.SelectionStart = cursorPosition;
            textBox.SelectionLength = 0;
        }

        // Metodo para calcular el area y perimetro del deltoide
        private void CalculateKite()
        {
            // Validar que todos los campos tengan valores
            if (string.IsNullOrWhiteSpace(txtMajorDiagonal.Text) ||
                string.IsNullOrWhiteSpace(txtMinorDiagonal.Text) ||
                string.IsNullOrWhiteSpace(txtSide.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los valores requeridos.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Convertir los valores ingresados a double
                double majorDiagonal = Convert.ToDouble(txtMajorDiagonal.Text);
                double minorDiagonal = Convert.ToDouble(txtMinorDiagonal.Text);
                double side = Convert.ToDouble(txtSide.Text);

                // Crear el objeto deltoide
                CKite kite = new CKite(majorDiagonal, minorDiagonal, side);

                // Validar que los datos sean coherentes para un deltoide
                if (!kite.ValidateData())
                {
                    // Calcular la distancia desde el centro hasta un vertice
                    double halfMajorDiagonal = majorDiagonal / 2;
                    double halfMinorDiagonal = minorDiagonal / 2;
                    double minSideLength = Math.Sqrt(Math.Pow(halfMajorDiagonal, 2) + Math.Pow(halfMinorDiagonal, 2));

                    string mensaje = "Los valores ingresados no corresponden a un deltoide valido.\n\n" +
                        $"Diagonal Mayor: {majorDiagonal}\n" +
                        $"Diagonal Menor: {minorDiagonal}\n" +
                        $"Lado: {side}\n\n" +
                        $"El lado minimo requerido es: {minSideLength:F2}\n" +
                        $"La diagonal mayor debe ser mayor que la diagonal menor.";

                    MessageBox.Show(mensaje, "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calcular perimetro y area
                double perimeter = kite.CalculatePerimeter();
                double area = kite.CalculateArea();

                // Mostrar resultados con dos decimales
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

        // Metodo para resetear el formulario
        private void ResetForm()
        {
            // Limpiar todos los campos
            txtMajorDiagonal.Clear();
            txtMinorDiagonal.Clear();
            txtSide.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();

            // Colocar el focus en el primer campo
            txtMajorDiagonal.Focus();
        }

        // Metodo para salir de la aplicacion
        private void ExitApplication()
        {
          this.Close();
        }

        private void frmKite_Load(object sender, EventArgs e)
        {

        }
    }
}

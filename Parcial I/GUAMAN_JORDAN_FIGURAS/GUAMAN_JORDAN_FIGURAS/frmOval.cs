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
    public partial class frmOval : Form
    {
        // Instancia de la clase COval
        private COval oval;

        public frmOval()
        {
            InitializeComponent();
            oval = new COval();
        }

        private void frmOval_Load(object sender, EventArgs e)
        {
            // Inicializar el formulario
            ClearFields();
            txtSemiMajorAxis.Focus();
        }

        private void txtSemiMajorAxis_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(txtSemiMajorAxis);
        }

        private void txtSemiMinorAxis_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(txtSemiMinorAxis);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no esten vacios
                if (string.IsNullOrWhiteSpace(txtSemiMajorAxis.Text) || string.IsNullOrWhiteSpace(txtSemiMinorAxis.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar y convertir los valores
                if (!double.TryParse(txtSemiMajorAxis.Text, out double semiMajorAxis) || semiMajorAxis <= 0)
                {
                    MessageBox.Show("El valor del semieje mayor debe ser un numero positivo.", "Error de validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSemiMajorAxis.Focus();
                    return;
                }

                if (!double.TryParse(txtSemiMinorAxis.Text, out double semiMinorAxis) || semiMinorAxis <= 0)
                {
                    MessageBox.Show("El valor del semieje menor debe ser un numero positivo.", "Error de validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSemiMinorAxis.Focus();
                    return;
                }

                // Validar que el semieje menor no sea mayor que el semieje mayor
                if (semiMinorAxis > semiMajorAxis)
                {
                    MessageBox.Show("El semieje menor no puede ser mayor que el semieje mayor.", "Error de validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSemiMinorAxis.Focus();
                    return;
                }

                // Asignar valores al objeto oval
                oval.SemiMajorAxis = semiMajorAxis;
                oval.SemiMinorAxis = semiMinorAxis;

                // Calcular y mostrar resultados
                double perimeter = oval.CalculatePerimeter();
                double area = oval.CalculateArea();

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
            txtSemiMajorAxis.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario directamente sin confirmación
            this.Close();
        }

        private void ClearFields()
        {
            // Limpiar todos los campos de texto
            txtSemiMajorAxis.Clear();
            txtSemiMinorAxis.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();

            // Reiniciar el objeto oval
            oval = new COval();
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
    }
}

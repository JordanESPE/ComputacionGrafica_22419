using System;
using System.Windows.Forms;
namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmHeptagon : Form
    {
        // variable para el objeto CHeptagon
        private CHeptagon heptagon;
        public frmHeptagon()
        {
            InitializeComponent();
        }
        private void frmHeptagon_Load(object sender, EventArgs e)
        {
            // inicialización si es necesario
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // leer el tamaño del lado
                double sideLength = Convert.ToDouble(txtSize.Text);

                // verificar si el valor es negativo o cero
                if (sideLength <= 0)
                {
                    MessageBox.Show("El valor del lado debe ser mayor que cero.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // evitar continuar si es inválido
                }

                // Comprobar si se ingresó un valor para el apotema
                if (!string.IsNullOrWhiteSpace(txtApotem.Text))
                {
                    double apotema = Convert.ToDouble(txtApotem.Text);

                    // verificar si el valor del apotema es negativo o cero
                    if (apotema <= 0)
                    {
                        MessageBox.Show("El valor del apotema debe ser mayor que cero.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Crear objeto heptágono con lado y apotema proporcionados
                    heptagon = new CHeptagon(sideLength, apotema);
                }
                else
                {
                    // Crear objeto heptágono solo con el lado
                    heptagon = new CHeptagon(sideLength);
                    // Mostrar el apotema calculado
                    txtApotem.Text = heptagon.CalculateApotema().ToString("0.####");
                }

                // calcular perímetro y área
                double perimeter = heptagon.CalculatePerimeter();
                double area = heptagon.CalculateArea();

                // mostrar resultados
                txtPerimeter.Text = perimeter.ToString("0.##");
                txtArea.Text = area.ToString("0.##");
            }
            catch (FormatException)
            {
                // mostrar mensaje de error
                MessageBox.Show("Por favor, ingrese un valor válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // limpiar campos y objeto heptágono
            txtSize.Clear();
            txtApotem.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            heptagon = null; // limpiar objeto
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // cerrar formulario
            this.Close();
        }
        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            // manejar cambios en el tamaño del lado
        }
        private void txtPerimeter_TextChanged(object sender, EventArgs e)
        {
            // manejar cambios en el perímetro
        }
        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            // manejar cambios en el área
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // manejar clic en la etiqueta de apotema
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // manejar cambios en el campo de apotema
        }
    }
}
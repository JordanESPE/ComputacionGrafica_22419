using System;
using System.Windows.Forms;
namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmHexagon : Form
    {
        private CHexagon hexagono;
        public frmHexagon()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) // calcular
        {
            try
            {
                // leer el valor del lado
                double lado = Convert.ToDouble(txtSize.Text);

                // verificar si el valor del lado es negativo o cero
                if (lado <= 0)
                {
                    MessageBox.Show("El valor del lado debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // evitar continuar si el valor es inválido
                }

                // Comprobar si se ingresó un valor para el apotema
                if (!string.IsNullOrWhiteSpace(txtApotema.Text))
                {
                    double apotema = Convert.ToDouble(txtApotema.Text);

                    // verificar si el valor del apotema es negativo o cero
                    if (apotema <= 0)
                    {
                        MessageBox.Show("El valor del apotema debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Crear objeto hexágono con lado y apotema proporcionados
                    hexagono = new CHexagon(lado, apotema);
                }
                else
                {
                    // Crear objeto hexágono solo con el lado
                    hexagono = new CHexagon(lado);
                    // Mostrar el apotema calculado
                    txtApotema.Text = hexagono.CalcularApotema().ToString("0.##");
                }

                // calcular perímetro y área
                double perimetro = hexagono.CalcularPerimetro();
                double area = hexagono.CalcularArea();

                // mostrar resultados
                txtPerimeter.Text = perimetro.ToString("0.##");
                txtArea.Text = area.ToString("0.##");
            }
            catch (FormatException)
            {
                // mostrar mensaje de error
                MessageBox.Show("Ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e) // limpiar
        {
            // limpiar campos y objeto hexágono
            txtSize.Clear();
            txtApotema.Clear();
            txtArea.Clear();
            txtPerimeter.Clear();
            hexagono = null;
        }
        private void button3_Click(object sender, EventArgs e) // salir
        {
            // cerrar formulario
            this.Close();
        }
        private void frmHexagon_Load(object sender, EventArgs e)
        {
            // inicialización si es necesario
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando cambia el texto del apotema
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmPentagon : Form
    {
        public frmPentagon()
        {
            InitializeComponent();

            // Bloquear entrada de letras y simbolos
            txtSide.KeyPress += ValidarEntradaNumerica;
            txtApothem.KeyPress += ValidarEntradaNumerica;
        }

        private void ValidarEntradaNumerica(object sender, KeyPressEventArgs e)
        {
            // Permitir solo numeros, coma, punto y tecla de borrado
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Solo permitir un punto o una coma
            TextBox txt = sender as TextBox;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (txt.Text.Contains(".") || txt.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSide.Text) || string.IsNullOrWhiteSpace(txtApothem.Text))
            {
                MessageBox.Show("Por favor, ingrese valores en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double lado = double.Parse(txtSide.Text.Replace(',', '.'));
                double apotema = double.Parse(txtApothem.Text.Replace(',', '.'));

                CPentagon pentagono = new CPentagon(lado, apotema);

                double perimetro = pentagono.CalcularPerimetro();
                double area = pentagono.CalcularArea();

                txtPerimeter.Text = perimetro.ToString("F2");
                txtArea.Text = area.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese solo numeros validos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSide.Clear();
            txtApothem.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSide.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Metodos vacios necesarios por el disenador
        private void lblSide_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void txtSide_TextChanged(object sender, EventArgs e) { }
        private void txtPerimeter_TextChanged(object sender, EventArgs e) { }
        private void txtArea_TextChanged(object sender, EventArgs e) { }
        private void grbOutputs_Enter(object sender, EventArgs e) { }

        private void frmPentagon_Load(object sender, EventArgs e)
        {

        }
    }
}

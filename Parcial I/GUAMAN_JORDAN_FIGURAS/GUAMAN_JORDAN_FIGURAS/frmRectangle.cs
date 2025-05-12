using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmRectangle : Form
    {
        public frmRectangle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(txtWidth.Text.Trim());
                double height = double.Parse(txtHeigth.Text.Trim());

                CRectangle rect = new CRectangle(width, height);

                txtPerimeter.Text = rect.CalculatePerimeter().ToString("F2");
                txtArea.Text = rect.CalculateArea().ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numericos validos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // limpia los campos de entrada y salida
            txtWidth.Clear();
            txtHeigth.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtWidth.Focus(); // da foco al campo de ancho
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // cierra la aplicacion
            Close();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            // limpia los resultados cuando cambia el ancho
            txtPerimeter.Clear();
            txtArea.Clear();
        }

        private void txtHeigth_TextChanged(object sender, EventArgs e)
        {
            // limpia los resultados cuando cambia la altura
            txtPerimeter.Clear();
            txtArea.Clear();
        }

        private void txtPerimeter_TextChanged(object sender, EventArgs e) { }
        private void txtArea_TextChanged(object sender, EventArgs e) { }

        private void frmRectangle_Load(object sender, EventArgs e) { }
    }
}

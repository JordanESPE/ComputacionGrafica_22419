using System.Windows.Forms;
using System;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmEllipse : Form
    {
        public frmEllipse()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // obtener datos
                double semiMajorAxis = Convert.ToDouble(txtSemiMajorAxis.Text);
                double semiMinorAxis = Convert.ToDouble(txtSemiMinorAxis.Text);

                // validar si el eje mayor es menor que el eje menor
                if (semiMajorAxis < semiMinorAxis)
                {
                    var result = MessageBox.Show(
                        "El semieje mayor no puede ser menor que el semieje menor. Deseas continuar con este valor?",
                        "Precaucion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    // si el usuario elige no, salir
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                // calcular perimetro aproximado
                double perimeter = Math.PI * (3 * (semiMajorAxis + semiMinorAxis) - Math.Sqrt((3 * semiMajorAxis + semiMinorAxis) * (semiMajorAxis + 3 * semiMinorAxis)));
                txtPerimeter.Text = perimeter.ToString("0.##");

                // calcular area
                double area = Math.PI * semiMajorAxis * semiMinorAxis;
                txtArea.Text = area.ToString("0.##");
            }
            catch (FormatException)
            {
                // mostrar error de formato
                MessageBox.Show("Por favor, ingrese valores validos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // limpiar campos
            txtSemiMajorAxis.Clear();
            txtSemiMinorAxis.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // cerrar formulario
            this.Close();
        }

        private void frmEllipse_Load(object sender, EventArgs e)
        {
            // evento de carga
        }
    }
}

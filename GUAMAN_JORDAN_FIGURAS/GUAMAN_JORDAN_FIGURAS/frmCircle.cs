using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmCircle : Form
    {
        public frmCircle()
        {
            InitializeComponent();
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {
            // inicializar si es necesario
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double radio, area, perimetro;

            if (double.TryParse(txtRadio.Text, out radio) && radio > 0)
            {
                area = Math.PI * Math.Pow(radio, 2);
                perimetro = 2 * Math.PI * radio;

                txtArea.Text = area.ToString("F2");
                txtPerimeter.Text = perimetro.ToString("F2");
            }
            else
            {
                MessageBox.Show("ingresa un valor valido para el radio");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRadio.Clear();
            txtArea.Clear();
            txtPerimeter.Clear();
            txtRadio.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra el formulario
        }
    }
}

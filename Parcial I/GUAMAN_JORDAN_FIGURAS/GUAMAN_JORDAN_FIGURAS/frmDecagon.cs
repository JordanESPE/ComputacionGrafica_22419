using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmDecagon : Form
    {
        public frmDecagon()
        {
            InitializeComponent();
        }

        private void frmDecagon_Load(object sender, EventArgs e)
        {
            // Aqui puedo preparar todo lo que necesito al iniciar el formulario
        }

        private void grbProcess_Enter(object sender, EventArgs e)
        {
            // Este evento se activa cuando entro al grupo de proceso, por ahora no necesito hacer nada aqui
        }

        private void grbInputs_Enter(object sender, EventArgs e)
        {
            // Este evento ocurre cuando entro al grupo de entradas, lo dejo vacio por si lo uso luego
        }

        private void grbOutputs_Enter(object sender, EventArgs e)
        {
            // Este tambien lo dejo vacio por si en un futuro quiero mostrar algo al entrar aqui
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Primero intento leer los valores que el usuario ingreso
            if (double.TryParse(txtSize.Text, out double size) && size > 0 &&
                double.TryParse(txtApothem.Text, out double apothem) && apothem > 0)
            {
                // Si todo esta bien, calculo el perimetro del decagono
                double perimeter = 10 * size;

                // Ahora calculo el area usando la formula con el apotema
                double area = 5 * size * apothem;

                // Muestro los resultados en los cuadros de texto
                txtPerimeter.Text = perimeter.ToString("F2");
                txtArea.Text = area.ToString("F2");
            }
            else
            {
                // Si algo esta mal, le aviso al usuario que revise sus datos
                MessageBox.Show("Por favor, ingresa valores positivos y validos para el tamano y el apotema", "Entrada invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Limpio todos los campos para que el usuario pueda empezar de nuevo
            txtSize.Clear();
            txtApothem.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSize.Focus(); // Pongo el cursor de nuevo en el primer campo
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Solo cierro la pestaña del formulario, no la aplicacion
            this.Hide(); // Esto oculta el formulario
        }
    }
}

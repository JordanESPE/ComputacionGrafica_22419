using System;
using System.Windows.Forms;

namespace GUAMAN_JORDAN_FIGURAS
{
    public partial class frmRhombus : Form
    {
        CRhombus objRhombus = new CRhombus();

        public frmRhombus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMajorDiagonal.Text) ||
                    string.IsNullOrWhiteSpace(txtMinorDiagonal.Text) ||
                    string.IsNullOrWhiteSpace(txtSide.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double majorDiagonal = double.Parse(txtMajorDiagonal.Text);
                double minorDiagonal = double.Parse(txtMinorDiagonal.Text);
                double side = double.Parse(txtSide.Text);

                if (majorDiagonal <= 0 || minorDiagonal <= 0 || side <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser positivos.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (minorDiagonal > majorDiagonal)
                {
                    MessageBox.Show("La diagonal menor no puede ser mayor que la diagonal mayor.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                objRhombus.SetMajorDiagonal(majorDiagonal);
                objRhombus.SetMinorDiagonal(minorDiagonal);
                objRhombus.SetSide(side);

                double area = objRhombus.CalculateArea();
                double perimeter = objRhombus.CalculatePerimeter();

                txtArea.Text = area.ToString("F2");
                txtPerimeter.Text = perimeter.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numericos validos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // limpia los campos
            txtMajorDiagonal.Clear();
            txtMinorDiagonal.Clear();
            txtSide.Clear();
            txtArea.Clear();
            txtPerimeter.Clear();
            txtMajorDiagonal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // cierra la aplicacion
            this.Close();
        }

        // metodos vacios generados por el diseñador (pueden quedar asi si no los usas)
        private void txtMajorDiagonal_TextChanged(object sender, EventArgs e) { }
        private void txtMinorDiagonal_TextChanged(object sender, EventArgs e) { }
        private void txtSide_TextChanged(object sender, EventArgs e) { }
        private void txtPerimeter_TextChanged(object sender, EventArgs e) { }
        private void txtArea_TextChanged(object sender, EventArgs e) { }

        private void frmRhombus_Load(object sender, EventArgs e) { }
    }
}

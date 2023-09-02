using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {

        private string sexoSeleccionado = "";

        private Image imagenSeleccionada;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioHombre_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.hombreava;
            if (radioHombre.Checked)
            {
                sexoSeleccionado = "Hombre";
            }

        }

        private void Mujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mujerava;
            if (Mujer.Checked)
            {
                sexoSeleccionado = "Mujer";
            }


        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(textNombre.Text))
            {
                textNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textNombre.Text);
                textNombre.SelectionStart = textNombre.Text.Length;
            }



        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textApellido.Text))
            {
                textApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textApellido.Text);
                textApellido.SelectionStart = textApellido.Text.Length;
            }


        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de Imagen (*.jpg; *.bmp; *.png)|*.jpg;*.bmp;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textFoto.Text = openFileDialog1.FileName;

                string rutaImagen = openFileDialog1.FileName;
                imagenSeleccionada = Image.FromFile(rutaImagen);
            }
        }

        private void ValidarTxtSaldo(TextBox txtSaldo)
        {
            if (string.IsNullOrWhiteSpace(txtSaldo.Text) || !int.TryParse(txtSaldo.Text, out _))
            {
                MessageBox.Show("El campo debe contener un valor numérico y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaldo.Clear();
                txtSaldo.Focus();
            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                string apellido = textApellido.Text;
                string nombre = textNombre.Text;
                DateTime fecha = dateTimePicker1.Value;
                decimal saldo = Convert.ToDecimal(textBoxSaldo.Text);
                string ruta = textFoto.Text;
                Image imagen = imagenSeleccionada;
                string vacio = "";

                // Agregar fila al DataGridView
                int rowIndex = dataGridView1.Rows.Add(apellido, nombre, fecha, sexoSeleccionado, vacio, saldo, imagen, ruta);

                // Configurar valor en la columna de botón para la fila recién agregada
                dataGridView1.Rows[rowIndex].Cells["ColumnaEliminar"].Value = "Eliminar";
                dataGridView1.Rows[rowIndex].Cells["ColumnaImagen"].Value = imagenSeleccionada;
                pictureBox1.Image = imagenSeleccionada;

                // Cambia la fuente de las columnas "Nombre" y "Apellido" en el DataGridView
                DataGridViewCellStyle nombreCellStyle = new DataGridViewCellStyle();
                nombreCellStyle.Font = new Font("Century Gothic", 12); // Cambia la fuente según tus preferencias

                DataGridViewCellStyle apellidoCellStyle = new DataGridViewCellStyle();
                apellidoCellStyle.Font = new Font("Century Gothic", 12); // Cambia la fuente según tus preferencias

                // Asigna el nuevo estilo de celda a las columnas específicas
                dataGridView1.Columns["ColuNombre"].DefaultCellStyle = nombreCellStyle;
                dataGridView1.Columns["coluApellido"].DefaultCellStyle = apellidoCellStyle;

                textNombre.Clear();
                textApellido.Clear();
                textBoxSaldo.Clear();
                textFoto.Clear();

                if (saldo < 50)
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ColumnaEliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila correspondiente al registro
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private bool ValidarCamposVacios()
        {
            bool val = true;
            if (!(string.IsNullOrWhiteSpace(textBoxSaldo.Text) || string.IsNullOrWhiteSpace(textApellido.Text) || string.IsNullOrWhiteSpace(textNombre.Text)) && !(radioHombre.Checked || Mujer.Checked))
            {
                val = false; ; // Al menos un campo está vacío o contiene solo espacios en blanco
            }
            return val;

        }

     
    }
}
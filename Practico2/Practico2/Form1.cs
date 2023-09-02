using Microsoft.VisualBasic;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void TGuardar_Click(object sender, EventArgs e)
        {
            LModificar.Text = TApellido.Text + " " + TNombre.Text;



            if (ValidarCamposVacios())
            {
                // Mostrar un MessageBox para confirmar la inserción
                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (ask == MsgBoxResult.Yes)
                {
                    MessageBox.Show("El cliente " + LModificar.Text + " se inserto correctamente", "Guardar", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número ni una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suprimir la tecla
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private bool ValidarCamposVacios()
        {
            if (string.IsNullOrWhiteSpace(TDni.Text) || string.IsNullOrWhiteSpace(TApellido.Text) || string.IsNullOrWhiteSpace(TNombre.Text))
            {
                return false; // Al menos un campo está vacío o contiene solo espacios en blanco
            }

            return true; // Todos los campos tienen contenido
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {

            if (ValidarCamposVacios())
            {
                MsgBoxResult response = (MsgBoxResult)MessageBox.Show("Estas a punto de eliminar el cliente: " + TApellido.Text + " " + TNombre.Text, "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (response == MsgBoxResult.Yes)
                {


                    LModificar.Text = "Modificar";
                    MessageBox.Show("El cliente: " + TApellido.Text + " " + TNombre.Text + " se eliminó correctamente", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TDni.Clear();
                    TNombre.Clear();
                    TApellido.Clear();


                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBvaron_CheckedChanged(object sender, EventArgs e)
        {


            // Cambiar la imagen del PictureBox a la imagen del varón
            pictureBox1.Image = Properties.Resources.hombre; // 


        }

        private void RBmujer_CheckedChanged(object sender, EventArgs e)
        {


            // Cambiar la imagen del PictureBox a la imagen de la mujer
            pictureBox1.Image = Properties.Resources.mujer; 



        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese el carácter no válido
            }

        }

        
    }
}
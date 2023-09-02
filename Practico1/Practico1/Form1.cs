using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox3.Text + " " + textBox2.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


namespace Practico5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textNombre = new TextBox();
            textApellido = new TextBox();
            textFoto = new TextBox();
            labelNombre = new Label();
            labelApellido = new Label();
            labelFecha = new Label();
            labelSexo = new Label();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            dateTimePicker1 = new DateTimePicker();
            radioHombre = new RadioButton();
            Mujer = new RadioButton();
            pictureBox1 = new PictureBox();
            btnGuardar = new Button();
            btnFoto = new Button();
            dataGridView1 = new DataGridView();
            textBoxSaldo = new TextBox();
            coluApellido = new DataGridViewTextBoxColumn();
            ColuNombre = new DataGridViewTextBoxColumn();
            CfechaNac = new DataGridViewTextBoxColumn();
            Csexo = new DataGridViewTextBoxColumn();
            ColumnaEliminar = new DataGridViewButtonColumn();
            Csaldo = new DataGridViewTextBoxColumn();
            ColumnaImagen = new DataGridViewImageColumn();
            Cruta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.Location = new Point(158, 69);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(222, 23);
            textNombre.TabIndex = 0;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(158, 108);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(222, 23);
            textApellido.TabIndex = 1;
            textApellido.TextChanged += textApellido_TextChanged;
            // 
            // textFoto
            // 
            textFoto.Location = new Point(158, 281);
            textFoto.Name = "textFoto";
            textFoto.Size = new Size(222, 23);
            textFoto.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Transparent;
            labelNombre.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.ForeColor = SystemColors.ControlLightLight;
            labelNombre.Location = new Point(45, 62);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(99, 33);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.BackColor = Color.Transparent;
            labelApellido.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelApellido.ForeColor = SystemColors.ControlLightLight;
            labelApellido.Location = new Point(45, 101);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(107, 33);
            labelApellido.TabIndex = 5;
            labelApellido.Text = "Apellido:";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.BackColor = Color.Transparent;
            labelFecha.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.ForeColor = SystemColors.ControlLightLight;
            labelFecha.Location = new Point(45, 140);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(230, 33);
            labelFecha.TabIndex = 6;
            labelFecha.Text = "Fecha de Nacimiento:";
            // 
            // labelSexo
            // 
            labelSexo.AutoSize = true;
            labelSexo.BackColor = Color.Transparent;
            labelSexo.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSexo.ForeColor = SystemColors.ControlLightLight;
            labelSexo.Location = new Point(77, 183);
            labelSexo.Name = "labelSexo";
            labelSexo.Size = new Size(75, 33);
            labelSexo.TabIndex = 7;
            labelSexo.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(68, 226);
            label5.Name = "label5";
            label5.Size = new Size(84, 33);
            label5.TabIndex = 8;
            label5.Text = "Saldo:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(281, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(99, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // radioHombre
            // 
            radioHombre.AutoSize = true;
            radioHombre.BackColor = Color.Transparent;
            radioHombre.Checked = true;
            radioHombre.Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioHombre.ForeColor = SystemColors.ControlLightLight;
            radioHombre.Location = new Point(170, 191);
            radioHombre.Name = "radioHombre";
            radioHombre.Size = new Size(74, 23);
            radioHombre.TabIndex = 11;
            radioHombre.TabStop = true;
            radioHombre.Text = "Hombre";
            radioHombre.UseVisualStyleBackColor = false;
            radioHombre.CheckedChanged += radioHombre_CheckedChanged;
            // 
            // Mujer
            // 
            Mujer.AutoSize = true;
            Mujer.BackColor = Color.Transparent;
            Mujer.Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Mujer.ForeColor = SystemColors.ControlLightLight;
            Mujer.Location = new Point(281, 191);
            Mujer.Name = "Mujer";
            Mujer.Size = new Size(59, 23);
            Mujer.TabIndex = 12;
            Mujer.Text = "Mujer";
            Mujer.UseVisualStyleBackColor = false;
            Mujer.CheckedChanged += Mujer_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hombreava;
            pictureBox1.Location = new Point(456, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources.guardarr;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(191, 310);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 63);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(68, 281);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(75, 23);
            btnFoto.TabIndex = 15;
            btnFoto.Text = "Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { coluApellido, ColuNombre, CfechaNac, Csexo, ColumnaEliminar, Csaldo, ColumnaImagen, Cruta });
            dataGridView1.Location = new Point(1, 373);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(824, 145);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBoxSaldo
            // 
            textBoxSaldo.Location = new Point(158, 233);
            textBoxSaldo.Name = "textBoxSaldo";
            textBoxSaldo.Size = new Size(222, 23);
            textBoxSaldo.TabIndex = 17;
            // 
            // coluApellido
            // 
            coluApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            coluApellido.HeaderText = "Apellido";
            coluApellido.MinimumWidth = 30;
            coluApellido.Name = "coluApellido";
            // 
            // ColuNombre
            // 
            ColuNombre.HeaderText = "Nombre";
            ColuNombre.Name = "ColuNombre";
            // 
            // CfechaNac
            // 
            CfechaNac.HeaderText = "Fecha Nacimiento";
            CfechaNac.Name = "CfechaNac";
            // 
            // Csexo
            // 
            Csexo.HeaderText = "Sexo";
            Csexo.Name = "Csexo";
            // 
            // ColumnaEliminar
            // 
            ColumnaEliminar.HeaderText = "Eliminar";
            ColumnaEliminar.Name = "ColumnaEliminar";
            ColumnaEliminar.Resizable = DataGridViewTriState.True;
            // 
            // Csaldo
            // 
            Csaldo.HeaderText = "Saldo";
            Csaldo.Name = "Csaldo";
            Csaldo.Resizable = DataGridViewTriState.True;
            Csaldo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaImagen
            // 
            ColumnaImagen.HeaderText = "Foto";
            ColumnaImagen.MinimumWidth = 30;
            ColumnaImagen.Name = "ColumnaImagen";
            // 
            // Cruta
            // 
            Cruta.HeaderText = "Ruta";
            Cruta.Name = "Cruta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondope;
            ClientSize = new Size(826, 517);
            Controls.Add(textBoxSaldo);
            Controls.Add(dataGridView1);
            Controls.Add(btnFoto);
            Controls.Add(btnGuardar);
            Controls.Add(pictureBox1);
            Controls.Add(Mujer);
            Controls.Add(radioHombre);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(labelSexo);
            Controls.Add(labelFecha);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(textFoto);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Name = "Form1";
            Text = "Formulario con DataGrid";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textFoto;
        private TextBox txtSaldo;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelFecha;
        private Label labelSexo;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioHombre;
        private RadioButton Mujer;
        private PictureBox pictureBox1;
        private Button btnGuardar;
        private Button btnFoto;
        private DataGridView dataGridView1;
        private TextBox textBoxSaldo;
        private DataGridViewTextBoxColumn coluApellido;
        private DataGridViewTextBoxColumn ColuNombre;
        private DataGridViewTextBoxColumn CfechaNac;
        private DataGridViewTextBoxColumn Csexo;
        private DataGridViewButtonColumn ColumnaEliminar;
        private DataGridViewTextBoxColumn Csaldo;
        private DataGridViewImageColumn ColumnaImagen;
        private DataGridViewTextBoxColumn Cruta;
    }
}
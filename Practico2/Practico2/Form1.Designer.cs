namespace Practico2
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
            LNombre = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNya = new Label();
            LModificar = new Label();
            TNombre = new TextBox();
            TApellido = new TextBox();
            TDni = new TextBox();
            TGuardar = new Button();
            TEliminar = new Button();
            panel1 = new Panel();
            CHmastercard = new CheckBox();
            CHvisa = new CheckBox();
            CHnaranja = new CheckBox();
            LTarjeta = new Label();
            LTelefono = new Label();
            TTelefono = new TextBox();
            RBvaron = new RadioButton();
            RBmujer = new RadioButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BTNsalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(24, 142);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(48, 58);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(24, 100);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(3, 26);
            LNya.Name = "LNya";
            LNya.Size = new Size(110, 15);
            LNya.TabIndex = 4;
            LNya.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(122, 26);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 5;
            LModificar.Text = "Modificar";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(122, 142);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 6;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(122, 100);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 7;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TDni
            // 
            TDni.Location = new Point(122, 58);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 8;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TGuardar
            // 
            TGuardar.Image = Properties.Resources.WhatsApp_Image_2023_08_25_at_01_451;
            TGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            TGuardar.Location = new Point(12, 428);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(135, 67);
            TGuardar.TabIndex = 9;
            TGuardar.Text = "Guardar";
            TGuardar.TextAlign = ContentAlignment.MiddleRight;
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Image = Properties.Resources.WhatsApp_Image_2023_08_25_at_01_453;
            TEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            TEliminar.Location = new Point(153, 428);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(147, 67);
            TEliminar.TabIndex = 10;
            TEliminar.Text = "Eliminar";
            TEliminar.TextAlign = ContentAlignment.MiddleRight;
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(CHmastercard);
            panel1.Controls.Add(CHvisa);
            panel1.Controls.Add(CHnaranja);
            panel1.Controls.Add(LTarjeta);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LNya);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(LApellido);
            panel1.Location = new Point(27, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 349);
            panel1.TabIndex = 11;
            // 
            // CHmastercard
            // 
            CHmastercard.AutoSize = true;
            CHmastercard.Location = new Point(147, 320);
            CHmastercard.Name = "CHmastercard";
            CHmastercard.Size = new Size(85, 19);
            CHmastercard.TabIndex = 14;
            CHmastercard.Text = "Mastercard";
            CHmastercard.UseVisualStyleBackColor = true;
            // 
            // CHvisa
            // 
            CHvisa.AutoSize = true;
            CHvisa.Location = new Point(147, 295);
            CHvisa.Name = "CHvisa";
            CHvisa.Size = new Size(47, 19);
            CHvisa.TabIndex = 13;
            CHvisa.Text = "Visa";
            CHvisa.UseVisualStyleBackColor = true;
            // 
            // CHnaranja
            // 
            CHnaranja.AutoSize = true;
            CHnaranja.Location = new Point(147, 270);
            CHnaranja.Name = "CHnaranja";
            CHnaranja.Size = new Size(67, 19);
            CHnaranja.TabIndex = 12;
            CHnaranja.Text = "Naranja";
            CHnaranja.UseVisualStyleBackColor = true;
            // 
            // LTarjeta
            // 
            LTarjeta.AutoSize = true;
            LTarjeta.Location = new Point(33, 258);
            LTarjeta.Name = "LTarjeta";
            LTarjeta.Size = new Size(102, 15);
            LTarjeta.TabIndex = 11;
            LTarjeta.Text = "Tarjetas de credito";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(26, 192);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(52, 15);
            LTelefono.TabIndex = 10;
            LTelefono.Text = "Telefono";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(122, 185);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(100, 23);
            TTelefono.TabIndex = 9;
            
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // RBvaron
            // 
            RBvaron.AutoSize = true;
            RBvaron.Checked = true;
            RBvaron.Location = new Point(359, 210);
            RBvaron.Name = "RBvaron";
            RBvaron.Size = new Size(55, 19);
            RBvaron.TabIndex = 14;
            RBvaron.TabStop = true;
            RBvaron.Text = "Varon";
            RBvaron.UseVisualStyleBackColor = true;
            RBvaron.CheckedChanged += RBvaron_CheckedChanged;
            // 
            // RBmujer
            // 
            RBmujer.AutoSize = true;
            RBmujer.Location = new Point(434, 210);
            RBmujer.Name = "RBmujer";
            RBmujer.Size = new Size(56, 19);
            RBmujer.TabIndex = 15;
            RBmujer.Text = "Mujer";
            RBmujer.UseVisualStyleBackColor = true;
            RBmujer.CheckedChanged += RBmujer_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hombre;
            pictureBox1.Location = new Point(359, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(221, 19);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 17;
            label1.Text = "Nuevo Cliente";
            // 
            // BTNsalir
            // 
            BTNsalir.Image = Properties.Resources.WhatsApp_Image_2023_08_25_at_01_58_50;
            BTNsalir.ImageAlign = ContentAlignment.MiddleLeft;
            BTNsalir.Location = new Point(400, 428);
            BTNsalir.Name = "BTNsalir";
            BTNsalir.Size = new Size(144, 67);
            BTNsalir.TabIndex = 18;
            BTNsalir.Text = "Salir";
            BTNsalir.TextAlign = ContentAlignment.MiddleRight;
            BTNsalir.UseVisualStyleBackColor = true;
            BTNsalir.Click += BTNsalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 507);
            Controls.Add(BTNsalir);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(RBmujer);
            Controls.Add(RBvaron);
            Controls.Add(panel1);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Name = "Form1";
            Text = "Pequeño Formulario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LNombre;
        private Label LDni;
        private Label LApellido;
        private Label LNya;
        private Label LModificar;
        private TextBox TNombre;
        private TextBox TApellido;
        private TextBox TDni;
        private Button TGuardar;
        private Button TEliminar;
        private Panel panel1;
        private Label LTelefono;
        private TextBox TTelefono;
        private CheckBox CHmastercard;
        private CheckBox CHvisa;
        private CheckBox CHnaranja;
        private Label LTarjeta;
        private RadioButton RBvaron;
        private RadioButton RBmujer;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BTNsalir;
    }
}
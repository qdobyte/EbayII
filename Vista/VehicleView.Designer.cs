namespace Vista
{
    partial class VehicleView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleView));
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblKilometraje = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbKilometraje = new System.Windows.Forms.TextBox();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbSubirImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txbVendedor = new System.Windows.Forms.TextBox();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cbxLinea = new System.Windows.Forms.ComboBox();
            this.cbxCiudad = new System.Windows.Forms.ComboBox();
            this.txbMotor = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(35, 55);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(87, 13);
            this.lblTipoVehiculo.TabIndex = 0;
            this.lblTipoVehiculo.Text = "Tipo de Vehiculo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(35, 81);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(35, 107);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(33, 13);
            this.lblLinea.TabIndex = 2;
            this.lblLinea.Text = "Linea";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(35, 133);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(35, 263);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(35, 211);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(34, 13);
            this.lblMotor.TabIndex = 6;
            this.lblMotor.Text = "Motor";
            // 
            // lblKilometraje
            // 
            this.lblKilometraje.AutoSize = true;
            this.lblKilometraje.Location = new System.Drawing.Point(35, 185);
            this.lblKilometraje.Name = "lblKilometraje";
            this.lblKilometraje.Size = new System.Drawing.Size(58, 13);
            this.lblKilometraje.TabIndex = 5;
            this.lblKilometraje.Text = "Kilometraje";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(35, 159);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(35, 237);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad";
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(129, 605);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(75, 23);
            this.btnPublicar.TabIndex = 12;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Location = new System.Drawing.Point(116, 12);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(110, 13);
            this.lblEncabezado.TabIndex = 10;
            this.lblEncabezado.Text = "Registro de Vehiculos";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(147, 74);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(166, 20);
            this.txbMarca.TabIndex = 1;
            // 
            // txbKilometraje
            // 
            this.txbKilometraje.Location = new System.Drawing.Point(147, 178);
            this.txbKilometraje.Name = "txbKilometraje";
            this.txbKilometraje.Size = new System.Drawing.Size(166, 20);
            this.txbKilometraje.TabIndex = 5;
            this.txbKilometraje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKilometraje_KeyPress);
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(147, 152);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(166, 20);
            this.txbPlaca.TabIndex = 4;
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(147, 126);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(166, 20);
            this.txbModelo.TabIndex = 3;
            this.txbModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbModelo_KeyPress);
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(147, 256);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(166, 20);
            this.txbPrecio.TabIndex = 8;
            this.txbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecio_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(38, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btbSubirImagen
            // 
            this.btbSubirImagen.Location = new System.Drawing.Point(319, 548);
            this.btbSubirImagen.Name = "btbSubirImagen";
            this.btbSubirImagen.Size = new System.Drawing.Size(30, 23);
            this.btbSubirImagen.TabIndex = 11;
            this.btbSubirImagen.Text = "...";
            this.btbSubirImagen.UseVisualStyleBackColor = true;
            this.btbSubirImagen.Click += new System.EventHandler(this.btbSubirImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(35, 289);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 13;
            this.lblVendedor.Text = "Vendedor";
            // 
            // txbVendedor
            // 
            this.txbVendedor.Location = new System.Drawing.Point(147, 282);
            this.txbVendedor.Name = "txbVendedor";
            this.txbVendedor.Size = new System.Drawing.Size(166, 20);
            this.txbVendedor.TabIndex = 9;
            this.txbVendedor.TextChanged += new System.EventHandler(this.txbVendedor_TextChanged);
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(147, 47);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(166, 21);
            this.cbxTipoVehiculo.TabIndex = 0;
            // 
            // cbxLinea
            // 
            this.cbxLinea.FormattingEnabled = true;
            this.cbxLinea.Location = new System.Drawing.Point(147, 99);
            this.cbxLinea.Name = "cbxLinea";
            this.cbxLinea.Size = new System.Drawing.Size(166, 21);
            this.cbxLinea.TabIndex = 2;
            // 
            // cbxCiudad
            // 
            this.cbxCiudad.FormattingEnabled = true;
            this.cbxCiudad.Location = new System.Drawing.Point(147, 229);
            this.cbxCiudad.Name = "cbxCiudad";
            this.cbxCiudad.Size = new System.Drawing.Size(166, 21);
            this.cbxCiudad.TabIndex = 7;
            // 
            // txbMotor
            // 
            this.txbMotor.Location = new System.Drawing.Point(147, 204);
            this.txbMotor.Name = "txbMotor";
            this.txbMotor.Size = new System.Drawing.Size(166, 20);
            this.txbMotor.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(35, 315);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(147, 308);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(166, 83);
            this.txbDescripcion.TabIndex = 10;
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(38, 578);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(275, 20);
            this.txbUrl.TabIndex = 17;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 640);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txbMotor);
            this.Controls.Add(this.cbxCiudad);
            this.Controls.Add(this.cbxLinea);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Controls.Add(this.txbVendedor);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.btbSubirImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbKilometraje);
            this.Controls.Add(this.txbPlaca);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.lblKilometraje);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblKilometraje;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btbSubirImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblVendedor;
        public System.Windows.Forms.ComboBox cbxTipoVehiculo;
        public System.Windows.Forms.TextBox txbMarca;
        public System.Windows.Forms.TextBox txbKilometraje;
        public System.Windows.Forms.TextBox txbPlaca;
        public System.Windows.Forms.TextBox txbModelo;
        public System.Windows.Forms.TextBox txbPrecio;
        public System.Windows.Forms.TextBox txbVendedor;
        public System.Windows.Forms.ComboBox cbxLinea;
        public System.Windows.Forms.ComboBox cbxCiudad;
        public System.Windows.Forms.TextBox txbMotor;
        private System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbUrl;
    }
}
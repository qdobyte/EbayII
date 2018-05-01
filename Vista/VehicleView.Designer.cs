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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.txtTipoVehiculo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLinea = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPlaca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCilindraje = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtModelo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKilometraje = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCiudad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtVendedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btbSubirImagen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPublicar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAccesorios = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(401, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(780, 507);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(10, 20);
            this.txbUrl.TabIndex = 17;
            this.txbUrl.Visible = false;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(254, 27);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(270, 37);
            this.lblEncabezado.TabIndex = 33;
            this.lblEncabezado.Text = "Registro de Vehiculos";
            // 
            // txtTipoVehiculo
            // 
            this.txtTipoVehiculo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoVehiculo.ForeColor = System.Drawing.Color.White;
            this.txtTipoVehiculo.HintForeColor = System.Drawing.Color.White;
            this.txtTipoVehiculo.HintText = "Tipo Vehiculo";
            this.txtTipoVehiculo.isPassword = false;
            this.txtTipoVehiculo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtTipoVehiculo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtTipoVehiculo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtTipoVehiculo.LineThickness = 3;
            this.txtTipoVehiculo.Location = new System.Drawing.Point(11, 100);
            this.txtTipoVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoVehiculo.Name = "txtTipoVehiculo";
            this.txtTipoVehiculo.Size = new System.Drawing.Size(155, 31);
            this.txtTipoVehiculo.TabIndex = 0;
            this.txtTipoVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLinea
            // 
            this.txtLinea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLinea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea.ForeColor = System.Drawing.Color.White;
            this.txtLinea.HintForeColor = System.Drawing.Color.White;
            this.txtLinea.HintText = "Linea";
            this.txtLinea.isPassword = false;
            this.txtLinea.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtLinea.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtLinea.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtLinea.LineThickness = 3;
            this.txtLinea.Location = new System.Drawing.Point(11, 152);
            this.txtLinea.Margin = new System.Windows.Forms.Padding(4);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(155, 31);
            this.txtLinea.TabIndex = 2;
            this.txtLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.ForeColor = System.Drawing.Color.White;
            this.txtPlaca.HintForeColor = System.Drawing.Color.White;
            this.txtPlaca.HintText = "Placa";
            this.txtPlaca.isPassword = false;
            this.txtPlaca.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtPlaca.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtPlaca.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtPlaca.LineThickness = 3;
            this.txtPlaca.Location = new System.Drawing.Point(11, 204);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(155, 31);
            this.txtPlaca.TabIndex = 4;
            this.txtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCilindraje
            // 
            this.txtCilindraje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCilindraje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCilindraje.ForeColor = System.Drawing.Color.White;
            this.txtCilindraje.HintForeColor = System.Drawing.Color.White;
            this.txtCilindraje.HintText = "Cilindraje";
            this.txtCilindraje.isPassword = false;
            this.txtCilindraje.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtCilindraje.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtCilindraje.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtCilindraje.LineThickness = 3;
            this.txtCilindraje.Location = new System.Drawing.Point(11, 256);
            this.txtCilindraje.Margin = new System.Windows.Forms.Padding(4);
            this.txtCilindraje.Name = "txtCilindraje";
            this.txtCilindraje.Size = new System.Drawing.Size(155, 31);
            this.txtCilindraje.TabIndex = 6;
            this.txtCilindraje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMarca
            // 
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.HintForeColor = System.Drawing.Color.White;
            this.txtMarca.HintText = "Marca";
            this.txtMarca.isPassword = false;
            this.txtMarca.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtMarca.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtMarca.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtMarca.LineThickness = 3;
            this.txtMarca.Location = new System.Drawing.Point(190, 100);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(155, 31);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtModelo
            // 
            this.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.White;
            this.txtModelo.HintForeColor = System.Drawing.Color.White;
            this.txtModelo.HintText = "Modelo";
            this.txtModelo.isPassword = false;
            this.txtModelo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtModelo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtModelo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtModelo.LineThickness = 3;
            this.txtModelo.Location = new System.Drawing.Point(190, 152);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(155, 31);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKilometraje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometraje.ForeColor = System.Drawing.Color.White;
            this.txtKilometraje.HintForeColor = System.Drawing.Color.White;
            this.txtKilometraje.HintText = "Kilometraje";
            this.txtKilometraje.isPassword = false;
            this.txtKilometraje.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtKilometraje.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtKilometraje.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtKilometraje.LineThickness = 3;
            this.txtKilometraje.Location = new System.Drawing.Point(190, 204);
            this.txtKilometraje.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(155, 31);
            this.txtKilometraje.TabIndex = 5;
            this.txtKilometraje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCiudad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.ForeColor = System.Drawing.Color.White;
            this.txtCiudad.HintForeColor = System.Drawing.Color.White;
            this.txtCiudad.HintText = "Ciudad";
            this.txtCiudad.isPassword = false;
            this.txtCiudad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtCiudad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtCiudad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtCiudad.LineThickness = 3;
            this.txtCiudad.Location = new System.Drawing.Point(190, 257);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(155, 31);
            this.txtCiudad.TabIndex = 7;
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.ForeColor = System.Drawing.Color.White;
            this.txtVendedor.HintForeColor = System.Drawing.Color.White;
            this.txtVendedor.HintText = "Vendedor";
            this.txtVendedor.isPassword = false;
            this.txtVendedor.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtVendedor.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtVendedor.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtVendedor.LineThickness = 3;
            this.txtVendedor.Location = new System.Drawing.Point(11, 309);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(333, 31);
            this.txtVendedor.TabIndex = 100;
            this.txtVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.HintForeColor = System.Drawing.Color.White;
            this.txtPrecio.HintText = "Precio";
            this.txtPrecio.isPassword = false;
            this.txtPrecio.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtPrecio.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtPrecio.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtPrecio.LineThickness = 3;
            this.txtPrecio.Location = new System.Drawing.Point(11, 359);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(333, 31);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(741, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 34);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 45;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btbSubirImagen
            // 
            this.btbSubirImagen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btbSubirImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btbSubirImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbSubirImagen.BorderRadius = 0;
            this.btbSubirImagen.ButtonText = "Subir Foto";
            this.btbSubirImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbSubirImagen.DisabledColor = System.Drawing.Color.Gray;
            this.btbSubirImagen.Iconcolor = System.Drawing.Color.Transparent;
            this.btbSubirImagen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btbSubirImagen.Iconimage")));
            this.btbSubirImagen.Iconimage_right = null;
            this.btbSubirImagen.Iconimage_right_Selected = null;
            this.btbSubirImagen.Iconimage_Selected = null;
            this.btbSubirImagen.IconMarginLeft = 0;
            this.btbSubirImagen.IconMarginRight = 0;
            this.btbSubirImagen.IconRightVisible = true;
            this.btbSubirImagen.IconRightZoom = 0D;
            this.btbSubirImagen.IconVisible = true;
            this.btbSubirImagen.IconZoom = 48D;
            this.btbSubirImagen.IsTab = false;
            this.btbSubirImagen.Location = new System.Drawing.Point(675, 396);
            this.btbSubirImagen.Name = "btbSubirImagen";
            this.btbSubirImagen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btbSubirImagen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btbSubirImagen.OnHoverTextColor = System.Drawing.Color.White;
            this.btbSubirImagen.selected = false;
            this.btbSubirImagen.Size = new System.Drawing.Size(106, 29);
            this.btbSubirImagen.TabIndex = 10;
            this.btbSubirImagen.Text = "Subir Foto";
            this.btbSubirImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbSubirImagen.Textcolor = System.Drawing.Color.White;
            this.btbSubirImagen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSubirImagen.Click += new System.EventHandler(this.btbSubirImagen_Click_1);
            // 
            // btnPublicar
            // 
            this.btnPublicar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnPublicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnPublicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPublicar.BorderRadius = 0;
            this.btnPublicar.ButtonText = "Publicar";
            this.btnPublicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublicar.DisabledColor = System.Drawing.Color.Gray;
            this.btnPublicar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPublicar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPublicar.Iconimage")));
            this.btnPublicar.Iconimage_right = null;
            this.btnPublicar.Iconimage_right_Selected = null;
            this.btnPublicar.Iconimage_Selected = null;
            this.btnPublicar.IconMarginLeft = 0;
            this.btnPublicar.IconMarginRight = 0;
            this.btnPublicar.IconRightVisible = true;
            this.btnPublicar.IconRightZoom = 0D;
            this.btnPublicar.IconVisible = true;
            this.btnPublicar.IconZoom = 48D;
            this.btnPublicar.IsTab = false;
            this.btnPublicar.Location = new System.Drawing.Point(495, 471);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnPublicar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnPublicar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPublicar.selected = false;
            this.btnPublicar.Size = new System.Drawing.Size(161, 42);
            this.btnPublicar.TabIndex = 11;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPublicar.Textcolor = System.Drawing.Color.White;
            this.btnPublicar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // txtAccesorios
            // 
            this.txtAccesorios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccesorios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccesorios.ForeColor = System.Drawing.Color.White;
            this.txtAccesorios.HintForeColor = System.Drawing.Color.White;
            this.txtAccesorios.HintText = "Accesorios";
            this.txtAccesorios.isPassword = false;
            this.txtAccesorios.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtAccesorios.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtAccesorios.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtAccesorios.LineThickness = 3;
            this.txtAccesorios.Location = new System.Drawing.Point(11, 437);
            this.txtAccesorios.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccesorios.Name = "txtAccesorios";
            this.txtAccesorios.Size = new System.Drawing.Size(333, 89);
            this.txtAccesorios.TabIndex = 9;
            this.txtAccesorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VehicleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(793, 539);
            this.Controls.Add(this.txtAccesorios);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btbSubirImagen);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtKilometraje);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCilindraje);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.txtTipoVehiculo);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehicleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Label lblEncabezado;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipoVehiculo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLinea;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPlaca;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCilindraje;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMarca;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtModelo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKilometraje;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCiudad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVendedor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecio;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btbSubirImagen;
        private Bunifu.Framework.UI.BunifuFlatButton btnPublicar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAccesorios;
    }
}
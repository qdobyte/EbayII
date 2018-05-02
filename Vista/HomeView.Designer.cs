namespace Vista
{
    partial class HomeView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.dtgVehiclesList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.lblSortByPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuiOSSwitch2 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuiOSSwitch3 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnVender = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiclesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVehiclesList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgVehiclesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVehiclesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVehiclesList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgVehiclesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVehiclesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVehiclesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVehiclesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiclesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.model,
            this.km,
            this.price});
            this.dtgVehiclesList.DoubleBuffered = true;
            this.dtgVehiclesList.EnableHeadersVisualStyles = false;
            this.dtgVehiclesList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dtgVehiclesList.HeaderForeColor = System.Drawing.Color.White;
            this.dtgVehiclesList.Location = new System.Drawing.Point(12, 136);
            this.dtgVehiclesList.Name = "dtgVehiclesList";
            this.dtgVehiclesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgVehiclesList.Size = new System.Drawing.Size(723, 343);
            this.dtgVehiclesList.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(134, 16);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch1.TabIndex = 36;
            this.bunifuiOSSwitch1.Value = false;
            // 
            // lblSortByPrice
            // 
            this.lblSortByPrice.AutoSize = true;
            this.lblSortByPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortByPrice.ForeColor = System.Drawing.Color.White;
            this.lblSortByPrice.Location = new System.Drawing.Point(55, 21);
            this.lblSortByPrice.Name = "lblSortByPrice";
            this.lblSortByPrice.Size = new System.Drawing.Size(40, 15);
            this.lblSortByPrice.TabIndex = 37;
            this.lblSortByPrice.Text = "Precio";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(55, 53);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(48, 15);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "Modelo";
            // 
            // bunifuiOSSwitch2
            // 
            this.bunifuiOSSwitch2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch2.BackgroundImage")));
            this.bunifuiOSSwitch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch2.Location = new System.Drawing.Point(134, 48);
            this.bunifuiOSSwitch2.Name = "bunifuiOSSwitch2";
            this.bunifuiOSSwitch2.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch2.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuiOSSwitch2.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch2.TabIndex = 39;
            this.bunifuiOSSwitch2.Value = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(55, 85);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(67, 15);
            this.bunifuCustomLabel3.TabIndex = 42;
            this.bunifuCustomLabel3.Text = "Kilometraje";
            // 
            // bunifuiOSSwitch3
            // 
            this.bunifuiOSSwitch3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch3.BackgroundImage")));
            this.bunifuiOSSwitch3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch3.Location = new System.Drawing.Point(134, 80);
            this.bunifuiOSSwitch3.Name = "bunifuiOSSwitch3";
            this.bunifuiOSSwitch3.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch3.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuiOSSwitch3.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch3.TabIndex = 41;
            this.bunifuiOSSwitch3.Value = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuiOSSwitch2);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCheckbox1);
            this.panel1.Controls.Add(this.lblSortByPrice);
            this.panel1.Controls.Add(this.bunifuiOSSwitch3);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuiOSSwitch1);
            this.panel1.Location = new System.Drawing.Point(192, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 118);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(194, 85);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 15);
            this.bunifuCustomLabel4.TabIndex = 44;
            this.bunifuCustomLabel4.Text = "Ascendente";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(269, 80);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 43;
            // 
            // btnVender
            // 
            this.btnVender.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVender.BorderRadius = 0;
            this.btnVender.ButtonText = "Vender";
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.DisabledColor = System.Drawing.Color.Gray;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVender.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVender.Iconimage")));
            this.btnVender.Iconimage_right = null;
            this.btnVender.Iconimage_right_Selected = null;
            this.btnVender.Iconimage_Selected = null;
            this.btnVender.IconMarginLeft = 0;
            this.btnVender.IconMarginRight = 0;
            this.btnVender.IconRightVisible = true;
            this.btnVender.IconRightZoom = 0D;
            this.btnVender.IconVisible = true;
            this.btnVender.IconZoom = 48D;
            this.btnVender.IsTab = false;
            this.btnVender.Location = new System.Drawing.Point(513, 12);
            this.btnVender.Name = "btnVender";
            this.btnVender.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnVender.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnVender.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVender.selected = false;
            this.btnVender.Size = new System.Drawing.Size(108, 42);
            this.btnVender.TabIndex = 41;
            this.btnVender.Text = "Vender";
            this.btnVender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVender.Textcolor = System.Drawing.Color.White;
            this.btnVender.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Logout";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 48D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(627, 12);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(108, 42);
            this.bunifuFlatButton1.TabIndex = 44;
            this.bunifuFlatButton1.Text = "Logout";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Buscar";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 48D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(513, 70);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(222, 42);
            this.bunifuFlatButton2.TabIndex = 45;
            this.bunifuFlatButton2.Text = "Buscar";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.image.Frozen = true;
            this.image.HeaderText = "Imagen";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 57;
            // 
            // model
            // 
            this.model.Frozen = true;
            this.model.HeaderText = "Modelo";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // km
            // 
            this.km.Frozen = true;
            this.km.HeaderText = "Kilometraje";
            this.km.Name = "km";
            this.km.ReadOnly = true;
            // 
            // price
            // 
            this.price.Frozen = true;
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(747, 491);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgVehiclesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ebay";
            this.Load += new System.EventHandler(this.HomeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiclesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgVehiclesList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSortByPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnVender;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}
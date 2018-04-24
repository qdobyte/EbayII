namespace Vista
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxPublicacion = new System.Windows.Forms.PictureBox();
            this.lblPrecioPublicacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPublicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPublicacion
            // 
            this.pictureBoxPublicacion.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPublicacion.Name = "pictureBoxPublicacion";
            this.pictureBoxPublicacion.Size = new System.Drawing.Size(226, 152);
            this.pictureBoxPublicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPublicacion.TabIndex = 0;
            this.pictureBoxPublicacion.TabStop = false;
            // 
            // lblPrecioPublicacion
            // 
            this.lblPrecioPublicacion.AutoSize = true;
            this.lblPrecioPublicacion.Location = new System.Drawing.Point(3, 158);
            this.lblPrecioPublicacion.Name = "lblPrecioPublicacion";
            this.lblPrecioPublicacion.Size = new System.Drawing.Size(35, 13);
            this.lblPrecioPublicacion.TabIndex = 1;
            this.lblPrecioPublicacion.Text = "label1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrecioPublicacion);
            this.Controls.Add(this.pictureBoxPublicacion);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(232, 231);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPublicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPublicacion;
        private System.Windows.Forms.Label lblPrecioPublicacion;
    }
}

namespace Vista
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUsuarioByLogin = new System.Windows.Forms.Label();
            this.lblContrasenaByLogin = new System.Windows.Forms.Label();
            this.txbUsuarioByLogin = new System.Windows.Forms.TextBox();
            this.txbContrasenaByLogin = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuarioByLogin
            // 
            this.lblUsuarioByLogin.AutoSize = true;
            this.lblUsuarioByLogin.Location = new System.Drawing.Point(60, 63);
            this.lblUsuarioByLogin.Name = "lblUsuarioByLogin";
            this.lblUsuarioByLogin.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioByLogin.TabIndex = 0;
            this.lblUsuarioByLogin.Text = "Usuario";
            // 
            // lblContrasenaByLogin
            // 
            this.lblContrasenaByLogin.AutoSize = true;
            this.lblContrasenaByLogin.Location = new System.Drawing.Point(42, 107);
            this.lblContrasenaByLogin.Name = "lblContrasenaByLogin";
            this.lblContrasenaByLogin.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenaByLogin.TabIndex = 1;
            this.lblContrasenaByLogin.Text = "Contraseña";
            // 
            // txbUsuarioByLogin
            // 
            this.txbUsuarioByLogin.Location = new System.Drawing.Point(130, 56);
            this.txbUsuarioByLogin.Name = "txbUsuarioByLogin";
            this.txbUsuarioByLogin.Size = new System.Drawing.Size(124, 20);
            this.txbUsuarioByLogin.TabIndex = 0;
            // 
            // txbContrasenaByLogin
            // 
            this.txbContrasenaByLogin.Location = new System.Drawing.Point(130, 100);
            this.txbContrasenaByLogin.Name = "txbContrasenaByLogin";
            this.txbContrasenaByLogin.PasswordChar = '*';
            this.txbContrasenaByLogin.Size = new System.Drawing.Size(124, 20);
            this.txbContrasenaByLogin.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(140, 142);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(103, 185);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 207);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txbContrasenaByLogin);
            this.Controls.Add(this.txbUsuarioByLogin);
            this.Controls.Add(this.lblContrasenaByLogin);
            this.Controls.Add(this.lblUsuarioByLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioByLogin;
        private System.Windows.Forms.Label lblContrasenaByLogin;
        private System.Windows.Forms.TextBox txbUsuarioByLogin;
        private System.Windows.Forms.TextBox txbContrasenaByLogin;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblError;
    }
}


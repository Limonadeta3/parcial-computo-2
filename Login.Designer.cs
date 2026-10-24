namespace SistemasUsuarios
{
    partial class Login
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
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblClave = new Label();
            txtUsuarioLogin = new TextBox();
            txtClaveLogin = new TextBox();
            btnIniciarSesion = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(103, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(295, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inicio de Sesión";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(53, 125);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(20, 31);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = " ";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(53, 215);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(140, 31);
            lblClave.TabIndex = 2;
            lblClave.Text = "Contraseña:";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(53, 159);
            txtUsuarioLogin.Multiline = true;
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(380, 53);
            txtUsuarioLogin.TabIndex = 3;
            // 
            // txtClaveLogin
            // 
            txtClaveLogin.Location = new Point(53, 249);
            txtClaveLogin.Multiline = true;
            txtClaveLogin.Name = "txtClaveLogin";
            txtClaveLogin.PasswordChar = '*';
            txtClaveLogin.Size = new Size(380, 53);
            txtClaveLogin.TabIndex = 4;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(158, 362);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(214, 56);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtClaveLogin);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtUsuarioLogin;
        private TextBox txtClaveLogin;
        private Button btnIniciarSesion;
    }
}
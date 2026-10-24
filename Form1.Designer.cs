namespace SistemasUsuarios
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
            lblIdUsuario = new Label();
            txtIdUsuario = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtClave = new TextBox();
            lblClave = new Label();
            txtConfirmarClave = new TextBox();
            lblConfirmarClave = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            btnPrimero = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnUltimo = new Button();
            label1 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(47, 10);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(81, 20);
            lblIdUsuario.TabIndex = 0;
            lblIdUsuario.Text = "ID Usuario:";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(135, 7);
            txtIdUsuario.Multiline = true;
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.ReadOnly = true;
            txtIdUsuario.Size = new Size(165, 32);
            txtIdUsuario.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(146, 79);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(165, 36);
            txtUsuario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(58, 83);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(132, 160);
            txtClave.Multiline = true;
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(179, 37);
            txtClave.TabIndex = 5;
            txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(76, 160);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(48, 20);
            lblClave.TabIndex = 4;
            lblClave.Text = "Clave:";
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(161, 237);
            txtConfirmarClave.Multiline = true;
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.Size = new Size(150, 37);
            txtConfirmarClave.TabIndex = 7;
            txtConfirmarClave.UseSystemPasswordChar = true;
            // 
            // lblConfirmarClave
            // 
            lblConfirmarClave.AutoSize = true;
            lblConfirmarClave.Location = new Point(17, 243);
            lblConfirmarClave.Name = "lblConfirmarClave";
            lblConfirmarClave.Size = new Size(118, 20);
            lblConfirmarClave.TabIndex = 6;
            lblConfirmarClave.Text = "Confirmar Clave:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(470, 207);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(156, 41);
            txtTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(388, 210);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(470, 18);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 47);
            txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(385, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(470, 116);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(168, 39);
            txtDireccion.TabIndex = 13;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(385, 119);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(73, 20);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirrecion:";
            // 
            // btnPrimero
            // 
            btnPrimero.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrimero.Location = new Point(49, 302);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(49, 44);
            btnPrimero.TabIndex = 14;
            btnPrimero.Text = "|<";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(85, 302);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(49, 44);
            btnAnterior.TabIndex = 15;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(195, 302);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(49, 44);
            btnSiguiente.TabIndex = 16;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUltimo.Location = new Point(242, 302);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(49, 44);
            btnUltimo.TabIndex = 17;
            btnUltimo.Text = ">|";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 318);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 18;
            label1.Text = "x o n";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(353, 299);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 44);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(478, 299);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 44);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(602, 299);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 44);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToOrderColumns = true;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(37, 352);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(718, 182);
            dgvUsuarios.TabIndex = 22;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(btnUltimo);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(btnPrimero);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtConfirmarClave);
            Controls.Add(lblConfirmarClave);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(txtIdUsuario);
            Controls.Add(lblIdUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdUsuario;
        private TextBox txtIdUsuario;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtClave;
        private Label lblClave;
        private TextBox txtConfirmarClave;
        private Label lblConfirmarClave;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Button btnPrimero;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnUltimo;
        private Label label1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvUsuarios;
    }
}

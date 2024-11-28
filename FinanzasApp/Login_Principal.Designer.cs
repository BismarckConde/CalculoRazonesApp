namespace FinanzasApp
{
    partial class Login_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Principal));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtUsuarioLogin = new TextBox();
            txrContraseñaLogin = new TextBox();
            label3 = new Label();
            LbCrearUsuario = new Label();
            IconbAceptar = new FontAwesome.Sharp.IconButton();
            IconBCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 20);
            label1.Name = "label1";
            label1.Size = new Size(334, 38);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido al Sistema!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold);
            label2.Location = new Point(232, 79);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Usuario :";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold);
            txtUsuarioLogin.Location = new Point(232, 106);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(122, 27);
            txtUsuarioLogin.TabIndex = 3;
            // 
            // txrContraseñaLogin
            // 
            txrContraseñaLogin.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold);
            txrContraseñaLogin.Location = new Point(232, 171);
            txrContraseñaLogin.Name = "txrContraseñaLogin";
            txrContraseñaLogin.PasswordChar = '*';
            txrContraseñaLogin.Size = new Size(122, 27);
            txrContraseñaLogin.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold);
            label3.Location = new Point(232, 144);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 4;
            label3.Text = "Contraseña :";
            // 
            // LbCrearUsuario
            // 
            LbCrearUsuario.AutoSize = true;
            LbCrearUsuario.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbCrearUsuario.ForeColor = Color.FromArgb(0, 0, 192);
            LbCrearUsuario.Location = new Point(210, 207);
            LbCrearUsuario.Name = "LbCrearUsuario";
            LbCrearUsuario.Size = new Size(255, 16);
            LbCrearUsuario.TabIndex = 6;
            LbCrearUsuario.Text = "¿No tienes usuario?. ¡REGISTRATE AQUI!";
            LbCrearUsuario.Click += LbCrearUsuario_Click;
            // 
            // IconbAceptar
            // 
            IconbAceptar.BackColor = Color.Blue;
            IconbAceptar.FlatStyle = FlatStyle.Flat;
            IconbAceptar.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold);
            IconbAceptar.ForeColor = Color.White;
            IconbAceptar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            IconbAceptar.IconColor = Color.White;
            IconbAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconbAceptar.IconSize = 30;
            IconbAceptar.ImageAlign = ContentAlignment.TopLeft;
            IconbAceptar.Location = new Point(195, 240);
            IconbAceptar.Name = "IconbAceptar";
            IconbAceptar.Size = new Size(126, 37);
            IconbAceptar.TabIndex = 7;
            IconbAceptar.Text = "  Aceptar";
            IconbAceptar.UseVisualStyleBackColor = false;
            IconbAceptar.Click += IconbAceptar_Click;
            // 
            // IconBCancelar
            // 
            IconBCancelar.BackColor = Color.Red;
            IconBCancelar.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold);
            IconBCancelar.ForeColor = Color.White;
            IconBCancelar.IconChar = FontAwesome.Sharp.IconChar.CircleExclamation;
            IconBCancelar.IconColor = Color.Black;
            IconBCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconBCancelar.IconSize = 30;
            IconBCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            IconBCancelar.Location = new Point(335, 240);
            IconBCancelar.Name = "IconBCancelar";
            IconBCancelar.Size = new Size(126, 37);
            IconBCancelar.TabIndex = 8;
            IconBCancelar.Text = "     Cancelar";
            IconBCancelar.UseVisualStyleBackColor = false;
            // 
            // Login_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(476, 289);
            Controls.Add(IconBCancelar);
            Controls.Add(IconbAceptar);
            Controls.Add(LbCrearUsuario);
            Controls.Add(txrContraseñaLogin);
            Controls.Add(label3);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login_Principal";
            Text = "Login_Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtUsuarioLogin;
        private TextBox txrContraseñaLogin;
        private Label label3;
        private Label LbCrearUsuario;
        private FontAwesome.Sharp.IconButton IconbAceptar;
        private FontAwesome.Sharp.IconButton IconBCancelar;
    }
}
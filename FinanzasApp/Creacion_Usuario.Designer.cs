namespace FinanzasApp
{
    partial class Creacion_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creacion_Usuario));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            IconbAceptar = new FontAwesome.Sharp.IconButton();
            txrContraseñaLogin = new TextBox();
            label3 = new Label();
            txtUsuarioLogin = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold);
            label2.Location = new Point(258, 69);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuario :";
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
            IconbAceptar.Location = new Point(336, 216);
            IconbAceptar.Name = "IconbAceptar";
            IconbAceptar.Size = new Size(114, 29);
            IconbAceptar.TabIndex = 13;
            IconbAceptar.Text = "Aceptar";
            IconbAceptar.UseVisualStyleBackColor = false;
            // 
            // txrContraseñaLogin
            // 
            txrContraseñaLogin.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold);
            txrContraseñaLogin.Location = new Point(258, 157);
            txrContraseñaLogin.Name = "txrContraseñaLogin";
            txrContraseñaLogin.PasswordChar = '*';
            txrContraseñaLogin.Size = new Size(192, 27);
            txrContraseñaLogin.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold);
            label3.Location = new Point(258, 130);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 10;
            label3.Text = "Contraseña :";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold);
            txtUsuarioLogin.Location = new Point(258, 92);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(192, 27);
            txtUsuarioLogin.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(441, 28);
            label1.TabIndex = 15;
            label1.Text = "Crea un usuario para ingresar al sistema...";
            // 
            // Creacion_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(481, 270);
            Controls.Add(label1);
            Controls.Add(IconbAceptar);
            Controls.Add(txrContraseñaLogin);
            Controls.Add(label3);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Creacion_Usuario";
            Text = "Creacion_Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private FontAwesome.Sharp.IconButton IconbAceptar;
        private TextBox txrContraseñaLogin;
        private Label label3;
        private TextBox txtUsuarioLogin;
        private Label label1;
    }
}
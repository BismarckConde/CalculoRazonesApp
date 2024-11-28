namespace FinanzasApp.VistaMenu
{
    partial class Balance_General
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
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            txtMonto = new TextBox();
            label3 = new Label();
            txtNombreCuenta = new TextBox();
            cmbTipoActivos = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            cmbTipoPasivos = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            groupBox4 = new GroupBox();
            dgvBalance = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombreCuenta);
            groupBox1.Controls.Add(cmbTipoActivos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Activos";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(136, 141);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 30);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar Activos";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(172, 103);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 25);
            txtMonto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(149, 17);
            label3.TabIndex = 4;
            label3.Text = "Monto de la cuenta :\r\n";
            // 
            // txtNombreCuenta
            // 
            txtNombreCuenta.Location = new Point(172, 62);
            txtNombreCuenta.Name = "txtNombreCuenta";
            txtNombreCuenta.Size = new Size(100, 25);
            txtNombreCuenta.TabIndex = 3;
            // 
            // cmbTipoActivos
            // 
            cmbTipoActivos.FormattingEnabled = true;
            cmbTipoActivos.Location = new Point(148, 29);
            cmbTipoActivos.Name = "cmbTipoActivos";
            cmbTipoActivos.Size = new Size(124, 25);
            cmbTipoActivos.TabIndex = 2;
            cmbTipoActivos.Text = "-- Seleccione --";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(160, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre de la cuenta :\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 0;
            label1.Text = "Tipo de cuenta :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(cmbTipoPasivos);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(372, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 191);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pasivos";
            // 
            // button1
            // 
            button1.Location = new Point(128, 139);
            button1.Name = "button1";
            button1.Size = new Size(141, 32);
            button1.TabIndex = 6;
            button1.Text = "Agregar Pasivos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 106);
            label4.Name = "label4";
            label4.Size = new Size(149, 17);
            label4.TabIndex = 4;
            label4.Text = "Monto de la cuenta :\r\n";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 3;
            // 
            // cmbTipoPasivos
            // 
            cmbTipoPasivos.FormattingEnabled = true;
            cmbTipoPasivos.Location = new Point(136, 29);
            cmbTipoPasivos.Name = "cmbTipoPasivos";
            cmbTipoPasivos.Size = new Size(133, 25);
            cmbTipoPasivos.TabIndex = 2;
            cmbTipoPasivos.Text = "-- Seleccione --";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 67);
            label5.Name = "label5";
            label5.Size = new Size(160, 17);
            label5.TabIndex = 1;
            label5.Text = "Nombre de la cuenta :\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 34);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 0;
            label6.Text = "Tipo de cuenta :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label8);
            groupBox3.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(732, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(296, 191);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Capital";
            // 
            // button2
            // 
            button2.Location = new Point(123, 132);
            button2.Name = "button2";
            button2.Size = new Size(152, 39);
            button2.TabIndex = 6;
            button2.Text = "Agregar Capital";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(175, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 86);
            label7.Name = "label7";
            label7.Size = new Size(149, 17);
            label7.TabIndex = 4;
            label7.Text = "Monto de la cuenta :\r\n";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(175, 44);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 25);
            textBox4.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 47);
            label8.Name = "label8";
            label8.Size = new Size(160, 17);
            label8.TabIndex = 1;
            label8.Text = "Nombre de la cuenta :\r\n";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvBalance);
            groupBox4.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(18, 301);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(788, 295);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Agregados";
            // 
            // dgvBalance
            // 
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Location = new Point(26, 41);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.Size = new Size(739, 234);
            dgvBalance.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(871, 410);
            button3.Name = "button3";
            button3.Size = new Size(110, 54);
            button3.TabIndex = 4;
            button3.Text = "Guardar Datos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(871, 317);
            button4.Name = "button4";
            button4.Size = new Size(110, 54);
            button4.TabIndex = 5;
            button4.Text = "Calcular Balance";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Balance_General
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 618);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Balance_General";
            Text = "Balance_General";
            Load += Balance_General_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMonto;
        private Label label3;
        private TextBox txtNombreCuenta;
        private ComboBox cmbTipoActivos;
        private Label label2;
        private Label label1;
        private Button btnAgregar;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private ComboBox cmbTipoPasivos;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Button button2;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private GroupBox groupBox4;
        private DataGridView dgvBalance;
        private Button button3;
        private Button button4;
    }
}
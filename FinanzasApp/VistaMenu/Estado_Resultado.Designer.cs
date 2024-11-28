namespace FinanzasApp.VistaMenu
{
    partial class Estado_Resultado
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
            label1 = new Label();
            txtIngresos = new TextBox();
            txtCostoVentas = new TextBox();
            label2 = new Label();
            txtGastosOperativos = new TextBox();
            label3 = new Label();
            Otrosingresos = new TextBox();
            label4 = new Label();
            txtOtrosGastos = new TextBox();
            label5 = new Label();
            txtImuesto = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            btnCargar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtImuesto);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtOtrosGastos);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Otrosingresos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGastosOperativos);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCostoVentas);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIngresos);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 364);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado de Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 53);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 0;
            label1.Text = "Ingresos :";
            // 
            // txtIngresos
            // 
            txtIngresos.Location = new Point(98, 50);
            txtIngresos.Name = "txtIngresos";
            txtIngresos.Size = new Size(100, 25);
            txtIngresos.TabIndex = 1;
            txtIngresos.TextChanged += textBox1_TextChanged;
            // 
            // txtCostoVentas
            // 
            txtCostoVentas.Location = new Point(323, 50);
            txtCostoVentas.Name = "txtCostoVentas";
            txtCostoVentas.Size = new Size(100, 25);
            txtCostoVentas.TabIndex = 3;
            txtCostoVentas.TextChanged += txtCostoVentas_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 53);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 2;
            label2.Text = "Costo de venta :";
            // 
            // txtGastosOperativos
            // 
            txtGastosOperativos.Location = new Point(577, 50);
            txtGastosOperativos.Name = "txtGastosOperativos";
            txtGastosOperativos.Size = new Size(100, 25);
            txtGastosOperativos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 53);
            label3.Name = "label3";
            label3.Size = new Size(142, 17);
            label3.TabIndex = 4;
            label3.Text = "Gastos Operativos :";
            // 
            // Otrosingresos
            // 
            Otrosingresos.Location = new Point(142, 112);
            Otrosingresos.Name = "Otrosingresos";
            Otrosingresos.Size = new Size(100, 25);
            Otrosingresos.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 115);
            label4.Name = "label4";
            label4.Size = new Size(118, 17);
            label4.TabIndex = 6;
            label4.Text = "Otros Ingresos :";
            // 
            // txtOtrosGastos
            // 
            txtOtrosGastos.Location = new Point(368, 112);
            txtOtrosGastos.Name = "txtOtrosGastos";
            txtOtrosGastos.Size = new Size(100, 25);
            txtOtrosGastos.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 115);
            label5.Name = "label5";
            label5.Size = new Size(106, 17);
            label5.TabIndex = 8;
            label5.Text = "Otros Gastos :";
            // 
            // txtImuesto
            // 
            txtImuesto.Location = new Point(566, 112);
            txtImuesto.Name = "txtImuesto";
            txtImuesto.Size = new Size(100, 25);
            txtImuesto.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(482, 115);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 10;
            label6.Text = "impuesto :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(773, 150);
            dataGridView1.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(686, 53);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 33);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(686, 115);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 33);
            btnCargar.TabIndex = 14;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // Estado_Resultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 450);
            Controls.Add(groupBox1);
            Name = "Estado_Resultado";
            Text = "Estado_Resultado";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIngresos;
        private Label label1;
        private TextBox Otrosingresos;
        private Label label4;
        private TextBox txtGastosOperativos;
        private Label label3;
        private TextBox txtCostoVentas;
        private Label label2;
        private TextBox txtImuesto;
        private Label label6;
        private TextBox txtOtrosGastos;
        private Label label5;
        private Button btnCargar;
        private Button btnGuardar;
        private DataGridView dataGridView1;
    }
}
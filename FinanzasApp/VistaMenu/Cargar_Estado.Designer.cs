namespace FinanzasApp.VistaMenu
{
    partial class Cargar_Estado
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
            dataGridView1 = new DataGridView();
            btnCargarEstado = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCargarEstado);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(31, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 332);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado de Resultado cargado";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(679, 217);
            dataGridView1.TabIndex = 0;
            // 
            // btnCargarEstado
            // 
            btnCargarEstado.Location = new Point(580, 276);
            btnCargarEstado.Name = "btnCargarEstado";
            btnCargarEstado.Size = new Size(123, 38);
            btnCargarEstado.TabIndex = 1;
            btnCargarEstado.Text = "Mostrar";
            btnCargarEstado.UseVisualStyleBackColor = true;
            // 
            // Cargar_Estado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Cargar_Estado";
            Text = "Cargar_Estado";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCargarEstado;
        private DataGridView dataGridView1;
    }
}
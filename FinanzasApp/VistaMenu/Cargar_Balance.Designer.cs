namespace FinanzasApp.VistaMenu
{
    partial class Cargar_Balance
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
            dgvBalance = new DataGridView();
            btnCargar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Controls.Add(dgvBalance);
            groupBox1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(746, 353);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Balance Cargado";
            // 
            // dgvBalance
            // 
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Location = new Point(22, 57);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.Size = new Size(702, 229);
            dgvBalance.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(559, 307);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(165, 33);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar Balance";
            btnCargar.UseVisualStyleBackColor = true;
         
            // 
            // Cargar_Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Cargar_Balance";
            Text = "Cargar_Balance";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCargar;
        private DataGridView dgvBalance;
    }
}
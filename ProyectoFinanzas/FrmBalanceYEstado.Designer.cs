namespace ProyectoFinanzas
{
    partial class FrmBalanceYEstado
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
            tabControl1 = new TabControl();
            tbgBalanceGeneral = new TabPage();
            button1 = new Button();
            dgvBalanceGeneral = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbgEstadoResultado = new TabPage();
            button2 = new Button();
            dgvEstadoDeResultado = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tbgBalanceGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBalanceGeneral).BeginInit();
            tbgEstadoResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoDeResultado).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbgBalanceGeneral);
            tabControl1.Controls.Add(tbgEstadoResultado);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1048, 534);
            tabControl1.TabIndex = 0;
            // 
            // tbgBalanceGeneral
            // 
            tbgBalanceGeneral.BackColor = Color.FromArgb(49, 66, 82);
            tbgBalanceGeneral.Controls.Add(button1);
            tbgBalanceGeneral.Controls.Add(dgvBalanceGeneral);
            tbgBalanceGeneral.Controls.Add(label4);
            tbgBalanceGeneral.Controls.Add(label3);
            tbgBalanceGeneral.Controls.Add(label2);
            tbgBalanceGeneral.Controls.Add(label1);
            tbgBalanceGeneral.Location = new Point(4, 30);
            tbgBalanceGeneral.Name = "tbgBalanceGeneral";
            tbgBalanceGeneral.Padding = new Padding(3);
            tbgBalanceGeneral.Size = new Size(1040, 500);
            tbgBalanceGeneral.TabIndex = 0;
            tbgBalanceGeneral.Text = "Balance";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(415, 419);
            button1.Name = "button1";
            button1.Size = new Size(220, 51);
            button1.TabIndex = 5;
            button1.Text = "Generar Balance General";
            button1.UseVisualStyleBackColor = false;
            button1.Click += GenerarBalance;
            // 
            // dgvBalanceGeneral
            // 
            dgvBalanceGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBalanceGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalanceGeneral.Location = new Point(162, 173);
            dgvBalanceGeneral.Name = "dgvBalanceGeneral";
            dgvBalanceGeneral.Size = new Size(711, 214);
            dgvBalanceGeneral.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(253, 126);
            label4.Name = "label4";
            label4.Size = new Size(516, 44);
            label4.TabIndex = 3;
            label4.Text = "Cifras expresadas en millones de dólares americanos ($)\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(375, 90);
            label3.Name = "label3";
            label3.Size = new Size(260, 22);
            label3.TabIndex = 2;
            label3.Text = "Al 31 de diciembre de 2019\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(191, 57);
            label2.Name = "label2";
            label2.Size = new Size(640, 22);
            label2.TabIndex = 1;
            label2.Text = "C O C A - C O L A F E M S A , S . A . B . D E C . V . Y S U B S I D I A R I A S\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(375, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 39);
            label1.TabIndex = 0;
            label1.Text = "Balance General";
            // 
            // tbgEstadoResultado
            // 
            tbgEstadoResultado.BackColor = Color.FromArgb(49, 66, 82);
            tbgEstadoResultado.Controls.Add(button2);
            tbgEstadoResultado.Controls.Add(dgvEstadoDeResultado);
            tbgEstadoResultado.Controls.Add(label8);
            tbgEstadoResultado.Controls.Add(label7);
            tbgEstadoResultado.Controls.Add(label6);
            tbgEstadoResultado.Controls.Add(label5);
            tbgEstadoResultado.Location = new Point(4, 30);
            tbgEstadoResultado.Name = "tbgEstadoResultado";
            tbgEstadoResultado.Padding = new Padding(3);
            tbgEstadoResultado.Size = new Size(1040, 500);
            tbgEstadoResultado.TabIndex = 1;
            tbgEstadoResultado.Text = "Estado de Resultado";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 61, 45);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(436, 425);
            button2.Name = "button2";
            button2.Size = new Size(176, 51);
            button2.TabIndex = 6;
            button2.Text = "Generar Estado de Resultado\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += GenerarEstado;
            // 
            // dgvEstadoDeResultado
            // 
            dgvEstadoDeResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstadoDeResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadoDeResultado.Location = new Point(76, 155);
            dgvEstadoDeResultado.Name = "dgvEstadoDeResultado";
            dgvEstadoDeResultado.Size = new Size(885, 264);
            dgvEstadoDeResultado.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(302, 110);
            label8.Name = "label8";
            label8.Size = new Size(428, 42);
            label8.TabIndex = 4;
            label8.Text = "Cifras expresadas en millones de dólares americanos ($)\r\n\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(401, 77);
            label7.Name = "label7";
            label7.Size = new Size(225, 21);
            label7.TabIndex = 3;
            label7.Text = "AL 31 de diciembre del 2019\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(193, 45);
            label6.Name = "label6";
            label6.Size = new Size(651, 23);
            label6.TabIndex = 2;
            label6.Text = "C O C A - C O L A F E M S A , S . A . B . D E C . V . y S U B S I D I A R I A S\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(348, 12);
            label5.Name = "label5";
            label5.Size = new Size(344, 33);
            label5.TabIndex = 1;
            label5.Text = "ESTADO DE RESULTADO";
            // 
            // FrmBalanceYEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1048, 534);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBalanceYEstado";
            Text = "FrmBalanceYEstado";
            Load += FrmBalanceYEstado_Load;
            tabControl1.ResumeLayout(false);
            tbgBalanceGeneral.ResumeLayout(false);
            tbgBalanceGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBalanceGeneral).EndInit();
            tbgEstadoResultado.ResumeLayout(false);
            tbgEstadoResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoDeResultado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbgBalanceGeneral;
        private TabPage tbgEstadoResultado;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private DataGridView dgvBalanceGeneral;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private DataGridView dgvEstadoDeResultado;
        private Button button2;
    }
}
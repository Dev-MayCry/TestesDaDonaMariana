namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
    partial class TelaQuestao
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtListaDisciplinas = new ComboBox();
            txtListaMaterias = new ComboBox();
            txtSerie = new NumericUpDown();
            txtEnunciado = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            alternativaD = new RadioButton();
            alternativaA = new RadioButton();
            alternativaB = new RadioButton();
            alternativaC = new RadioButton();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            txtAlternativaD = new TextBox();
            txtAlternativaC = new TextBox();
            txtAlternativaB = new TextBox();
            txtAlternativaA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtSerie).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Disciplina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Matéria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Enunciado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 41);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Série:";
            // 
            // txtListaDisciplinas
            // 
            txtListaDisciplinas.FormattingEnabled = true;
            txtListaDisciplinas.Location = new Point(109, 39);
            txtListaDisciplinas.Name = "txtListaDisciplinas";
            txtListaDisciplinas.Size = new Size(486, 23);
            txtListaDisciplinas.TabIndex = 5;
            txtListaDisciplinas.SelectedIndexChanged += txtListaDisciplinas_SelectedIndexChanged;
            // 
            // txtListaMaterias
            // 
            txtListaMaterias.FormattingEnabled = true;
            txtListaMaterias.Location = new Point(109, 68);
            txtListaMaterias.Name = "txtListaMaterias";
            txtListaMaterias.Size = new Size(625, 23);
            txtListaMaterias.TabIndex = 6;
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(642, 39);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(92, 23);
            txtSerie.TabIndex = 7;
            txtSerie.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtSerie.ValueChanged += txtSerie_ValueChanged;
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(109, 97);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(625, 178);
            txtEnunciado.TabIndex = 8;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(578, 430);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 50);
            btnOK.TabIndex = 13;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(659, 430);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 50);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(109, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(63, 23);
            txtId.TabIndex = 17;
            txtId.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 13);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 16;
            label6.Text = "Id:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(alternativaD);
            groupBox1.Controls.Add(alternativaA);
            groupBox1.Controls.Add(alternativaB);
            groupBox1.Controls.Add(alternativaC);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAlternativaD);
            groupBox1.Controls.Add(txtAlternativaC);
            groupBox1.Controls.Add(txtAlternativaB);
            groupBox1.Controls.Add(txtAlternativaA);
            groupBox1.Location = new Point(111, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 143);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas";
            // 
            // alternativaD
            // 
            alternativaD.AutoSize = true;
            alternativaD.Location = new Point(602, 114);
            alternativaD.Name = "alternativaD";
            alternativaD.Size = new Size(14, 13);
            alternativaD.TabIndex = 20;
            alternativaD.TabStop = true;
            alternativaD.UseVisualStyleBackColor = true;
            // 
            // alternativaA
            // 
            alternativaA.AutoSize = true;
            alternativaA.Location = new Point(602, 27);
            alternativaA.Name = "alternativaA";
            alternativaA.Size = new Size(14, 13);
            alternativaA.TabIndex = 8;
            alternativaA.TabStop = true;
            alternativaA.UseVisualStyleBackColor = true;
            // 
            // alternativaB
            // 
            alternativaB.AutoSize = true;
            alternativaB.Location = new Point(602, 56);
            alternativaB.Name = "alternativaB";
            alternativaB.Size = new Size(14, 13);
            alternativaB.TabIndex = 9;
            alternativaB.TabStop = true;
            alternativaB.UseVisualStyleBackColor = true;
            // 
            // alternativaC
            // 
            alternativaC.AutoSize = true;
            alternativaC.Location = new Point(602, 85);
            alternativaC.Name = "alternativaC";
            alternativaC.Size = new Size(14, 13);
            alternativaC.TabIndex = 19;
            alternativaC.TabStop = true;
            alternativaC.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 112);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 7;
            label9.Text = "d)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 83);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 6;
            label8.Text = "c)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 54);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 5;
            label7.Text = "b)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 25);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 4;
            label4.Text = "a)";
            // 
            // txtAlternativaD
            // 
            txtAlternativaD.Location = new Point(30, 109);
            txtAlternativaD.Name = "txtAlternativaD";
            txtAlternativaD.Size = new Size(566, 23);
            txtAlternativaD.TabIndex = 3;
            txtAlternativaD.EnabledChanged += txtAlternativaD_TextChanged;
            txtAlternativaD.TextChanged += txtAlternativaD_TextChanged;
            // 
            // txtAlternativaC
            // 
            txtAlternativaC.Location = new Point(30, 80);
            txtAlternativaC.Name = "txtAlternativaC";
            txtAlternativaC.Size = new Size(566, 23);
            txtAlternativaC.TabIndex = 2;
            txtAlternativaC.EnabledChanged += txtAlternativaC_TextChanged;
            txtAlternativaC.TextChanged += txtAlternativaC_TextChanged;
            // 
            // txtAlternativaB
            // 
            txtAlternativaB.Location = new Point(30, 51);
            txtAlternativaB.Name = "txtAlternativaB";
            txtAlternativaB.Size = new Size(566, 23);
            txtAlternativaB.TabIndex = 1;
            txtAlternativaB.EnabledChanged += txtAlternativaB_TextChanged;
            txtAlternativaB.TextChanged += txtAlternativaB_TextChanged;
            // 
            // txtAlternativaA
            // 
            txtAlternativaA.Location = new Point(30, 22);
            txtAlternativaA.Name = "txtAlternativaA";
            txtAlternativaA.Size = new Size(566, 23);
            txtAlternativaA.TabIndex = 0;
            txtAlternativaA.TextChanged += txtAlternativaA_TextChanged;
            // 
            // TelaQuestao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 493);
            Controls.Add(groupBox1);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtEnunciado);
            Controls.Add(txtSerie);
            Controls.Add(txtListaMaterias);
            Controls.Add(txtListaDisciplinas);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestao";
            ShowIcon = false;
            Text = "Cadastro de Questão";
            ((System.ComponentModel.ISupportInitialize)txtSerie).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private ComboBox txtListaDisciplinas;
        private ComboBox txtListaMaterias;
        private NumericUpDown txtSerie;
        private TextBox txtEnunciado;
        private Button btnOK;
        private Button btnCancelar;
        private TextBox txtId;
        private Label label6;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private TextBox txtAlternativaD;
        private TextBox txtAlternativaC;
        private TextBox txtAlternativaB;
        private TextBox txtAlternativaA;
        private RadioButton alternativaD;
        private RadioButton alternativaA;
        private RadioButton alternativaB;
        private RadioButton alternativaC;
    }
}
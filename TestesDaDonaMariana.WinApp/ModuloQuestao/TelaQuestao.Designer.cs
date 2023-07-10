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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtListaDisciplinas = new System.Windows.Forms.ComboBox();
            this.txtSerie = new System.Windows.Forms.NumericUpDown();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alternativaD = new System.Windows.Forms.RadioButton();
            this.alternativaA = new System.Windows.Forms.RadioButton();
            this.alternativaB = new System.Windows.Forms.RadioButton();
            this.alternativaC = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlternativaD = new System.Windows.Forms.TextBox();
            this.txtAlternativaC = new System.Windows.Forms.TextBox();
            this.txtAlternativaB = new System.Windows.Forms.TextBox();
            this.txtAlternativaA = new System.Windows.Forms.TextBox();
            this.txtListaMaterias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disciplina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matéria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enunciado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Série:";
            // 
            // txtListaDisciplinas
            // 
            this.txtListaDisciplinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtListaDisciplinas.FormattingEnabled = true;
            this.txtListaDisciplinas.Location = new System.Drawing.Point(109, 39);
            this.txtListaDisciplinas.Name = "txtListaDisciplinas";
            this.txtListaDisciplinas.Size = new System.Drawing.Size(486, 23);
            this.txtListaDisciplinas.TabIndex = 5;
            this.txtListaDisciplinas.SelectedIndexChanged += new System.EventHandler(this.txtListaDisciplinas_SelectedIndexChanged);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(642, 39);
            this.txtSerie.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.txtSerie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(92, 23);
            this.txtSerie.TabIndex = 7;
            this.txtSerie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSerie.ValueChanged += new System.EventHandler(this.txtSerie_ValueChanged);
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(109, 97);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(625, 178);
            this.txtEnunciado.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(578, 430);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 50);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(659, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 50);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(109, 10);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(63, 23);
            this.txtId.TabIndex = 17;
            this.txtId.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.alternativaD);
            this.groupBox1.Controls.Add(this.alternativaA);
            this.groupBox1.Controls.Add(this.alternativaB);
            this.groupBox1.Controls.Add(this.alternativaC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAlternativaD);
            this.groupBox1.Controls.Add(this.txtAlternativaC);
            this.groupBox1.Controls.Add(this.txtAlternativaB);
            this.groupBox1.Controls.Add(this.txtAlternativaA);
            this.groupBox1.Location = new System.Drawing.Point(111, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 143);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternativas";
            // 
            // alternativaD
            // 
            this.alternativaD.AutoSize = true;
            this.alternativaD.Location = new System.Drawing.Point(602, 114);
            this.alternativaD.Name = "alternativaD";
            this.alternativaD.Size = new System.Drawing.Size(14, 13);
            this.alternativaD.TabIndex = 20;
            this.alternativaD.TabStop = true;
            this.alternativaD.UseVisualStyleBackColor = true;
            // 
            // alternativaA
            // 
            this.alternativaA.AutoSize = true;
            this.alternativaA.Location = new System.Drawing.Point(602, 27);
            this.alternativaA.Name = "alternativaA";
            this.alternativaA.Size = new System.Drawing.Size(14, 13);
            this.alternativaA.TabIndex = 8;
            this.alternativaA.TabStop = true;
            this.alternativaA.UseVisualStyleBackColor = true;
            // 
            // alternativaB
            // 
            this.alternativaB.AutoSize = true;
            this.alternativaB.Location = new System.Drawing.Point(602, 56);
            this.alternativaB.Name = "alternativaB";
            this.alternativaB.Size = new System.Drawing.Size(14, 13);
            this.alternativaB.TabIndex = 9;
            this.alternativaB.TabStop = true;
            this.alternativaB.UseVisualStyleBackColor = true;
            // 
            // alternativaC
            // 
            this.alternativaC.AutoSize = true;
            this.alternativaC.Location = new System.Drawing.Point(602, 85);
            this.alternativaC.Name = "alternativaC";
            this.alternativaC.Size = new System.Drawing.Size(14, 13);
            this.alternativaC.TabIndex = 19;
            this.alternativaC.TabStop = true;
            this.alternativaC.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "d)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "c)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "b)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "a)";
            // 
            // txtAlternativaD
            // 
            this.txtAlternativaD.Location = new System.Drawing.Point(30, 109);
            this.txtAlternativaD.Name = "txtAlternativaD";
            this.txtAlternativaD.Size = new System.Drawing.Size(566, 23);
            this.txtAlternativaD.TabIndex = 3;
            this.txtAlternativaD.TextChanged += new System.EventHandler(this.txtAlternativaD_TextChanged);
            // 
            // txtAlternativaC
            // 
            this.txtAlternativaC.Location = new System.Drawing.Point(30, 80);
            this.txtAlternativaC.Name = "txtAlternativaC";
            this.txtAlternativaC.Size = new System.Drawing.Size(566, 23);
            this.txtAlternativaC.TabIndex = 2;
            this.txtAlternativaC.TextChanged += new System.EventHandler(this.txtAlternativaC_TextChanged);
            // 
            // txtAlternativaB
            // 
            this.txtAlternativaB.Location = new System.Drawing.Point(30, 51);
            this.txtAlternativaB.Name = "txtAlternativaB";
            this.txtAlternativaB.Size = new System.Drawing.Size(566, 23);
            this.txtAlternativaB.TabIndex = 1;
            this.txtAlternativaB.TextChanged += new System.EventHandler(this.txtAlternativaB_TextChanged);
            // 
            // txtAlternativaA
            // 
            this.txtAlternativaA.Location = new System.Drawing.Point(30, 22);
            this.txtAlternativaA.Name = "txtAlternativaA";
            this.txtAlternativaA.Size = new System.Drawing.Size(566, 23);
            this.txtAlternativaA.TabIndex = 0;
            this.txtAlternativaA.TextChanged += new System.EventHandler(this.txtAlternativaA_TextChanged);
            // 
            // txtListaMaterias
            // 
            this.txtListaMaterias.FormattingEnabled = true;
            this.txtListaMaterias.Location = new System.Drawing.Point(109, 68);
            this.txtListaMaterias.Name = "txtListaMaterias";
            this.txtListaMaterias.Size = new System.Drawing.Size(625, 23);
            this.txtListaMaterias.TabIndex = 19;
            // 
            // TelaQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 491);
            this.Controls.Add(this.txtListaMaterias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtListaDisciplinas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(770, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(770, 530);
            this.Name = "TelaQuestao";
            this.ShowIcon = false;
            this.Text = "Cadastro de Questão";
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private ComboBox txtListaDisciplinas;
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
        private ComboBox txtListaMaterias;
    }
}
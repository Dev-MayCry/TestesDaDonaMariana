namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
    partial class TelaTeste
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
            txtId = new TextBox();
            label6 = new Label();
            txtSerie = new NumericUpDown();
            txtListaDisciplinas = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkRecuperacao = new CheckBox();
            label4 = new Label();
            txtTitulo = new TextBox();
            label3 = new Label();
            txtNumeroQuestoes = new NumericUpDown();
            btnCancelar = new Button();
            btnOK = new Button();
            btnSortear = new Button();
            label7 = new Label();
            listQuestoes = new ListBox();
            txtListaMaterias = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtSerie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNumeroQuestoes).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(515, 25);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(53, 23);
            txtId.TabIndex = 27;
            txtId.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(474, 28);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 26;
            label6.Text = "Id:";
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(515, 54);
            txtSerie.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            txtSerie.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtSerie.Name = "txtSerie";
            txtSerie.ReadOnly = true;
            txtSerie.Size = new Size(53, 23);
            txtSerie.TabIndex = 24;
            txtSerie.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtSerie.ValueChanged += txtSerie_ValueChanged;
            // 
            // txtListaDisciplinas
            // 
            txtListaDisciplinas.DropDownStyle = ComboBoxStyle.DropDownList;
            txtListaDisciplinas.FormattingEnabled = true;
            txtListaDisciplinas.Location = new Point(123, 54);
            txtListaDisciplinas.Name = "txtListaDisciplinas";
            txtListaDisciplinas.Size = new Size(332, 23);
            txtListaDisciplinas.TabIndex = 22;
            txtListaDisciplinas.SelectedIndexChanged += txtListaDisciplinas_SelectedValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(474, 56);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 21;
            label5.Text = "Série:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 86);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 19;
            label2.Text = "Matéria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 56);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 18;
            label1.Text = "Disciplina:";
            // 
            // checkRecuperacao
            // 
            checkRecuperacao.AutoSize = true;
            checkRecuperacao.Location = new Point(474, 88);
            checkRecuperacao.Name = "checkRecuperacao";
            checkRecuperacao.Size = new Size(94, 19);
            checkRecuperacao.TabIndex = 28;
            checkRecuperacao.Text = "Recuperação";
            checkRecuperacao.UseVisualStyleBackColor = true;
            checkRecuperacao.CheckedChanged += checkRecuperacao_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 28);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 29;
            label4.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(123, 24);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(332, 24);
            txtTitulo.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 141);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 31;
            label3.Text = "Número de Questões: ";
            // 
            // txtNumeroQuestoes
            // 
            txtNumeroQuestoes.Location = new Point(157, 139);
            txtNumeroQuestoes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtNumeroQuestoes.Name = "txtNumeroQuestoes";
            txtNumeroQuestoes.ReadOnly = true;
            txtNumeroQuestoes.Size = new Size(53, 23);
            txtNumeroQuestoes.TabIndex = 32;
            txtNumeroQuestoes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(512, 529);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 50);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(426, 529);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 50);
            btnOK.TabIndex = 33;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnSortear
            // 
            btnSortear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSortear.Location = new Point(236, 123);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(359, 50);
            btnSortear.TabIndex = 35;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 192);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 37;
            label7.Text = "Questões Sorteadas:";
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 15;
            listQuestoes.Location = new Point(30, 210);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(565, 304);
            listQuestoes.TabIndex = 38;
            // 
            // txtListaMaterias
            // 
            txtListaMaterias.FormattingEnabled = true;
            txtListaMaterias.Location = new Point(123, 86);
            txtListaMaterias.Name = "txtListaMaterias";
            txtListaMaterias.Size = new Size(332, 23);
            txtListaMaterias.TabIndex = 39;
            txtListaMaterias.SelectedIndexChanged += txtListaMaterias_SelectedValueChanged;
            // 
            // TelaTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 591);
            Controls.Add(txtListaMaterias);
            Controls.Add(listQuestoes);
            Controls.Add(label7);
            Controls.Add(btnSortear);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtNumeroQuestoes);
            Controls.Add(label3);
            Controls.Add(txtTitulo);
            Controls.Add(label4);
            Controls.Add(checkRecuperacao);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(txtSerie);
            Controls.Add(txtListaDisciplinas);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(630, 630);
            MinimumSize = new Size(630, 630);
            Name = "TelaTeste";
            ShowIcon = false;
            Text = "Cadastro de Testes";
            ((System.ComponentModel.ISupportInitialize)txtSerie).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNumeroQuestoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label6;
        private NumericUpDown txtSerie;
        private ComboBox txtListaDisciplinas;
        private Label label5;
        private Label label2;
        private Label label1;
        private CheckBox checkRecuperacao;
        private Label label4;
        private TextBox txtTitulo;
        private Label label3;
        private NumericUpDown txtNumeroQuestoes;
        private Button btnCancelar;
        private Button btnOK;
        private Button btnSortear;
        private Label label7;
        private ListBox listQuestoes;
        private ComboBox txtListaMaterias;
    }
}
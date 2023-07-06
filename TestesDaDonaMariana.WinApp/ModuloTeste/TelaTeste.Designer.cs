namespace TestesDaDonaMariana.WinApp.ModuloTeste {
    partial class TelaTeste {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.NumericUpDown();
            this.txtListaMaterias = new System.Windows.Forms.ComboBox();
            this.txtListaDisciplinas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkRecuperacao = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroQuestoes = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSortear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listQuestoes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroQuestoes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(515, 25);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(53, 23);
            this.txtId.TabIndex = 27;
            this.txtId.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Id:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(515, 54);
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
            this.txtSerie.Size = new System.Drawing.Size(53, 23);
            this.txtSerie.TabIndex = 24;
            this.txtSerie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSerie.ValueChanged += new System.EventHandler(this.txtSerie_ValueChanged);
            // 
            // txtListaMaterias
            // 
            this.txtListaMaterias.FormattingEnabled = true;
            this.txtListaMaterias.Location = new System.Drawing.Point(123, 83);
            this.txtListaMaterias.Name = "txtListaMaterias";
            this.txtListaMaterias.Size = new System.Drawing.Size(332, 23);
            this.txtListaMaterias.TabIndex = 23;
            this.txtListaMaterias.SelectedValueChanged += new System.EventHandler(this.txtListaMaterias_SelectedValueChanged);
            // 
            // txtListaDisciplinas
            // 
            this.txtListaDisciplinas.FormattingEnabled = true;
            this.txtListaDisciplinas.Location = new System.Drawing.Point(123, 54);
            this.txtListaDisciplinas.Name = "txtListaDisciplinas";
            this.txtListaDisciplinas.Size = new System.Drawing.Size(332, 23);
            this.txtListaDisciplinas.TabIndex = 22;
            this.txtListaDisciplinas.SelectedValueChanged += new System.EventHandler(this.txtListaDisciplinas_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Série:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Matéria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Disciplina:";
            // 
            // checkRecuperacao
            // 
            this.checkRecuperacao.AutoSize = true;
            this.checkRecuperacao.Location = new System.Drawing.Point(474, 83);
            this.checkRecuperacao.Name = "checkRecuperacao";
            this.checkRecuperacao.Size = new System.Drawing.Size(94, 19);
            this.checkRecuperacao.TabIndex = 28;
            this.checkRecuperacao.Text = "Recuperação";
            this.checkRecuperacao.UseVisualStyleBackColor = true;
            this.checkRecuperacao.CheckedChanged += new System.EventHandler(this.checkRecuperacao_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(123, 24);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(332, 24);
            this.txtTitulo.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Número de Questões: ";
            // 
            // txtNumeroQuestoes
            // 
            this.txtNumeroQuestoes.Location = new System.Drawing.Point(157, 139);
            this.txtNumeroQuestoes.Name = "txtNumeroQuestoes";
            this.txtNumeroQuestoes.Size = new System.Drawing.Size(53, 23);
            this.txtNumeroQuestoes.TabIndex = 32;
            this.txtNumeroQuestoes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(520, 523);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 50);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(434, 523);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 50);
            this.btnOK.TabIndex = 33;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnSortear
            // 
            this.btnSortear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSortear.Location = new System.Drawing.Point(236, 123);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(359, 50);
            this.btnSortear.TabIndex = 35;
            this.btnSortear.Text = "Sortear Questões";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Questões Sorteadas:";
            // 
            // listQuestoes
            // 
            this.listQuestoes.FormattingEnabled = true;
            this.listQuestoes.ItemHeight = 15;
            this.listQuestoes.Location = new System.Drawing.Point(30, 210);
            this.listQuestoes.Name = "listQuestoes";
            this.listQuestoes.Size = new System.Drawing.Size(565, 304);
            this.listQuestoes.TabIndex = 38;
            // 
            // TelaTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 585);
            this.Controls.Add(this.listQuestoes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNumeroQuestoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkRecuperacao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtListaMaterias);
            this.Controls.Add(this.txtListaDisciplinas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaTeste";
            this.Text = "Cadastro de Testes";
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroQuestoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtId;
        private Label label6;
        private NumericUpDown txtSerie;
        private ComboBox txtListaMaterias;
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
    }
}
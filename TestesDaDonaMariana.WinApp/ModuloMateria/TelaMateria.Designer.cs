namespace TestesDaDonaMariana.WinApp.ModuloMateria
{
    partial class TelaMateria
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
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtDisciplina = new ComboBox();
            label4 = new Label();
            txtSerie = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtSerie).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 71);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 18;
            label3.Text = "Disciplina:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(395, 23);
            txtNome.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 42);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 16;
            label2.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(65, 9);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(63, 23);
            txtId.TabIndex = 15;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 12);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 14;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(395, 168);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(314, 168);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtDisciplina
            // 
            txtDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDisciplina.FormattingEnabled = true;
            txtDisciplina.Location = new Point(65, 68);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(395, 23);
            txtDisciplina.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 108);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 20;
            label4.Text = "Série: ";
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(65, 106);
            txtSerie.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            txtSerie.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(63, 23);
            txtSerie.TabIndex = 22;
            txtSerie.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TelaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 221);
            Controls.Add(txtSerie);
            Controls.Add(label4);
            Controls.Add(txtDisciplina);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaMateria";
            Text = "TelaMateria";
            ((System.ComponentModel.ISupportInitialize)txtSerie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private ComboBox txtDisciplina;
        private Label label4;
        private NumericUpDown txtSerie;
    }
}
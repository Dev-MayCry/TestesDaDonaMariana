namespace TestesDaDonaMariana.WinApp.ModuloDisciplina
{
    partial class TelaDisciplinaForm
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
            btnSalvar = new Button();
            button2 = new Button();
            label1 = new Label();
            txtDisciplina = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(165, 103);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 50);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "OK";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(246, 103);
            button2.Name = "button2";
            button2.Size = new Size(75, 50);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Disciplina:";
            // 
            // txtDisciplina
            // 
            txtDisciplina.Location = new Point(79, 57);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(189, 23);
            txtDisciplina.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 4;
            label2.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(79, 28);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(45, 23);
            txtId.TabIndex = 5;
            txtId.Text = "0";
            // 
            // TelaDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 161);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtDisciplina);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MaximumSize = new Size(350, 200);
            MinimizeBox = false;
            MinimumSize = new Size(350, 200);
            Name = "TelaDisciplinaForm";
            ShowIcon = false;
            Text = "Cadastro de Disciplina";
            Click += btnSalvar_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button button2;
        private Label label1;
        private TextBox txtDisciplina;
        private Label label2;
        private TextBox txtId;
    }
}
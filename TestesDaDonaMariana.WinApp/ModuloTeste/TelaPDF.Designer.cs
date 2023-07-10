namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
    partial class TelaPDF
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            button1 = new Button();
            localFile = new TextBox();
            titulo = new Label();
            folderBrowserDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(403, 133);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 50);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(322, 133);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 50);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(374, 66);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 5;
            button1.Text = "Selecionar Local";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // localFile
            // 
            localFile.Location = new Point(12, 66);
            localFile.Name = "localFile";
            localFile.ReadOnly = true;
            localFile.Size = new Size(350, 23);
            localFile.TabIndex = 6;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(12, 24);
            titulo.Name = "titulo";
            titulo.Size = new Size(50, 19);
            titulo.TabIndex = 7;
            titulo.Text = "label1";
            // 
            // TelaPDF
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(484, 191);
            Controls.Add(titulo);
            Controls.Add(localFile);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximumSize = new Size(500, 230);
            MinimumSize = new Size(500, 230);
            Name = "TelaPDF";
            ShowIcon = false;
            Text = "Imprimir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private Button button1;
        private TextBox localFile;
        private Label titulo;
        private FolderBrowserDialog folderBrowserDialog;
    }
}
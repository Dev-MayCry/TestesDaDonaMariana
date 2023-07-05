namespace e_Agenda.WinApp.ModuloContato
{
    partial class TabelaDisciplinaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridDisciplina = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridDisciplina).BeginInit();
            SuspendLayout();
            // 
            // gridCliente
            // 
            gridDisciplina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDisciplina.Dock = DockStyle.Fill;
            gridDisciplina.Location = new Point(0, 0);
            gridDisciplina.Name = "gridCliente";
            gridDisciplina.RowTemplate.Height = 25;
            gridDisciplina.Size = new Size(442, 413);
            gridDisciplina.TabIndex = 0;
            // 
            // TabelaClienteControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridDisciplina);
            Name = "TabelaClienteControl";
            Size = new Size(442, 413);
            ((System.ComponentModel.ISupportInitialize)gridDisciplina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridDisciplina;
    }
}

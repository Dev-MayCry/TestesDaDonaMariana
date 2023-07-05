namespace TestesDaDonaMariana.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tpMenuCadastros = new ToolStripMenuItem();
            DisciplinaToolStripMenuItem = new ToolStripMenuItem();
            matériasToolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btn_Voltar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_Adicionar = new ToolStripButton();
            btn_Editar = new ToolStripButton();
            btn_Excluir = new ToolStripButton();
            panelRegistros = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tpMenuCadastros });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tpMenuCadastros
            // 
            tpMenuCadastros.DropDownItems.AddRange(new ToolStripItem[] { DisciplinaToolStripMenuItem, matériasToolStripMenuItem1 });
            tpMenuCadastros.Name = "tpMenuCadastros";
            tpMenuCadastros.Size = new Size(71, 20);
            tpMenuCadastros.Text = "Cadastros";
            // 
            // DisciplinaToolStripMenuItem
            // 
            DisciplinaToolStripMenuItem.Name = "DisciplinaToolStripMenuItem";
            DisciplinaToolStripMenuItem.Size = new Size(180, 22);
            DisciplinaToolStripMenuItem.Text = "Disciplinas";
            DisciplinaToolStripMenuItem.Click += DisciplinaToolStripMenuItem_Click;
            // 
            // matériasToolStripMenuItem1
            // 
            matériasToolStripMenuItem1.Name = "matériasToolStripMenuItem1";
            matériasToolStripMenuItem1.Size = new Size(180, 22);
            matériasToolStripMenuItem1.Text = "Matérias";
            matériasToolStripMenuItem1.Click += matériasToolStripMenuItem1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_Voltar, toolStripSeparator1, btn_Adicionar, btn_Editar, btn_Excluir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 47);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_Voltar
            // 
            btn_Voltar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Voltar.Image = Properties.Resources.arrow_back_FILL0_wght500_GRAD0_opsz40;
            btn_Voltar.ImageScaling = ToolStripItemImageScaling.None;
            btn_Voltar.ImageTransparentColor = Color.Magenta;
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(44, 44);
            btn_Voltar.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Adicionar.Image = Properties.Resources.add_box_FILL0_wght500_GRAD0_opsz40;
            btn_Adicionar.ImageScaling = ToolStripItemImageScaling.None;
            btn_Adicionar.ImageTransparentColor = Color.Magenta;
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(44, 44);
            btn_Adicionar.Text = "toolStripButton2";
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Editar.Image = Properties.Resources.edit_FILL0_wght500_GRAD0_opsz40__1_;
            btn_Editar.ImageScaling = ToolStripItemImageScaling.None;
            btn_Editar.ImageTransparentColor = Color.Magenta;
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(44, 44);
            btn_Editar.Text = "toolStripButton3";
            // 
            // btn_Excluir
            // 
            btn_Excluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Excluir.Image = Properties.Resources.delete_FILL0_wght500_GRAD0_opsz40__1_;
            btn_Excluir.ImageScaling = ToolStripItemImageScaling.None;
            btn_Excluir.ImageTransparentColor = Color.Magenta;
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(44, 44);
            btn_Excluir.Text = "toolStripButton4";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 71);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(784, 390);
            panelRegistros.TabIndex = 4;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Testes da Dona Mariana";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tpMenuCadastros;
        private ToolStrip toolStrip1;
        private ToolStripButton btn_Voltar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_Adicionar;
        private ToolStripButton btn_Editar;
        private ToolStripButton btn_Excluir;
        private Panel panelRegistros;
        private ToolStripMenuItem DisciplinaToolStripMenuItem;
        private ToolStripMenuItem matériasToolStripMenuItem1;
    }
}
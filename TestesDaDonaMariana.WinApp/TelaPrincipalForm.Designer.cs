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
            disciplinasToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            questoesToolStripMenuItem = new ToolStripMenuItem();
            testesToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btn_Adicionar = new ToolStripButton();
            btn_Editar = new ToolStripButton();
            btn_Excluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_Visualizar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_Duplicar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btn_Imprimir = new ToolStripButton();
            labelTipoCadastro = new ToolStripLabel();
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
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tpMenuCadastros
            // 
            tpMenuCadastros.DropDownItems.AddRange(new ToolStripItem[] { disciplinasToolStripMenuItem, materiasToolStripMenuItem, questoesToolStripMenuItem, testesToolStripMenuItem });
            tpMenuCadastros.Name = "tpMenuCadastros";
            tpMenuCadastros.Size = new Size(71, 20);
            tpMenuCadastros.Text = "Cadastros";
            // 
            // disciplinasToolStripMenuItem
            // 
            disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            disciplinasToolStripMenuItem.Size = new Size(130, 22);
            disciplinasToolStripMenuItem.Text = "Disciplinas";
            disciplinasToolStripMenuItem.Click += DisciplinaToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(130, 22);
            materiasToolStripMenuItem.Text = "Matérias";
            materiasToolStripMenuItem.Click += matériasToolStripMenuItem1_Click;
            // 
            // questoesToolStripMenuItem
            // 
            questoesToolStripMenuItem.Name = "questoesToolStripMenuItem";
            questoesToolStripMenuItem.Size = new Size(130, 22);
            questoesToolStripMenuItem.Text = "Questões";
            questoesToolStripMenuItem.Click += questõesToolStripMenuItem_Click;
            // 
            // testesToolStripMenuItem
            // 
            testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            testesToolStripMenuItem.Size = new Size(130, 22);
            testesToolStripMenuItem.Text = "Testes";
            testesToolStripMenuItem.Click += testesToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Enabled = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_Adicionar, btn_Editar, btn_Excluir, toolStripSeparator2, btn_Visualizar, toolStripSeparator3, btn_Duplicar, toolStripSeparator4, btn_Imprimir, labelTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1264, 47);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Adicionar.Image = Properties.Resources.add_box_FILL0_wght500_GRAD0_opsz40;
            btn_Adicionar.ImageScaling = ToolStripItemImageScaling.None;
            btn_Adicionar.ImageTransparentColor = Color.Magenta;
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(44, 44);
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
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Excluir.Image = Properties.Resources.delete_FILL0_wght500_GRAD0_opsz40__1_;
            btn_Excluir.ImageScaling = ToolStripItemImageScaling.None;
            btn_Excluir.ImageTransparentColor = Color.Magenta;
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(44, 44);
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 47);
            // 
            // btn_Visualizar
            // 
            btn_Visualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Visualizar.Image = Properties.Resources.preview_FILL0_wght500_GRAD0_opsz40;
            btn_Visualizar.ImageScaling = ToolStripItemImageScaling.None;
            btn_Visualizar.ImageTransparentColor = Color.Magenta;
            btn_Visualizar.Name = "btn_Visualizar";
            btn_Visualizar.Size = new Size(44, 44);
            btn_Visualizar.Click += btn_Visualizar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 47);
            // 
            // btn_Duplicar
            // 
            btn_Duplicar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Duplicar.Image = Properties.Resources.library_add_FILL0_wght500_GRAD0_opsz40__1_;
            btn_Duplicar.ImageScaling = ToolStripItemImageScaling.None;
            btn_Duplicar.ImageTransparentColor = Color.Magenta;
            btn_Duplicar.Name = "btn_Duplicar";
            btn_Duplicar.Size = new Size(44, 44);
            btn_Duplicar.Click += btn_Duplicar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 47);
            // 
            // btn_Imprimir
            // 
            btn_Imprimir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Imprimir.Image = Properties.Resources.print_FILL0_wght500_GRAD0_opsz40;
            btn_Imprimir.ImageScaling = ToolStripItemImageScaling.None;
            btn_Imprimir.ImageTransparentColor = Color.Magenta;
            btn_Imprimir.Name = "btn_Imprimir";
            btn_Imprimir.Size = new Size(44, 44);
            btn_Imprimir.Click += btn_Imprimir_Click;
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(55, 44);
            labelTipoCadastro.Text = "                ";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 71);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1264, 610);
            panelRegistros.TabIndex = 4;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            MaximumSize = new Size(1280, 720);
            MinimizeBox = false;
            MinimumSize = new Size(1280, 720);
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
        private ToolStripButton btn_Adicionar;
        private ToolStripButton btn_Editar;
        private ToolStripButton btn_Excluir;
        private Panel panelRegistros;
        private ToolStripMenuItem DisciplinaToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem questoesToolStripMenuItem;
        private ToolStripLabel labelTipoCadastro;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_Visualizar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_Duplicar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btn_Imprimir;
        private ToolStripMenuItem testesToolStripMenuItem;
        private ToolStripMenuItem disciplinasToolStripMenuItem;
    }
}
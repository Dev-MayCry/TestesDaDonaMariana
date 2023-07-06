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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tpMenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.matériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matériasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.questõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Voltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Adicionar = new System.Windows.Forms.ToolStripButton();
            this.btn_Editar = new System.Windows.Forms.ToolStripButton();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Visualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Duplicar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.testesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.tpMenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matériasToolStripMenuItem,
            this.matériasToolStripMenuItem1,
            this.questõesToolStripMenuItem,
            this.testesToolStripMenuItem});
            this.tpMenuCadastros.Name = "tpMenuCadastros";
            this.tpMenuCadastros.Size = new System.Drawing.Size(71, 20);
            this.tpMenuCadastros.Text = "Cadastros";
            // 
            // DisciplinaToolStripMenuItem
            // 
            this.matériasToolStripMenuItem.Name = "matériasToolStripMenuItem";
            this.matériasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matériasToolStripMenuItem.Text = "Disciplinas";
            DisciplinaToolStripMenuItem.Name = "DisciplinaToolStripMenuItem";
            DisciplinaToolStripMenuItem.Size = new Size(180, 22);
            DisciplinaToolStripMenuItem.Text = "Disciplinas";
            DisciplinaToolStripMenuItem.Click += DisciplinaToolStripMenuItem_Click;
            // 
            // matériasToolStripMenuItem1
            // 
            this.matériasToolStripMenuItem1.Name = "matériasToolStripMenuItem1";
            this.matériasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.matériasToolStripMenuItem1.Text = "Matérias";
            this.matériasToolStripMenuItem1.Click += new System.EventHandler(this.matériasToolStripMenuItem1_Click);
            // 
            // questõesToolStripMenuItem
            // 
            this.questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            this.questõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.questõesToolStripMenuItem.Text = "Questões";
            this.questõesToolStripMenuItem.Click += new System.EventHandler(this.questõesToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Voltar,
            this.toolStripSeparator1,
            this.btn_Adicionar,
            this.btn_Editar,
            this.btn_Excluir,
            this.toolStripSeparator2,
            this.btn_Visualizar,
            this.toolStripSeparator3,
            this.btn_Duplicar,
            this.toolStripSeparator4,
            this.btn_Imprimir,
            this.labelTipoCadastro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 47);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Voltar.Image = global::TestesDaDonaMariana.WinApp.Properties.Resources.arrow_back_FILL0_wght500_GRAD0_opsz40;
            this.btn_Voltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Voltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(44, 44);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Adicionar.Image = global::TestesDaDonaMariana.WinApp.Properties.Resources.add_box_FILL0_wght500_GRAD0_opsz40;
            this.btn_Adicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Adicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(44, 44);
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Editar.Image = global::TestesDaDonaMariana.WinApp.Properties.Resources.edit_FILL0_wght500_GRAD0_opsz40__1_;
            this.btn_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(44, 44);
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Excluir.Image = global::TestesDaDonaMariana.WinApp.Properties.Resources.delete_FILL0_wght500_GRAD0_opsz40__1_;
            this.btn_Excluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(44, 44);
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Visualizar.Image = global::TestesDaDonaMariana.WinApp.Properties.Resources.preview_FILL0_wght500_GRAD0_opsz40;
            this.btn_Visualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Visualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(44, 44);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // btn_Duplicar
            // 
            this.btn_Duplicar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Duplicar.Image = global::TestesDaDonaMariana.WinApp.Properties.Resources.library_add_FILL0_wght500_GRAD0_opsz40__1_;
            this.btn_Duplicar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Duplicar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Duplicar.Name = "btn_Duplicar";
            this.btn_Duplicar.Size = new System.Drawing.Size(44, 44);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Imprimir.Image = global::TestesDaDonaMariana.WinApp.Properties.Resources.print_FILL0_wght500_GRAD0_opsz40;
            this.btn_Imprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(44, 44);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(55, 44);
            this.labelTipoCadastro.Text = "                ";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 71);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(784, 390);
            panelRegistros.TabIndex = 4;
            // 
            // testesToolStripMenuItem
            // 
            this.testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            this.testesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testesToolStripMenuItem.Text = "Testes";
            this.testesToolStripMenuItem.Click += new System.EventHandler(this.testesToolStripMenuItem_Click);
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
        private ToolStripMenuItem questõesToolStripMenuItem;
        private ToolStripLabel labelTipoCadastro;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_Visualizar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_Duplicar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btn_Imprimir;
        private ToolStripMenuItem testesToolStripMenuItem;
    }
}
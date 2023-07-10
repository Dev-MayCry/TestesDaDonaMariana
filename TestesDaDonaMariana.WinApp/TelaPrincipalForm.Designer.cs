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
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Adicionar = new System.Windows.Forms.ToolStripButton();
            this.btn_Editar = new System.Windows.Forms.ToolStripButton();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Visualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Duplicar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.btn_ImprimirGabarito = new System.Windows.Forms.ToolStripButton();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tpMenuCadastros});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tpMenuCadastros
            // 
            this.tpMenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.questoesToolStripMenuItem,
            this.testesToolStripMenuItem});
            this.tpMenuCadastros.Name = "tpMenuCadastros";
            this.tpMenuCadastros.Size = new System.Drawing.Size(71, 20);
            this.tpMenuCadastros.Text = "Cadastros";
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            this.disciplinasToolStripMenuItem.Click += new System.EventHandler(this.DisciplinaToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.materiasToolStripMenuItem.Text = "Matérias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.matériasToolStripMenuItem1_Click);
            // 
            // questoesToolStripMenuItem
            // 
            this.questoesToolStripMenuItem.Name = "questoesToolStripMenuItem";
            this.questoesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.questoesToolStripMenuItem.Text = "Questões";
            this.questoesToolStripMenuItem.Click += new System.EventHandler(this.questõesToolStripMenuItem_Click);
            // 
            // testesToolStripMenuItem
            // 
            this.testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            this.testesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.testesToolStripMenuItem.Text = "Testes";
            this.testesToolStripMenuItem.Click += new System.EventHandler(this.testesToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Adicionar,
            this.btn_Editar,
            this.btn_Excluir,
            this.toolStripSeparator2,
            this.btn_Visualizar,
            this.toolStripSeparator3,
            this.btn_Duplicar,
            this.toolStripSeparator4,
            this.btn_Imprimir,
            this.btn_ImprimirGabarito,
            this.labelTipoCadastro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 47);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
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
            this.btn_Duplicar.Click += new System.EventHandler(this.btn_Duplicar_Click);
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
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_ImprimirGabarito
            // 
            this.btn_ImprimirGabarito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ImprimirGabarito.Image = global::TestesDaDonaMariana.WinApp.Properties.Resources.print_connect_FILL0_wght500_GRAD0_opsz40;
            this.btn_ImprimirGabarito.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ImprimirGabarito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ImprimirGabarito.Name = "btn_ImprimirGabarito";
            this.btn_ImprimirGabarito.Size = new System.Drawing.Size(44, 44);
            this.btn_ImprimirGabarito.Click += new System.EventHandler(this.btn_ImprimirGabarito_Click);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(55, 44);
            this.labelTipoCadastro.Text = "                ";
            // 
            // panelRegistros
            // 
            this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistros.Location = new System.Drawing.Point(0, 71);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(1264, 610);
            this.panelRegistros.TabIndex = 4;
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testes da Dona Mariana";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ToolStripButton btn_ImprimirGabarito;
    }
}
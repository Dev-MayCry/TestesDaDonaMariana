using FestaInfantil.ModuloCliente;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloAlternativa;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste;
using TestesDaDonaMariana.WinApp.Compartilhado;
using TestesDaDonaMariana.WinApp.ModuloMateria;
using TestesDaDonaMariana.WinApp.ModuloQuestao;
using TestesDaDonaMariana.WinApp.ModuloTeste;

namespace TestesDaDonaMariana.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        private RepositorioMateriaEmSql repositorioMateria = new RepositorioMateriaEmSql();
        private RepositorioDisciplinaEmSql repositorioDisciplina = new RepositorioDisciplinaEmSql();
        private RepositorioQuestaoEmSql repositorioQuestao = new RepositorioQuestaoEmSql();
        private RepositorioTesteEmSql repositorioTeste = new RepositorioTesteEmSql();
        private RepositorioAlternativaEmSql repositorioAlternativa = new RepositorioAlternativaEmSql();

        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void matériasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina, repositorioQuestao);
            ConfigurarTelaPrincipal(controlador);
        }

        private void questõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestao(repositorioQuestao, repositorioDisciplina, repositorioMateria, repositorioAlternativa);
            ConfigurarTelaPrincipal(controlador);
        }
        private void testesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTeste(repositorioMateria, repositorioDisciplina, repositorioQuestao, repositorioTeste);
            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            labelTipoCadastro.Text = controlador.LabelTipoCadastro;
            toolStrip1.Enabled = true;
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btn_Adicionar.ToolTipText = controlador.ToolTipInserir;
            btn_Editar.ToolTipText = controlador.ToolTipEditar;
            btn_Excluir.ToolTipText = controlador.ToolTipExcluir;
            btn_Visualizar.ToolTipText = controlador.ToolTipVisualizar;
            btn_Duplicar.ToolTipText = controlador.ToolTipDuplicar;
            btn_Imprimir.ToolTipText = controlador.ToolTipImprimir;


            btn_Adicionar.Enabled = controlador.InserirHabilitado;
            btn_Editar.Enabled = controlador.EditarHabilitado;
            btn_Excluir.Enabled = controlador.ExcluirHabilitado;
            btn_Visualizar.Enabled = controlador.VisualizarHabilitado;
            btn_Duplicar.Enabled = controlador.DuplicarHabilitado;
            btn_Imprimir.Enabled = controlador.ImprimirHabilitado;
        }
        private void DisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }



        private void btn_Editar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }


    }


}

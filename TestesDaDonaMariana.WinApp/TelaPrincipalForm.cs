using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;
using TestesDaDonaMariana.WinApp.Compartilhado;
using TestesDaDonaMariana.WinApp.ModuloMateria;
using TestesDaDonaMariana.WinApp.ModuloQuestao;

namespace TestesDaDonaMariana.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        private RepositorioMateriaEmSql repositorioMateria = new RepositorioMateriaEmSql();
        private RepositorioDisciplinaEmSql repositorioDisciplina = new RepositorioDisciplinaEmSql();
        private RepositorioQuestaoEmSql repositorioQuestao = new RepositorioQuestaoEmSql();

        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void matériasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }

        private void questõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestao(repositorioQuestao, repositorioDisciplina, repositorioMateria);
            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {

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


            btn_Adicionar.Enabled = controlador.InserirHabilitado;
            btn_Editar.Enabled = controlador.EditarHabilitado;
            btn_Excluir.Enabled = controlador.ExcluirHabilitado;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btn_Editar_Click(object sender, EventArgs e) {
            controlador.Editar();
        }

        private void btn_Excluir_Click(object sender, EventArgs e) {
            controlador.Excluir();
        }
    }
}
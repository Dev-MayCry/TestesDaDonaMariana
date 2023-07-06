using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private TabelaQuestaoControl tabelaQuestao;
        private RepositorioQuestaoEmSql repositorioQuestao;
        private RepositorioDisciplinaEmSql repositorioDisciplina;
        private RepositorioMateriaEmSql repositorioMateria;

        public ControladorQuestao(RepositorioQuestaoEmSql repositorioQuestao, RepositorioDisciplinaEmSql repositorioDisciplina, RepositorioMateriaEmSql repositorioMateria)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
        }

        public override string ToolTipInserir => "Inserir nova Questão";
        public override string ToolTipEditar => "Editar Questão Existente";
        public override string ToolTipExcluir => "Excluir Questão Existente";
        public override string ToolTipVisualizar => "Visualizar Questão Existente";

        public override string LabelTipoCadastro => "Cadastro De Questões";

        public override bool EditarHabilitado { get { return true; } }
        public override bool VisualizarHabilitado { get { return true; } }

        public override void Inserir()
        {
            TelaQuestao telaQuestao = new TelaQuestao(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos());
            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestao.ObterQuestao();

                repositorioQuestao.Inserir(questao);
            }
            CarregarQuestoes();
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();
            tabelaQuestao.AtualizarRegistros(questoes);
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if(tabelaQuestao == null) tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestao;
        }
    }
}

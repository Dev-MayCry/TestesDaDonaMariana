using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloAlternativa;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;
using TestesDaDonaMariana.WinApp.Compartilhado;
using TestesDaDonaMariana.WinApp.ModuloMateria;

namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private TabelaQuestaoControl tabelaQuestao;
        private RepositorioQuestaoEmSql repositorioQuestao;
        private RepositorioDisciplinaEmSql repositorioDisciplina;
        private RepositorioMateriaEmSql repositorioMateria;
        private RepositorioAlternativaEmSql repositorioAlternativa;

        public ControladorQuestao(RepositorioQuestaoEmSql repositorioQuestao, RepositorioDisciplinaEmSql repositorioDisciplina, RepositorioMateriaEmSql repositorioMateria, RepositorioAlternativaEmSql repositorioAlternativa)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
            this.repositorioAlternativa = repositorioAlternativa;
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
            TelaQuestao telaQuestao = new TelaQuestao(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioAlternativa.SelecionarTodos());
            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();
            while (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestao.ObterQuestao();
                if (ValidarAtributos(questao))
                {
                    opcaoEscolhida = telaQuestao.ShowDialog();
                    continue;
                }
                repositorioQuestao.Inserir(questao);
                foreach (Alternativa a in questao.alternativas)
                {
                    repositorioAlternativa.Inserir(a);
                }
                break;
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
            Questao questao = ObterQuestaoSelecionada();

            if (questao == null)
            {
                MessageBox.Show($"Nenhuma questão selecionada!", "Edição de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaQuestao tela = new TelaQuestao(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioAlternativa.SelecionarTodos());
            tela.ConfigurarTela(questao);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            while (opcaoEscolhida == DialogResult.OK)
            {
                Questao questaoAtualizada = tela.ObterQuestao();
                if (ValidarAtributos(questaoAtualizada))
                {
                    opcaoEscolhida = tela.ShowDialog();
                    continue;
                }
                repositorioQuestao.Editar(questaoAtualizada.id, questaoAtualizada);
                foreach (Alternativa a in questaoAtualizada.alternativas)
                {
                    repositorioAlternativa.Editar(a.id, a);
                }
                break;
            }

            CarregarQuestoes();
        }

        public override void Excluir()
        {
            Questao questao = ObterQuestaoSelecionada();

            if (questao == null)
            {
                MessageBox.Show($"Nenhuma questão selecionada!", "Exclusão de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a questão {questao.enunciado}?", "Exclusão de Questões",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (opcaoEscolhida == DialogResult.OK)
            {
                foreach (Alternativa a in questao.alternativas)
                {
                    repositorioAlternativa.Excluir(a);
                }
                repositorioQuestao.Excluir(questao);
                foreach (Alternativa a in questao.alternativas)
                {
                    repositorioAlternativa.Excluir(a);
                }
            }

            CarregarQuestoes();
        }

        private Questao ObterQuestaoSelecionada()
        {
            int id = tabelaQuestao.ObterIdSelecionado();

            return repositorioQuestao.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaQuestao == null) tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestao;
        }

        private bool ValidarAtributos(Questao questao)
        {
            
            return false;
        }
    }
}

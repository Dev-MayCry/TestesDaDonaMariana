using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloAlternativa;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private TabelaQuestaoControl tabelaQuestao;
        private RepositorioQuestaoEmSql repositorioQuestao;
        private RepositorioDisciplinaEmSql repositorioDisciplina;
        private RepositorioMateriaEmSql repositorioMateria;
        private RepositorioAlternativaEmSql repositorioAlternativa;
        private RepositorioTesteEmSql repositorioTeste;

        public ControladorQuestao(RepositorioQuestaoEmSql repositorioQuestao, RepositorioDisciplinaEmSql repositorioDisciplina, RepositorioMateriaEmSql repositorioMateria, RepositorioAlternativaEmSql repositorioAlternativa, RepositorioTesteEmSql repositorioTeste)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
            this.repositorioAlternativa = repositorioAlternativa;
            this.repositorioTeste = repositorioTeste;
        }

        public override string ToolTipInserir => "Inserir Nova Questão";
        public override string ToolTipEditar => "Editar Questão Existente";
        public override string ToolTipExcluir => "Excluir Questão Existente";
        public override string ToolTipVisualizar => "Visualizar Questão Existente";

        public override string LabelTipoCadastro => "Cadastro De Questões";

        public override bool EditarHabilitado { get { return true; } }
        public override bool VisualizarHabilitado { get { return true; } }

        public override void Inserir()
        {
            TelaQuestao telaQuestao = new TelaQuestao(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioAlternativa.SelecionarTodos(), false);
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

            TelaQuestao tela = new TelaQuestao(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioAlternativa.SelecionarTodos(), false);
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

                foreach (Alternativa a in questao.alternativas)
                {
                    repositorioAlternativa.Excluir(a);
                }

                foreach (Alternativa a in questaoAtualizada.alternativas)
                {
                    repositorioAlternativa.Inserir(a);
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

            if (VerificarTestes(questao)) return;

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a questão {questao.enunciado}?", "Exclusão de Questões", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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

        public bool VerificarTestes(Questao questao) { 

            List<Teste> testes = repositorioTeste.SelecionarTodos();

            foreach (Teste teste in testes) {

                repositorioTeste.CarregarQuestoes(teste);
                if (teste.questoes.Any(t => t.id == questao.id)) 
                {
                    MessageBox.Show($"Não é possível Excluir uma questão que esteja cadastrada em um teste!", "Excluir Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }

            }
            return false;
            
        }

        public override void Visualizar()
        {
            Questao questao = ObterQuestaoSelecionada();

            if (questao == null)
            {
                MessageBox.Show($"Nenhuma questão selecionada!", "Edição de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaQuestao tela = new TelaQuestao(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioAlternativa.SelecionarTodos(), true);
            tela.ConfigurarTelaLeitura(questao);

            tela.ShowDialog();
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
            if (questao.enunciado.Length < 3)
            {
                MessageBox.Show($"O enunciado da questão é muito pequeno!", "Nova Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if(questao.alternativas.Count < 2)
            {
                MessageBox.Show($"É necessário ao menos 2 alternativas para salvar a questão!", "Nova Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            for(int i = 1; i < questao.alternativas.Count; i++)
            {
                if (questao.alternativas[i].descricao == questao.alternativas[i - 1].descricao)
                {
                    MessageBox.Show($"Não podem existir 2 alternativas iguais!", "Nova Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
            }
            return false;
        }
    }
}

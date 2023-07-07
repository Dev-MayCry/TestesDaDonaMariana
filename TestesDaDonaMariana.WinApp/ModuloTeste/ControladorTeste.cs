

using System.Drawing.Drawing2D;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste;
using TestesDaDonaMariana.WinApp.Compartilhado;
using TestesDaDonaMariana.WinApp.ModuloMateria;
using TestesDaDonaMariana.WinApp.ModuloQuestao;

namespace TestesDaDonaMariana.WinApp.ModuloTeste {


    internal class ControladorTeste : ControladorBase {

        private TabelaTesteControl tabelaTeste;
        private RepositorioMateriaEmSql repositorioMateria;
        private RepositorioDisciplinaEmSql repositorioDisciplina;
        private RepositorioQuestaoEmSql repositorioQuestao;
        private RepositorioTesteEmSql repositorioTeste;

        public ControladorTeste(RepositorioMateriaEmSql repositorioMateria, RepositorioDisciplinaEmSql repositorioDisciplina, RepositorioQuestaoEmSql repositorioQuestao, RepositorioTesteEmSql repositorioTeste) {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioTeste= repositorioTeste;
        }

        public override string ToolTipInserir => "Gerar Novo Teste";
        public override string ToolTipExcluir => "Excluir Teste Existente";
        public override string ToolTipDuplicar => "Duplicar Teste Existente";
        public override string ToolTipVisualizar => "Visualizar Teste Existente";
        public override string ToolTipImprimir => "Imprimir Teste Selecionado";

        public override string LabelTipoCadastro => "Cadastro de Testes";

        public override bool VisualizarHabilitado { get { return true; } }
        public override bool DuplicarHabilitado { get { return true; } }
        public override bool ImprimirHabilitado { get { return true; } }

        

        public override void Excluir() {
            Teste testeSelecionado = ObterTesteSelecionada();

            if (testeSelecionado == null) {
                MessageBox.Show($"Nenhum teste selecionado!", "Exclusão de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o teste {testeSelecionado.titulo}?", "Exclusão de Testes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (opcaoEscolhida == DialogResult.OK) {
                repositorioTeste.Excluir(testeSelecionado);
                repositorioTeste.ExcluirRelacao(testeSelecionado);
            }

            CarregarTestes();
        }

        public override void Inserir() {
            TelaTeste telaTeste = new TelaTeste(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());
            DialogResult opcaoEscolhida = telaTeste.ShowDialog();

            while (opcaoEscolhida == DialogResult.OK) {
                    Teste teste = telaTeste.ObterTeste();
                if (ValidarNome(teste)) {

                    opcaoEscolhida = telaTeste.ShowDialog();
                    continue;
                }

                repositorioTeste.Inserir(teste);

               foreach (Questao q in teste.questoes) {

               repositorioTeste.InserirQuestoes(teste.id, q.id);

               }
                break;
                
            }
            CarregarTestes();
        }

        private bool ValidarNome(Teste teste) {
            if (repositorioTeste.SelecionarTodos().Any(t => t.titulo == teste.titulo)) {
                MessageBox.Show($"Não é possível cadastrar um teste com o mesmo título", "Novo Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            } else if (teste.titulo.Length < 3) {
                MessageBox.Show($"O título do teste não pode ser menor que 3 caracteres!", "Novo Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            } else if (teste.questoes.Count == 0) {
                MessageBox.Show($"Não é possível salvar um teste sem questões!", "Novo Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            return false;
        }

        public override void Duplicar() {

            Teste testeSelecionado = ObterTesteSelecionada();

            


            if (testeSelecionado == null) {
                MessageBox.Show($"Nenhum teste selecionado!", "Duplicação de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTeste tela = new TelaTeste(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());
            tela.ConfigurarTela(testeSelecionado);

     
            DialogResult opcaoEscolhida = tela.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK) {
                Teste teste = tela.ObterTeste();

                repositorioTeste.Inserir(teste);

                foreach (Questao q in teste.questoes) {

                    repositorioTeste.InserirQuestoes(teste.id, q.id);

                }

            }
            CarregarTestes();
        }

        public override void Visualizar() {

            Teste testeSelecionado = ObterTesteSelecionada();

            repositorioTeste.CarregarQuestoes(testeSelecionado);


            if (testeSelecionado == null) {
                MessageBox.Show($"Nenhum teste selecionado!", "Edição de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTeste tela = new TelaTeste(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());
            tela.ConfigurarTelaLeitura(testeSelecionado);


            DialogResult opcaoEscolhida = tela.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK) {


            }
            CarregarTestes();

        }

        public override UserControl ObterListagem() {
            if (tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            CarregarTestes();
            return tabelaTeste;
        }

        private Teste ObterTesteSelecionada() {
            int id = tabelaTeste.ObterIdSelecionado();

            return repositorioTeste.SelecionarPorId(id);
        }
        private void CarregarTestes() {
            List<Teste> testes = repositorioTeste.SelecionarTodos();
            tabelaTeste.AtualizarRegistros(testes);
        }
    }
}

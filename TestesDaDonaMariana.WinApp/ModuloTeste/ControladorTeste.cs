

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

        public override void Editar() {
            throw new NotImplementedException();
        }

        public override void Excluir() {
            throw new NotImplementedException();
        }

        public override void Inserir() {
            TelaTeste telaTeste = new TelaTeste(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());
            DialogResult opcaoEscolhida = telaTeste.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK) {
                Teste teste = telaTeste.ObterTeste();

                repositorioTeste.Inserir(teste);

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

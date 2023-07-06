using System.Drawing.Drawing2D;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloMateria {

    public class ControladorMateria : ControladorBase {

        private TabelaMateriaControl tabelaMateria;
        private RepositorioMateriaEmSql repositorioMateria;
        private RepositorioDisciplinaEmSql repositorioDisciplina;
        private RepositorioQuestaoEmSql repositorioQuestao;

        public ControladorMateria(RepositorioMateriaEmSql repositorioMateria, RepositorioDisciplinaEmSql repositorioDisciplina, RepositorioQuestaoEmSql repositorioQuestao) {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
        }

        public override string ToolTipInserir => "Inserir nova Matéria";

        public override string ToolTipEditar => "Editar Matéria Existente";

        public override string ToolTipExcluir => "Excluir Matéria Existente";

        public override string LabelTipoCadastro => "Cadastro De Matérias";

        public override bool EditarHabilitado { get { return true; } }

        public override void Inserir() {
            if (VerificarDisciplinas())
                return;

            TelaMateria telaMateria = new TelaMateria(repositorioDisciplina.SelecionarTodos());
            DialogResult opcaoEscolhida = telaMateria.ShowDialog();
            while (opcaoEscolhida == DialogResult.OK) {
                Materia materia = telaMateria.ObterMateria();
                if (ValidarAtributos(materia)) {
                    opcaoEscolhida = telaMateria.ShowDialog();
                    continue;
                }
                repositorioMateria.Inserir(materia);
                break;
            }

            CarregarMaterias();
        }



        public override void Editar() {
            Materia materia = ObterMateriaSelecionada();

            if (materia == null) {
                MessageBox.Show($"Nenhuma matéria selecionada!",
                    "Edição de Matérias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaMateria tela = new TelaMateria(repositorioDisciplina.SelecionarTodos());
            tela.ConfigurarTela(materia);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            while (opcaoEscolhida == DialogResult.OK) {
                Materia materiaAtualizada = tela.ObterMateria();
                if (ValidarAtributos(materiaAtualizada)) {
                    opcaoEscolhida = tela.ShowDialog();
                    continue;
                }
                repositorioMateria.Editar(materiaAtualizada.id, materiaAtualizada);
                break;
            }

            CarregarMaterias();

        }


        public override void Excluir() {
            Materia materia = ObterMateriaSelecionada();

            if (materia == null) {
                MessageBox.Show($"Nenhuma matéria selecionada!",
                    "Edição de Matérias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            if (VerificarQuestoes(materia)) return;

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a matéria {materia.nome}?", "Exclusão de Matérias",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (opcaoEscolhida == DialogResult.OK) {
                repositorioMateria.Excluir(materia);
            }

            CarregarMaterias();
        }

        public bool VerificarQuestoes(Materia materia) {   //verifica se a matéria está sendo usada em alguma questão
            if (repositorioQuestao.SelecionarTodos().Any(q => q.materia.nome == materia.nome)) {
                MessageBox.Show($"Não é possível Excluir uma matéria que esteja cadastrada em uma questão!", "Excluir Matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            } else return false;
        }

        private bool ValidarAtributos(Materia materia) {
            if (repositorioMateria.SelecionarTodos().Any(m => m.nome == materia.nome)) {
                MessageBox.Show($"Matéria já cadastrada!", "Nova Matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            } else if (materia.nome.Length < 5) {
                MessageBox.Show($"O nome da matéria não pode ser menor que 5 caracteres!", "Nova Matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            return false;
        }

        private bool VerificarDisciplinas() {
            if (repositorioDisciplina.SelecionarTodos().Count() == 0) {
                MessageBox.Show($"Nenhuma Disciplina cadastrada", "Nova Matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            } else return false;
        }


        public override UserControl ObterListagem() {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMateria;
        }

        private Materia ObterMateriaSelecionada() {
            int id = tabelaMateria.ObterIdSelecionado();

            return repositorioMateria.SelecionarPorId(id);
        }
        private void CarregarMaterias() {
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            tabelaMateria.AtualizarRegistros(materias);
        }
    }
}

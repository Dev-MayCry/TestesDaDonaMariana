using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloMateria {

    public class ControladorMateria : ControladorBase {

        private TabelaMateriaControl tabelaMateria;
        private RepositorioMateriaEmSql repositorioMateria;
        private RepositorioDisciplinaEmSql repositorioDisciplina;

        public ControladorMateria(RepositorioMateriaEmSql repositorioMateria, RepositorioDisciplinaEmSql repositorioDisciplina) {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string ToolTipInserir => "Inserir nova Matéria";

        public override string ToolTipEditar => "Editar Matéria Existente";

        public override string ToolTipExcluir => "Excluir Matéria Existente";

        public override void Inserir() {
            TelaMateria telaMateria = new TelaMateria(repositorioDisciplina.SelecionarTodos());
            DialogResult opcaoEscolhida = telaMateria.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK) {
                Materia materia = telaMateria.ObterMateria();

                repositorioMateria.Inserir(materia);
            }
            CarregarMaterias();
        }


        public override void Editar() {
            Materia materia = ObterMateriaSelecionada();

            if(materia == null) {
                MessageBox.Show($"Nenhuma matéria selecionada!",
                    "Edição de Matérias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaMateria tela = new TelaMateria(repositorioDisciplina.SelecionarTodos());
            tela.ConfigurarTela(materia);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                Materia materiaAtualizada = tela.ObterMateria();
                repositorioMateria.Editar(materiaAtualizada.id, materiaAtualizada);
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

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a matéria {materia.nome}?", "Exclusão de Matérias",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (opcaoEscolhida == DialogResult.OK) {
                repositorioMateria.Excluir(materia);
            }

            CarregarMaterias();
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

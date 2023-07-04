using System.Drawing.Drawing2D;
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

        private void CarregarMaterias() {
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            tabelaMateria.AtualizarRegistros(materias);
        }

        public override void Editar() {
            throw new NotImplementedException();
        }

        public override void Excluir() {
            throw new NotImplementedException();
        }


        public override UserControl ObterListagem() {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMateria;
        }
    }
}

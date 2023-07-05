
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.WinApp;
using TestesDaDonaMariana.WinApp.Compartilhado;
using TestesDaDonaMariana.WinApp.ModuloDisciplina;

namespace FestaInfantil.ModuloCliente
{
    public class ControladorDisciplina : ControladorBase
    {
       
        public ControladorDisciplina(RepositorioDisciplinaEmSql repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
          
        }

        public override string ToolTipInserir => "Inserir nova Disciplina";

        public override string ToolTipEditar => "Editar Disciplina Existente";

        public override string ToolTipExcluir => "Excluir Disciplina Existente";

        public override string LabelTipoCadastro => "Cadastro De Disciplinas";

        public override void Inserir()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();
            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
               Disciplina novaDisciplina = telaDisciplina.ObterDisciplina();
                repositorioDisciplina.Inserir(novaDisciplina);
                CarregarDisciplina();
            }
        }

        public override void Editar()
        {
            Disciplina disciplinaSelecionada = ObterDisciplinaSelecionado();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Nenhuma Disciplina Selecionada!", "Editar Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina);
            telaDisciplina.ConfigurarTela(disciplinaSelecionada);

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplina = telaDisciplina.ObterDisciplina();

                repositorioDisciplina.Editar(disciplina.id, disciplina);

                CarregarDisciplina();
            }
        }

        public override void Excluir()
        {
            Disciplina disciplinaSelecionada = ObterDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Nenhuma Disciplina Selecionada!", "Excluir Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir a Disciplina {disciplinaSelecionada.disciplinas} ?", "Exclusão de Disciplina", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDisciplina.Excluir(disciplinaSelecionada);
                CarregarDisciplina();
            }
        }                    
        private void CarregarDisciplina()
        {
            List<Disciplina> disciplina = repositorioDisciplina.SelecionarTodos();
            tabelaDisciplina.AtualizarRegistros(disciplina);
            TelaPrincipalForm.Instancia.AtualizarRodape("Visualizando Disciplinas");
        }
                                   
    }
}

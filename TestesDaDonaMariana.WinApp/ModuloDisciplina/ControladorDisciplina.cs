
using e_Agenda.WinApp.ModuloContato;
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.WinApp;
using TestesDaDonaMariana.WinApp.Compartilhado;
using TestesDaDonaMariana.WinApp.ModuloDisciplina;
using TestesDaDonaMariana.WinApp.ModuloMateria;


namespace FestaInfantil.ModuloCliente
{
    public class ControladorDisciplina : ControladorBase
    {
        private TabelaDisciplinaControl tabelaDisciplina;
        private RepositorioDisciplinaEmSql repositorioDisciplina;
       
        public ControladorDisciplina(RepositorioDisciplinaEmSql repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
          
        }

        public override string ToolTipInserir => "Inserir nova Disciplina";

        public override string ToolTipEditar => "Editar Disciplina Existente";

        public override string ToolTipExcluir => "Excluir Disciplina Existente";

        public override string LabelTipoCadastro => "Cadastro de Disciplina";

        public override bool EditarHabilitado { get {  return true; } } 
        public override void Inserir()
        {

            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina);
            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();
            while (opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplina = telaDisciplina.ObterDisciplina();
                if (ValidarAtributos(disciplina))
                {
                    opcaoEscolhida = telaDisciplina.ShowDialog();
                    continue;
                }
                repositorioDisciplina.Inserir(disciplina);
                break;
            }

            CarregarDisciplina();
        }

        private bool ValidarAtributos(Disciplina disciplina)
        {
            if (repositorioDisciplina.SelecionarTodos().Any(m => m.nome == disciplina.nome))
            {
                MessageBox.Show($"Disciplina já cadastrada!", "Nova Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if (disciplina.nome.Length < 5)
            {
                MessageBox.Show($"O nome da Disciplina não pode ser menor que 5 caracteres!", "Nova Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            return false;
        }

        public override void Editar()
        {
            Disciplina disciplina = ObterDisciplinaSelecionada();

            if (disciplina == null)
            {
                MessageBox.Show($"Nenhuma disciplina selecionada!",
                    "Edição de Disciplina",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaDisciplinaForm tela = new TelaDisciplinaForm(repositorioDisciplina);
            tela.ConfigurarTela(disciplina);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            while (opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplinaAtualizada = tela.ObterDisciplina();
                if (ValidarAtributos(disciplinaAtualizada))
                {
                    opcaoEscolhida = tela.ShowDialog();
                    continue;
                }
                repositorioDisciplina.Editar(disciplinaAtualizada.id, disciplinaAtualizada);
                break;
            }

            CarregarDisciplina();

        }

        public override void Excluir()
        {
            Disciplina disciplinaSelecionada = ObterDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Nenhuma Disciplina Selecionada!", "Excluir Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir a Disciplina {disciplinaSelecionada.nome} ?", "Exclusão de Disciplina", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
           
        }
        private Disciplina ObterDisciplinaSelecionada()
        {
            int id = tabelaDisciplina.ObterIdSelecionado();
            return repositorioDisciplina.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarDisciplina();

            return tabelaDisciplina;
        }

    }
}

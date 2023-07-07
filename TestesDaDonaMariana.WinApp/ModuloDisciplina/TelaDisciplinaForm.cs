
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        private RepositorioDisciplinaEmSql repositorioDisciplina;

        public TelaDisciplinaForm(RepositorioDisciplinaEmSql disciplinas)
        {
            InitializeComponent();

            this.ConfigurarDialog();
            this.repositorioDisciplina = disciplinas;


        }


        public Disciplina ObterDisciplina()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtDisciplina.Text;          
            Disciplina disciplina = new Disciplina(id, nome);

            if (id > 0)
                disciplina.id = id;

            return disciplina;

        }
        public void btnSalvar_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = ObterDisciplina();

            string[] erros = disciplina.Validar();

        }

        internal void ConfigurarTela(Disciplina disciplina)
        {
            txtId.Text = disciplina.id.ToString();
            txtDisciplina.Text = disciplina.nome;

        }

    }


}


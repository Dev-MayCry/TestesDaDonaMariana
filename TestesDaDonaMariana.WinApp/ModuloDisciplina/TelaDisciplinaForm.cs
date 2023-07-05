
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        private IRepositorioDisciplina disciplinas;
        public TelaDisciplinaForm(IRepositorioDisciplina disciplinas)
        {
            InitializeComponent();

            this.ConfigurarDialog();
            this.disciplinas = disciplinas;
        }


        public Disciplina ObterDisciplina()
        {
            int id = Convert.ToInt32(txtId.Text);
            string disciplina = txtDisciplina.Text;
            txtDisciplina.Text = txtDisciplina.Text.ToUpper();
            

            Disciplina disciplina = new Disciplina(disciplina);

            if (id > 0)
                disciplina.Id = id;

            return disciplina;

        }
        private bool VerificarDisponibilidadeDisciplina(Disciplina disciplina)
        {
            List<Disciplina> listaDisciplina = disciplinas.SelecionarTodos();
            return listaDisciplina.Any(c => c.disciplinas == disciplina.disciplinas);
        }


        public void btnSalvar_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = ObterDisciplina();

            string[] erros = disciplina.Validar();

            if (erros.Length > 0 || VerificarDisponibilidadeDisciplina(disciplina))
            {
                if (VerificarDisponibilidadeDisciplina(disciplina))
                {
                    MessageBox.Show($"A Disciplina {disciplina.disciplinas} ja esta cadastrada.", "Nova disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                }
                DialogResult = DialogResult.None;
            }

        }

        internal void ConfigurarTela(Disciplina disciplina)
        {
            txtId.Text = disciplina.id.ToString();
            txtDisciplina.Text = disciplina.disciplinas;
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Visualizando Disciplinas");
        }
    }


}


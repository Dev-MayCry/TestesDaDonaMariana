using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloMateria {
    public partial class TelaMateria : Form {
        public TelaMateria(List<Disciplina> disciplinas) {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarDisciplinas(disciplinas);
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas) {
            txtDisciplina.Items.Clear();
            foreach(Disciplina d in disciplinas) {
                txtDisciplina.Items.Add(d);
            }
        }

        public Materia ObterMateria() {
            int id = Convert.ToInt32(txtId.Text);

            string nome = txtNome.Text;

            int serie = Convert.ToInt32(txtSerie.Text);

            Disciplina disciplina = (Disciplina)txtDisciplina.SelectedItem;

            Materia materia = new Materia(id, nome, serie, disciplina);

            if (id > 0)
                materia.id = id;

            return materia;
        }

        public void ConfigurarTela(Materia materia) {
            txtId.Text = materia.id.ToString();

            txtNome.Text = materia.nome;

            txtSerie.Text = Convert.ToString(materia.serie);
        }
    }
}

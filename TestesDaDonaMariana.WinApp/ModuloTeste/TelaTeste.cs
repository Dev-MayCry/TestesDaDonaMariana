
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloTeste {
    public partial class TelaTeste : Form {
        public TelaTeste(List<Disciplina> disciplinas, List<Materia> materias, List<Questao> questoes) {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarDisciplinas(disciplinas);
        }

        public Teste ObterTeste() {
            int id = Convert.ToInt32(txtId.Text);

            string titulo = txtTitulo.Text;

            int serie = Convert.ToInt32(txtSerie.Text);

            Disciplina disciplina = (Disciplina)txtListaDisciplinas.SelectedItem;

            Materia materia = (Materia)txtListaMaterias.SelectedItem;

            int numeroQuestoes = Convert.ToInt32(txtNumeroQuestoes.Text);

            Teste teste = new Teste(id,numeroQuestoes,disciplina,materia,DateTime.Now,titulo);

            //List<Questao> questoesDoTeste = new List<Questao>;

            //foreach (Questao q in listbox) {

            //    questoesDoTeste.Add(q);
            //}


            if (id > 0)
                materia.id = id;

            return teste;
        }


        private void CarregarDisciplinas(List<Disciplina> disciplinas) {

            txtListaDisciplinas.Items.Clear();
            foreach (Disciplina d in disciplinas) {
                txtListaDisciplinas.Items.Add(d);
            }

            txtListaDisciplinas.SelectedIndex = 0;


        }


    }
}


using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloTeste {
    public partial class TelaTeste : Form {

        List<Materia> materias;
        List<Questao> questoes;
        List<Questao> listaDeSorteio = new List<Questao>();
        public TelaTeste(List<Disciplina> disciplinas, List<Materia> materias, List<Questao> questoes) {
            InitializeComponent();
            this.ConfigurarDialog();
            this.materias = materias;
            this.questoes = questoes;
            CarregarDisciplinas(disciplinas);
        }

        public Teste ObterTeste() {
            int id = Convert.ToInt32(txtId.Text);

            string titulo = txtTitulo.Text;

            int serie = Convert.ToInt32(txtSerie.Text);

            Disciplina disciplina = (Disciplina)txtListaDisciplinas.SelectedItem;

            Materia materia = (Materia)txtListaMaterias.SelectedItem;

            int numeroQuestoes = Convert.ToInt32(txtNumeroQuestoes.Text);

            Teste teste = new Teste(id, numeroQuestoes, disciplina, materia, DateTime.Now, titulo);

            List<Questao> questoesSorteadas = ObterQuestoesSorteadas();


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


        private void txtListaDisciplinas_SelectedValueChanged(object sender, EventArgs e) {

            CarregarMaterias();
            List<Questao> listaSorteio = DefinirListaQuestoesSorteio();
            txtNumeroQuestoes.Maximum = listaSorteio.Count();
        }


        private void txtSerie_ValueChanged(object sender, EventArgs e) {

             
            CarregarMaterias();
            DefinirListaQuestoesSorteio();
            

        }

        private void txtListaMaterias_SelectedValueChanged(object sender, EventArgs e) {
            DefinirListaQuestoesSorteio();
            
        }

        private List<Questao> DefinirListaQuestoesSorteio() {
            int serieSelecionada = Convert.ToInt32(txtSerie.Value);
            Disciplina disciplina = (Disciplina)txtListaDisciplinas.SelectedItem;
            Materia materia = (Materia)txtListaMaterias.SelectedItem;

            List<Questao> listaSorteio = new List<Questao>();

            if (txtListaMaterias.Text == "Recuperação") {
                foreach (Questao q in questoes) {
                    if(q.disciplina.nome == disciplina.nome && q.serie == serieSelecionada) {
                        listaSorteio.Add(q);
                    }

                }
            } 

            else {
                foreach (Questao q in questoes) {
                    if (q.disciplina.nome == disciplina.nome && q.serie == serieSelecionada && q.materia.nome == materia.nome) {
                        listaSorteio.Add(q);
                    }
                }
                
            }

            txtNumeroQuestoes.Maximum = listaSorteio.Count();
            return listaSorteio;

        }
        


        private void CarregarMaterias() {

            int serieSelecionada = Convert.ToInt32(txtSerie.Value);
            Disciplina disciplina = (Disciplina)txtListaDisciplinas.SelectedItem;


            txtListaMaterias.Enabled = true;

            List<Materia> listaMaterias = new List<Materia>();

            foreach (Materia m in materias) {
                if (m.disciplina.nome == disciplina.nome && m.serie == serieSelecionada) {
                    listaMaterias.Add(m);
                }

            }
            txtListaMaterias.Items.Clear();

            if (listaMaterias.Count != 0) {

                foreach (Materia m in listaMaterias) {
                    txtListaMaterias.Items.Add(m);
                }

                txtListaMaterias.SelectedIndex = 0;
            } else {
                txtListaMaterias.Items.Clear();
                txtListaMaterias.Text = "Nenhuma matéria cadastrada na série selecionada.";
                txtListaMaterias.Enabled = false;
            }


        }   

        private void checkRecuperacao_CheckedChanged(object sender, EventArgs e) {
            if(checkRecuperacao.Checked == true) {

                txtListaMaterias.Enabled = false;
                txtListaMaterias.Text = "Recuperação";
            } else {

                txtListaMaterias.Enabled = true;

                CarregarMaterias();
                DefinirListaQuestoesSorteio();
                
            }
        }

        private void btnSortear_Click(object sender, EventArgs e) {

            listQuestoes.Items.Clear();

            List<Questao> ListaSorteio = DefinirListaQuestoesSorteio();
            
            Random random = new Random();
            List<Questao> questoesSorteadas = new List<Questao>();

            while (questoesSorteadas.Count < Convert.ToInt32(txtNumeroQuestoes.Value)) {

                int index = random.Next(0, ListaSorteio.Count);
                Questao questao = ListaSorteio[index];
                if (!questoesSorteadas.Contains(questao)) {
                    questoesSorteadas.Add(questao);
                }
            }

            foreach (Questao q in questoesSorteadas) {
                listQuestoes.Items.Add(q);

            }
        }

        private List<Questao> ObterQuestoesSorteadas() {
            List<Questao> listaQuestoes = new List<Questao>();

            foreach (Questao q in listQuestoes.Items) {
                listaQuestoes.Add(q);
            }


            return listaQuestoes;
        }
    }
}

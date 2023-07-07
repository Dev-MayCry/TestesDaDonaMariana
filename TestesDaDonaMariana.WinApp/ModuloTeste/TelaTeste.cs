
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloTeste {
    public partial class TelaTeste : Form {

        List<Materia> materias;
        List<Questao> questoes;
        
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

            bool recuperacao = false;

            if (checkRecuperacao.Checked == true) 
                recuperacao = true;
            
            int numeroQuestoes = Convert.ToInt32(txtNumeroQuestoes.Text);
            
            List<Questao> questoesSorteadas = ObterQuestoesSorteadas();

            Teste teste = new Teste(id, numeroQuestoes, disciplina,materia, DateTime.Now, titulo,recuperacao,serie);

            teste.questoes = questoesSorteadas;

            

            if (id > 0)
                teste.id = id;

            return teste;
        }

        public void ConfigurarTela(Teste teste) {
            
            txtTitulo.Text = teste.titulo.ToString();

            txtListaDisciplinas.SelectedItem = teste.disciplina;

            txtSerie.Text = Convert.ToString(teste.serie);

            

            txtNumeroQuestoes.Text = Convert.ToString(teste.numeroQuestoes);

            foreach (Questao q in teste.questoes) {
                listQuestoes.Items.Add(q);
            }

            if (teste.recuperacao) {

                checkRecuperacao.Checked = true;
                txtListaMaterias.Enabled = false;
                txtListaMaterias.Text = "Recuperação";
            } 
            else {
                txtListaMaterias.SelectedItem = teste.materia;
            }

        }

        public void ConfigurarTelaLeitura(Teste teste) {
            txtTitulo.Text = teste.titulo.ToString();
            txtTitulo.Enabled = false;

            txtListaDisciplinas.SelectedItem = teste.disciplina;
            txtListaDisciplinas.Enabled= false;

            //txtSerie.Text = Convert.ToString(teste.serie);

            txtSerie.Enabled = false;

            if (teste.recuperacao)
            {
                checkRecuperacao.Checked = true;
                txtListaMaterias.Text = "Recuperação"; //algum erro aqui, quando debuga não dá erro
            }
            else
            {
                txtListaMaterias.SelectedItem = teste.materia;
            }

            txtListaMaterias.Enabled= false;

            txtNumeroQuestoes.Text = Convert.ToString(teste.numeroQuestoes);
            txtNumeroQuestoes.Enabled = false;

            foreach (Questao q in teste.questoes) {
                listQuestoes.Items.Add(q);
            }

            listQuestoes.Enabled = false;

            btnSortear.Enabled = false;
            
            checkRecuperacao.Enabled = false;
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

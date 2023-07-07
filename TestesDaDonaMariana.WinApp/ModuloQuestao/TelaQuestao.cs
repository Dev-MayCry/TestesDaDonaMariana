using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
    public partial class TelaQuestao : Form
    {
        List<Materia> listaMaterias;
        List<Alternativa> listaAlternativas;
        public TelaQuestao(List<Disciplina> disciplinas, List<Materia> materias, List<Alternativa> alternativas)
        {
            InitializeComponent();
            listaMaterias = materias;
            listaAlternativas = alternativas;
            this.ConfigurarDialog();
            CarregarDisciplinas(disciplinas);
            BloquearAlternativas();
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            txtListaDisciplinas.Items.Clear();
            foreach (Disciplina d in disciplinas) txtListaDisciplinas.Items.Add(d);
            txtListaDisciplinas.SelectedIndex = 0;

            txtListaMaterias.Enabled = true;
        }

        private void txtListaDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarMaterias();
        }

        private void CarregarMaterias()
        {
            txtListaMaterias.Items.Clear();
            foreach (Materia m in listaMaterias)
            {
                if (m.disciplina.Equals(txtListaDisciplinas.SelectedItem) && txtSerie.Value == m.serie)
                {
                    txtListaMaterias.Items.Add(m);
                }
            }

            txtListaMaterias.Enabled = true;

            if (txtListaMaterias.Items.Count > 0)
                txtListaMaterias.SelectedIndex = 0;

            if (txtListaMaterias.Items.Count == 0)
            {
                txtListaMaterias.Items.Clear();
                txtListaMaterias.Text = "Nenhuma matéria cadastrada na série selecionada.";
                txtListaMaterias.Enabled = false;
            }

        }

        private void BloquearAlternativas()
        {
            alternativaA.Checked = false;
            txtAlternativaB.Enabled = false;
            alternativaB.Enabled = false;
            txtAlternativaC.Enabled = false;
            alternativaC.Enabled = false;
            txtAlternativaD.Enabled = false;
            alternativaD.Enabled = false;
        }

        private void BloquearTodasAsAlternativas()
        {
            alternativaA.Enabled = false;
            alternativaB.Enabled = false;
            alternativaC.Enabled = false;
            alternativaD.Enabled = false;
            txtAlternativaA.Enabled = false;
            txtAlternativaB.Enabled = false;
            txtAlternativaC.Enabled = false;
            txtAlternativaD.Enabled = false;
        }

        public Questao ObterQuestao()
        {
            int id = Convert.ToInt32(txtId.Text);

            Disciplina disciplina = (Disciplina)txtListaDisciplinas.SelectedItem;

            int serie = Convert.ToInt32(txtSerie.Text);

            Materia materia = (Materia)txtListaMaterias.SelectedItem;

            string enunciado = txtEnunciado.Text;

            Alternativa aA = new(txtAlternativaA.Text, alternativaA.Checked);
            Alternativa aB = new();
            Alternativa aC = new();
            Alternativa aD = new();
            if (txtAlternativaB.Enabled)
            {
                aB.descricao = txtAlternativaB.Text;
                aB.gabarito = alternativaB.Checked;
            }
            if (txtAlternativaC.Enabled)
            {
                aC.descricao = txtAlternativaC.Text;
                aC.gabarito = alternativaC.Checked;
            }
            if (txtAlternativaD.Enabled)
            {
                aD.descricao = txtAlternativaD.Text;
                aD.gabarito = alternativaD.Checked;
            }

            int numeroAlternativas = 0;

            Questao questao = new Questao(id, enunciado, numeroAlternativas, disciplina, serie, materia);

            questao.alternativas.Add(aA); questao.alternativas[0].questao = questao;

            if (txtAlternativaB.Enabled && txtAlternativaB.Text != "")
            {
                questao.alternativas.Add(aB);
                questao.alternativas[1].questao = questao;
            }
            if (txtAlternativaC.Enabled && txtAlternativaC.Text != "")
            {
                questao.alternativas.Add(aC);
                questao.alternativas[2].questao = questao;
            }
            if (txtAlternativaD.Enabled && txtAlternativaD.Text != "")
            {
                questao.alternativas.Add(aD);
                questao.alternativas[3].questao = questao;
            }

            questao.numeroAlternativas = questao.alternativas.Count;

            if (id > 0)
                questao.id = id;

            return questao;
        }

        public void ConfigurarTela(Questao questao)
        {
            txtId.Text = questao.id.ToString();

            txtListaDisciplinas.SelectedItem = questao.disciplina;

            txtSerie.Text = Convert.ToString(questao.serie);

            txtListaMaterias.SelectedItem = questao.materia;

            txtEnunciado.Text = questao.enunciado;

            foreach (Alternativa a in listaAlternativas)
            {
                if (a.questao.id == questao.id)
                    questao.alternativas.Add(a);
            }

            txtAlternativaA.Text = questao.alternativas[0].descricao;
            alternativaA.Checked = questao.alternativas[0].gabarito;
            txtAlternativaB.Text = questao.alternativas[1].descricao;
            alternativaB.Checked = questao.alternativas[1].gabarito;
            if (questao.numeroAlternativas >= 3)
            {
                txtAlternativaC.Text = questao.alternativas[2].descricao;
                alternativaC.Checked = questao.alternativas[2].gabarito;
            }
            if (questao.numeroAlternativas == 4)
            {
                txtAlternativaD.Text = questao.alternativas[3].descricao;
                alternativaD.Checked = questao.alternativas[3].gabarito;
            }
        }

        public void ConfigurarTelaLeitura(Questao questao)
        {
            txtId.Text = questao.id.ToString();

            txtListaDisciplinas.SelectedItem = questao.disciplina;
            txtListaDisciplinas.Enabled = false;

            txtSerie.Text = Convert.ToString(questao.serie);
            txtSerie.Enabled = false;

            txtListaMaterias.SelectedItem = questao.materia;
            txtListaMaterias.Enabled = false;
            
            txtEnunciado.Text = questao.enunciado;
            txtEnunciado.Enabled = false;

            foreach (Alternativa a in listaAlternativas)
            {
                if (a.questao.id == questao.id)
                    questao.alternativas.Add(a);
            }

            txtAlternativaA.Text = questao.alternativas[0].descricao;
            alternativaA.Checked = questao.alternativas[0].gabarito;
            txtAlternativaB.Text = questao.alternativas[1].descricao;
            alternativaB.Checked = questao.alternativas[1].gabarito;
            if (questao.numeroAlternativas >= 3)
            {
                txtAlternativaC.Text = questao.alternativas[2].descricao;
                alternativaC.Checked = questao.alternativas[2].gabarito;
            }
            if (questao.numeroAlternativas == 4)
            {
                txtAlternativaD.Text = questao.alternativas[3].descricao;
                alternativaD.Checked = questao.alternativas[3].gabarito;
            }
            BloquearTodasAsAlternativas();
        }

        private void txtSerie_ValueChanged(object sender, EventArgs e)
        {
            if (txtSerie.Value < 1) txtSerie.Value = 1;
            else if (txtSerie.Value > 9) txtSerie.Value = 9;
            CarregarMaterias();
        }

        private void txtAlternativaA_TextChanged(object sender, EventArgs e)
        {
            if (txtAlternativaA.Text != "")
            {
                txtAlternativaB.Enabled = true;
            }
            else
            {
                alternativaB.Enabled = false;
                alternativaC.Enabled = false;
                alternativaD.Enabled = false;
                txtAlternativaB.Enabled = false;
                txtAlternativaC.Enabled = false;
                txtAlternativaD.Enabled = false;

                if (alternativaB.Checked || alternativaC.Checked || alternativaD.Checked)
                    alternativaA.Checked = true;
            }
        }

        private void txtAlternativaB_TextChanged(object sender, EventArgs e)
        {
            if (txtAlternativaB.Text != "" && txtAlternativaB.Enabled)
            {
                alternativaB.Enabled = true;
                txtAlternativaC.Enabled = true;
            }
            else
            {
                alternativaB.Enabled = false;
                alternativaC.Enabled = false;
                alternativaD.Enabled = false;
                txtAlternativaC.Enabled = false;
                txtAlternativaD.Enabled = false;

                if (alternativaB.Checked || alternativaC.Checked || alternativaD.Checked)
                    alternativaA.Checked = true;
            }
        }

        private void txtAlternativaC_TextChanged(object sender, EventArgs e)
        {
            if (txtAlternativaC.Text != "" && txtAlternativaC.Enabled)
            {
                alternativaC.Enabled = true;
                txtAlternativaD.Enabled = true;
            }
            else
            {
                alternativaC.Enabled = false;
                alternativaD.Enabled = false;
                txtAlternativaD.Enabled = false;

                if (alternativaC.Checked || alternativaD.Checked)
                    alternativaA.Checked = true;
            }
        }

        private void txtAlternativaD_TextChanged(object sender, EventArgs e)
        {
            if (txtAlternativaD.Text != "" && txtAlternativaD.Enabled)
                alternativaD.Enabled = true;
            else
            {
                alternativaD.Enabled = false;

                if (alternativaD.Checked)
                    alternativaA.Checked = true;
            }
        }
    }
}

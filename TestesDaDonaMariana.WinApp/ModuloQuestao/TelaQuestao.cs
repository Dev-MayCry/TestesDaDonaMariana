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

            txtListaMaterias.Enabled = false;
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
            
            if(txtListaMaterias.Items.Count > 0)
                txtListaMaterias.SelectedIndex = 0;
        }

        private void BloquearAlternativas()
        {
            alternativaC.Enabled = false;
            alternativaD.Enabled = false;
        }

        public Questao ObterQuestao()
        {
            int id = Convert.ToInt32(txtId.Text);

            Disciplina disciplina = (Disciplina)txtListaDisciplinas.SelectedItem;

            int serie = Convert.ToInt32(txtSerie.Text);

            Materia materia = (Materia)txtListaMaterias.SelectedItem;

            string enunciado = txtEnunciado.Text;

            Alternativa aA = new(txtAlternativaA.Text, alternativaA.Checked);
            Alternativa aB = new(txtAlternativaB.Text, alternativaB.Checked);
            Alternativa aC = new();
            Alternativa aD = new();
            if (txtAlternativaC.Text != "")
            {
                aC.descricao = txtAlternativaC.Text; aC.gabarito = alternativaC.Checked;
            }
            if (txtAlternativaD.Text != "")
            {
                aD.descricao = txtAlternativaD.Text; aD.gabarito = alternativaC.Checked;
            }

            int numeroAlternativas = 0;

            Questao questao = new Questao(id, enunciado, numeroAlternativas, disciplina, serie, materia);
            questao.alternativas.Add(aA); questao.alternativas[0].questao = questao;
            questao.alternativas.Add(aB); questao.alternativas[1].questao = questao;
            if (txtAlternativaC.Text != "") 
            {
                questao.alternativas.Add(aC); questao.alternativas[2].questao = questao; 
            }
            if (txtAlternativaD.Text != "")
            {
                questao.alternativas.Add(aD); questao.alternativas[3].questao = questao;
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
                if(a.questao.id == questao.id)
                    questao.alternativas.Add(a);
            }

            txtAlternativaA.Text = questao.alternativas[0].descricao;
            alternativaA.Checked = questao.alternativas[0].gabarito;
            txtAlternativaB.Text = questao.alternativas[1].descricao;
            alternativaB.Checked = questao.alternativas[1].gabarito;
            if (questao.numeroAlternativas == 3)
            {
                txtAlternativaC.Text = questao.alternativas[2].descricao;
                alternativaC.Checked = questao.alternativas[2].gabarito;
            }
            else if(questao.numeroAlternativas == 4)
            {
                txtAlternativaD.Text = questao.alternativas[3].descricao;
                alternativaD.Checked = questao.alternativas[3].gabarito;
            }
        }

        private void txtSerie_ValueChanged(object sender, EventArgs e)
        {
            if (txtSerie.Value < 1) txtSerie.Value = 1;
            else if (txtSerie.Value > 9) txtSerie.Value = 9;
            CarregarMaterias();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            alternativaB.Checked = false; alternativaC.Checked = false; alternativaD.Checked = false;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            alternativaA.Checked = false; alternativaC.Checked = false; alternativaD.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            alternativaA.Checked = false; alternativaB.Checked = false; alternativaD.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            alternativaA.Checked = false; alternativaB.Checked = false; alternativaC.Checked = false;
        }

        private void txtAlternativaC_TextChanged(object sender, EventArgs e)
        {
            alternativaC.Enabled = true;
        }

        private void txtAlternativaD_TextChanged(object sender, EventArgs e)
        {
            alternativaD.Enabled = true;
        }
    }
}

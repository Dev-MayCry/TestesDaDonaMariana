using System.Collections.Generic;
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
    public partial class TelaQuestao : Form
    {
        public TelaQuestao(List<Disciplina> disciplinas, List<Materia> materias)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarInformacoes(disciplinas, materias);
            BloquearAlternativas();
        }

        private void CarregarInformacoes(List<Disciplina> disciplinas, List<Materia> materias)
        {
            txtListaDisciplinas.Items.Clear();
            foreach (Disciplina d in disciplinas) txtListaDisciplinas.Items.Add(d);
            
            txtListaMaterias.Items.Clear();
            foreach (Materia m in materias) txtListaMaterias.Items.Add(m);
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
            if (txtAlternativaC.Text != null) aC.alternativa = txtAlternativaC.Text; aC.isTrue = alternativaC.Checked;
            if (txtAlternativaD.Text != null) aD.alternativa = txtAlternativaC.Text; aD.isTrue = alternativaC.Checked;

            int numeroAlternativas = 0;

            Questao questao = new Questao(id, enunciado, numeroAlternativas, disciplina, serie, materia, aA, aB, aC, aD);

            if (id > 0)
                questao.id = id;

            return questao;
        }

        private void txtSerie_ValueChanged(object sender, EventArgs e)
        {
            if (txtSerie.Value < 1) txtSerie.Value = 1;
            else if (txtSerie.Value > 9) txtSerie.Value = 9;
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

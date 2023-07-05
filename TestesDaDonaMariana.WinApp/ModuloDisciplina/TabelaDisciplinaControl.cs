
using TestesDaDonaMariana.Dominio.ModuloDisciplina;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            gridDisciplina.ConfigurarGridZebrado();

            gridDisciplina.ConfigurarGridSomenteLeitura();

        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "disciplina",
                    HeaderText = "disciplina"
                },
                new DataGridViewTextBoxColumn()
                {
                   
                },

            };

            gridDisciplina.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            gridDisciplina.Rows.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                gridDisciplina.Rows.Add(disciplina.id, disciplina.disciplinas);
            }
        }

        public int ObterIdSelecionado()
        {
            if (gridDisciplina.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridDisciplina.SelectedRows[0].Cells["id"].Value);

            return id;
        }
        public DataGridViewRowCollection ObterTodasDisciplinas()
        {          
           return  gridDisciplina.Rows;            
        }
    }
}

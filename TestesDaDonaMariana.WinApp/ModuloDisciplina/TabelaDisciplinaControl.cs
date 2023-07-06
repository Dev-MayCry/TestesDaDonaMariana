
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();

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

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            grid.Rows.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                grid.Rows.Add(disciplina.id, disciplina.nome);
            }
        }

        public int ObterIdSelecionado()
        {
            if (grid.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            return id;
        }
        public DataGridViewRowCollection ObterTodasDisciplinas()
        {
            return grid.Rows;
        }
    }
}

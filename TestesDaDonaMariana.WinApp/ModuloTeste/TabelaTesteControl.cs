
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloTeste {
    public partial class TabelaTesteControl : UserControl {
        public TabelaTesteControl() {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        private void ConfigurarColunas() {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "titulo",
                    HeaderText = "Título"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "disciplina",
                    HeaderText = "Disciplina"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "materia",
                    HeaderText = "Matéria"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "numeroQuestoes",
                    HeaderText = "Número de Questões"
                },
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Teste> testes) {
            grid.Rows.Clear();

            foreach (Teste t in testes) {
                if (t.recuperacao) {
                    grid.Rows.Add(
                    t.id,
                    t.titulo,
                    t.disciplina.nome,
                    "Recuperação",
                    t.numeroQuestoes
                );

                } 
                else {
                    grid.Rows.Add(
                    t.id,
                    t.titulo,
                    t.disciplina.nome,
                    t.materia.nome,
                    t.numeroQuestoes
                );
                }
                
            }
        }

        public int ObterIdSelecionado() {
            if (grid.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}

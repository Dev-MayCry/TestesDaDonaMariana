using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;

namespace TestesDaDonaMariana.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        public int numeroQuestoes;
        public Disciplina disciplina;
        public Materia materia = null;
        public DateTime data;
        public string titulo;
        public bool recuperacao = false;
        public int serie;
        public List<Questao> questoes;



        public Teste(int id, int numeroQuestoes, Disciplina disciplina, Materia materia, DateTime data, string titulo,bool recuperacao, int serie) {
            this.id = id;
            this.numeroQuestoes = numeroQuestoes;
            this.disciplina = disciplina;
            this.materia = materia;
            this.data = data;
            this.titulo = titulo;
            this.recuperacao = recuperacao;
            this.serie = serie;
            this.questoes = new List<Questao>();

        }
        

        public override void AtualizarInformacoes(Teste registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}

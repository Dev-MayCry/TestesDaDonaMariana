using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        public int numeroQuestoes;
        public Disciplina disciplina;
        public Materia materia;
        public DateTime data;

        public Teste(int id, int numeroQuestoes, Disciplina disciplina, Materia materia, DateTime data)
        {
            this.id = id;
            this.numeroQuestoes = numeroQuestoes;
            this.disciplina = disciplina;
            this.materia = materia;
            this.data = data;
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

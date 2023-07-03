using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public string enunciado;
        public int numeroAlternativas;
        public Disciplina disciplina;
        public Materia materia;

        public Questao(int id, string? enunciado, int numeroAlternativas, Disciplina disciplina, Materia materia)
        {
            this.id = id;
            this.enunciado = enunciado;
            this.numeroAlternativas = numeroAlternativas;
            this.disciplina = disciplina;
            this.materia = materia;
        }

        public override void AtualizarInformacoes(Questao registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}

using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public string enunciado;
        public int numeroAlternativas;
        public Disciplina disciplina;
        public int serie;
        public Materia materia;
        public Alternativa alternativaA;
        public Alternativa alternativaB;
        public Alternativa alternativaC;
        public Alternativa alternativaD;

        public Questao(int id, string? enunciado, int numeroAlternativas, Disciplina disciplina, int serie, Materia materia, Alternativa alternativaA, Alternativa alternativaB, Alternativa? alternativaC, Alternativa? alternativaD)
        {
            this.id = id;
            this.enunciado = enunciado;
            this.numeroAlternativas = numeroAlternativas;
            this.disciplina = disciplina;
            this.serie = serie;
            this.materia = materia;
            this.alternativaA = alternativaA;
            this.alternativaB = alternativaB;
            this.alternativaC = alternativaC;
            this.alternativaD = alternativaD;
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

using TestesDaDonaMariana.Dominio.ModuloDisciplina;

namespace TestesDaDonaMariana.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string nome;
        public int serie;
        public Disciplina disciplina;

        public Materia(int id, string? nome, int serie, Disciplina disciplina)
        {
            this.id = id;
            this.nome = nome;
            this.serie = serie;
            this.disciplina = disciplina;
        }

        public override void AtualizarInformacoes(Materia registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return nome;
        }

        public override bool Equals(object? obj)
        {
            return nome == ((Materia)obj).nome && serie == ((Materia)obj).serie && id == ((Materia)obj).id;
        }
    }
}

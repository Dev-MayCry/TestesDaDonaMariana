namespace TestesDaDonaMariana.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string nome;

        public Disciplina(int id, string? nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public override void AtualizarInformacoes(Disciplina registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return nome;
        }

        public override bool Equals(object? obj)
        {
            return obj is Disciplina disciplina && id == disciplina.id && nome == disciplina.nome;
        }
    }
}

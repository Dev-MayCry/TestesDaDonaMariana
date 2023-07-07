using System.Text.RegularExpressions;

namespace TestesDaDonaMariana.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string nome;

        public Disciplina()
        {

        }
        public Disciplina(int id, string? nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public override string ToString() {
            return nome;
        }
        

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome) || nome.Any(char.IsDigit) || !Regex.IsMatch(nome, @"^[a-zA-Z\s]+$") ||nome.Length < 5)
                erros.Add("O campo 'nome' é obrigatório ou possui caracteres inválidos. Digite um nome válido.");

            return erros.ToArray();
        }

        public override bool Equals(object? obj) {
            return obj is Disciplina disciplina &&
                   id == disciplina.id &&
                   nome == disciplina.nome;
        }

        public override void AtualizarInformacoes(Disciplina registroAtualizado) {
            throw new NotImplementedException();
        }
    }
}

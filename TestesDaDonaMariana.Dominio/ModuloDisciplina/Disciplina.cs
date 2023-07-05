using System.Text.RegularExpressions;

namespace TestesDaDonaMariana.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string disciplinas;

        public Disciplina()
        {

        }
        public Disciplina(int id, string? disciplinas)
        {
            this.id = id;
            this.disciplinas = disciplinas;
        }
        public override string ToString() {
            return disciplinas;
        }
        public override void AtualizarInformacoes(Disciplina registroAtualizado)
        {
            this.disciplinas = registroAtualizado.disciplinas;          
        }


        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(disciplinas) || disciplinas.Any(char.IsDigit) || !Regex.IsMatch(disciplinas, @"^[a-zA-Z\s]+$") ||disciplinas.Length < 5)
                erros.Add("O campo 'nome' é obrigatório ou possui caracteres inválidos. Digite um nome válido.");

            return erros.ToArray();
        }
    }
}

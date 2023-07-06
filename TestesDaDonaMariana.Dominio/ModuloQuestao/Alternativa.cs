namespace TestesDaDonaMariana.Dominio.ModuloQuestao
{
    public class Alternativa : EntidadeBase<Alternativa>
    {
        public string? descricao;
        public bool gabarito;
        public Questao questao;

        public Alternativa(){}

        public Alternativa(string? descricao, bool gabarito)
        {
            this.descricao = descricao;
            this.gabarito = gabarito;
        }

        public Alternativa(int id, string? descricao, bool gabarito, Questao questao)
        {
            this.id = id;
            this.descricao = descricao;
            this.gabarito = gabarito;
            this.questao = questao;
        }

        public override void AtualizarInformacoes(Alternativa registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}

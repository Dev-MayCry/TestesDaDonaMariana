namespace TestesDaDonaMariana.Dominio.ModuloQuestao
{
    public class Alternativa : EntidadeBase<Alternativa>
    {
        public string alternativa;
        public bool isTrue;

        public Alternativa(){}

        public Alternativa(string alternativa, bool isTrue)
        {
            this.alternativa = alternativa;
            this.isTrue = isTrue;
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

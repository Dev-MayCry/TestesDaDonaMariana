﻿namespace TestesDaDonaMariana.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string nome;

        public override void AtualizarInformacoes(Disciplina registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}

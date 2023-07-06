using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloAlternativa
{
    public class MapeadorAlternativa : MapeadorBase<Alternativa>
    {
        public override void ConfigurarParametros(SqlCommand comando, Alternativa registro)
        {
            comando.Parameters.AddWithValue("ID", registro.id);

            comando.Parameters.AddWithValue("DESCRICAO", registro.descricao);

            comando.Parameters.AddWithValue("GABARITO", registro.gabarito);
            
            comando.Parameters.AddWithValue("QUESTAO_ID", registro.questao.id);

        }

        public override Alternativa ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["ALTERNATIVA_ID"]);

            string? descricao = Convert.ToString(leitorRegistros["ALTERNATIVA_DESCRICAO"]);

            bool gabarito = Convert.ToBoolean(leitorRegistros["ALTERNATIVA_GABARITO"]);

            Questao questao = new MapeadorQuestao().ConverterRegistro(leitorRegistros);

            Alternativa alternativa = new Alternativa(id, descricao, gabarito, questao);

            return alternativa;
        }
    }
}

using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste
{
    public class MapeadorTeste : MapeadorBase<Teste>
    {
        public override void ConfigurarParametros(SqlCommand comando, Teste registro)
        {
            comando.Parameters.AddWithValue("ID", registro.id);
            comando.Parameters.AddWithValue("NUMERO_QUESTOES", registro.numeroQuestoes);
            comando.Parameters.AddWithValue("MATERIA_ID", registro.materia.id);
            comando.Parameters.AddWithValue("DATA_CRIACAO", registro.data);
            comando.Parameters.AddWithValue("DISCIPLINA_ID", registro.disciplina.id);
            comando.Parameters.AddWithValue("TITULO", registro.titulo);
            comando.Parameters.AddWithValue("RECUPERACAO", registro.recuperacao);
            comando.Parameters.AddWithValue("SERIE", registro.serie);

            
           
        }

        public override Teste ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["TESTE_ID"]);

            int numeroQuestoes = Convert.ToInt32(leitorRegistros["TESTE_NUMERO_QUESTOES"]);

            Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);

            DateTime data = Convert.ToDateTime(leitorRegistros["TESTE_DATA_CRIACAO"]);
            
            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

            string titulo = Convert.ToString(leitorRegistros["TESTE_TITULO"]);

            bool recuperacao = Convert.ToBoolean(leitorRegistros["TESTE_RECUPERACAO"]);

            int serie = Convert.ToInt32(leitorRegistros["TESTE_SERIE"]);

            Teste teste = new Teste(id, numeroQuestoes, disciplina, materia, data, titulo,recuperacao,serie);

            //while (leitorRegistros.Read()) {
            //    Questao q = new MapeadorQuestao().ConverterRegistro(leitorRegistros);

            //    teste.questoes.Add(q);
            //}

            return teste;
        }
    }
}

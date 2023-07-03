using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste
{
    public class MapeadorTeste : MapeadorBase<Teste>
    {
        public override void ConfigurarParametros(SqlCommand comando, Teste registro)
        {
            comando.Parameters.AddWithValue("ID", registro.id);

            comando.Parameters.AddWithValue("NUMERO_QUESTOES", registro.numeroQuestoes);

            comando.Parameters.AddWithValue("DISCIPLINA", registro.disciplina);
            
            comando.Parameters.AddWithValue("MATERIA", registro.materia);
            
            comando.Parameters.AddWithValue("DATA", registro.data);
        }

        public override Teste ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["TESTE_ID"]);

            int numeroQuestoes = Convert.ToInt32(leitorRegistros["TESTE_NUMERO_QUESTOES"]);

            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

            Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);

            DateTime data = Convert.ToDateTime(leitorRegistros["TESTE_DATA"]);

            Teste teste = new Teste(id, numeroQuestoes, disciplina, materia, data);

            return teste;
        }
    }
}

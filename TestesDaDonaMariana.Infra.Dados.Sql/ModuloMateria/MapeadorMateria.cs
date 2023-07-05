using Microsoft.Data.SqlClient;

using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria
{
    public class MapeadorMateria : MapeadorBase<Materia>
    {
        public override void ConfigurarParametros(SqlCommand comando, Materia registro)
        {
            comando.Parameters.AddWithValue("ID", registro.id);

            comando.Parameters.AddWithValue("NOME", registro.nome);

            comando.Parameters.AddWithValue("SERIE", registro.serie);

            comando.Parameters.AddWithValue("ID_DISCIPLINA", registro.disciplina.id);
        }

        public override Materia ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["MATERIA_ID"]);

            string? nome = Convert.ToString(leitorRegistros["MATERIA_NOME"]);

            int serie = Convert.ToInt32(leitorRegistros["MATERIA_SERIE"]);

            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

            Materia materia = new Materia(id, nome, serie, disciplina);

            return materia;
        }
    }
}

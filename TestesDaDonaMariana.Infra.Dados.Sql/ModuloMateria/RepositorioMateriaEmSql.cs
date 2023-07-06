using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria
{
    public class RepositorioMateriaEmSql : RepositorioEmSqlBase<Materia, MapeadorMateria>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [dbo].[TBMateria]
                   ([nome]
                   ,[serie]
                   ,[Disciplina_ID])
             VALUES
                   (@nome
                   ,@serie
                   ,@Disciplina_ID)     

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [dbo].[TBMATERIA] 
	        SET 
		        [nome] = @nome,
				[serie] = @serie,
				[Disciplina_ID] = @DISCIPLINA_ID
	        WHERE 
		        [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBMATERIA]
	        WHERE 
		        [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 
					M.[ID] MATERIA_ID
					,M.[nome] MATERIA_NOME
					,M.[serie] MATERIA_SERIE

					,D.[ID] DISCIPLINA_ID
					,D.[NOME] DISCIPLINA_NOME

				  FROM 
				  [dbo].[TBMateria] AS M INNER JOIN
				  [DBO].[TBDisciplina] AS D

				  ON
					M.DISCIPLINA_ID = D.ID";

        protected override string sqlSelecionarPorId =>

            @"SELECT M.[ID] MATERIA_ID
					,M.[nome]	MATERIA_NOME
					,M.[serie] MATERIA_SERIE

					,D.[ID] DISCIPLINA_ID
					,D.[NOME] DISCIPLINA_NOME

				  FROM 
				  [dbo].[TBMateria] AS M INNER JOIN
				  [DBO].[TBDisciplina] AS D

				ON
					M.DISCIPLINA_ID = D.ID

				WHERE 
					M.[ID] = @ID";
    }
}


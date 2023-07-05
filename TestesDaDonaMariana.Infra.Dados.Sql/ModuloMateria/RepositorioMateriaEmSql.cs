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
                   ,[ID_Disciplina])
             VALUES
                   (@nome
                   ,@serie
                   ,@ID_Disciplina)     

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [dbo].[TBMATERIA] 
	        SET 
		        [nome] = @nome,
				[serie] = @serie,
				[ID_Disciplina] = @DISCIPLINA_ID
	        WHERE 
		        [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBMATERIA]
	        WHERE 
		        [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT M.[ID] ""ID""
					,M.[nome] ""NOME""
					,M.[serie] ""SERIE""
					,M.[ID_Disciplina] ""MATERIA_DISCIPLINA_ID""

					,D.[ID] ""DISCIPLINA_ID""
					,D.[NOME] ""DISCIPLINA_NOME""

				  FROM 
				  [dbo].[TBMateria] AS M INNER JOIN
				  [DBO].[TBDisciplina] AS D

				  ON
					M.ID_Disciplina = D.ID";

        protected override string sqlSelecionarPorId =>

            @"SELECT M.[ID] ""ID""
					,M.[nome] ""NOME""
					,M.[serie] ""SERIE""
					,M.[ID_Disciplina] ""MATERIA_DISCIPLINA_ID""

					,D.[ID] ""DISCIPLINA_ID""
					,D.[NOME] ""DISCIPLINA_NOME""

				  FROM 
				  [dbo].[TBMateria] AS M INNER JOIN
				  [DBO].[TBDisciplina] AS D

				ON
					M.ID_Disciplina = D.ID

				WHERE 
					M.[ID] = @ID";
    }
}


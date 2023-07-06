using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste
{
    public class RepositorioTesteEmSql : RepositorioEmSqlBase<Teste, MapeadorTeste>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [DBO].[TBTESTE] 
	            (
		            [NUMERO_QUESTOES],
		            [DISCIPLINA_ID],
		            [MATERIA_ID],
		            [DATA],
					[TITULO]
	            )
	            VALUES 
	            (
		            @NUMERO_QUESTOES,
		            @DISCIPLINA_ID,
		            @MATERIA_ID,
		            @DATA,
					@TITULO
	            );                 

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBTESTE] 
	        SET 
		        [NUMERO_QUESTOES] = @NUMERO_QUESTOES,
		        [DISCIPLINA_ID] = @DISCIPLINA_ID,
		        [MATERIA_ID] = @MATERIA_ID,
		        [DATA] = @DATA,
				[TITULO] = @TITULO
	        WHERE 
		        [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBTESTE]
	        WHERE 
		        [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 

	            T.[ID]				TESTE_ID,
                T.[NUMERO_QUESTOES]	TESTE_NUMERO_QUESTOES,
                T.[DATA_CRIACAO]	TESTE_DATA,
				T.[TITULO]			TESTE_TITULO,

				D.[ID]		DISCIPLINA_ID,
				D.[NOME]	DISCIPLINA_NOME,

				M.[ID] MATERIA_ID,
				M.[NOME] MATERIA_NOME,
				M.[SERIE] MATERIA_SERIE
				
            FROM 
	            [DBO].[TBTESTE] AS T

				INNER JOIN [DBO].[TBDISCIPLINA] AS D

					ON T.DISCIPLINA_ID = D.ID

				INNER JOIN [DBO].[TBMATERIA] AS M

					ON T.MATERIA_ID = M.ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT 

	            [ID]				TESTE_ID,
                [NUMERO_QUESTOES]	TESTE_NUMERO_QUESTOES,
                [DISCIPLINA]		TESTE_DISCIPLINA,
                [MATERIA]			TESTE_MATERIA,
                [DATA]				TESTE_DATA,
				[TITULO]			TESTE_TITULO
	        
            FROM 
	            [TBTESTE] 
            WHERE 
                [ID] = @ID";
    }
}

using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao
{
    public class RepositorioQuestaoEmSql : RepositorioEmSqlBase<Questao, MapeadorQuestao>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBQUESTAO] 
	            (
		            [ENUNCIADO],
					[NUMERO_ALTERNATIVAS],
					[DISCIPLINA_ID],
					[MATERIA_ID],
					[SERIE]
	            )
	            VALUES 
	            (
		            @ENUNCIADO,
					@NUMERO_ALTERNATIVAS,
					@DISCIPLINA_ID,
					@MATERIA_ID,
					@SERIE
	            );                 

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBQUESTAO] 
	        SET 
		        [ENUNCIADO] = @ENUNCIADO,
		        [NUMERO_ALTERNATIVAS] = @NUMERO_ALTERNATIVAS,
		        [DISCIPLINA_ID] = @DISCIPLINA_ID,
		        [MATERIA_ID] = @MATERIA_ID,
				[SERIE] = @SERIE
	        WHERE 
		        [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBQUESTAO]
	        WHERE 
		        [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 

	            Q.[ID]					QUESTAO_ID,
                Q.[ENUNCIADO]				QUESTAO_ENUNCIADO,
                Q.[NUMERO_ALTERNATIVAS]	QUESTAO_NUMERO_ALTERNATIVAS,
				Q.[SERIE]				QUESTAO_SERIE,

				D.[ID]		DISCIPLINA_ID,
				D.[NOME]	DISCIPLINA_NOME,

				M.[ID] MATERIA_ID,
				M.[NOME] MATERIA_NOME,
				M.[SERIE] MATERIA_SERIE

	
            FROM 
				[DBO].[TBQUESTAO] AS Q 
				
				INNER JOIN [DBO].[TBDISCIPLINA] AS D
			
					ON Q.DISCIPLINA_ID = D.ID

				INNER JOIN [DBO].[TBMATERIA] AS M
					ON Q.MATERIA_ID = M.ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT 

	            Q.[ID]					QUESTAO_ID,
                Q.[ENUNCIADO]				QUESTAO_ENUNCIADO,
                Q.[NUMERO_ALTERNATIVAS]	QUESTAO_NUMERO_ALTERNATIVAS,
				Q.[SERIE]				QUESTAO_SERIE,

				D.[ID]		DISCIPLINA_ID,
				D.[NOME]	DISCIPLINA_NOME,

				M.[ID] MATERIA_ID,
				M.[NOME] MATERIA_NOME,
				M.[SERIE] MATERIA_SERIE

	
            FROM 
				[DBO].[TBQUESTAO] AS Q 
				
				INNER JOIN [DBO].[TBDISCIPLINA] AS D
			
					ON Q.DISCIPLINA_ID = D.ID

				INNER JOIN [DBO].[TBMATERIA] AS M
					ON Q.MATERIA_ID = M.ID

			WHERE 
					Q.[ID] = @ID";
    }
}

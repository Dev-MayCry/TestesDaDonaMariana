using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloAlternativa
{
    public class RepositorioAlternativaEmSql : RepositorioEmSqlBase<Alternativa, MapeadorAlternativa>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBALTERNATIVA]
			(
				[DESCRICAO],
				[GABARITO],
				[QUESTAO_ID]
			)
			VALUES
			(
				@DESCRICAO,
				@GABARITO,
				@QUESTAO_ID
			);   

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBALTERNATIVA] 
	        SET 
		        [DESCRICAO] = @DESCRICAO,
				[GABARITO] = @GABARITO,
				[QUESTAO_ID] = @QUESTAO_ID
	        WHERE 
		        [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBALTERNATIVA]
	        WHERE 
		        [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 
				A.[ID]			ALTERNATIVA_ID,
				A.[DESCRICAO]	ALTERNATIVA_DESCRICAO,
				A.[GABARITO]	ALTERNATIVA_GABARITO,

				Q.[ID]					QUESTAO_ID,
                Q.[ENUNCIADO]			QUESTAO_ENUNCIADO,
                Q.[NUMERO_ALTERNATIVAS]	QUESTAO_NUMERO_ALTERNATIVAS,
				Q.[SERIE]				QUESTAO_SERIE,

				D.[ID]		DISCIPLINA_ID,
				D.[NOME]	DISCIPLINA_NOME,

				M.[ID] MATERIA_ID,
				M.[NOME] MATERIA_NOME,
				M.[SERIE] MATERIA_SERIE

			FROM 
				[DBO].[TBALTERNATIVA] AS A 

				INNER JOIN [DBO].[TBQUESTAO] AS Q

					ON A.QUESTAO_ID = Q.ID

				INNER JOIN [DBO].[TBDISCIPLINA] AS D
			
					ON Q.DISCIPLINA_ID = D.ID

				INNER JOIN [DBO].[TBMATERIA] AS M

					ON Q.MATERIA_ID = M.ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
				A.[ID]			ALTERNATIVA_ID,
				A.[DESCRICAO]	ALTERNATIVA_DESCRICAO,
				A.[GABARITO]	ALTERNATIVA_GABARITO,

				Q.[ID]					QUESTAO_ID,
                Q.[ENUNCIADO]			QUESTAO_ENUNCIADO,
                Q.[NUMERO_ALTERNATIVAS]	QUESTAO_NUMERO_ALTERNATIVAS,
				Q.[SERIE]				QUESTAO_SERIE,

				D.[ID]		DISCIPLINA_ID,
				D.[NOME]	DISCIPLINA_NOME,

				M.[ID] MATERIA_ID,
				M.[NOME] MATERIA_NOME,
				M.[SERIE] MATERIA_SERIE

			FROM 
				[DBO].[TBALTERNATIVA] AS A 

				INNER JOIN [DBO].[TBQUESTAO] AS Q

					ON A.QUESTAO_ID = Q.ID

				INNER JOIN [DBO].[TBDISCIPLINA] AS D
			
					ON Q.DISCIPLINA_ID = D.ID

				INNER JOIN [DBO].[TBMATERIA] AS M

					ON Q.MATERIA_ID = M.ID

				WHERE 
					A.[ID] = @ID";
    }
}

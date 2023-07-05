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
					[ID_DISCIPLINA],
					[ID_MATERIA]
	            )
	            VALUES 
	            (
		            @ENUNCIADO,
					@NUMERO_ALTERNATIVAS,
					@DISCIPLINA,
					@MATERIA
	            );                 

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBQUESTAO] 
	        SET 
		        [ENUNCIADO] = @ENUNCIADO,
		        [NUMERO_ALTERNATIVAS] = @NUMERO_ALTERNATIVAS,
		        [ID_DISCIPLINA] = @DISCIPLINA,
		        [ID_MATERIA] = @MATERIA
	        WHERE 
		        [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBQUESTAO]
	        WHERE 
		        [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 

	            [ID]					QUESTAO_ID,
                [ENUNCIADO]				QUESTAO_ENUNCIADO,
                [NUMERO_ALTERNATIVAS]	QUESTAO_NUMERO_ALTERNATIVAS,
                [ID_DISCIPLINA]			QUESTAO_DISCIPLINA,
                [ID_MATERIA]			QUESTAO_MATERIA
	
            FROM 
	            [TBQUESTAO]";

        protected override string sqlSelecionarPorId =>
            @"SELECT 

	            [ID]					QUESTAO_ID,
                [ENUNCIADO]				QUESTAO_ENUNCIADO,
                [NUMERO_ALTERNATIVAS]	QUESTAO_NUMERO_ALTERNATIVAS,
                [ID_DISCIPLINA]			QUESTAO_DISCIPLINA,
                [ID_MATERIA]			QUESTAO_MATERIA
	        
            FROM 
	            [TBQUESTAO] 
            WHERE 
                [ID] = @ID";
    }
}

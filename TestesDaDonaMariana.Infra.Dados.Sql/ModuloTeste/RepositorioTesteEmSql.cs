using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste
{
    public class RepositorioTesteEmSql : RepositorioEmSqlBase<Teste, MapeadorTeste>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBTESTE] 
	            (
		            [NUMERO_QUESTOES],
		            [DISCIPLINA],
		            [MATERIA],
		            [DATA]
	            )
	            VALUES 
	            (
		            @NUMERO_QUESTOES,
		            @DISCIPLINA,
		            @MATERIA,
		            @DATA
	            );                 

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBTESTE] 
	        SET 
		        [NUMERO_QUESTOES] = @NUMERO_QUESTOES,
		        [DISCIPLINA] = @DISCIPLINA,
		        [MATERIA] = @MATERIA,
		        [DATA] = @DATA
	        WHERE 
		        [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBTESTE]
	        WHERE 
		        [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 

	            [ID]				TESTE_ID,
                [NUMERO_QUESTOES]	TESTE_NUMERO_QUESTOES,
                [DISCIPLINA]		TESTE_DISCIPLINA,
                [MATERIA]			TESTE_MATERIA,
                [DATA]				TESTE_DATA
				
            FROM 
	            [TBTESTE]";

        protected override string sqlSelecionarPorId =>
            @"SELECT 

	            [ID]				TESTE_ID,
                [NUMERO_QUESTOES]	TESTE_NUMERO_QUESTOES,
                [DISCIPLINA]		TESTE_DISCIPLINA,
                [MATERIA]			TESTE_MATERIA,
                [DATA]				TESTE_DATA
	        
            FROM 
	            [TBTESTE] 
            WHERE 
                [ID] = @ID";
    }
}

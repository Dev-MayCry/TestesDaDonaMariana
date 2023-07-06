using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina
{
    public class RepositorioDisciplinaEmSql : RepositorioEmSqlBase<Disciplina, MapeadorDisciplina>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBDISCIPLINA] 
	            (
		            [NOME]
	            )
	            VALUES 
	            (
		            @NOME 
	            );                 

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBDISCIPLINA] 
	        SET 
		        [NOME] = @NOME
	        WHERE 
		        [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBDISCIPLINA]
	        WHERE 
		        [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 

	            [ID]        DISCIPLINA_ID,
                [NOME]      DISCIPLINA_NOME
	
            FROM 
	            [TBDISCIPLINA]";

        protected override string sqlSelecionarPorId =>
            @"SELECT 

	            [ID]        DISCIPLINA_ID,
	            [NOME]      DISCIPLINA_NOME
	        
            FROM 
	            [TBDISCIPLINA] 
            WHERE 
                [ID] = @ID";
    }
}
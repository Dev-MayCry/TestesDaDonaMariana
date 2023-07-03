using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria
{
    public class RepositorioMateriaEmSql : RepositorioEmSqlBase<Materia, MapeadorMateria>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBMATERIA] 
	            (
		            [NOME],
					[SERIE],
					[DISCIPLINA]
	            )
	            VALUES 
	            (
		            @NOME, 
					@SERIE,
					@DISCIPLINA
	            );                 

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBMATERIA] 
	        SET 
		        [NOME] = @NOME,
				[SERIE] = @SERIE,
				[DISCIPLINA] = @DISCIPLINA
	        WHERE 
		        [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBMATERIA]
	        WHERE 
		        [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 

	            [ID]			MATERIA_ID,
                [NOME]			MATERIA_NOME,
				[SERIE]			MATERIA_SERIE,
				[DISCIPLINA]	MATERIA_DISCIPLINA
	
            FROM 
	            [TBMATERIA]";

        protected override string sqlSelecionarPorId =>
            @"SELECT 

	            [ID]			MATERIA_ID,
                [NOME]			MATERIA_NOME,
				[SERIE]			MATERIA_SERIE,
				[DISCIPLINA]	MATERIA_DISCIPLINA
	        
            FROM 
	            [TBMATERIA] 
            WHERE 
                [ID] = @ID";
    }
}
}

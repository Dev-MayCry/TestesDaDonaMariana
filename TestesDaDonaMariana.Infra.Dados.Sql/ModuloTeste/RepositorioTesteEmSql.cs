using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste
{
    public class RepositorioTesteEmSql : RepositorioEmSqlBase<Teste, MapeadorTeste>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [DBO].[TBTESTE] 
	            (
		            [NUMERO_QUESTOES],
					[MATERIA_ID],
					[DATA_CRIACAO],
		            [DISCIPLINA_ID],
					[TITULO],
                    [RECUPERACAO],
                    [SERIE]
	            )
	            VALUES 
	            (
		            @NUMERO_QUESTOES,
					@MATERIA_ID,
					@DATA_CRIACAO,
		            @DISCIPLINA_ID,
					@TITULO,
                    @RECUPERACAO,
                    @SERIE
	            );                 

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBTESTE] 
	        SET 
		        [NUMERO_QUESTOES] = @NUMERO_QUESTOES,
		        [DISCIPLINA_ID] = @DISCIPLINA_ID,
		        [MATERIA_ID] = @MATERIA_ID,
		        [DATA_CRIACAO] = @DATA_CRIACAO,
				[TITULO] = @TITULO,
                [RECUPERACAO] = @RECUPERACAO,
                [SERIE] = SERIE
	        WHERE 
		        [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBTESTE]
	        WHERE 
		        [ID] = @ID";

        protected string sqlExcluirRelacao =>
            @"DELETE FROM [TBTESTE_TBQUESTÃO]
	        WHERE 
		        [TESTE_ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 

	            T.[ID]				TESTE_ID,
                T.[NUMERO_QUESTOES]	TESTE_NUMERO_QUESTOES,
                T.[DATA_CRIACAO]	TESTE_DATA_CRIACAO,
				T.[TITULO]			TESTE_TITULO,
                T.[RECUPERACAO]     TESTE_RECUPERACAO,
                T.[SERIE]           TESTE_SERIE,

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
                    T.[ID] AS TESTE_ID,
                    T.[NUMERO_QUESTOES] AS TESTE_NUMERO_QUESTOES,
                    T.[DATA_CRIACAO] AS TESTE_DATA_CRIACAO,
                    T.[TITULO] AS TESTE_TITULO,
                    T.[RECUPERACAO] AS TESTE_RECUPERACAO,
                    T.[SERIE] AS TESTE_SERIE,
                    D.[ID] AS DISCIPLINA_ID,
                    D.[NOME] AS DISCIPLINA_NOME,
                    M.[ID] AS MATERIA_ID,
                    M.[NOME] AS MATERIA_NOME,
                    M.[SERIE] AS MATERIA_SERIE,
                    Q.[ID] AS QUESTAO_ID,
                    Q.[ENUNCIADO] AS QUESTAO_ENUNCIADO,
                    Q.[NUMERO_ALTERNATIVAS] AS QUESTAO_NUMERO_ALTERNATIVAS,
                    Q.[SERIE] AS QUESTAO_SERIE
                FROM 
                    [DBO].[TBTESTE] AS T
                    INNER JOIN [DBO].[TBDISCIPLINA] AS D ON T.DISCIPLINA_ID = D.ID
                    INNER JOIN [DBO].[TBMATERIA] AS M ON T.MATERIA_ID = M.ID
                    INNER JOIN [DBO].[TBTeste_TBQuestão] AS TQ ON T.ID = TQ.TESTE_ID
                    INNER JOIN [DBO].[TBQUESTAO] AS Q ON TQ.QUESTAO_ID = Q.ID
                WHERE 
                    T.[ID] = @ID";




        private const string sqlAdicionarQuestao =
            @"INSERT INTO [TBTESTE_TBQUESTÃO]
                (
                    [TESTE_ID]
                   ,[QUESTAO_ID])
            VALUES
                (
                    @TESTE_ID
                   ,@QUESTAO_ID
                )";

        private const string sqlCarregarQuestoes =
           @"SELECT 

                    D.[ID] AS DISCIPLINA_ID,
                    D.[NOME] AS DISCIPLINA_NOME,
                    M.[ID] AS MATERIA_ID,
                    M.[NOME] AS MATERIA_NOME,
                    M.[SERIE] AS MATERIA_SERIE,
                    Q.[ID] AS QUESTAO_ID,
                    Q.[ENUNCIADO] AS QUESTAO_ENUNCIADO,
                    Q.[NUMERO_ALTERNATIVAS] AS QUESTAO_NUMERO_ALTERNATIVAS,
                    Q.[SERIE] AS QUESTAO_SERIE	

			FROM 
				[DBO].[TBQUESTAO] AS Q

				INNER JOIN [DBO].[TBTeste_TBQuestão] AS TQ

					ON Q.ID = TQ.QUESTAO_ID

				INNER JOIN [DBO].[TBDISCIPLINA] AS D ON DISCIPLINA_ID = D.ID
                INNER JOIN [DBO].[TBMATERIA] AS M ON MATERIA_ID = M.ID

				WHERE 
					TQ.[TESTE_ID] = @ID" ;



       
        public void CarregarQuestoes(Teste teste) {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoSelecionarItens = conexaoComBanco.CreateCommand();
            comandoSelecionarItens.CommandText = sqlCarregarQuestoes;

            comandoSelecionarItens.Parameters.AddWithValue("ID", teste.id);

            //executa o comando
            SqlDataReader leitorItem = comandoSelecionarItens.ExecuteReader();


            while (leitorItem.Read()) {
                Questao q = new MapeadorQuestao().ConverterRegistro(leitorItem);

                teste.questoes.Add(q);  
          
            }

            //encerra a conexão
            conexaoComBanco.Close();

        }
        public virtual void ExcluirRelacao(Teste teste) {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoExcluir = conexaoComBanco.CreateCommand();
            comandoExcluir.CommandText = sqlExcluirRelacao;

            //adiciona os parâmetros no comando
            comandoExcluir.Parameters.AddWithValue("ID", teste.id);

            //executa o comando
            comandoExcluir.ExecuteNonQuery();

            //encerra a conexão
            conexaoComBanco.Close();
        }

        public void InserirQuestoes(int testeID, int questaoID) {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlAdicionarQuestao;

            //adiciona os parâmetros no comando
            comandoInserir.Parameters.AddWithValue("TESTE_ID", testeID);
            comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questaoID);

            //executa o comando
            comandoInserir.ExecuteNonQuery();

            //fecha conexão
            conexaoComBanco.Close();
        }
    }
}

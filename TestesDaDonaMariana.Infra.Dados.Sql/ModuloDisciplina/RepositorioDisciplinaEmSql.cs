using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloDisciplina;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina
{
    public class RepositorioDisciplinaEmSql
    {

        private const string enderecoBanco =
            @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=TestesDonaMarianaDb;Integrated Security=True";

        private const string sqlInserir =
            @"INSERT INTO [TBDISCIPLINA] 
	        (
		        [NOME]
	        )
	        VALUES 
	        (
		        @NOME 
	        );                 

        SELECT SCOPE_IDENTITY();";

        private const string sqlEditar =
            @"UPDATE [TBDISCIPLINA] 
	        SET 
		        [NOME] = @NOME
	        WHERE 
		        [ID] = @ID";

        private const string sqlExcluir =
            @"DELETE FROM [TBDISCIPLINA]
	        WHERE 
		        [ID] = @ID";

        private const string sqlSelecionarTodos =
            @"SELECT 

	        [ID]        DISCIPLINA_ID,
            [NOME]      DISCIPLINA_NOME
	
        FROM 
	        [TBDISCIPLINA]";

        private const string sqlSelecionarPorId =
            @"SELECT 

	        [ID]        DISCIPLINA_ID,
	        [NOME]      DISCIPLINA_NOME
	        
        FROM 
	        [TBDISCIPLINA] 
        WHERE 
            [ID] = @ID";

        public void Inserir(Disciplina novaDisciplina)
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlInserir;

            //adiciona os parâmetros no comando
            ConfigurarParametros(comandoInserir, novaDisciplina);

            //executa o comando
            object id = comandoInserir.ExecuteScalar();

            novaDisciplina.id = Convert.ToInt32(id);

            //encerra a conexão
            conexaoComBanco.Close();
        }

        public void Editar(int id, Disciplina disciplina)
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoEditar = conexaoComBanco.CreateCommand();
            comandoEditar.CommandText = sqlEditar;

            //adiciona os parâmetros no comando
            ConfigurarParametros(comandoEditar, disciplina);

            //executa o comando
            comandoEditar.ExecuteNonQuery();

            //encerra a conexão
            conexaoComBanco.Close();
        }

        public void Excluir(Disciplina disciplinaSelecionada)
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoExcluir = conexaoComBanco.CreateCommand();
            comandoExcluir.CommandText = sqlExcluir;

            //adiciona os parâmetros no comando
            comandoExcluir.Parameters.AddWithValue("ID", disciplinaSelecionada.id);

            //executa o comando
            comandoExcluir.ExecuteNonQuery();

            //encerra a conexão
            conexaoComBanco.Close();
        }

        public Disciplina SelecionarPorId(int id)
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoSelecionarPorId = conexaoComBanco.CreateCommand();
            comandoSelecionarPorId.CommandText = sqlSelecionarPorId;

            //adicionar parametro
            comandoSelecionarPorId.Parameters.AddWithValue("ID", id);

            //executa o comando
            SqlDataReader leitorDisciplina = comandoSelecionarPorId.ExecuteReader();

            Disciplina disciplina = null;

            if (leitorDisciplina.Read())
                //disciplina = ConverterParaDisciplina(leitorDisciplina);

            if (disciplina != null)
                //CarregarAlugueis(disciplina);

            //encerra a conexão
            conexaoComBanco.Close();

            return disciplina;
        }
        /*
        private void CarregarAlugueis(Disciplina cliente)
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoSelecionarAlugueisDoCliente = conexaoComBanco.CreateCommand();
            comandoSelecionarAlugueisDoCliente.CommandText = sqlSelecionarAlugueis;

            //configurar parâmetros
            comandoSelecionarAlugueisDoCliente.Parameters.AddWithValue("DISCIPLINA_ID", cliente.id);

            //executa o comando
            SqlDataReader leitorAluguel = comandoSelecionarAlugueisDoCliente.ExecuteReader();

            while (leitorAluguel.Read())
            {
                Aluguel aluguel = ConverterParaAluguel(leitorAluguel, cliente);

                cliente.RegistrarAluguel(aluguel);
            }

            //encerra a conexão
            conexaoComBanco.Close();
        }

        private Aluguel ConverterParaAluguel(SqlDataReader leitorAlugueis, Cliente cliente)
        {
            int id = Convert.ToInt32(leitorAlugueis["ALUGUEL_ID"]);
            decimal porcentagemSinal = Convert.ToDecimal(leitorAlugueis["ALUGUEL_PORCENTAGEM_SINAL"]);
            decimal porcentagemDesconto = Convert.ToDecimal(leitorAlugueis["ALUGUEL_PORCENTAGEM_DESCONTO"]);

            bool pagamentoConcluido = false;
            DateTime dataPagamento = DateTime.MinValue;

            if (leitorAlugueis["ALUGUEL_DATA_PAGAMENTO"] != DBNull.Value)
            {
                dataPagamento = Convert.ToDateTime(leitorAlugueis["ALUGUEL_DATA_PAGAMENTO"]);
                pagamentoConcluido = Convert.ToBoolean(leitorAlugueis["ALUGUEL_PAGAMENTO_CONCLUIDO"]);
            }

            Festa festa = ConverterParaFesta(leitorAlugueis);

            Tema tema = ConverterParaTema(leitorAlugueis);

            Aluguel aluguel = new Aluguel(cliente, festa, tema, porcentagemSinal, porcentagemDesconto);

            aluguel.id = id;
            aluguel.PagamentoConcluido = pagamentoConcluido;
            aluguel.DataPagamento = dataPagamento;


            return aluguel;
        }

        private static Festa ConverterParaFesta(SqlDataReader leitorAlugueis)
        {
            DateTime dataFesta = Convert.ToDateTime(leitorAlugueis["ALUGUEL_FESTA_DATA"]);
            TimeSpan horarioInicio = TimeSpan.FromTicks(Convert.ToInt64(leitorAlugueis["ALUGUEL_FESTA_HORARIOINICIO"]));
            TimeSpan horarioTermino = TimeSpan.FromTicks(Convert.ToInt64(leitorAlugueis["ALUGUEL_FESTA_HORARIOTERMINO"]));

            Endereco endereco = ConverterParaEndereco(leitorAlugueis);

            Festa festa = new Festa(endereco, dataFesta, horarioInicio, horarioTermino);
            return festa;
        }

        private static Tema ConverterParaTema(SqlDataReader leitorAlugueis)
        {
            int id = Convert.ToInt32(leitorAlugueis["TEMA_ID"]);
            string nome = Convert.ToString(leitorAlugueis["TEMA_NOME"]);
            decimal valor = Convert.ToDecimal(leitorAlugueis["TEMA_VALOR"]);

            Tema tema = new Tema(id, nome, valor);

            return tema;
        }

        private static Disciplina ConverterParaDisciplina(SqlDataReader leitorAlugueis)
        {
            int idDisciplina = Convert.ToInt32(leitorAlugueis["DISCIPLINA_ID"]);
            string nomeDisciplina = Convert.ToString(leitorAlugueis["DISCIPLINA_NOME"]);
            
            Disciplina disciplina = new Disciplina(idDisciplina, nomeDisciplina);
            return disciplina;
        }

        private static Endereco ConverterParaEndereco(SqlDataReader leitorAlugueis)
        {
            string estado = Convert.ToString(leitorAlugueis["ALUGUEL_ENDERECO_ESTADO"]);
            string cidade = Convert.ToString(leitorAlugueis["ALUGUEL_ENDERECO_CIDADE"]);
            string bairro = Convert.ToString(leitorAlugueis["ALUGUEL_ENDERECO_BAIRRO"]);
            string rua = Convert.ToString(leitorAlugueis["ALUGUEL_ENDERECO_RUA"]);
            string numero = Convert.ToString(leitorAlugueis["ALUGUEL_ENDERECO_NUMERO"]);

            Endereco endereco = new Endereco(rua, bairro, cidade, estado, numero);
            return endereco;
        }


        public List<Disciplina> SelecionarTodos(bool carregarAlugueis = false)
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoSelecionarTodos = conexaoComBanco.CreateCommand();
            comandoSelecionarTodos.CommandText = sqlSelecionarTodos;

            //executa o comando
            SqlDataReader leitorClientes = comandoSelecionarTodos.ExecuteReader();

            List<Cliente> clientes = new List<Cliente>();

            while (leitorClientes.Read())
            {
                Cliente cliente = ConverterParaCliente(leitorClientes);

                if (carregarAlugueis)
                    CarregarAlugueis(cliente);

                clientes.Add(cliente);
            }

            //encerra a conexão
            conexaoComBanco.Close();

            return clientes;
        }*/

        private void ConfigurarParametros(SqlCommand comandoInserir, Disciplina novaDisciplina)
        {
            comandoInserir.Parameters.AddWithValue("ID", novaDisciplina.id);

            comandoInserir.Parameters.AddWithValue("NOME", novaDisciplina.nome);
        }
    }
}
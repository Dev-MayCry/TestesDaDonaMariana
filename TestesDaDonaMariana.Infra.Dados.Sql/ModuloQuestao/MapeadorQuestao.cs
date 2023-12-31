﻿using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao
{
    public class MapeadorQuestao : MapeadorBase<Questao>
    {
        public override void ConfigurarParametros(SqlCommand comando, Questao registro)
        {
            comando.Parameters.AddWithValue("ID", registro.id);

            comando.Parameters.AddWithValue("ENUNCIADO", registro.enunciado);

            comando.Parameters.AddWithValue("NUMERO_ALTERNATIVAS", registro.numeroAlternativas);
            
            comando.Parameters.AddWithValue("DISCIPLINA_ID", registro.disciplina.id);
            
            comando.Parameters.AddWithValue("MATERIA_ID", registro.materia.id);
            
            comando.Parameters.AddWithValue("SERIE", registro.serie);

        }

        public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["QUESTAO_ID"]);

            string? enunciado = Convert.ToString(leitorRegistros["QUESTAO_ENUNCIADO"]);
            
            int numeroAlternativas = Convert.ToInt32(leitorRegistros["QUESTAO_NUMERO_ALTERNATIVAS"]);
            
            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

            int serie = Convert.ToInt32(leitorRegistros["QUESTAO_SERIE"]);

            Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);

            Questao questao = new Questao(id, enunciado, numeroAlternativas, disciplina, serie, materia);

            return questao;
        }
    }
}

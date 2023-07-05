CREATE TABLE [dbo].[TBTeste] (
    [ID]              INT  NOT NULL IDENTITY,
    [Numero_Questoes] INT  NOT NULL,
    [Materia_ID]      INT  NULL,
    [Data_Criacao]    DATE NOT NULL,
    [Disciplina_ID]   INT  NOT NULL,
    CONSTRAINT [PK_Teste] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Teste_DisciplinaTB] FOREIGN KEY ([Disciplina_ID]) REFERENCES [dbo].[TBDisciplina] ([ID]),
    CONSTRAINT [FK_Teste_MateriaDB] FOREIGN KEY ([Materia_ID]) REFERENCES [dbo].[TBMateria] ([ID])
);


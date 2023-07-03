CREATE TABLE [dbo].[TBTeste] (
    [ID]              INT  NOT NULL,
    [Numero_Questoes] INT  NOT NULL,
    [ID_Materia]      INT  NULL,
    [Data_Criacao]    DATE NOT NULL,
    [ID_Disciplina]   INT  NOT NULL,
    CONSTRAINT [PK_Teste] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Teste_DisciplinaTB] FOREIGN KEY ([ID_Disciplina]) REFERENCES [dbo].[TBDisciplina] ([ID]),
    CONSTRAINT [FK_Teste_MateriaDB] FOREIGN KEY ([ID_Materia]) REFERENCES [dbo].[TBMateria] ([ID])
);


CREATE TABLE [dbo].[TBMateria] (
    [ID]            INT          NOT NULL IDENTITY,
    [nome]          VARCHAR (50) NOT NULL,
    [serie]         VARCHAR (50) NOT NULL,
    [Disciplina_ID] INT          NOT NULL,
    CONSTRAINT [PK_MateriaDB] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_MateriaDB_DisciplinaTB] FOREIGN KEY ([Disciplina_ID]) REFERENCES [dbo].[TBDisciplina] ([ID])
);


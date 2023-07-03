CREATE TABLE [dbo].[TBQuestao] (
    [ID]                  INT           NOT NULL,
    [Enunciado]           VARCHAR (MAX) NOT NULL,
    [Numero_Alternativas] INT           NOT NULL,
    [ID_Disciplina]       INT           NULL,
    [ID_Materia]          INT           NULL,
    CONSTRAINT [PK_QuestaoDB] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_QuestaoDB_DisciplinaTB] FOREIGN KEY ([ID_Disciplina]) REFERENCES [dbo].[TBDisciplina] ([ID]),
    CONSTRAINT [FK_QuestaoDB_MateriaDB] FOREIGN KEY ([ID_Materia]) REFERENCES [dbo].[TBMateria] ([ID])
);


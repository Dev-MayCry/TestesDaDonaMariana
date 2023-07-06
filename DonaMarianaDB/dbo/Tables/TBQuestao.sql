CREATE TABLE [dbo].[TBQuestao] (
    [ID]                  INT           NOT NULL IDENTITY,
    [Enunciado]           VARCHAR (MAX) NOT NULL,
    [Numero_Alternativas] INT           NOT NULL,
    [Disciplina_ID]       INT           NOT NULL,
    [Materia_ID]          INT           NOT NULL,
    [SERIE]               INT           NOT NULL,
    CONSTRAINT [PK_QuestaoDB] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_QuestaoDB_DisciplinaTB] FOREIGN KEY ([Disciplina_ID]) REFERENCES [dbo].[TBDisciplina] ([ID]),
    CONSTRAINT [FK_QuestaoDB_MateriaDB] FOREIGN KEY ([Materia_ID]) REFERENCES [dbo].[TBMateria] ([ID])
);


CREATE TABLE [dbo].[TBDisciplina] (
    [ID]   INT          NOT NULL IDENTITY,
    [nome] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_DisciplinaTB] PRIMARY KEY CLUSTERED ([ID] ASC)
);


﻿CREATE TABLE [dbo].[TBMateria] (
    [ID]            INT          NOT NULL,
    [nome]          VARCHAR (50) NOT NULL,
    [serie]         INT NOT NULL,
    [ID_Disciplina] INT          NOT NULL,
    CONSTRAINT [PK_MateriaDB] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_MateriaDB_DisciplinaTB] FOREIGN KEY ([ID_Disciplina]) REFERENCES [dbo].[TBDisciplina] ([ID])
);


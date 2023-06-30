CREATE TABLE [dbo].[TBAlternativa] (
    [ID]         INT          NOT NULL,
    [Gabarito]   BIT          NOT NULL,
    [ID_Questao] INT          NOT NULL,
    [Descricao]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Alternativa] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Alternativa_QuestaoDB] FOREIGN KEY ([ID_Questao]) REFERENCES [dbo].[TBQuestao] ([ID])
);


CREATE TABLE [dbo].[TBAlternativa] (
    [ID]         INT          IDENTITY (1, 1) NOT NULL,
    [Gabarito]   BIT          NOT NULL,
    [Descricao]  VARCHAR (50) NOT NULL,
    [Questao_ID] INT          NOT NULL,
    CONSTRAINT [PK_Alternativa] PRIMARY KEY CLUSTERED ([ID] ASC)
);




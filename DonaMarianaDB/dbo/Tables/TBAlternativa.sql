CREATE TABLE [dbo].[TBAlternativa] (
    [ID]         INT          NOT NULL  IDENTITY,
    [Gabarito]   BIT          NOT NULL,
    [Descricao]  VARCHAR (50) NOT NULL,
    [Questao_ID] INT          NOT NULL,
    CONSTRAINT [PK_Alternativa] PRIMARY KEY CLUSTERED ([ID] ASC),
);


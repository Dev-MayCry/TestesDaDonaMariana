CREATE TABLE [dbo].[TBAlternativa] (
    [ID]         INT          NOT NULL  IDENTITY,
    [Descricao]  VARCHAR (50) NOT NULL,
    [Gabarito]   BIT          NOT NULL,
    [Questao_ID] INT          NOT NULL,
    CONSTRAINT [PK_Alternativa] PRIMARY KEY CLUSTERED ([ID] ASC),
);


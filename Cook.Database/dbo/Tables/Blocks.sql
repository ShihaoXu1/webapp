CREATE TABLE [dbo].[Blocks] (
    [BlockId]    INT            IDENTITY (1, 1) NOT NULL,
    [Visibility] BIT            NOT NULL,
    [Name]       NVARCHAR (100) NOT NULL,
    [Brief]      NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([BlockId] ASC)
);




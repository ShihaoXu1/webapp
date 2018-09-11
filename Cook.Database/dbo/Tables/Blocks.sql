CREATE TABLE [dbo].[Blocks] (
    [BlockId]           INT            IDENTITY (1, 1) NOT NULL,
    [Visible]           BIT            NULL,
    [BlockIntroduction] NVARCHAR (500) NULL,
    [BlockName]         NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([BlockId] ASC)
);






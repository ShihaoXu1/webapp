CREATE TABLE [dbo].[Roles] (
    [UserRole] INT           NOT NULL,
    [Roles]    NVARCHAR (10) NOT NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([UserRole] ASC)
);


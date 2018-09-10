CREATE TABLE [dbo].[Users] (
    [UserId]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50)  NOT NULL,
    [PasswordHash] NVARCHAR (100) NULL,
    [Gender]       CHAR (1)       NULL,
    [Brief]        NVARCHAR (200) NULL,
    [Email]        NVARCHAR (100) NOT NULL,
    [RegisterTime] ROWVERSION     NULL,
    [Activity]     BIT            NOT NULL,
    [UserRole]     INT            NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
);








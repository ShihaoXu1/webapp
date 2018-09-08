CREATE TABLE [dbo].[Users] (
    [UserId]       INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (200) NOT NULL,
    [LastName]     NVARCHAR (200) NOT NULL,
    [Password]     VARBINARY (50) NULL,
    [PasswordHash] INT            NULL,
    [CreatedTime]  DATETIME       NULL,
    [LastLogin]    DATETIME       NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
);






CREATE TABLE [dbo].[Users] (
    [UserId]             INT            IDENTITY (1, 1) NOT NULL,
    [PasswordHash]       NVARCHAR (100) NULL,
    [GenderId]           INT            NULL,
    [Email]              NVARCHAR (100) NOT NULL,
    [Active]             BIT            NOT NULL,
    [UserName]           NVARCHAR (100) NOT NULL,
    [BriefInstroduction] NVARCHAR (200) NULL,
    [RegisterTime]       DATETIME2 (7)  NULL,
    [UserRoleId]         INT            NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Users_Gender] FOREIGN KEY ([GenderId]) REFERENCES [dbo].[Gender] ([GenderId]),
    CONSTRAINT [FK_Users_UserRoles1] FOREIGN KEY ([UserRoleId]) REFERENCES [dbo].[UserRoles] ([UserRoleId]),
    CONSTRAINT [IX_Users] UNIQUE NONCLUSTERED ([Email] ASC)
);












CREATE TABLE [dbo].[UserRoles] (
    [UserRoleId] INT           NOT NULL,
    [RolesName]  NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([UserRoleId] ASC)
);


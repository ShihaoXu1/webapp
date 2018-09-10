CREATE TABLE [dbo].[Posts] (
    [PostId]     INT            IDENTITY (1, 1) NOT NULL,
    [Title]      NVARCHAR (200) NULL,
    [Content]    TEXT           NULL,
    [BlockId]    INT            NOT NULL,
    [PostTime]   DATETIME       NULL,
    [UserId]     INT            NULL,
    [Visibility] BIT            NOT NULL,
    CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED ([PostId] ASC),
    CONSTRAINT [fk_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);


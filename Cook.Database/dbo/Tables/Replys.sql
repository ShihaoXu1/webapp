CREATE TABLE [dbo].[Replys] (
    [ReplyId]    INT            IDENTITY (1, 1) NOT NULL,
    [content]    NVARCHAR (500) NULL,
    [PostId]     INT            NULL,
    [UserId]     INT            NOT NULL,
    [Replytime]  ROWVERSION     NULL,
    [Visibility] BIT            NOT NULL,
    CONSTRAINT [PK_Reply] PRIMARY KEY CLUSTERED ([ReplyId] ASC),
    CONSTRAINT [fk_Replys_PostId] FOREIGN KEY ([PostId]) REFERENCES [dbo].[Posts] ([PostId]),
    CONSTRAINT [fk_Replys_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);


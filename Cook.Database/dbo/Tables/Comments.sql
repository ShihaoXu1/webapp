CREATE TABLE [dbo].[Comments] (
    [ReplyId]        INT             IDENTITY (1, 1) NOT NULL,
    [CommentContent] NVARCHAR (1000) NULL,
    [PostId]         INT             NULL,
    [UserId]         INT             NOT NULL,
    [Replytime]      DATETIME2 (7)   NULL,
    [Visible]        BIT             NOT NULL,
    CONSTRAINT [PK_Reply] PRIMARY KEY CLUSTERED ([ReplyId] ASC),
    CONSTRAINT [FK_Comments_Posts] FOREIGN KEY ([PostId]) REFERENCES [dbo].[Posts] ([PostId])
);


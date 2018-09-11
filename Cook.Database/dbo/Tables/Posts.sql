CREATE TABLE [dbo].[Posts] (
    [PostId]      INT             IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (200)  NULL,
    [PostContent] NVARCHAR (4000) NULL,
    [BlockId]     INT             NOT NULL,
    [CreatedTime] DATETIME2 (7)   NULL,
    [UserId]      INT             NULL,
    [Visibility]  BIT             NOT NULL,
    CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED ([PostId] ASC),
    CONSTRAINT [FK_Posts_Posts] FOREIGN KEY ([PostId]) REFERENCES [dbo].[Posts] ([PostId])
);




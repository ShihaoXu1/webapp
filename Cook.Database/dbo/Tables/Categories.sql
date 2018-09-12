CREATE TABLE [dbo].[Categories] (
    [CategoriesId]         INT            IDENTITY (1, 1) NOT NULL,
    [Visible]              BIT            NULL,
    [CategoryIntroduction] NVARCHAR (500) NULL,
    [CategoryName]         NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([CategoriesId] ASC)
);


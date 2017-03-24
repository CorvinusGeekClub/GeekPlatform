CREATE TABLE [dbo].[Course_News] (
    [Course_News_Id] INT            NOT NULL IDENTITY,
    [Course_Id]      INT            NOT NULL,
    [Title]     NVARCHAR(MAX)     NOT NULL,
    [Content]   NVARCHAR (MAX) NOT NULL,
    [PostTime] DATETIME2 NOT NULL, 
    PRIMARY KEY CLUSTERED ([Course_News_Id] ASC),
    CONSTRAINT [FK_Table_ToCourse] FOREIGN KEY ([Course_Id]) REFERENCES [dbo].[Course] ([Course_Id])
);

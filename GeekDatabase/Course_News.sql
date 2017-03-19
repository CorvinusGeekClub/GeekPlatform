CREATE TABLE [dbo].[Course_News] (
    [Course_News_Id] INT            NOT NULL IDENTITY,
    [Course_Id]      INT            NOT NULL,
    [News_Title]     NCHAR (40)     NOT NULL,
    [News_Content]   NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Course_News_Id] ASC),
    CONSTRAINT [FK_Table_ToCourse] FOREIGN KEY ([Course_Id]) REFERENCES [dbo].[Course] ([Course_Id])
);

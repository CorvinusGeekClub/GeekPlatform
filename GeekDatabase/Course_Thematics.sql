CREATE TABLE [dbo].[Course_Thematics]
(
	[Course_Thematics_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Course_Id]	INT NOT NULL,
	[Week_Number]	tinyint NOT NULL,
	[Actual_Date]	date NOT NULL,
	[Title]	nvarchar(40) NOT NULL,
	[Description]	nvarchar(max) NOT NULL,
	[Homework_Description]	nvarchar(max) NOT NULL, 
    CONSTRAINT [FK_Course_Thematics_ToCourse] FOREIGN KEY ([Course_Id]) REFERENCES [Course]([Course_Id])
);

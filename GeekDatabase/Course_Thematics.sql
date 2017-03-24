CREATE TABLE [dbo].[Course_Thematics]
(
    [Course_Id]	INT NOT NULL,
	[Week_Number]	tinyint NOT NULL,
	[Actual_Date]	date NOT NULL,
	[Title]	nvarchar(40) NOT NULL,
	[Description]	nvarchar(max) NOT NULL,
	[Homework_Description]	nvarchar(max) NULL, 
    CONSTRAINT [FK_Course_Thematics_ToCourse] FOREIGN KEY ([Course_Id]) REFERENCES [Course]([Course_Id]), 
    CONSTRAINT [PK_Course_Thematics] PRIMARY KEY ([Course_Id], [Week_Number])
);

CREATE TABLE [dbo].[Homework_Upload]
(
	[Homework_Upload_Id]	INT NOT NULL PRIMARY KEY IDENTITY,
	[Course_Id]	INT NOT NULL,
	[Week_Number] TINYINT NOT NULL,
	[Profile_Id]	INT NOT NULL,
	[Upload_URL]	NVARCHAR(MAX) NOT NULL,
	[Upload_DateTime]	DATETIME2 NOT NULL,
	[Comment]	NVARCHAR(MAX) NOT NULL, 
    [Is_Active] BIT NOT NULL, 
    CONSTRAINT [FK_Homework_Upload_ToCourse_Thematics] FOREIGN KEY ([Course_Id], [Week_Number]) REFERENCES [Course_Thematics]([Course_Id],[Week_Number]),
	CONSTRAINT [FK_Homework_Upload_ToProfile] FOREIGN KEY ([Profile_Id]) REFERENCES [Profile]([Profile_Id])
);

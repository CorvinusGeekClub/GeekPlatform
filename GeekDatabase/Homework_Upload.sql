CREATE TABLE [dbo].[Homework_Upload]
(
	[Homework_Upload_Id]	INT NOT NULL PRIMARY KEY IDENTITY,
	[Course_Thematics_Id]	INT NOT NULL,
	[Profile_Id]	INT NOT NULL,
	[Upload_URL]	NVARCHAR(MAX) NOT NULL,
	[Upload_Date]	DATE NOT NULL,
	[Comment]	NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_Homework_Upload_ToCourse_Thematics] FOREIGN KEY ([Course_Thematics_Id]) REFERENCES [Course_Thematics]([Course_Thematics_Id]),
	CONSTRAINT [FK_Homework_Upload_ToProfile] FOREIGN KEY ([Profile_Id]) REFERENCES [Profile]([Profile_Id])
);

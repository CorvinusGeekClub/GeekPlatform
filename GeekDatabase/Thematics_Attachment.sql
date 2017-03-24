﻿CREATE TABLE [dbo].[Thematics_Attachment]
(
	[Thematics_Attachment_Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Course_Thematics_Id]	INT	NOT NULL,
	[Is_Homework]	BIT	NOT NULL,
	[Attachment_URL]	NVARCHAR(MAX)	NOT NULL,
	[Description]	NVARCHAR(MAX)	NOT NULL, 
    CONSTRAINT [FK_Thematics_Attachment_ToCourse_Thematics] FOREIGN KEY ([Course_Thematics_Id]) REFERENCES [Course_Thematics]([Course_Thematics_Id])
);
﻿CREATE TABLE [dbo].[Thematics_Attachment]
(
	[Thematics_Attachment_Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Course_Id]	INT	NOT NULL,
	[Week_Number] TINYINT NOT NULL,
	[Is_Homework]	BIT	NOT NULL,
	[Attachment_FileName]	NVARCHAR(128)	NOT NULL,
	[Description]	NVARCHAR(MAX)	NOT NULL, 
    [Is_Active] BIT NOT NULL, 
    CONSTRAINT [FK_Thematics_Attachment_ToCourse_Thematics] FOREIGN KEY ([Course_Id], [Week_Number]) REFERENCES [Course_Thematics]([Course_Id], [Week_Number])
);

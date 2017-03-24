CREATE TABLE [dbo].[Member_Competency]
(
	[Member_Competency_Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Profile_Id] INT NOT NULL, 
    [Competency_Id] INT NOT NULL,
	[Competency_Lvl]	TINYINT NOT NULL,
	[Competency_Comment]	NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_Member_Competency_ToCompetency] FOREIGN KEY ([Competency_Id]) REFERENCES [Competency]([Competency_Id]), 
    CONSTRAINT [FK_Member_Competency_ToProfile] FOREIGN KEY ([Profile_Id]) REFERENCES [Profile]([Profile_Id])
)

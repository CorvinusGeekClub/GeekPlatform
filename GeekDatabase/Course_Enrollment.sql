﻿CREATE TABLE [dbo].[Course_Enrollment] (
    [Course_Enrollment_Id]  INT NOT NULL IDENTITY,
    [Profile_Id]             INT NOT NULL,
    [Course_Id]              INT NOT NULL,
    [Is_Enrollment_Approved] BIT NOT NULL,
    [Approver]               INT NOT NULL,
    [Is_Instructor]          BIT NOT NULL,
    [Is_Finished]            BIT NOT NULL,
    PRIMARY KEY CLUSTERED ([Course_Enrollment_Id] ASC),
    CONSTRAINT [FK_Course_Enrollment_ToProfile] FOREIGN KEY ([Profile_Id]) REFERENCES [dbo].[Profile] ([Profile_Id]),
    CONSTRAINT [FK_Course_Enrollment_ToCourse] FOREIGN KEY ([Course_Id]) REFERENCES [dbo].[Course] ([Course_Id]), 
    CONSTRAINT [FK_Course_Enrollment_ToProfile_2] FOREIGN KEY ([Approver]) REFERENCES [dbo].[Profile] ([Profile_Id])
);


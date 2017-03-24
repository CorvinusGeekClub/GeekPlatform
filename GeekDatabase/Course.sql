CREATE TABLE [dbo].[Course] (
    [Course_Id]         INT            NOT NULL IDENTITY,
    [Course_Name]       NVARCHAR (MAX) NOT NULL,
    [Description_Short] NVARCHAR (200) NOT NULL,
    [Description_Long]  NVARCHAR (MAX) NOT NULL,
    [Icon_FileName]    NVARCHAR (MAX) NOT NULL,
    [Is_Workshop]       BIT            NOT NULL,
    [Is_Active] BIT NOT NULL , 
    [Is_Running] BIT NOT NULL, 
    [SignUp_Deadline] DATE NOT NULL, 
    CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([Course_Id] ASC)
);

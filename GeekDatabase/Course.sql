CREATE TABLE [dbo].[Course] (
    [Course_Id]         INT            NOT NULL IDENTITY,
    [Description_Short] NVARCHAR (200) NOT NULL,
    [Description_Long]  NVARCHAR (MAX) NOT NULL,
    [Icon_Large_URL]    NVARCHAR (MAX) NOT NULL,
    [Icon_Medium_URL]   NVARCHAR (MAX) NOT NULL,
    [Icon_Small_Url]    NVARCHAR (MAX) NOT NULL,
    [Is_Workshop]       BIT            NOT NULL,
    CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([Course_Id] ASC)
);

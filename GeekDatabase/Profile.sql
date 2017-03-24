CREATE TABLE [dbo].[Profile] (
    [Profile_Id]       INT            NOT NULL IDENTITY,
    [Name]             NVARCHAR (40)  NOT NULL,
    [Pic_FileName]          NVARCHAR (128) NULL,
    [Team_Member]      NVARCHAR (20)  NULL,
    [Membership_Start] DATE           NOT NULL,
    [Uni_Start]        DATE           NULL,
    [Major]            NVARCHAR (64)  NULL,
    [Workplace]        NVARCHAR (64)  NULL,
    [Email]            NVARCHAR (64)  NULL,
    [Phone]            NVARCHAR (16)  NULL,
    [Slack]            NVARCHAR (64)  NULL,
    [Skype]            NVARCHAR (64)  NULL,
    [Address]          NVARCHAR (64)  NULL,
    [Birthday]         DATE           NULL,
    [Is_Admin]         BIT            NOT NULL,
    [Is_Active]        BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Profile_Id] ASC)
);

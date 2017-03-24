CREATE TABLE [dbo].[Profile] (
    [Profile_Id]       INT            NOT NULL IDENTITY,
    [Name]             NVARCHAR (40)  NOT NULL,
    [Pic_URL]          NVARCHAR (MAX) NOT NULL,
    [Team_Member]      NVARCHAR (20)  NOT NULL,
    [Membership_Start] DATE           NOT NULL,
    [Uni_Start]        DATE           NOT NULL,
    [Major]            NVARCHAR (64)  NULL,
    [Workplace]        NVARCHAR (64)  NULL,
    [Email]            NVARCHAR (64)  NOT NULL,
    [Phone]            NVARCHAR (16)  NOT NULL,
    [Slack]            NVARCHAR (64)  NOT NULL,
    [Skype]            NVARCHAR (64)  NULL,
    [Address]          NVARCHAR (64)  NOT NULL,
    [Birthday]         DATE           NOT NULL,
    [Is_Admin]         BIT            NOT NULL,
    [Is_Active]        BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Profile_Id] ASC)
);

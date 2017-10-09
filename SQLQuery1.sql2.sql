create table [dbo].[CenterNewsCreate](   
    [ID]    INT   IDENTITY (1, 1) NOT NULL,
	[Title] NVARCHAR (50)  NOT NULL,
	[ContentText] NVARCHAR (MAX) NOT NULL,
	[IsPublich]   BIT    NOT NULL,
	[PublishDate] DATETIME       NOT NULL,
    [CreateUser]  NVARCHAR (50)  NOT NULL,
    [CreateDate]  DATETIME       NOT NULL,
    [UpdateDate]  DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
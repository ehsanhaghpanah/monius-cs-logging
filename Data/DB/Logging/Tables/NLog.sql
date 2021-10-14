/**
 * Copyright (C) moniüs, 2013.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

CREATE TABLE [Logging].[NLog]
(
	[Id]				[bigint] IDENTITY(1, 1)	NOT NULL,
	[MachineName]		[nvarchar](256)		NULL,
	[LoggedAt]		[datetime]			NOT NULL,
	[LogLevel]		[nvarchar](8)			NOT NULL,
	[Message]			[nvarchar](max)		NOT NULL,
	[LoggedBy]		[nvarchar](320)		NULL,
	[CallSite]		[nvarchar](320)		NULL,
	[Exception]		[nvarchar](max)		NULL,

	CONSTRAINT [PK_NLog] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Logging].[NLog] 
	ADD CONSTRAINT [DF_NLog_LoggedAt] 
	DEFAULT (GetDate()) FOR [LoggedAt]
GO
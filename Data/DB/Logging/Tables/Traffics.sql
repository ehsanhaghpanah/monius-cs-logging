/**
 * Copyright (C) moniüs, 2013.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

CREATE TABLE [Logging].[Traffics]
(
	[Id]				[bigint] IDENTITY(1, 1)	NOT NULL,
	[LoggedAt]		[datetime]			NOT NULL,
	[ClientIP]		[nvarchar](64)			NOT NULL,			
	[ClientOS]		[nvarchar](64)			NULL,
	[TimeSpan]		[bigint]				NOT NULL,
	[Request]			[nvarchar](max)		NULL,
	[Respond]			[nvarchar](max)		NULL,

	CONSTRAINT [PK_Traffics] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [IN_Traffics_UI] ON [Logging].[Traffics]
(
	[LoggedAt] ASC,
	[ClientIP] ASC
) ON [PRIMARY]
GO

ALTER TABLE [Logging].[Traffics] 
	ADD CONSTRAINT [DF_Traffics_LoggedAt] 
	DEFAULT (GetDate()) FOR [LoggedAt]
GO
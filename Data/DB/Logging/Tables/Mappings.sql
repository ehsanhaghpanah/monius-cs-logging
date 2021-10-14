/**
 * Copyright (C) moniüs, 2013.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

CREATE TABLE [Logging].[Mappings]
(
	[Id]				[bigint] IDENTITY(1, 1)	NOT NULL,
	[Code]			[nvarchar](4)			NOT NULL,
	[Text]			[nvarchar](max)		NOT NULL,	
	[Comments]		[nvarchar](max)		NULL,
	[MappedTo]		[nvarchar](4)			NULL,

	CONSTRAINT [PK_Mappings] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [IN_Mappings_UI] ON [Logging].[Mappings]
(
	[Code] ASC
) ON [PRIMARY]
GO
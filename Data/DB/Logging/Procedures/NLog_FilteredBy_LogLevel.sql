/**
 * Copyright (C) moniüs, 2013.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

CREATE PROCEDURE [Logging].[NLog_FilteredBy_LogLevel] 
	@LogLevel nvarchar(32)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [MachineName] AS [ServerId], [LoggedAt], [LogLevel], [LoggedBy], [CallSite], [Message], [Exception]
	FROM [NLog] WHERE (Lower([LogLevel]) = Lower(@LogLevel)) ORDER BY [LoggedAt]
END
GO